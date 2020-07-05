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
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using TestingConnectionWithPostgre.Models.Convertors;

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// BatchPayment
    /// </summary>
    [DataContract]
    public partial class BatchPayment :  IEquatable<BatchPayment>, IValidatableObject
    {
        /// <summary>
        /// PAYBATCH for bill payments or RECBATCH for sales invoice payments (read-only)
        /// </summary>
        /// <value>PAYBATCH for bill payments or RECBATCH for sales invoice payments (read-only)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum PAYBATCH for value: PAYBATCH
            /// </summary>
            [EnumMember(Value = "PAYBATCH")]
            PAYBATCH = 1,

            /// <summary>
            /// Enum RECBATCH for value: RECBATCH
            /// </summary>
            [EnumMember(Value = "RECBATCH")]
            RECBATCH = 2

        }

        /// <summary>
        /// PAYBATCH for bill payments or RECBATCH for sales invoice payments (read-only)
        /// </summary>
        /// <value>PAYBATCH for bill payments or RECBATCH for sales invoice payments (read-only)</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// AUTHORISED or DELETED (read-only). New batch payments will have a status of AUTHORISED. It is not possible to delete batch payments via the API.
        /// </summary>
        /// <value>AUTHORISED or DELETED (read-only). New batch payments will have a status of AUTHORISED. It is not possible to delete batch payments via the API.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum AUTHORISED for value: AUTHORISED
            /// </summary>
            [EnumMember(Value = "AUTHORISED")]
            AUTHORISED = 1,

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            [EnumMember(Value = "DELETED")]
            DELETED = 2

        }

        /// <summary>
        /// AUTHORISED or DELETED (read-only). New batch payments will have a status of AUTHORISED. It is not possible to delete batch payments via the API.
        /// </summary>
        /// <value>AUTHORISED or DELETED (read-only). New batch payments will have a status of AUTHORISED. It is not possible to delete batch payments via the API.</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        
        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="Account", EmitDefaultValue=false)]
        public Account Account { get; set; }

        /// <summary>
        /// (NZ Only) Optional references for the batch payment transaction. It will also show with the batch payment transaction in the bank reconciliation Find &amp; Match screen. Depending on your individual bank, the detail may also show on the bank statement you import into Xero.
        /// </summary>
        /// <value>(NZ Only) Optional references for the batch payment transaction. It will also show with the batch payment transaction in the bank reconciliation Find &amp; Match screen. Depending on your individual bank, the detail may also show on the bank statement you import into Xero.</value>
        [DataMember(Name="Reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// (NZ Only) Optional references for the batch payment transaction. It will also show with the batch payment transaction in the bank reconciliation Find &amp; Match screen. Depending on your individual bank, the detail may also show on the bank statement you import into Xero.
        /// </summary>
        /// <value>(NZ Only) Optional references for the batch payment transaction. It will also show with the batch payment transaction in the bank reconciliation Find &amp; Match screen. Depending on your individual bank, the detail may also show on the bank statement you import into Xero.</value>
        [DataMember(Name="Particulars", EmitDefaultValue=false)]
        public string Particulars { get; set; }

        /// <summary>
        /// (NZ Only) Optional references for the batch payment transaction. It will also show with the batch payment transaction in the bank reconciliation Find &amp; Match screen. Depending on your individual bank, the detail may also show on the bank statement you import into Xero.
        /// </summary>
        /// <value>(NZ Only) Optional references for the batch payment transaction. It will also show with the batch payment transaction in the bank reconciliation Find &amp; Match screen. Depending on your individual bank, the detail may also show on the bank statement you import into Xero.</value>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// (Non-NZ Only) These details are sent to the org’s bank as a reference for the batch payment transaction. They will also show with the batch payment transaction in the bank reconciliation Find &amp; Match screen. Depending on your individual bank, the detail may also show on the bank statement imported into Xero. Maximum field length &#x3D; 18
        /// </summary>
        /// <value>(Non-NZ Only) These details are sent to the org’s bank as a reference for the batch payment transaction. They will also show with the batch payment transaction in the bank reconciliation Find &amp; Match screen. Depending on your individual bank, the detail may also show on the bank statement imported into Xero. Maximum field length &#x3D; 18</value>
        [DataMember(Name="Details", EmitDefaultValue=false)]
        public string Details { get; set; }

        /// <summary>
        /// (UK Only) Only shows on the statement line in Xero. Max length &#x3D;18
        /// </summary>
        /// <value>(UK Only) Only shows on the statement line in Xero. Max length &#x3D;18</value>
        [DataMember(Name="Narrative", EmitDefaultValue=false)]
        public string Narrative { get; set; }

        /// <summary>
        /// The Xero generated unique identifier for the bank transaction (read-only)
        /// </summary>
        /// <value>The Xero generated unique identifier for the bank transaction (read-only)</value>
        [DataMember(Name="BatchPaymentID", EmitDefaultValue=false)]
        public Guid? BatchPaymentID { get; private set; }

        /// <summary>
        /// Date the payment is being made (YYYY-MM-DD) e.g. 2009-09-06
        /// </summary>
        /// <value>Date the payment is being made (YYYY-MM-DD) e.g. 2009-09-06</value>
        [DataMember(Name="DateString", EmitDefaultValue=false)]
        public string DateString { get; set; }

        /// <summary>
        /// Date the payment is being made (YYYY-MM-DD) e.g. 2009-09-06
        /// </summary>
        /// <value>Date the payment is being made (YYYY-MM-DD) e.g. 2009-09-06</value>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The amount of the payment. Must be less than or equal to the outstanding amount owing on the invoice e.g. 200.00
        /// </summary>
        /// <value>The amount of the payment. Must be less than or equal to the outstanding amount owing on the invoice e.g. 200.00</value>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Gets or Sets Payments
        /// </summary>
        [DataMember(Name="Payments", EmitDefaultValue=false)]
        public List<Payment> Payments { get; set; }

        /// <summary>
        /// The total of the payments that make up the batch (read-only)
        /// </summary>
        /// <value>The total of the payments that make up the batch (read-only)</value>
        [DataMember(Name="TotalAmount", EmitDefaultValue=false)]
        public string TotalAmount { get; private set; }

        /// <summary>
        /// UTC timestamp of last update to the payment
        /// </summary>
        /// <value>UTC timestamp of last update to the payment</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// Booelan that tells you if the batch payment has been reconciled (read-only)
        /// </summary>
        /// <value>Booelan that tells you if the batch payment has been reconciled (read-only)</value>
        [DataMember(Name="IsReconciled", EmitDefaultValue=false)]
        public string IsReconciled { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchPayment {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Particulars: ").Append(Particulars).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Narrative: ").Append(Narrative).Append("\n");
            sb.Append("  BatchPaymentID: ").Append(BatchPaymentID).Append("\n");
            sb.Append("  DateString: ").Append(DateString).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  IsReconciled: ").Append(IsReconciled).Append("\n");
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
            return this.Equals(input as BatchPayment);
        }

        /// <summary>
        /// Returns true if BatchPayment instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchPayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchPayment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Particulars == input.Particulars ||
                    (this.Particulars != null &&
                    this.Particulars.Equals(input.Particulars))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.Narrative == input.Narrative ||
                    (this.Narrative != null &&
                    this.Narrative.Equals(input.Narrative))
                ) && 
                (
                    this.BatchPaymentID == input.BatchPaymentID ||
                    (this.BatchPaymentID != null &&
                    this.BatchPaymentID.Equals(input.BatchPaymentID))
                ) && 
                (
                    this.DateString == input.DateString ||
                    (this.DateString != null &&
                    this.DateString.Equals(input.DateString))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Payments == input.Payments ||
                    this.Payments != null &&
                    input.Payments != null &&
                    this.Payments.SequenceEqual(input.Payments)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.IsReconciled == input.IsReconciled ||
                    (this.IsReconciled != null &&
                    this.IsReconciled.Equals(input.IsReconciled))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.Particulars != null)
                    hashCode = hashCode * 59 + this.Particulars.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Narrative != null)
                    hashCode = hashCode * 59 + this.Narrative.GetHashCode();
                if (this.BatchPaymentID != null)
                    hashCode = hashCode * 59 + this.BatchPaymentID.GetHashCode();
                if (this.DateString != null)
                    hashCode = hashCode * 59 + this.DateString.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Payments != null)
                    hashCode = hashCode * 59 + this.Payments.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TotalAmount != null)
                    hashCode = hashCode * 59 + this.TotalAmount.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                if (this.IsReconciled != null)
                    hashCode = hashCode * 59 + this.IsReconciled.GetHashCode();
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
            // Reference (string) maxLength
            if(this.Reference != null && this.Reference.Length > 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, length must be less than 12.", new [] { "Reference" });
            }

            // Particulars (string) maxLength
            if(this.Particulars != null && this.Particulars.Length > 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Particulars, length must be less than 12.", new [] { "Particulars" });
            }

            // Code (string) maxLength
            if(this.Code != null && this.Code.Length > 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than 12.", new [] { "Code" });
            }

            // Details (string) maxLength
            if(this.Details != null && this.Details.Length > 18)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Details, length must be less than 18.", new [] { "Details" });
            }

            // Narrative (string) maxLength
            if(this.Narrative != null && this.Narrative.Length > 18)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Narrative, length must be less than 18.", new [] { "Narrative" });
            }

            yield break;
        }
    }

}
