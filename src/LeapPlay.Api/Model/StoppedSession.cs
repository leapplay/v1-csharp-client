/* 
 * Leap Play
 *
 * Learn more at https://www.leap-play.com
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = LeapPlay.Api.Client.SwaggerDateConverter;

namespace LeapPlay.Api.Model
{
    /// <summary>
    /// StoppedSession
    /// </summary>
    [DataContract]
    public partial class StoppedSession :  IEquatable<StoppedSession>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoppedSession" /> class.
        /// </summary>
        /// <param name="stationId">stationId.</param>
        /// <param name="sessionId">sessionId.</param>
        public StoppedSession(Guid? stationId = default(Guid?), Guid? sessionId = default(Guid?))
        {
            this.StationId = stationId;
            this.SessionId = sessionId;
        }
        
        /// <summary>
        /// Gets or Sets StationId
        /// </summary>
        [DataMember(Name="stationId", EmitDefaultValue=false)]
        public Guid? StationId { get; set; }

        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public Guid? SessionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoppedSession {\n");
            sb.Append("  StationId: ").Append(StationId).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
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
            return this.Equals(input as StoppedSession);
        }

        /// <summary>
        /// Returns true if StoppedSession instances are equal
        /// </summary>
        /// <param name="input">Instance of StoppedSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoppedSession input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StationId == input.StationId ||
                    (this.StationId != null &&
                    this.StationId.Equals(input.StationId))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
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
                if (this.StationId != null)
                    hashCode = hashCode * 59 + this.StationId.GetHashCode();
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                return hashCode;
            }
        }
    }

}
