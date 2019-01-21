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
    /// WhatsAppDocument
    /// </summary>
    [DataContract]
    public partial class WhatsAppDocument :  IEquatable<WhatsAppDocument>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppDocument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WhatsAppDocument() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppDocument" /> class.
        /// </summary>
        /// <param name="caption">Description for the document.</param>
        /// <param name="content">Base64-encoded image (required).</param>
        public WhatsAppDocument(string caption = default(string), string content = default(string))
        {
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for WhatsAppDocument and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            this.Caption = caption;
        }
        
        /// <summary>
        /// Description for the document
        /// </summary>
        /// <value>Description for the document</value>
        [DataMember(Name="caption", EmitDefaultValue=false)]
        public string Caption { get; set; }

        /// <summary>
        /// Base64-encoded image
        /// </summary>
        /// <value>Base64-encoded image</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WhatsAppDocument {\n");
            sb.Append("  Caption: ").Append(Caption).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(input as WhatsAppDocument);
        }

        /// <summary>
        /// Returns true if WhatsAppDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of WhatsAppDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WhatsAppDocument input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Caption == input.Caption ||
                    (this.Caption != null &&
                    this.Caption.Equals(input.Caption))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
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
                if (this.Caption != null)
                    hashCode = hashCode * 59 + this.Caption.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                return hashCode;
            }
        }
    }

}
