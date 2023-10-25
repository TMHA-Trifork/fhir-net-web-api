using Hl7.Fhir.Model;
using System.Collections.Generic;

namespace Hl7.Fhir.DemoFileSystemServer
{
    public class PatientResourceRepository : IResourceRepository
    {
        public Dictionary<string, Resource> SearchResources(IEnumerable<KeyValuePair<string, string>> parameters)
        {
            throw new System.NotImplementedException();
        }

        public Dictionary<string, Resource> SearchResourcesByReference(IEnumerable<ResourceReference> ids)
        {
            var pat1 = new Patient()
            {
                Id = "1"
            };
            var pat2 = new Patient()
            {
                Id = "2"
            };
            return new() { { "Patient/1",  pat1 }, { "Patient/2", pat2 } };
        }
    }
}