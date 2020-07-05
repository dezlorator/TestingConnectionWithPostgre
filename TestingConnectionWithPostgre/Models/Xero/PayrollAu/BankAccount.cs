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
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// BankAccount
    /// </summary>
    [DataContract]
    public partial class BankAccount :  IEquatable<BankAccount>, IValidatableObject
    {
        
        /// <summary>
        /// The text that will appear on your employee&#39;s bank statement when they receive payment
        /// </summary>
        /// <value>The text that will appear on your employee&#39;s bank statement when they receive payment</value>
        [DataMember(Name="StatementText", EmitDefaultValue=false)]
        public string StatementText { get; set; }

        /// <summary>
        /// The name of the account
        /// </summary>
        /// <value>The name of the account</value>
        [DataMember(Name="AccountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The BSB number of the account
        /// </summary>
        /// <value>The BSB number of the account</value>
        [DataMember(Name="BSB", EmitDefaultValue=false)]
        public string BSB { get; set; }

        /// <summary>
        /// The account number
        /// </summary>
        /// <value>The account number</value>
        [DataMember(Name="AccountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// If this account is the Remaining bank account
        /// </summary>
        /// <value>If this account is the Remaining bank account</value>
        [DataMember(Name="Remainder", EmitDefaultValue=false)]
        public bool? Remainder { get; set; }

        /// <summary>
        /// Fixed amounts (for example, if an employee wants to have $100 of their salary transferred to one account, and the remaining amount to another)
        /// </summary>
        /// <value>Fixed amounts (for example, if an employee wants to have $100 of their salary transferred to one account, and the remaining amount to another)</value>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankAccount {\n");
            sb.Append("  StatementText: ").Append(StatementText).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  BSB: ").Append(BSB).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Remainder: ").Append(Remainder).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as BankAccount);
        }

        /// <summary>
        /// Returns true if BankAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of BankAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StatementText == input.StatementText ||
                    (this.StatementText != null &&
                    this.StatementText.Equals(input.StatementText))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.BSB == input.BSB ||
                    (this.BSB != null &&
                    this.BSB.Equals(input.BSB))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.Remainder == input.Remainder ||
                    this.Remainder.Equals(input.Remainder)
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
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
                if (this.StatementText != null)
                    hashCode = hashCode * 59 + this.StatementText.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.BSB != null)
                    hashCode = hashCode * 59 + this.BSB.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                hashCode = hashCode * 59 + this.Remainder.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
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
