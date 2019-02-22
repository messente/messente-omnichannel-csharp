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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = com.Messente.Omnichannel.Client.OpenAPIDateConverter;

namespace com.Messente.Omnichannel.Model
{
    /// <summary>
    /// SMS message content
    /// </summary>
    [DataContract]
    public partial class SMS :  IEquatable<SMS>
    {
        /// <summary>
        /// Defines how non-GSM characters will be treated: - \&quot;on\&quot; Use replacement settings from the account&#39;s [API Auto Replace settings page](https://dashboard.messente.com/api-settings/auto-replace)(default) - \&quot;full\&quot; All non GSM 03.38 characters will be replaced with suitable alternatives - \&quot;off\&quot; Message content is not modified in any way 
        /// </summary>
        /// <value>Defines how non-GSM characters will be treated: - \&quot;on\&quot; Use replacement settings from the account&#39;s [API Auto Replace settings page](https://dashboard.messente.com/api-settings/auto-replace)(default) - \&quot;full\&quot; All non GSM 03.38 characters will be replaced with suitable alternatives - \&quot;off\&quot; Message content is not modified in any way </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AutoconvertEnum
        {
            /// <summary>
            /// Enum Full for value: full
            /// </summary>
            [EnumMember(Value = "full")]
            Full = 1,

            /// <summary>
            /// Enum On for value: on
            /// </summary>
            [EnumMember(Value = "on")]
            On = 2,

            /// <summary>
            /// Enum Off for value: off
            /// </summary>
            [EnumMember(Value = "off")]
            Off = 3

        }

        /// <summary>
        /// Defines how non-GSM characters will be treated: - \&quot;on\&quot; Use replacement settings from the account&#39;s [API Auto Replace settings page](https://dashboard.messente.com/api-settings/auto-replace)(default) - \&quot;full\&quot; All non GSM 03.38 characters will be replaced with suitable alternatives - \&quot;off\&quot; Message content is not modified in any way 
        /// </summary>
        /// <value>Defines how non-GSM characters will be treated: - \&quot;on\&quot; Use replacement settings from the account&#39;s [API Auto Replace settings page](https://dashboard.messente.com/api-settings/auto-replace)(default) - \&quot;full\&quot; All non GSM 03.38 characters will be replaced with suitable alternatives - \&quot;off\&quot; Message content is not modified in any way </value>
        [DataMember(Name="autoconvert", EmitDefaultValue=false)]
        public AutoconvertEnum? Autoconvert { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SMS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SMS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SMS" /> class.
        /// </summary>
        /// <param name="sender">Phone number or alphanumeric sender name.</param>
        /// <param name="validity">After how many minutes this channel is considered as failed and the next channel is attempted.</param>
        /// <param name="text">Text content of the SMS (required).</param>
        /// <param name="autoconvert">Defines how non-GSM characters will be treated: - \&quot;on\&quot; Use replacement settings from the account&#39;s [API Auto Replace settings page](https://dashboard.messente.com/api-settings/auto-replace)(default) - \&quot;full\&quot; All non GSM 03.38 characters will be replaced with suitable alternatives - \&quot;off\&quot; Message content is not modified in any way .</param>
        /// <param name="udh">hex-encoded string containing SMS UDH.</param>
        /// <param name="channel">channel (default to &quot;sms&quot;).</param>
        public SMS(string sender = default(string), int? validity = default(int?), string text = default(string), AutoconvertEnum? autoconvert = default(AutoconvertEnum?), string udh = default(string), string channel = "sms")
        {
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new InvalidDataException("text is a required property for SMS and cannot be null");
            }
            else
            {
                this.Text = text;
            }
            this.Sender = sender;
            this.Validity = validity;
            this.Autoconvert = autoconvert;
            this.Udh = udh;
            // use default value if no "channel" provided
            if (channel == null)
            {
                this.Channel = "sms";
            }
            else
            {
                this.Channel = channel;
            }
        }
        
        /// <summary>
        /// Phone number or alphanumeric sender name
        /// </summary>
        /// <value>Phone number or alphanumeric sender name</value>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public string Sender { get; set; }

        /// <summary>
        /// After how many minutes this channel is considered as failed and the next channel is attempted
        /// </summary>
        /// <value>After how many minutes this channel is considered as failed and the next channel is attempted</value>
        [DataMember(Name="validity", EmitDefaultValue=false)]
        public int? Validity { get; set; }

        /// <summary>
        /// Text content of the SMS
        /// </summary>
        /// <value>Text content of the SMS</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }


        /// <summary>
        /// hex-encoded string containing SMS UDH
        /// </summary>
        /// <value>hex-encoded string containing SMS UDH</value>
        [DataMember(Name="udh", EmitDefaultValue=false)]
        public string Udh { get; set; }

        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public string Channel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SMS {\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Validity: ").Append(Validity).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Autoconvert: ").Append(Autoconvert).Append("\n");
            sb.Append("  Udh: ").Append(Udh).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
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
            return this.Equals(input as SMS);
        }

        /// <summary>
        /// Returns true if SMS instances are equal
        /// </summary>
        /// <param name="input">Instance of SMS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SMS input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.Validity == input.Validity ||
                    (this.Validity != null &&
                    this.Validity.Equals(input.Validity))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Autoconvert == input.Autoconvert ||
                    (this.Autoconvert != null &&
                    this.Autoconvert.Equals(input.Autoconvert))
                ) && 
                (
                    this.Udh == input.Udh ||
                    (this.Udh != null &&
                    this.Udh.Equals(input.Udh))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
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
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.Validity != null)
                    hashCode = hashCode * 59 + this.Validity.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Autoconvert != null)
                    hashCode = hashCode * 59 + this.Autoconvert.GetHashCode();
                if (this.Udh != null)
                    hashCode = hashCode * 59 + this.Udh.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                return hashCode;
            }
        }
    }

}
