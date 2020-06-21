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
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// AccountsPayable
    /// </summary>
    [DataContract]
    public partial class AccountsPayable :  IEquatable<AccountsPayable>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets Outstanding
        /// </summary>
        [DataMember(Name="Outstanding", EmitDefaultValue=false)]
        public decimal? Outstanding { get; set; }

        /// <summary>
        /// Gets or Sets Overdue
        /// </summary>
        [DataMember(Name="Overdue", EmitDefaultValue=false)]
        public decimal? Overdue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountsPayable {\n");
            sb.Append("  Outstanding: ").Append(Outstanding).Append("\n");
            sb.Append("  Overdue: ").Append(Overdue).Append("\n");
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
            return this.Equals(input as AccountsPayable);
        }

        /// <summary>
        /// Returns true if AccountsPayable instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountsPayable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountsPayable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Outstanding == input.Outstanding ||
                    this.Outstanding.Equals(input.Outstanding)
                ) && 
                (
                    this.Overdue == input.Overdue ||
                    this.Overdue.Equals(input.Overdue)
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
                hashCode = hashCode * 59 + this.Outstanding.GetHashCode();
                hashCode = hashCode * 59 + this.Overdue.GetHashCode();
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
