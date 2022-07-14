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
		public void Parse(Hl7.Fhir.Model.Evidence.StatisticComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

			if (reader.MoveToFirstAttribute())
			{
				do
				{
					switch (reader.Name)
					{
						case "id":
							result.ElementId = reader.Value;
							break;
					}
				} while (reader.MoveToNextAttribute());
				reader.MoveToElement();
			}

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
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 40
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 50
							result.Note.Add(newItem_note);
							break;
						case "statisticType":
							result.StatisticType = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.StatisticType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".statisticType", cancellationToken); // 60
							break;
						case "category":
							result.Category = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Category as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".category", cancellationToken); // 70
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							Parse(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".quantity", cancellationToken); // 80
							break;
						case "numberOfEvents":
							result.NumberOfEventsElement = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.NumberOfEventsElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".numberOfEvents", cancellationToken); // 90
							break;
						case "numberAffected":
							result.NumberAffectedElement = new Hl7.Fhir.Model.UnsignedInt();
							Parse(result.NumberAffectedElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".numberAffected", cancellationToken); // 100
							break;
						case "sampleSize":
							result.SampleSize = new Hl7.Fhir.Model.Evidence.SampleSizeComponent();
							Parse(result.SampleSize as Hl7.Fhir.Model.Evidence.SampleSizeComponent, reader, outcome, locationPath + ".sampleSize", cancellationToken); // 110
							break;
						case "attributeEstimate":
							var newItem_attributeEstimate = new Hl7.Fhir.Model.Evidence.AttributeEstimateComponent();
							Parse(newItem_attributeEstimate, reader, outcome, locationPath + ".attributeEstimate["+result.AttributeEstimate.Count+"]", cancellationToken); // 120
							result.AttributeEstimate.Add(newItem_attributeEstimate);
							break;
						case "modelCharacteristic":
							var newItem_modelCharacteristic = new Hl7.Fhir.Model.Evidence.ModelCharacteristicComponent();
							Parse(newItem_modelCharacteristic, reader, outcome, locationPath + ".modelCharacteristic["+result.ModelCharacteristic.Count+"]", cancellationToken); // 130
							result.ModelCharacteristic.Add(newItem_modelCharacteristic);
							break;
						default:
							// Property not found
							HandlePropertyNotFound(reader, outcome, locationPath + "." + reader.Name);
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Evidence.StatisticComponent result, XmlReader reader, OperationOutcome outcome, string locationPath, CancellationToken cancellationToken)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

			if (reader.MoveToFirstAttribute())
			{
				do
				{
					switch (reader.Name)
					{
						case "id":
							result.ElementId = reader.Value;
							break;
					}
				} while (reader.MoveToNextAttribute());
				reader.MoveToElement();
			}

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
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome, locationPath + ".extension["+result.Extension.Count+"]", cancellationToken); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome, locationPath + ".modifierExtension["+result.ModifierExtension.Count+"]", cancellationToken); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "description":
							result.DescriptionElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.DescriptionElement as Hl7.Fhir.Model.FhirString, reader, outcome, locationPath + ".description", cancellationToken); // 40
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome, locationPath + ".note["+result.Note.Count+"]", cancellationToken); // 50
							result.Note.Add(newItem_note);
							break;
						case "statisticType":
							result.StatisticType = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.StatisticType as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".statisticType", cancellationToken); // 60
							break;
						case "category":
							result.Category = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Category as Hl7.Fhir.Model.CodeableConcept, reader, outcome, locationPath + ".category", cancellationToken); // 70
							break;
						case "quantity":
							result.Quantity = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Quantity as Hl7.Fhir.Model.Quantity, reader, outcome, locationPath + ".quantity", cancellationToken); // 80
							break;
						case "numberOfEvents":
							result.NumberOfEventsElement = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.NumberOfEventsElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".numberOfEvents", cancellationToken); // 90
							break;
						case "numberAffected":
							result.NumberAffectedElement = new Hl7.Fhir.Model.UnsignedInt();
							await ParseAsync(result.NumberAffectedElement as Hl7.Fhir.Model.UnsignedInt, reader, outcome, locationPath + ".numberAffected", cancellationToken); // 100
							break;
						case "sampleSize":
							result.SampleSize = new Hl7.Fhir.Model.Evidence.SampleSizeComponent();
							await ParseAsync(result.SampleSize as Hl7.Fhir.Model.Evidence.SampleSizeComponent, reader, outcome, locationPath + ".sampleSize", cancellationToken); // 110
							break;
						case "attributeEstimate":
							var newItem_attributeEstimate = new Hl7.Fhir.Model.Evidence.AttributeEstimateComponent();
							await ParseAsync(newItem_attributeEstimate, reader, outcome, locationPath + ".attributeEstimate["+result.AttributeEstimate.Count+"]", cancellationToken); // 120
							result.AttributeEstimate.Add(newItem_attributeEstimate);
							break;
						case "modelCharacteristic":
							var newItem_modelCharacteristic = new Hl7.Fhir.Model.Evidence.ModelCharacteristicComponent();
							await ParseAsync(newItem_modelCharacteristic, reader, outcome, locationPath + ".modelCharacteristic["+result.ModelCharacteristic.Count+"]", cancellationToken); // 130
							result.ModelCharacteristic.Add(newItem_modelCharacteristic);
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
