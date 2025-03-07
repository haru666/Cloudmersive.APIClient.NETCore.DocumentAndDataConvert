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
    /// Input to a string replacement request
    /// </summary>
    [DataContract]
    public partial class ReplaceStringRequest :  IEquatable<ReplaceStringRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceStringRequest" /> class.
        /// </summary>
        /// <param name="InputFileBytes">Optional: Bytes of the input file to operate on.</param>
        /// <param name="InputFileUrl">Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public)..</param>
        /// <param name="MatchString">String to search for and match against, to be replaced.</param>
        /// <param name="ReplaceString">String to replace the matched values with.</param>
        /// <param name="MatchCase">True if the case should be matched, false for case insensitive match.</param>
        public ReplaceStringRequest(byte[] InputFileBytes = default(byte[]), string InputFileUrl = default(string), string MatchString = default(string), string ReplaceString = default(string), bool? MatchCase = default(bool?))
        {
            this.InputFileBytes = InputFileBytes;
            this.InputFileUrl = InputFileUrl;
            this.MatchString = MatchString;
            this.ReplaceString = ReplaceString;
            this.MatchCase = MatchCase;
        }
        
        /// <summary>
        /// Optional: Bytes of the input file to operate on
        /// </summary>
        /// <value>Optional: Bytes of the input file to operate on</value>
        [DataMember(Name="InputFileBytes", EmitDefaultValue=false)]
        public byte[] InputFileBytes { get; set; }

        /// <summary>
        /// Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public).
        /// </summary>
        /// <value>Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public).</value>
        [DataMember(Name="InputFileUrl", EmitDefaultValue=false)]
        public string InputFileUrl { get; set; }

        /// <summary>
        /// String to search for and match against, to be replaced
        /// </summary>
        /// <value>String to search for and match against, to be replaced</value>
        [DataMember(Name="MatchString", EmitDefaultValue=false)]
        public string MatchString { get; set; }

        /// <summary>
        /// String to replace the matched values with
        /// </summary>
        /// <value>String to replace the matched values with</value>
        [DataMember(Name="ReplaceString", EmitDefaultValue=false)]
        public string ReplaceString { get; set; }

        /// <summary>
        /// True if the case should be matched, false for case insensitive match
        /// </summary>
        /// <value>True if the case should be matched, false for case insensitive match</value>
        [DataMember(Name="MatchCase", EmitDefaultValue=false)]
        public bool? MatchCase { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplaceStringRequest {\n");
            sb.Append("  InputFileBytes: ").Append(InputFileBytes).Append("\n");
            sb.Append("  InputFileUrl: ").Append(InputFileUrl).Append("\n");
            sb.Append("  MatchString: ").Append(MatchString).Append("\n");
            sb.Append("  ReplaceString: ").Append(ReplaceString).Append("\n");
            sb.Append("  MatchCase: ").Append(MatchCase).Append("\n");
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
            return this.Equals(input as ReplaceStringRequest);
        }

        /// <summary>
        /// Returns true if ReplaceStringRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplaceStringRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplaceStringRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InputFileBytes == input.InputFileBytes ||
                    (this.InputFileBytes != null &&
                    this.InputFileBytes.Equals(input.InputFileBytes))
                ) && 
                (
                    this.InputFileUrl == input.InputFileUrl ||
                    (this.InputFileUrl != null &&
                    this.InputFileUrl.Equals(input.InputFileUrl))
                ) && 
                (
                    this.MatchString == input.MatchString ||
                    (this.MatchString != null &&
                    this.MatchString.Equals(input.MatchString))
                ) && 
                (
                    this.ReplaceString == input.ReplaceString ||
                    (this.ReplaceString != null &&
                    this.ReplaceString.Equals(input.ReplaceString))
                ) && 
                (
                    this.MatchCase == input.MatchCase ||
                    (this.MatchCase != null &&
                    this.MatchCase.Equals(input.MatchCase))
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
                if (this.InputFileBytes != null)
                    hashCode = hashCode * 59 + this.InputFileBytes.GetHashCode();
                if (this.InputFileUrl != null)
                    hashCode = hashCode * 59 + this.InputFileUrl.GetHashCode();
                if (this.MatchString != null)
                    hashCode = hashCode * 59 + this.MatchString.GetHashCode();
                if (this.ReplaceString != null)
                    hashCode = hashCode * 59 + this.ReplaceString.GetHashCode();
                if (this.MatchCase != null)
                    hashCode = hashCode * 59 + this.MatchCase.GetHashCode();
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
