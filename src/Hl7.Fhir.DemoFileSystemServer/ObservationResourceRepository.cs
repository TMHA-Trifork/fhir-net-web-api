using Hl7.Fhir.Model;
using System.Collections.Generic;

namespace Hl7.Fhir.DemoFileSystemServer
{
    public class ObservationResourceRepository : IResourceRepository
    {
        public Dictionary<string, Resource> SearchResources(IEnumerable<KeyValuePair<string, string>> parameters)
        {
            var obs1 = new Observation()
            {
                Id = "1",
                Status = ObservationStatus.Final,
                Code = new("urn:adfdsaf", "1234"),
                Subject = new("Patient/1")
            };
            var obs2 = new Observation()
            {
                Id = "2",
                Status = ObservationStatus.Final,
                Code = new("urn:adfdsaf", "2345"),
                Subject = new("Patient/2")
            };
            return new() { { "Observation/1", obs1 }, { "Observation/2", obs2 } };  
        }

        public Dictionary<string, Resource> SearchResourcesByReference(IEnumerable<ResourceReference> ids)
        {
            throw new System.NotImplementedException();
        }
    }
}