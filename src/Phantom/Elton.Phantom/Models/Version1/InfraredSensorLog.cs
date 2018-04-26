/* 
 * Version 1
 *
 * This is version 1 document
 *
 * OpenAPI spec version: 0.0.2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = Elton.Phantom.Models.SwaggerDateConverter;

namespace Elton.Phantom.Models.Version1
{
    /// <summary>
    /// 获取某个红外传感器所有日志
    /// </summary>
    [DataContract]
    public partial class InfraredSensorLog :  IEquatable<InfraredSensorLog>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfraredSensorLog" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfraredSensorLog() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfraredSensorLog" /> class.
        /// </summary>
        /// <param name="Id">LogID (required).</param>
        /// <param name="Timestamp">timestamp (required).</param>
        /// <param name="Message">message (required).</param>
        public InfraredSensorLog(int? Id = default(int?), int? Timestamp = default(int?), string Message = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for InfraredSensorLog and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for InfraredSensorLog and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            // to ensure "Message" is required (not null)
            if (Message == null)
            {
                throw new InvalidDataException("Message is a required property for InfraredSensorLog and cannot be null");
            }
            else
            {
                this.Message = Message;
            }
        }
        
        /// <summary>
        /// LogID
        /// </summary>
        /// <value>LogID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// timestamp
        /// </summary>
        /// <value>timestamp</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public int? Timestamp { get; set; }

        /// <summary>
        /// message
        /// </summary>
        /// <value>message</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfraredSensorLog {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as InfraredSensorLog);
        }

        /// <summary>
        /// Returns true if InfraredSensorLog instances are equal
        /// </summary>
        /// <param name="input">Instance of InfraredSensorLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfraredSensorLog input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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