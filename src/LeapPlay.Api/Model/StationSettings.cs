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
    /// StationSettings
    /// </summary>
    [DataContract]
    public partial class StationSettings :  IEquatable<StationSettings>
    {
        /// <summary>
        /// Defines ControlMode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ControlModeEnum
        {
            
            /// <summary>
            /// Enum Undefined for value: Undefined
            /// </summary>
            [EnumMember(Value = "Undefined")]
            Undefined = 1,
            
            /// <summary>
            /// Enum Local for value: Local
            /// </summary>
            [EnumMember(Value = "Local")]
            Local = 2,
            
            /// <summary>
            /// Enum Remote for value: Remote
            /// </summary>
            [EnumMember(Value = "Remote")]
            Remote = 3,
            
            /// <summary>
            /// Enum RemoteWithQrCode for value: RemoteWithQrCode
            /// </summary>
            [EnumMember(Value = "RemoteWithQrCode")]
            RemoteWithQrCode = 4
        }

        /// <summary>
        /// Gets or Sets ControlMode
        /// </summary>
        [DataMember(Name="controlMode", EmitDefaultValue=false)]
        public ControlModeEnum? ControlMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StationSettings" /> class.
        /// </summary>
        /// <param name="stationId">stationId.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="qrCode">qrCode.</param>
        /// <param name="controlMode">controlMode.</param>
        public StationSettings(Guid? stationId = default(Guid?), string displayName = default(string), string qrCode = default(string), ControlModeEnum? controlMode = default(ControlModeEnum?))
        {
            this.StationId = stationId;
            this.DisplayName = displayName;
            this.QrCode = qrCode;
            this.ControlMode = controlMode;
        }
        
        /// <summary>
        /// Gets or Sets StationId
        /// </summary>
        [DataMember(Name="stationId", EmitDefaultValue=false)]
        public Guid? StationId { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets QrCode
        /// </summary>
        [DataMember(Name="qrCode", EmitDefaultValue=false)]
        public string QrCode { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StationSettings {\n");
            sb.Append("  StationId: ").Append(StationId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  QrCode: ").Append(QrCode).Append("\n");
            sb.Append("  ControlMode: ").Append(ControlMode).Append("\n");
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
            return this.Equals(input as StationSettings);
        }

        /// <summary>
        /// Returns true if StationSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of StationSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StationSettings input)
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
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.QrCode == input.QrCode ||
                    (this.QrCode != null &&
                    this.QrCode.Equals(input.QrCode))
                ) && 
                (
                    this.ControlMode == input.ControlMode ||
                    (this.ControlMode != null &&
                    this.ControlMode.Equals(input.ControlMode))
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.QrCode != null)
                    hashCode = hashCode * 59 + this.QrCode.GetHashCode();
                if (this.ControlMode != null)
                    hashCode = hashCode * 59 + this.ControlMode.GetHashCode();
                return hashCode;
            }
        }
    }

}
