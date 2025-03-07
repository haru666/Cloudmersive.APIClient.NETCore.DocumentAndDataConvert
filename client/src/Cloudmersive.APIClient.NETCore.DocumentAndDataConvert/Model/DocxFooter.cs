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
    /// Footer in a Word Document (DOCX)
    /// </summary>
    [DataContract]
    public partial class DocxFooter :  IEquatable<DocxFooter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocxFooter" /> class.
        /// </summary>
        /// <param name="Path">The Path of the location of this object; leave blank for new tables.</param>
        /// <param name="Paragraphs">Paragraphs in this footer.</param>
        /// <param name="SectionsWithFooter">Sections that the footer is applied to.</param>
        public DocxFooter(string Path = default(string), List<DocxParagraph> Paragraphs = default(List<DocxParagraph>), List<DocxSection> SectionsWithFooter = default(List<DocxSection>))
        {
            this.Path = Path;
            this.Paragraphs = Paragraphs;
            this.SectionsWithFooter = SectionsWithFooter;
        }
        
        /// <summary>
        /// The Path of the location of this object; leave blank for new tables
        /// </summary>
        /// <value>The Path of the location of this object; leave blank for new tables</value>
        [DataMember(Name="Path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Paragraphs in this footer
        /// </summary>
        /// <value>Paragraphs in this footer</value>
        [DataMember(Name="Paragraphs", EmitDefaultValue=false)]
        public List<DocxParagraph> Paragraphs { get; set; }

        /// <summary>
        /// Sections that the footer is applied to
        /// </summary>
        /// <value>Sections that the footer is applied to</value>
        [DataMember(Name="SectionsWithFooter", EmitDefaultValue=false)]
        public List<DocxSection> SectionsWithFooter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocxFooter {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Paragraphs: ").Append(Paragraphs).Append("\n");
            sb.Append("  SectionsWithFooter: ").Append(SectionsWithFooter).Append("\n");
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
            return this.Equals(input as DocxFooter);
        }

        /// <summary>
        /// Returns true if DocxFooter instances are equal
        /// </summary>
        /// <param name="input">Instance of DocxFooter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocxFooter input)
        {
            if (input == null)
                return false;

            return 
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
                    this.SectionsWithFooter == input.SectionsWithFooter ||
                    this.SectionsWithFooter != null &&
                    this.SectionsWithFooter.SequenceEqual(input.SectionsWithFooter)
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Paragraphs != null)
                    hashCode = hashCode * 59 + this.Paragraphs.GetHashCode();
                if (this.SectionsWithFooter != null)
                    hashCode = hashCode * 59 + this.SectionsWithFooter.GetHashCode();
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
