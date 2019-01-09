/* 
 * Omnichannel API
 *
 * Messente's API which allows sending messages via various channels with fallback options.
 *
 * OpenAPI spec version: 0.0.2
 * Contact: messente@messente.com
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
using OpenAPIDateConverter = com.Messente.Omnichannel.Client.OpenAPIDateConverter;

namespace com.Messente.Omnichannel.Model
{
    /// <summary>
    /// OmniMessageCreateSuccessResponse
    /// </summary>
    [DataContract]
    public partial class OmniMessageCreateSuccessResponse :  IEquatable<OmniMessageCreateSuccessResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OmniMessageCreateSuccessResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OmniMessageCreateSuccessResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OmniMessageCreateSuccessResponse" /> class.
        /// </summary>
        /// <param name="messages">List of messages that compose the Omnimessage (required).</param>
        /// <param name="to">Recipient phone number in e.164 format (required).</param>
        /// <param name="omnimessageId">Unique identifier for the Omnimessage (required).</param>
        public OmniMessageCreateSuccessResponse(List<MessageResult> messages = default(List<MessageResult>), string to = default(string), Guid? omnimessageId = default(Guid?))
        {
            // to ensure "messages" is required (not null)
            if (messages == null)
            {
                throw new InvalidDataException("messages is a required property for OmniMessageCreateSuccessResponse and cannot be null");
            }
            else
            {
                this.Messages = messages;
            }
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new InvalidDataException("to is a required property for OmniMessageCreateSuccessResponse and cannot be null");
            }
            else
            {
                this.To = to;
            }
            // to ensure "omnimessageId" is required (not null)
            if (omnimessageId == null)
            {
                throw new InvalidDataException("omnimessageId is a required property for OmniMessageCreateSuccessResponse and cannot be null");
            }
            else
            {
                this.OmnimessageId = omnimessageId;
            }
        }
        
        /// <summary>
        /// List of messages that compose the Omnimessage
        /// </summary>
        /// <value>List of messages that compose the Omnimessage</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<MessageResult> Messages { get; set; }

        /// <summary>
        /// Recipient phone number in e.164 format
        /// </summary>
        /// <value>Recipient phone number in e.164 format</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// Unique identifier for the Omnimessage
        /// </summary>
        /// <value>Unique identifier for the Omnimessage</value>
        [DataMember(Name="omnimessage_id", EmitDefaultValue=false)]
        public Guid? OmnimessageId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OmniMessageCreateSuccessResponse {\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  OmnimessageId: ").Append(OmnimessageId).Append("\n");
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
            return this.Equals(input as OmniMessageCreateSuccessResponse);
        }

        /// <summary>
        /// Returns true if OmniMessageCreateSuccessResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OmniMessageCreateSuccessResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OmniMessageCreateSuccessResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.OmnimessageId == input.OmnimessageId ||
                    (this.OmnimessageId != null &&
                    this.OmnimessageId.Equals(input.OmnimessageId))
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
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.OmnimessageId != null)
                    hashCode = hashCode * 59 + this.OmnimessageId.GetHashCode();
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