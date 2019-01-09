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
    /// The human-readable equivalent for this field is contained in \&quot;error\&quot;. This value is *null* if the message is still being processed. 
    /// </summary>
    /// <value>The human-readable equivalent for this field is contained in \&quot;error\&quot;. This value is *null* if the message is still being processed. </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Status
    {
        /// <summary>
        /// Enum ACK for value: ACK
        /// </summary>
        [EnumMember(Value = "ACK")]
        ACK = 1,

        /// <summary>
        /// Enum DELIVRD for value: DELIVRD
        /// </summary>
        [EnumMember(Value = "DELIVRD")]
        DELIVRD = 2,

        /// <summary>
        /// Enum UNDELIV for value: UNDELIV
        /// </summary>
        [EnumMember(Value = "UNDELIV")]
        UNDELIV = 3,

        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED = 4,

        /// <summary>
        /// Enum UNKNOWN for value: UNKNOWN
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 5,

        /// <summary>
        /// Enum ACCEPTD for value: ACCEPTD
        /// </summary>
        [EnumMember(Value = "ACCEPTD")]
        ACCEPTD = 6,

        /// <summary>
        /// Enum REJECTD for value: REJECTD
        /// </summary>
        [EnumMember(Value = "REJECTD")]
        REJECTD = 7,

        /// <summary>
        /// Enum DELETED for value: DELETED
        /// </summary>
        [EnumMember(Value = "DELETED")]
        DELETED = 8,

        /// <summary>
        /// Enum EXPIRED for value: EXPIRED
        /// </summary>
        [EnumMember(Value = "EXPIRED")]
        EXPIRED = 9,

        /// <summary>
        /// Enum NACK for value: NACK
        /// </summary>
        [EnumMember(Value = "NACK")]
        NACK = 10,

        /// <summary>
        /// Enum SEEN for value: SEEN
        /// </summary>
        [EnumMember(Value = "SEEN")]
        SEEN = 11

    }

}