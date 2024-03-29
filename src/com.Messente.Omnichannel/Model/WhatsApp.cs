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
    /// WhatsApp
    /// </summary>
    [DataContract]
    public partial class WhatsApp : Message,  IEquatable<WhatsApp>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsApp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WhatsApp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsApp" /> class.
        /// </summary>
        /// <param name="text">text.</param>
        /// <param name="image">image.</param>
        /// <param name="document">document.</param>
        /// <param name="audio">audio.</param>
        public WhatsApp(WhatsAppText text = default(WhatsAppText), WhatsAppImage image = default(WhatsAppImage), WhatsAppDocument document = default(WhatsAppDocument), WhatsAppAudio audio = default(WhatsAppAudio), string channel = default(string), string sender = default(string), int? validity = default(int?)) : base(channel, sender, validity)
        {
            this.Text = text;
            this.Image = image;
            this.Document = document;
            this.Audio = audio;
        }
        
        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public WhatsAppText Text { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public WhatsAppImage Image { get; set; }

        /// <summary>
        /// Gets or Sets Document
        /// </summary>
        [DataMember(Name="document", EmitDefaultValue=false)]
        public WhatsAppDocument Document { get; set; }

        /// <summary>
        /// Gets or Sets Audio
        /// </summary>
        [DataMember(Name="audio", EmitDefaultValue=false)]
        public WhatsAppAudio Audio { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WhatsApp {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  Audio: ").Append(Audio).Append("\n");
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
            return this.Equals(input as WhatsApp);
        }

        /// <summary>
        /// Returns true if WhatsApp instances are equal
        /// </summary>
        /// <param name="input">Instance of WhatsApp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WhatsApp input)
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
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && base.Equals(input) && 
                (
                    this.Document == input.Document ||
                    (this.Document != null &&
                    this.Document.Equals(input.Document))
                ) && base.Equals(input) && 
                (
                    this.Audio == input.Audio ||
                    (this.Audio != null &&
                    this.Audio.Equals(input.Audio))
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
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Document != null)
                    hashCode = hashCode * 59 + this.Document.GetHashCode();
                if (this.Audio != null)
                    hashCode = hashCode * 59 + this.Audio.GetHashCode();
                return hashCode;
            }
        }
    }

}
