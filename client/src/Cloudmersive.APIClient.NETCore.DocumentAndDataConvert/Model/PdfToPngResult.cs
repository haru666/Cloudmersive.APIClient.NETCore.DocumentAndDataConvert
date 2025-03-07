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
    /// Result of converting a PDF to a PNG array
    /// </summary>
    [DataContract]
    public partial class PdfToPngResult :  IEquatable<PdfToPngResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PdfToPngResult" /> class.
        /// </summary>
        /// <param name="Successful">True if the operation was successful, false otherwise.</param>
        /// <param name="PngResultPages">Array of converted pages.</param>
        public PdfToPngResult(bool? Successful = default(bool?), List<ConvertedPngPage> PngResultPages = default(List<ConvertedPngPage>))
        {
            this.Successful = Successful;
            this.PngResultPages = PngResultPages;
        }
        
        /// <summary>
        /// True if the operation was successful, false otherwise
        /// </summary>
        /// <value>True if the operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Array of converted pages
        /// </summary>
        /// <value>Array of converted pages</value>
        [DataMember(Name="PngResultPages", EmitDefaultValue=false)]
        public List<ConvertedPngPage> PngResultPages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PdfToPngResult {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  PngResultPages: ").Append(PngResultPages).Append("\n");
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
            return this.Equals(input as PdfToPngResult);
        }

        /// <summary>
        /// Returns true if PdfToPngResult instances are equal
        /// </summary>
        /// <param name="input">Instance of PdfToPngResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfToPngResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
                ) && 
                (
                    this.PngResultPages == input.PngResultPages ||
                    this.PngResultPages != null &&
                    this.PngResultPages.SequenceEqual(input.PngResultPages)
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
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                if (this.PngResultPages != null)
                    hashCode = hashCode * 59 + this.PngResultPages.GetHashCode();
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
