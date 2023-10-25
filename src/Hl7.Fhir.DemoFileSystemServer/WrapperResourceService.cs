using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Support;
using Hl7.Fhir.Utility;
using Hl7.Fhir.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hl7.Fhir.DemoFileSystemServer
{
    public interface IWrapperResourceServiceR4<TSP> : IFhirResourceServiceR4<TSP>
    where TSP : IServiceProvider
    {
        IResourceRepository Repository { get; }
    }

    public class WrapperResourceService<TSP> : IWrapperResourceServiceR4<TSP>
        where TSP : IServiceProvider
    {
        private readonly IResourceRepository resourceRepository;

        public string ResourceName { get; private set; }

        public ModelBaseInputs<TSP> RequestDetails { get; private set; }

        public IResourceRepository Repository => resourceRepository;

        public WrapperResourceService(ModelBaseInputs<TSP> requestDetails, string resourceName, IResourceRepository resourceRepository)
        {
            this.resourceRepository = resourceRepository;

            RequestDetails = requestDetails;
            ResourceName = resourceName;
        }

        public Task<Resource> Create(Resource resource, string ifMatch, string ifNoneExist, DateTimeOffset? ifModifiedSince)
        {
            throw new NotImplementedException();
        }

        public Task<string> Delete(string id, string ifMatch)
        {
            throw new NotImplementedException();
        }

        public Task<Resource> Get(string resourceId, string VersionId, SummaryType summary)
        {
            throw new NotImplementedException();
        }

        public Task<CapabilityStatement.ResourceComponent> GetRestResourceComponent()
        {
            var rt = new Hl7.Fhir.Model.CapabilityStatement.ResourceComponent();
            rt.TypeElement = new() { ObjectValue = ResourceName };
            rt.ReadHistory = true;
            rt.UpdateCreate = true;
            rt.Versioning = CapabilityStatement.ResourceVersionPolicy.Versioned;
            rt.ConditionalCreate = false;
            rt.ConditionalUpdate = false;
            rt.ConditionalDelete = CapabilityStatement.ConditionalDeleteStatus.NotSupported;

            if (ResourceName == "Observation")
                rt.SearchInclude = new List<string>() { "*", "Observation:patient" };

            rt.Interaction = new List<CapabilityStatement.ResourceInteractionComponent>()
            {
                new CapabilityStatement.ResourceInteractionComponent() { Code = CapabilityStatement.TypeRestfulInteraction.Create },
                new CapabilityStatement.ResourceInteractionComponent() { Code = CapabilityStatement.TypeRestfulInteraction.Read },
                new CapabilityStatement.ResourceInteractionComponent() { Code = CapabilityStatement.TypeRestfulInteraction.Update },
                new CapabilityStatement.ResourceInteractionComponent() { Code = CapabilityStatement.TypeRestfulInteraction.Delete },
                new CapabilityStatement.ResourceInteractionComponent() { Code = CapabilityStatement.TypeRestfulInteraction.SearchType },
                //new CapabilityStatement.ResourceInteractionComponent() { Code = CapabilityStatement.TypeRestfulInteraction.Vread },
                //new CapabilityStatement.ResourceInteractionComponent() { Code = CapabilityStatement.TypeRestfulInteraction.HistoryInstance },
                //new CapabilityStatement.ResourceInteractionComponent() { Code = CapabilityStatement.TypeRestfulInteraction.HistoryType },
            };

            return System.Threading.Tasks.Task.FromResult(rt);
        }

        public Task<Bundle> InstanceHistory(string ResourceId, DateTimeOffset? since, DateTimeOffset? Till, int? Count, SummaryType summary)
        {
            throw new NotImplementedException();
        }

        public Task<Resource> PerformOperation(string id, string operation, Parameters operationParameters, SummaryType summary)
        {
            throw new NotImplementedException();
        }

        public Task<Resource> PerformOperation(string operation, Parameters operationParameters, SummaryType summary)
        {
            throw new NotImplementedException();
        }

        public Task<Bundle> Search(IEnumerable<KeyValuePair<string, string>> parameters, int? Count, SummaryType summary, string sortby)
        {
            Bundle resource = new Bundle();
            resource.Meta ??= new Meta();
            resource.Meta.LastUpdated = DateTimeOffset.Now;
            resource.Id = new Uri("urn:uuid:" + Guid.NewGuid().ToFhirId()).OriginalString;
            resource.Type = Bundle.BundleType.Searchset;
            resource.ResourceBase = RequestDetails.BaseUri;

            var entries = resourceRepository.SearchResources(parameters);

            Dictionary<string, Resource> includedEntries = new();
            var includeparams = parameters.Where(kp => kp.Key == "_include");

            foreach (var includeparam in includeparams)
            {
                var query = includeparam.Value.Split(':');

                var type = ModelInfo.FhirTypeToCsType[query[0]];

                var service = (WrapperSystemService<TSP>)RequestDetails.ServiceProvider.GetService(typeof(IFhirSystemServiceR4<TSP>));
                string resourceName = query[1].Substring(0,1).ToUpper() + query[1].Substring(1);
                var repository = ((WrapperResourceService<TSP>)service.GetResourceService(RequestDetails, resourceName)).Repository;

                var ids = entries.Values.Select(e => e.NamedChildren.Where(nc => nc.ElementName == "subject").FirstOrDefault().Value as ResourceReference);
                var values = repository.SearchResourcesByReference(ids);

                foreach (var value in values)
                    includedEntries.Add(value.Key, value.Value);
            }

            foreach (var item in entries.Values)
            {
                resource.AddResourceEntry(item,
                    ResourceIdentity.Build(RequestDetails.BaseUri,
                        item.TypeName,
                        item.Id,
                        item.Meta?.VersionId).OriginalString).Search = new Bundle.SearchComponent()
                        {
                            Mode = Bundle.SearchEntryMode.Match
                        };
                //if (elementsFilterActive)
                //{
                //    // Add in the Meta Tag that indicates that this resource is only a partial
                //    if (item.Meta == null) item.Meta = new Meta();
                //    if (!item.Meta.Tag.Any(c => c.System == ResourceExtensions.SubsettedSystem && c.Code == "SUBSETTED"))
                //        item.Meta.Tag.Add(new Coding(ResourceExtensions.SubsettedSystem, "SUBSETTED"));
                //}
            }

            foreach (var item in includedEntries.Values)
            {
                resource.AddResourceEntry(item,
                    ResourceIdentity.Build(RequestDetails.BaseUri,
                        item.TypeName,
                        item.Id,
                        item.Meta?.VersionId).OriginalString).Search = new Bundle.SearchComponent()
                        {
                            Mode = Bundle.SearchEntryMode.Include
                        };
            }

            resource.Total = resource.Entry.Count(e => e.Search.Mode == Bundle.SearchEntryMode.Match);
            if (Count.HasValue)
                resource.Entry = resource.Entry.Take(Count.Value).ToList();
            //if (parameters.Count(p => p.Key != "_id" && !usedParameters.Contains(p.Key)) > 0)
            //{
            //    var outcome = new OperationOutcome();
            //    outcome.Issue.Add(new OperationOutcome.IssueComponent()
            //    {
            //        Severity = OperationOutcome.IssueSeverity.Warning,
            //        Code = OperationOutcome.IssueType.NotSupported,
            //        Details = new CodeableConcept() { Text = $"Unsupported search parameters used: {String.Join("&", parameters.Where(p => p.Key != "_id" && !usedParameters.Contains(p.Key)).Select(k => k.Key + "=" + k.Value))}" }
            //    });
            //    resource.AddResourceEntry(outcome,
            //        new Uri("urn:uuid:" + Guid.NewGuid().ToFhirId()).OriginalString).Search = new Bundle.SearchComponent()
            //        {
            //            Mode = Bundle.SearchEntryMode.Outcome
            //        };
            //}

            // Add in the navigation links
            resource.SelfLink = RequestDetails.RequestUri;

            return System.Threading.Tasks.Task.FromResult(resource);
        }

        public Task<Bundle> TypeHistory(DateTimeOffset? since, DateTimeOffset? Till, int? Count, SummaryType summary)
        {
            throw new NotImplementedException();
        }
    }
}