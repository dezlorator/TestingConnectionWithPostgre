/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.2.2
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// Attachments
    /// </summary>
    [DataContract]
    public partial class Attachments :  IEquatable<Attachments>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets _Attachments
        /// </summary>
        [DataMember(Name="Attachments", EmitDefaultValue=false)]
        public List<Attachment> _Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attachments {\n");
            sb.Append("  _Attachments: ").Append(_Attachments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as Attachments);
        }

        /// <summary>
        /// Returns true if Attachments instances are equal
        /// </summary>
        /// <param name="input">Instance of Attachments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Attachments input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Attachments == input._Attachments ||
                    this._Attachments != null &&
                    input._Attachments != null &&
                    this._Attachments.SequenceEqual(input._Attachments)
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
                if (this._Attachments != null)
                    hashCode = hashCode * 59 + this._Attachments.GetHashCode();
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
