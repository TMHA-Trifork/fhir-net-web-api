using Hl7.Fhir.Model;
using System.Collections.Generic;

public interface IResourceRepository
{
    Dictionary<string, Resource> SearchResources(IEnumerable<KeyValuePair<string, string>> parameters);
    Dictionary<string, Resource> SearchResourcesByReference(IEnumerable<ResourceReference> ids);
}
