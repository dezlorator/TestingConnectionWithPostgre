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
    /// ExpenseClaim
    /// </summary>
    [DataContract]
    public partial class ExpenseClaim :  IEquatable<ExpenseClaim>, IValidatableObject
    {
        /// <summary>
        /// Current status of an expense claim – see status types
        /// </summary>
        /// <value>Current status of an expense claim – see status types</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum SUBMITTED for value: SUBMITTED
            /// </summary>
            [EnumMember(Value = "SUBMITTED")]
            SUBMITTED = 1,

            /// <summary>
            /// Enum AUTHORISED for value: AUTHORISED
            /// </summary>
            [EnumMember(Value = "AUTHORISED")]
            AUTHORISED = 2,

            /// <summary>
            /// Enum PAID for value: PAID
            /// </summary>
            [EnumMember(Value = "PAID")]
            PAID = 3,

            /// <summary>
            /// Enum VOIDED for value: VOIDED
            /// </summary>
            [EnumMember(Value = "VOIDED")]
            VOIDED = 4,

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            [EnumMember(Value = "DELETED")]
            DELETED = 5

        }

        /// <summary>
        /// Current status of an expense claim – see status types
        /// </summary>
        /// <value>Current status of an expense claim – see status types</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        
        /// <summary>
        /// Xero generated unique identifier for an expense claim
        /// </summary>
        /// <value>Xero generated unique identifier for an expense claim</value>
        [DataMember(Name="ExpenseClaimID", EmitDefaultValue=false)]
        public Guid? ExpenseClaimID { get; set; }

        /// <summary>
        /// See Payments
        /// </summary>
        /// <value>See Payments</value>
        [DataMember(Name="Payments", EmitDefaultValue=false)]
        public List<Payment> Payments { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="User", EmitDefaultValue=false)]
        public User User { get; set; }

        /// <summary>
        /// Gets or Sets Receipts
        /// </summary>
        [DataMember(Name="Receipts", EmitDefaultValue=false)]
        public List<Receipt> Receipts { get; set; }

        /// <summary>
        /// Last modified date UTC format
        /// </summary>
        /// <value>Last modified date UTC format</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// The total of an expense claim being paid
        /// </summary>
        /// <value>The total of an expense claim being paid</value>
        [DataMember(Name="Total", EmitDefaultValue=false)]
        public decimal? Total { get; private set; }

        /// <summary>
        /// The amount due to be paid for an expense claim
        /// </summary>
        /// <value>The amount due to be paid for an expense claim</value>
        [DataMember(Name="AmountDue", EmitDefaultValue=false)]
        public decimal? AmountDue { get; private set; }

        /// <summary>
        /// The amount still to pay for an expense claim
        /// </summary>
        /// <value>The amount still to pay for an expense claim</value>
        [DataMember(Name="AmountPaid", EmitDefaultValue=false)]
        public decimal? AmountPaid { get; private set; }

        /// <summary>
        /// The date when the expense claim is due to be paid YYYY-MM-DD
        /// </summary>
        /// <value>The date when the expense claim is due to be paid YYYY-MM-DD</value>
        [DataMember(Name="PaymentDueDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? PaymentDueDate { get; private set; }

        /// <summary>
        /// The date the expense claim will be reported in Xero YYYY-MM-DD
        /// </summary>
        /// <value>The date the expense claim will be reported in Xero YYYY-MM-DD</value>
        [DataMember(Name="ReportingDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? ReportingDate { get; private set; }

        /// <summary>
        /// The Xero identifier for the Receipt e.g.  e59a2c7f-1306-4078-a0f3-73537afcbba9
        /// </summary>
        /// <value>The Xero identifier for the Receipt e.g.  e59a2c7f-1306-4078-a0f3-73537afcbba9</value>
        [DataMember(Name="ReceiptID", EmitDefaultValue=false)]
        public Guid? ReceiptID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpenseClaim {\n");
            sb.Append("  ExpenseClaimID: ").Append(ExpenseClaimID).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Receipts: ").Append(Receipts).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  AmountDue: ").Append(AmountDue).Append("\n");
            sb.Append("  AmountPaid: ").Append(AmountPaid).Append("\n");
            sb.Append("  PaymentDueDate: ").Append(PaymentDueDate).Append("\n");
            sb.Append("  ReportingDate: ").Append(ReportingDate).Append("\n");
            sb.Append("  ReceiptID: ").Append(ReceiptID).Append("\n");
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
            return this.Equals(input as ExpenseClaim);
        }

        /// <summary>
        /// Returns true if ExpenseClaim instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpenseClaim to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpenseClaim input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExpenseClaimID == input.ExpenseClaimID ||
                    (this.ExpenseClaimID != null &&
                    this.ExpenseClaimID.Equals(input.ExpenseClaimID))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Payments == input.Payments ||
                    this.Payments != null &&
                    input.Payments != null &&
                    this.Payments.SequenceEqual(input.Payments)
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Receipts == input.Receipts ||
                    this.Receipts != null &&
                    input.Receipts != null &&
                    this.Receipts.SequenceEqual(input.Receipts)
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.AmountDue == input.AmountDue ||
                    this.AmountDue.Equals(input.AmountDue)
                ) && 
                (
                    this.AmountPaid == input.AmountPaid ||
                    this.AmountPaid.Equals(input.AmountPaid)
                ) && 
                (
                    this.PaymentDueDate == input.PaymentDueDate ||
                    (this.PaymentDueDate != null &&
                    this.PaymentDueDate.Equals(input.PaymentDueDate))
                ) && 
                (
                    this.ReportingDate == input.ReportingDate ||
                    (this.ReportingDate != null &&
                    this.ReportingDate.Equals(input.ReportingDate))
                ) && 
                (
                    this.ReceiptID == input.ReceiptID ||
                    (this.ReceiptID != null &&
                    this.ReceiptID.Equals(input.ReceiptID))
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
                if (this.ExpenseClaimID != null)
                    hashCode = hashCode * 59 + this.ExpenseClaimID.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Payments != null)
                    hashCode = hashCode * 59 + this.Payments.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Receipts != null)
                    hashCode = hashCode * 59 + this.Receipts.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                hashCode = hashCode * 59 + this.Total.GetHashCode();
                hashCode = hashCode * 59 + this.AmountDue.GetHashCode();
                hashCode = hashCode * 59 + this.AmountPaid.GetHashCode();
                if (this.PaymentDueDate != null)
                    hashCode = hashCode * 59 + this.PaymentDueDate.GetHashCode();
                if (this.ReportingDate != null)
                    hashCode = hashCode * 59 + this.ReportingDate.GetHashCode();
                if (this.ReceiptID != null)
                    hashCode = hashCode * 59 + this.ReceiptID.GetHashCode();
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
