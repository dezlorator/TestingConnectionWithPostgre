/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
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

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// SuperFundProducts
    /// </summary>
    [DataContract]
    public partial class SuperFundProducts :  IEquatable<SuperFundProducts>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets _SuperFundProducts
        /// </summary>
        [DataMember(Name="SuperFundProducts", EmitDefaultValue=false)]
        public List<SuperFundProduct> _SuperFundProducts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuperFundProducts {\n");
            sb.Append("  _SuperFundProducts: ").Append(_SuperFundProducts).Append("\n");
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
            return this.Equals(input as SuperFundProducts);
        }

        /// <summary>
        /// Returns true if SuperFundProducts instances are equal
        /// </summary>
        /// <param name="input">Instance of SuperFundProducts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuperFundProducts input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._SuperFundProducts == input._SuperFundProducts ||
                    this._SuperFundProducts != null &&
                    input._SuperFundProducts != null &&
                    this._SuperFundProducts.SequenceEqual(input._SuperFundProducts)
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
                if (this._SuperFundProducts != null)
                    hashCode = hashCode * 59 + this._SuperFundProducts.GetHashCode();
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
