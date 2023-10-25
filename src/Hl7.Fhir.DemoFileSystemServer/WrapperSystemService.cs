using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.WebApi;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hl7.Fhir.DemoFileSystemServer
{
    public class WrapperSystemService<TSP> : Hl7.Fhir.WebApi.IFhirSystemServiceR4<TSP>
        where TSP : IServiceProvider
    {
        public async Task<CapabilityStatement> GetConformance(ModelBaseInputs<TSP> request, SummaryType summary)
        {
            Hl7.Fhir.Model.CapabilityStatement con = new Hl7.Fhir.Model.CapabilityStatement();
            con.Url = request.BaseUri + "metadata";
            con.Description = new Markdown("Demonstration Directory based FHIR server");
            con.DateElement = new Hl7.Fhir.Model.FhirDateTime("2017-04-30");
            con.Version = "1.0.0.0";
            con.Name = "demoCapStmt";
            con.Experimental = true;
            con.Status = PublicationStatus.Active;
            con.FhirVersion = FHIRVersion.N4_3_0;
            // con.AcceptUnknown = CapabilityStatement.UnknownContentCode.Extensions;
            con.Format = new string[] { "xml", "json" };
            con.Kind = CapabilityStatementKind.Instance;
            con.Meta = new Meta();
            con.Meta.LastUpdatedElement = Instant.Now();

            con.Implementation = new CapabilityStatement.ImplementationComponent();
            con.Implementation.Url = request.BaseUri.OriginalString.Trim('/');

            con.Rest = new List<Hl7.Fhir.Model.CapabilityStatement.RestComponent>
            {
                new Hl7.Fhir.Model.CapabilityStatement.RestComponent()
                {
                    Operation = new List<Hl7.Fhir.Model.CapabilityStatement.OperationComponent>()
                }
            };
            con.Rest[0].Mode = CapabilityStatement.RestfulCapabilityMode.Server;
            con.Rest[0].Resource = new List<Hl7.Fhir.Model.CapabilityStatement.ResourceComponent>();

            foreach (var resName in ModelInfo.SupportedResources)
            {
                var c = await GetResourceService(request, resName).GetRestResourceComponent();
                if (c != null)
                    con.Rest[0].Resource.Add(c);
            }

            return con;
        }

        public IFhirResourceServiceR4<TSP> GetResourceService(ModelBaseInputs<TSP> request, string resourceName)
        {
            if (!Hl7.Fhir.Model.ModelInfo.IsCoreModelType(resourceName))
                throw new NotImplementedException();

            //if (ModelInfo.IsConformanceResource(resourceName))
            //    return new CanonicalResourceService<TSP>(request, resourceName, Directory, _source, _source, _indexer);
  
            IResourceRepository repository = null;
            switch (resourceName)
            {
                case "Patient":
                    repository = new PatientResourceRepository();
                    break;
                case "Observation":
                    repository = new ObservationResourceRepository();
                    break;
                default:
                    break;
            }
            return new WrapperResourceService<TSP>(request, resourceName, repository);
        }

        public Task<Resource> PerformOperation(ModelBaseInputs<TSP> request, string operation, Parameters operationParameters, SummaryType summary)
        {
            throw new NotImplementedException();
        }

        public Task<Bundle> ProcessBatch(ModelBaseInputs<TSP> request, Bundle bundle)
        {
            throw new NotImplementedException();
        }

        public Task<Bundle> Search(ModelBaseInputs<TSP> request, IEnumerable<KeyValuePair<string, string>> parameters, int? Count, SummaryType summary)
        {
            throw new NotImplementedException();
        }

        public Task<Bundle> SystemHistory(ModelBaseInputs<TSP> request, DateTimeOffset? since, DateTimeOffset? Till, int? Count, SummaryType summary)
        {
            throw new NotImplementedException();
        }
    }
}
