// -----------------------------------------------------------------------------
// GENERATED CODE - DO NOT EDIT
// -----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Fhir.Model;
using Hl7.Fhir.Utility;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Threading;

namespace Hl7.Fhir.CustomSerializer
{
    public partial class FhirCustomXmlReader
    {
		private void Parse(Endpoint result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

			if (reader.IsEmptyElement)
				return;

			// otherwise proceed to read all the other nodes
			while (reader.Read())
			{
				if (cancellationToken.IsCancellationRequested)
					return;
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id", cancellationToken); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta", cancellationToken); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules", cancellationToken); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language", cancellationToken); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text", cancellationToken); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]", cancellationToken);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Endpoint.EndpointStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Endpoint.EndpointStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "connectionType":
							result.ConnectionType = new Hl7.Fhir.Model.Coding();
							Parse(result.ConnectionType as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".connectionType", cancellationToken); // 110
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 120
							break;
						case "managingOrganization":
							result.ManagingOrganization = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.ManagingOrganization as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".managingOrganization", cancellationToken); // 130
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactPoint();
							Parse(newItem_contact, reader, outcome, locationPath + ".contact["+result.Contact.Count+"]", cancellationToken); // 140
							result.Contact.Add(newItem_contact);
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							Parse(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period", cancellationToken); // 150
							break;
						case "payloadType":
							var newItem_payloadType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_payloadType, reader, outcome, locationPath + ".payloadType["+result.PayloadType.Count+"]", cancellationToken); // 160
							result.PayloadType.Add(newItem_payloadType);
							break;
						case "payloadMimeType":
							var newItem_payloadMimeType = new Hl7.Fhir.Model.Code();
							Parse(newItem_payloadMimeType, reader, outcome, locationPath + ".payloadMimeType["+result.PayloadMimeTypeElement.Count+"]", cancellationToken); // 170
							result.PayloadMimeTypeElement.Add(newItem_payloadMimeType);
							break;
						case "address":
							result.AddressElement = new Hl7.Fhir.Model.FhirUrl();
							Parse(result.AddressElement as Hl7.Fhir.Model.FhirUrl, reader, outcome, locationPath + ".address", cancellationToken); // 180
							break;
						case "header":
							var newItem_header = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_header, reader, outcome, locationPath + ".header["+result.HeaderElement.Count+"]", cancellationToken); // 190
							result.HeaderElement.Add(newItem_header);
							break;
						default:
							// Property not found
							// System.Diagnostics.Trace.WriteLine($\"Unexpected token found {reader.Name}\");
							HandlePropertyNotFound(reader, outcome, locationPath + "." + reader.Name);
							// reader.ReadInnerXml();
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		private async System.Threading.Tasks.Task ParseAsync(Endpoint result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

			if (reader.IsEmptyElement)
				return;

			// otherwise proceed to read all the other nodes
			while (await reader.ReadAsync().ConfigureAwait(false))
			{
				if (cancellationToken.IsCancellationRequested)
					return;
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome, locationPath + ".id", cancellationToken); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome, locationPath + ".meta", cancellationToken); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".implicitRules", cancellationToken); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome, locationPath + ".language", cancellationToken); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome, locationPath + ".text", cancellationToken); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome, locationPath + ".contained["+result.Contained.Count+"]", cancellationToken);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Endpoint.EndpointStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Endpoint.EndpointStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "connectionType":
							result.ConnectionType = new Hl7.Fhir.Model.Coding();
							await ParseAsync(result.ConnectionType as Hl7.Fhir.Model.Coding, reader, outcome, locationPath + ".connectionType", cancellationToken); // 110
							break;
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".name", cancellationToken); // 120
							break;
						case "managingOrganization":
							result.ManagingOrganization = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.ManagingOrganization as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".managingOrganization", cancellationToken); // 130
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactPoint();
							await ParseAsync(newItem_contact, reader, outcome, locationPath + ".contact["+result.Contact.Count+"]", cancellationToken); // 140
							result.Contact.Add(newItem_contact);
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Period as Hl7.Fhir.Model.Period, reader, outcome, locationPath + ".period", cancellationToken); // 150
							break;
						case "payloadType":
							var newItem_payloadType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_payloadType, reader, outcome, locationPath + ".payloadType["+result.PayloadType.Count+"]", cancellationToken); // 160
							result.PayloadType.Add(newItem_payloadType);
							break;
						case "payloadMimeType":
							var newItem_payloadMimeType = new Hl7.Fhir.Model.Code();
							await ParseAsync(newItem_payloadMimeType, reader, outcome, locationPath + ".payloadMimeType["+result.PayloadMimeTypeElement.Count+"]", cancellationToken); // 170
							result.PayloadMimeTypeElement.Add(newItem_payloadMimeType);
							break;
						case "address":
							result.AddressElement = new Hl7.Fhir.Model.FhirUrl();
							await ParseAsync(result.AddressElement as Hl7.Fhir.Model.FhirUrl, reader, outcome, locationPath + ".address", cancellationToken); // 180
							break;
						case "header":
							var newItem_header = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_header, reader, outcome, locationPath + ".header["+result.HeaderElement.Count+"]", cancellationToken); // 190
							result.HeaderElement.Add(newItem_header);
							break;
						default:
							// Property not found
							await HandlePropertyNotFoundAsync(reader, outcome, locationPath + "." + reader.Name);
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}
	}
}
