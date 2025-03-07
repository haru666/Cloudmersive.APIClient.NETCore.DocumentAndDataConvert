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
    /// Column in an Excel spreadsheet worksheet
    /// </summary>
    [DataContract]
    public partial class XlsxSpreadsheetColumn :  IEquatable<XlsxSpreadsheetColumn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XlsxSpreadsheetColumn" /> class.
        /// </summary>
        /// <param name="Path">The Path of the location of this object; leave blank for new rows.</param>
        /// <param name="HeadingCell">Heading cell for this column.</param>
        public XlsxSpreadsheetColumn(string Path = default(string), XlsxSpreadsheetCell HeadingCell = default(XlsxSpreadsheetCell))
        {
            this.Path = Path;
            this.HeadingCell = HeadingCell;
        }
        
        /// <summary>
        /// The Path of the location of this object; leave blank for new rows
        /// </summary>
        /// <value>The Path of the location of this object; leave blank for new rows</value>
        [DataMember(Name="Path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Heading cell for this column
        /// </summary>
        /// <value>Heading cell for this column</value>
        [DataMember(Name="HeadingCell", EmitDefaultValue=false)]
        public XlsxSpreadsheetCell HeadingCell { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XlsxSpreadsheetColumn {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  HeadingCell: ").Append(HeadingCell).Append("\n");
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
            return this.Equals(input as XlsxSpreadsheetColumn);
        }

        /// <summary>
        /// Returns true if XlsxSpreadsheetColumn instances are equal
        /// </summary>
        /// <param name="input">Instance of XlsxSpreadsheetColumn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XlsxSpreadsheetColumn input)
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
                    this.HeadingCell == input.HeadingCell ||
                    (this.HeadingCell != null &&
                    this.HeadingCell.Equals(input.HeadingCell))
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
                if (this.HeadingCell != null)
                    hashCode = hashCode * 59 + this.HeadingCell.GetHashCode();
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
