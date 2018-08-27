/* 
 * convertapi
 *
 * Convert API lets you effortlessly convert file formats and types.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Model
{
    /// <summary>
    /// A cell in a Word Document (DOCX) file
    /// </summary>
    [DataContract]
    public partial class DocxTableCell :  IEquatable<DocxTableCell>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocxTableCell" /> class.
        /// </summary>
        /// <param name="CellIndex">The index of the cell, 0-based.</param>
        /// <param name="Path">The Path of the location of this object; leave blank for new tables.</param>
        /// <param name="Paragraphs">Paragraphs inside the cell; this is where the contents of the cell are stored.</param>
        /// <param name="CellShadingColor">Color of the cell shading.</param>
        /// <param name="CellShadingFill">Fill of the cell shading.</param>
        /// <param name="CellShadingPattern">Pattern of the cell shading.</param>
        /// <param name="CellWidthMode">Width mode of the cell; can be auto (for automatic) or manual.</param>
        /// <param name="CellWidth">Width of the cell.</param>
        public DocxTableCell(int? CellIndex = default(int?), string Path = default(string), List<DocxParagraph> Paragraphs = default(List<DocxParagraph>), string CellShadingColor = default(string), string CellShadingFill = default(string), string CellShadingPattern = default(string), string CellWidthMode = default(string), string CellWidth = default(string))
        {
            this.CellIndex = CellIndex;
            this.Path = Path;
            this.Paragraphs = Paragraphs;
            this.CellShadingColor = CellShadingColor;
            this.CellShadingFill = CellShadingFill;
            this.CellShadingPattern = CellShadingPattern;
            this.CellWidthMode = CellWidthMode;
            this.CellWidth = CellWidth;
        }
        
        /// <summary>
        /// The index of the cell, 0-based
        /// </summary>
        /// <value>The index of the cell, 0-based</value>
        [DataMember(Name="CellIndex", EmitDefaultValue=false)]
        public int? CellIndex { get; set; }

        /// <summary>
        /// The Path of the location of this object; leave blank for new tables
        /// </summary>
        /// <value>The Path of the location of this object; leave blank for new tables</value>
        [DataMember(Name="Path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Paragraphs inside the cell; this is where the contents of the cell are stored
        /// </summary>
        /// <value>Paragraphs inside the cell; this is where the contents of the cell are stored</value>
        [DataMember(Name="Paragraphs", EmitDefaultValue=false)]
        public List<DocxParagraph> Paragraphs { get; set; }

        /// <summary>
        /// Color of the cell shading
        /// </summary>
        /// <value>Color of the cell shading</value>
        [DataMember(Name="CellShadingColor", EmitDefaultValue=false)]
        public string CellShadingColor { get; set; }

        /// <summary>
        /// Fill of the cell shading
        /// </summary>
        /// <value>Fill of the cell shading</value>
        [DataMember(Name="CellShadingFill", EmitDefaultValue=false)]
        public string CellShadingFill { get; set; }

        /// <summary>
        /// Pattern of the cell shading
        /// </summary>
        /// <value>Pattern of the cell shading</value>
        [DataMember(Name="CellShadingPattern", EmitDefaultValue=false)]
        public string CellShadingPattern { get; set; }

        /// <summary>
        /// Width mode of the cell; can be auto (for automatic) or manual
        /// </summary>
        /// <value>Width mode of the cell; can be auto (for automatic) or manual</value>
        [DataMember(Name="CellWidthMode", EmitDefaultValue=false)]
        public string CellWidthMode { get; set; }

        /// <summary>
        /// Width of the cell
        /// </summary>
        /// <value>Width of the cell</value>
        [DataMember(Name="CellWidth", EmitDefaultValue=false)]
        public string CellWidth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocxTableCell {\n");
            sb.Append("  CellIndex: ").Append(CellIndex).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Paragraphs: ").Append(Paragraphs).Append("\n");
            sb.Append("  CellShadingColor: ").Append(CellShadingColor).Append("\n");
            sb.Append("  CellShadingFill: ").Append(CellShadingFill).Append("\n");
            sb.Append("  CellShadingPattern: ").Append(CellShadingPattern).Append("\n");
            sb.Append("  CellWidthMode: ").Append(CellWidthMode).Append("\n");
            sb.Append("  CellWidth: ").Append(CellWidth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DocxTableCell);
        }

        /// <summary>
        /// Returns true if DocxTableCell instances are equal
        /// </summary>
        /// <param name="input">Instance of DocxTableCell to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocxTableCell input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CellIndex == input.CellIndex ||
                    (this.CellIndex != null &&
                    this.CellIndex.Equals(input.CellIndex))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Paragraphs == input.Paragraphs ||
                    this.Paragraphs != null &&
                    this.Paragraphs.SequenceEqual(input.Paragraphs)
                ) && 
                (
                    this.CellShadingColor == input.CellShadingColor ||
                    (this.CellShadingColor != null &&
                    this.CellShadingColor.Equals(input.CellShadingColor))
                ) && 
                (
                    this.CellShadingFill == input.CellShadingFill ||
                    (this.CellShadingFill != null &&
                    this.CellShadingFill.Equals(input.CellShadingFill))
                ) && 
                (
                    this.CellShadingPattern == input.CellShadingPattern ||
                    (this.CellShadingPattern != null &&
                    this.CellShadingPattern.Equals(input.CellShadingPattern))
                ) && 
                (
                    this.CellWidthMode == input.CellWidthMode ||
                    (this.CellWidthMode != null &&
                    this.CellWidthMode.Equals(input.CellWidthMode))
                ) && 
                (
                    this.CellWidth == input.CellWidth ||
                    (this.CellWidth != null &&
                    this.CellWidth.Equals(input.CellWidth))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CellIndex != null)
                    hashCode = hashCode * 59 + this.CellIndex.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Paragraphs != null)
                    hashCode = hashCode * 59 + this.Paragraphs.GetHashCode();
                if (this.CellShadingColor != null)
                    hashCode = hashCode * 59 + this.CellShadingColor.GetHashCode();
                if (this.CellShadingFill != null)
                    hashCode = hashCode * 59 + this.CellShadingFill.GetHashCode();
                if (this.CellShadingPattern != null)
                    hashCode = hashCode * 59 + this.CellShadingPattern.GetHashCode();
                if (this.CellWidthMode != null)
                    hashCode = hashCode * 59 + this.CellWidthMode.GetHashCode();
                if (this.CellWidth != null)
                    hashCode = hashCode * 59 + this.CellWidth.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
