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
    /// Viber
    /// </summary>
    [DataContract]
    public partial class Viber : Message,  IEquatable<Viber>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Viber" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Viber() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Viber" /> class.
        /// </summary>
        /// <param name="text">Plaintext content for Viber.</param>
        /// <param name="imageUrl">URL for the embedded image. Valid combinations: 1) &#39;image_url&#39; 2) &#39;text&#39;, &#39;image_url&#39;, &#39;button_url&#39;, &#39;button_text&#39;.</param>
        /// <param name="buttonUrl">URL of the button, must be specified along with &#39;text&#39;, &#39;button_text&#39;  and &#39;image_url&#39; (optional).</param>
        /// <param name="buttonText">Must be specified along with &#39;text&#39;, &#39;button_url&#39;, &#39;button_text&#39;, &#39;image_url&#39; (optional).</param>
        public Viber(string text = default(string), string imageUrl = default(string), string buttonUrl = default(string), string buttonText = default(string), string channel = default(string), string sender = default(string), int? validity = default(int?)) : base(channel, sender, validity)
        {
            this.Text = text;
            this.ImageUrl = imageUrl;
            this.ButtonUrl = buttonUrl;
            this.ButtonText = buttonText;
        }
        
        /// <summary>
        /// Plaintext content for Viber
        /// </summary>
        /// <value>Plaintext content for Viber</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// URL for the embedded image. Valid combinations: 1) &#39;image_url&#39; 2) &#39;text&#39;, &#39;image_url&#39;, &#39;button_url&#39;, &#39;button_text&#39;
        /// </summary>
        /// <value>URL for the embedded image. Valid combinations: 1) &#39;image_url&#39; 2) &#39;text&#39;, &#39;image_url&#39;, &#39;button_url&#39;, &#39;button_text&#39;</value>
        [DataMember(Name="image_url", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// URL of the button, must be specified along with &#39;text&#39;, &#39;button_text&#39;  and &#39;image_url&#39; (optional)
        /// </summary>
        /// <value>URL of the button, must be specified along with &#39;text&#39;, &#39;button_text&#39;  and &#39;image_url&#39; (optional)</value>
        [DataMember(Name="button_url", EmitDefaultValue=false)]
        public string ButtonUrl { get; set; }

        /// <summary>
        /// Must be specified along with &#39;text&#39;, &#39;button_url&#39;, &#39;button_text&#39;, &#39;image_url&#39; (optional)
        /// </summary>
        /// <value>Must be specified along with &#39;text&#39;, &#39;button_url&#39;, &#39;button_text&#39;, &#39;image_url&#39; (optional)</value>
        [DataMember(Name="button_text", EmitDefaultValue=false)]
        public string ButtonText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Viber {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  ButtonUrl: ").Append(ButtonUrl).Append("\n");
            sb.Append("  ButtonText: ").Append(ButtonText).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as Viber);
        }

        /// <summary>
        /// Returns true if Viber instances are equal
        /// </summary>
        /// <param name="input">Instance of Viber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Viber input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && base.Equals(input) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && base.Equals(input) && 
                (
                    this.ButtonUrl == input.ButtonUrl ||
                    (this.ButtonUrl != null &&
                    this.ButtonUrl.Equals(input.ButtonUrl))
                ) && base.Equals(input) && 
                (
                    this.ButtonText == input.ButtonText ||
                    (this.ButtonText != null &&
                    this.ButtonText.Equals(input.ButtonText))
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
                int hashCode = base.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.ButtonUrl != null)
                    hashCode = hashCode * 59 + this.ButtonUrl.GetHashCode();
                if (this.ButtonText != null)
                    hashCode = hashCode * 59 + this.ButtonText.GetHashCode();
                return hashCode;
            }
        }
    }

}
