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
		private void Parse(EvidenceReport result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.UrlElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".url", cancellationToken); // 90
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "useContext":
							var newItem_useContext = new Hl7.Fhir.Model.UsageContext();
							Parse(newItem_useContext, reader, outcome, locationPath + ".useContext["+result.UseContext.Count+"]", cancellationToken); // 110
							result.UseContext.Add(newItem_useContext);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 120
							result.Identifier.Add(newItem_identifier);
							break;
						case "relatedIdentifier":
							var newItem_relatedIdentifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_relatedIdentifier, reader, outcome, locationPath + ".relatedIdentifier["+result.RelatedIdentifier.Count+"]", cancellationToken); // 130
							result.RelatedIdentifier.Add(newItem_relatedIdentifier);
							break;
						case "citeAsReference":
							result.CiteAs = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.CiteAs as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".citeAs", cancellationToken); // 140
							break;
						case "citeAsMarkdown":
							result.CiteAs = new Hl7.Fhir.Model.Markdown();
							Parse(result.CiteAs as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".citeAs", cancellationToken); // 140
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 150
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 160
							result.Note.Add(newItem_note);
							break;
						case "relatedArtifact":
							var newItem_relatedArtifact = new Hl7.Fhir.Model.RelatedArtifact();
							Parse(newItem_relatedArtifact, reader, outcome, locationPath + ".relatedArtifact["+result.RelatedArtifact.Count+"]", cancellationToken); // 170
							result.RelatedArtifact.Add(newItem_relatedArtifact);
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.EvidenceReport.SubjectComponent();
							Parse(result.Subject as Hl7.Fhir.Model.EvidenceReport.SubjectComponent, reader, outcome, locationPath + ".subject", cancellationToken); // 180
							break;
						case "publisher":
							result.PublisherElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.PublisherElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".publisher", cancellationToken); // 190
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_contact, reader, outcome, locationPath + ".contact["+result.Contact.Count+"]", cancellationToken); // 200
							result.Contact.Add(newItem_contact);
							break;
						case "author":
							var newItem_author = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_author, reader, outcome, locationPath + ".author["+result.Author.Count+"]", cancellationToken); // 210
							result.Author.Add(newItem_author);
							break;
						case "editor":
							var newItem_editor = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_editor, reader, outcome, locationPath + ".editor["+result.Editor.Count+"]", cancellationToken); // 220
							result.Editor.Add(newItem_editor);
							break;
						case "reviewer":
							var newItem_reviewer = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_reviewer, reader, outcome, locationPath + ".reviewer["+result.Reviewer.Count+"]", cancellationToken); // 230
							result.Reviewer.Add(newItem_reviewer);
							break;
						case "endorser":
							var newItem_endorser = new Hl7.Fhir.Model.ContactDetail();
							Parse(newItem_endorser, reader, outcome, locationPath + ".endorser["+result.Endorser.Count+"]", cancellationToken); // 240
							result.Endorser.Add(newItem_endorser);
							break;
						case "relatesTo":
							var newItem_relatesTo = new Hl7.Fhir.Model.EvidenceReport.RelatesToComponent();
							Parse(newItem_relatesTo, reader, outcome, locationPath + ".relatesTo["+result.RelatesTo.Count+"]", cancellationToken); // 250
							result.RelatesTo.Add(newItem_relatesTo);
							break;
						case "section":
							var newItem_section = new Hl7.Fhir.Model.EvidenceReport.SectionComponent();
							Parse(newItem_section, reader, outcome, locationPath + ".section["+result.Section.Count+"]", cancellationToken); // 260
							result.Section.Add(newItem_section);
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

		private async System.Threading.Tasks.Task ParseAsync(EvidenceReport result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
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
						case "url":
							result.UrlElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.UrlElement as Hl7.Fhir.Model.FhirUri, reader, outcome, locationPath + ".url", cancellationToken); // 90
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.PublicationStatus>, reader, outcome, locationPath + ".status", cancellationToken); // 100
							break;
						case "useContext":
							var newItem_useContext = new Hl7.Fhir.Model.UsageContext();
							await ParseAsync(newItem_useContext, reader, outcome, locationPath + ".useContext["+result.UseContext.Count+"]", cancellationToken); // 110
							result.UseContext.Add(newItem_useContext);
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome, locationPath + ".identifier["+result.Identifier.Count+"]", cancellationToken); // 120
							result.Identifier.Add(newItem_identifier);
							break;
						case "relatedIdentifier":
							var newItem_relatedIdentifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_relatedIdentifier, reader, outcome, locationPath + ".relatedIdentifier["+result.RelatedIdentifier.Count+"]", cancellationToken); // 130
							result.RelatedIdentifier.Add(newItem_relatedIdentifier);
							break;
						case "citeAsReference":
							result.CiteAs = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.CiteAs as Hl7.Fhir.Model.ResourceReference, reader, outcome, locationPath + ".citeAs", cancellationToken); // 140
							break;
						case "citeAsMarkdown":
							result.CiteAs = new Hl7.Fhir.Model.Markdown();
							await ParseAsync(result.CiteAs as Hl7.Fhir.Model.Markdown, reader, outcome, locationPath + ".citeAs", cancellationToken); // 140
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".type", cancellationToken); // 150
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 160
							result.Note.Add(newItem_note);
							break;
						case "relatedArtifact":
							var newItem_relatedArtifact = new Hl7.Fhir.Model.RelatedArtifact();
							await ParseAsync(newItem_relatedArtifact, reader, outcome, locationPath + ".relatedArtifact["+result.RelatedArtifact.Count+"]", cancellationToken); // 170
							result.RelatedArtifact.Add(newItem_relatedArtifact);
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.EvidenceReport.SubjectComponent();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.EvidenceReport.SubjectComponent, reader, outcome, locationPath + ".subject", cancellationToken); // 180
							break;
						case "publisher":
							result.PublisherElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.PublisherElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".publisher", cancellationToken); // 190
							break;
						case "contact":
							var newItem_contact = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_contact, reader, outcome, locationPath + ".contact["+result.Contact.Count+"]", cancellationToken); // 200
							result.Contact.Add(newItem_contact);
							break;
						case "author":
							var newItem_author = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_author, reader, outcome, locationPath + ".author["+result.Author.Count+"]", cancellationToken); // 210
							result.Author.Add(newItem_author);
							break;
						case "editor":
							var newItem_editor = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_editor, reader, outcome, locationPath + ".editor["+result.Editor.Count+"]", cancellationToken); // 220
							result.Editor.Add(newItem_editor);
							break;
						case "reviewer":
							var newItem_reviewer = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_reviewer, reader, outcome, locationPath + ".reviewer["+result.Reviewer.Count+"]", cancellationToken); // 230
							result.Reviewer.Add(newItem_reviewer);
							break;
						case "endorser":
							var newItem_endorser = new Hl7.Fhir.Model.ContactDetail();
							await ParseAsync(newItem_endorser, reader, outcome, locationPath + ".endorser["+result.Endorser.Count+"]", cancellationToken); // 240
							result.Endorser.Add(newItem_endorser);
							break;
						case "relatesTo":
							var newItem_relatesTo = new Hl7.Fhir.Model.EvidenceReport.RelatesToComponent();
							await ParseAsync(newItem_relatesTo, reader, outcome, locationPath + ".relatesTo["+result.RelatesTo.Count+"]", cancellationToken); // 250
							result.RelatesTo.Add(newItem_relatesTo);
							break;
						case "section":
							var newItem_section = new Hl7.Fhir.Model.EvidenceReport.SectionComponent();
							await ParseAsync(newItem_section, reader, outcome, locationPath + ".section["+result.Section.Count+"]", cancellationToken); // 260
							result.Section.Add(newItem_section);
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
