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
    /// DeliveryResult
    /// </summary>
    [DataContract]
    public partial class DeliveryResult :  IEquatable<DeliveryResult>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public Status? Status { get; set; }
        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public Channel? Channel { get; set; }
        /// <summary>
        /// Gets or Sets Err
        /// </summary>
        [DataMember(Name="err", EmitDefaultValue=false)]
        public Err? Err { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryResult" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="channel">channel.</param>
        /// <param name="messageId">Unique identifier for the message.</param>
        /// <param name="error">Human-readable description of what went wrong, *null* in case of success or if the messages has not been processed yet.</param>
        /// <param name="err">err.</param>
        /// <param name="timestamp">When this status was received by Omnichannel API.</param>
        public DeliveryResult(Status? status = default(Status?), Channel? channel = default(Channel?), Guid? messageId = default(Guid?), string error = default(string), Err? err = default(Err?), DateTime? timestamp = default(DateTime?))
        {
            this.Status = status;
            this.Channel = channel;
            this.MessageId = messageId;
            this.Error = error;
            this.Err = err;
            this.Timestamp = timestamp;
        }
        


        /// <summary>
        /// Unique identifier for the message
        /// </summary>
        /// <value>Unique identifier for the message</value>
        [DataMember(Name="message_id", EmitDefaultValue=false)]
        public Guid? MessageId { get; set; }

        /// <summary>
        /// Human-readable description of what went wrong, *null* in case of success or if the messages has not been processed yet
        /// </summary>
        /// <value>Human-readable description of what went wrong, *null* in case of success or if the messages has not been processed yet</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }


        /// <summary>
        /// When this status was received by Omnichannel API
        /// </summary>
        /// <value>When this status was received by Omnichannel API</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeliveryResult {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Err: ").Append(Err).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as DeliveryResult);
        }

        /// <summary>
        /// Returns true if DeliveryResult instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Err == input.Err ||
                    (this.Err != null &&
                    this.Err.Equals(input.Err))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Err != null)
                    hashCode = hashCode * 59 + this.Err.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
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
