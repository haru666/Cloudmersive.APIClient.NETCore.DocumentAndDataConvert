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
    /// Input to a Insert Tables request
    /// </summary>
    [DataContract]
    public partial class InsertDocxTablesRequest :  IEquatable<InsertDocxTablesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsertDocxTablesRequest" /> class.
        /// </summary>
        /// <param name="InputFileBytes">Optional: Bytes of the input file to operate on.</param>
        /// <param name="InputFileUrl">Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public)..</param>
        /// <param name="TableToInsert">Table you would like to insert.</param>
        /// <param name="InsertPlacement">Optional; default is DocumentEnd.  Placement Type of the insert; possible values are: DocumentStart (very beginning of the document), DocumentEnd (very end of the document), BeforeExistingObject (right before an existing object - fill in the InsertPath field using the Path value from an existing object), AfterExistingObject (right after an existing object - fill in the InsertPath field using the Path value from an existing object).</param>
        /// <param name="InsertPath">Optional; location within the document to insert the object; fill in the InsertPath field using the Path value from an existing object.  Used with InsertPlacement of BeforeExistingObject or AfterExistingObject.</param>
        public InsertDocxTablesRequest(byte[] InputFileBytes = default(byte[]), string InputFileUrl = default(string), DocxTable TableToInsert = default(DocxTable), string InsertPlacement = default(string), string InsertPath = default(string))
        {
            this.InputFileBytes = InputFileBytes;
            this.InputFileUrl = InputFileUrl;
            this.TableToInsert = TableToInsert;
            this.InsertPlacement = InsertPlacement;
            this.InsertPath = InsertPath;
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
        /// Table you would like to insert
        /// </summary>
        /// <value>Table you would like to insert</value>
        [DataMember(Name="TableToInsert", EmitDefaultValue=false)]
        public DocxTable TableToInsert { get; set; }

        /// <summary>
        /// Optional; default is DocumentEnd.  Placement Type of the insert; possible values are: DocumentStart (very beginning of the document), DocumentEnd (very end of the document), BeforeExistingObject (right before an existing object - fill in the InsertPath field using the Path value from an existing object), AfterExistingObject (right after an existing object - fill in the InsertPath field using the Path value from an existing object)
        /// </summary>
        /// <value>Optional; default is DocumentEnd.  Placement Type of the insert; possible values are: DocumentStart (very beginning of the document), DocumentEnd (very end of the document), BeforeExistingObject (right before an existing object - fill in the InsertPath field using the Path value from an existing object), AfterExistingObject (right after an existing object - fill in the InsertPath field using the Path value from an existing object)</value>
        [DataMember(Name="InsertPlacement", EmitDefaultValue=false)]
        public string InsertPlacement { get; set; }

        /// <summary>
        /// Optional; location within the document to insert the object; fill in the InsertPath field using the Path value from an existing object.  Used with InsertPlacement of BeforeExistingObject or AfterExistingObject
        /// </summary>
        /// <value>Optional; location within the document to insert the object; fill in the InsertPath field using the Path value from an existing object.  Used with InsertPlacement of BeforeExistingObject or AfterExistingObject</value>
        [DataMember(Name="InsertPath", EmitDefaultValue=false)]
        public string InsertPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InsertDocxTablesRequest {\n");
            sb.Append("  InputFileBytes: ").Append(InputFileBytes).Append("\n");
            sb.Append("  InputFileUrl: ").Append(InputFileUrl).Append("\n");
            sb.Append("  TableToInsert: ").Append(TableToInsert).Append("\n");
            sb.Append("  InsertPlacement: ").Append(InsertPlacement).Append("\n");
            sb.Append("  InsertPath: ").Append(InsertPath).Append("\n");
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
            return this.Equals(input as InsertDocxTablesRequest);
        }

        /// <summary>
        /// Returns true if InsertDocxTablesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of InsertDocxTablesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsertDocxTablesRequest input)
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
                    this.TableToInsert == input.TableToInsert ||
                    (this.TableToInsert != null &&
                    this.TableToInsert.Equals(input.TableToInsert))
                ) && 
                (
                    this.InsertPlacement == input.InsertPlacement ||
                    (this.InsertPlacement != null &&
                    this.InsertPlacement.Equals(input.InsertPlacement))
                ) && 
                (
                    this.InsertPath == input.InsertPath ||
                    (this.InsertPath != null &&
                    this.InsertPath.Equals(input.InsertPath))
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
                if (this.TableToInsert != null)
                    hashCode = hashCode * 59 + this.TableToInsert.GetHashCode();
                if (this.InsertPlacement != null)
                    hashCode = hashCode * 59 + this.InsertPlacement.GetHashCode();
                if (this.InsertPath != null)
                    hashCode = hashCode * 59 + this.InsertPath.GetHashCode();
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
