/*
 * Private API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Auth.Private.Client.Client.FileParameter;
using OpenAPIDateConverter = Auth.Private.Client.Client.OpenAPIDateConverter;

namespace Auth.Private.Client.Model
{
    /// <summary>
    /// ApiApiPrivateLoginCallbackRejectResponse
    /// </summary>
    [DataContract(Name = "Api.Api.Private.LoginCallback.RejectResponse")]
    public partial class ApiApiPrivateLoginCallbackRejectResponse : IEquatable<ApiApiPrivateLoginCallbackRejectResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiApiPrivateLoginCallbackRejectResponse" /> class.
        /// </summary>
        /// <param name="loginResponseId">loginResponseId.</param>
        public ApiApiPrivateLoginCallbackRejectResponse(string loginResponseId = default(string))
        {
            this.LoginResponseId = loginResponseId;
        }

        /// <summary>
        /// Gets or Sets LoginResponseId
        /// </summary>
        [DataMember(Name = "loginResponseId", EmitDefaultValue = true)]
        public string LoginResponseId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiApiPrivateLoginCallbackRejectResponse {\n");
            sb.Append("  LoginResponseId: ").Append(LoginResponseId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApiApiPrivateLoginCallbackRejectResponse);
        }

        /// <summary>
        /// Returns true if ApiApiPrivateLoginCallbackRejectResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiApiPrivateLoginCallbackRejectResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiApiPrivateLoginCallbackRejectResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LoginResponseId == input.LoginResponseId ||
                    (this.LoginResponseId != null &&
                    this.LoginResponseId.Equals(input.LoginResponseId))
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
                if (this.LoginResponseId != null)
                {
                    hashCode = (hashCode * 59) + this.LoginResponseId.GetHashCode();
                }
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
