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
    /// SessionLog
    /// </summary>
    [DataContract]
    public partial class SessionLog :  IEquatable<SessionLog>
    {
        /// <summary>
        /// Defines RequestedBy
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RequestedByEnum
        {
            
            /// <summary>
            /// Enum Undefined for value: Undefined
            /// </summary>
            [EnumMember(Value = "Undefined")]
            Undefined = 1,
            
            /// <summary>
            /// Enum ShellClient for value: ShellClient
            /// </summary>
            [EnumMember(Value = "ShellClient")]
            ShellClient = 2,
            
            /// <summary>
            /// Enum WebApi for value: WebApi
            /// </summary>
            [EnumMember(Value = "WebApi")]
            WebApi = 3
        }

        /// <summary>
        /// Gets or Sets RequestedBy
        /// </summary>
        [DataMember(Name="requestedBy", EmitDefaultValue=false)]
        public RequestedByEnum? RequestedBy { get; set; }
        /// <summary>
        /// Defines LatestState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LatestStateEnum
        {
            
            /// <summary>
            /// Enum Requested for value: Requested
            /// </summary>
            [EnumMember(Value = "Requested")]
            Requested = 1,
            
            /// <summary>
            /// Enum Delivered for value: Delivered
            /// </summary>
            [EnumMember(Value = "Delivered")]
            Delivered = 2,
            
            /// <summary>
            /// Enum Started for value: Started
            /// </summary>
            [EnumMember(Value = "Started")]
            Started = 3,
            
            /// <summary>
            /// Enum Ended for value: Ended
            /// </summary>
            [EnumMember(Value = "Ended")]
            Ended = 4,
            
            /// <summary>
            /// Enum Canceled for value: Canceled
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled = 5,
            
            /// <summary>
            /// Enum DeliveryTimeout for value: DeliveryTimeout
            /// </summary>
            [EnumMember(Value = "DeliveryTimeout")]
            DeliveryTimeout = 6,
            
            /// <summary>
            /// Enum ResponseTimeout for value: ResponseTimeout
            /// </summary>
            [EnumMember(Value = "ResponseTimeout")]
            ResponseTimeout = 7
        }

        /// <summary>
        /// Gets or Sets LatestState
        /// </summary>
        [DataMember(Name="latestState", EmitDefaultValue=false)]
        public LatestStateEnum? LatestState { get; set; }
        /// <summary>
        /// Defines StoppedBy
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StoppedByEnum
        {
            
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,
            
            /// <summary>
            /// Enum UserLogout for value: UserLogout
            /// </summary>
            [EnumMember(Value = "UserLogout")]
            UserLogout = 2,
            
            /// <summary>
            /// Enum RemoteLogout for value: RemoteLogout
            /// </summary>
            [EnumMember(Value = "RemoteLogout")]
            RemoteLogout = 3,
            
            /// <summary>
            /// Enum Inactivity for value: Inactivity
            /// </summary>
            [EnumMember(Value = "Inactivity")]
            Inactivity = 4,
            
            /// <summary>
            /// Enum StationShutdown for value: StationShutdown
            /// </summary>
            [EnumMember(Value = "StationShutdown")]
            StationShutdown = 5,
            
            /// <summary>
            /// Enum LimitReached for value: LimitReached
            /// </summary>
            [EnumMember(Value = "LimitReached")]
            LimitReached = 6,
            
            /// <summary>
            /// Enum ConnectionLoss for value: ConnectionLoss
            /// </summary>
            [EnumMember(Value = "ConnectionLoss")]
            ConnectionLoss = 7,
            
            /// <summary>
            /// Enum SubscriptionEnded for value: SubscriptionEnded
            /// </summary>
            [EnumMember(Value = "SubscriptionEnded")]
            SubscriptionEnded = 8
        }

        /// <summary>
        /// Gets or Sets StoppedBy
        /// </summary>
        [DataMember(Name="stoppedBy", EmitDefaultValue=false)]
        public StoppedByEnum? StoppedBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionLog" /> class.
        /// </summary>
        /// <param name="stationId">stationId.</param>
        /// <param name="sessionId">sessionId.</param>
        /// <param name="requestedBy">requestedBy.</param>
        /// <param name="latestState">latestState.</param>
        /// <param name="startedUtc">startedUtc.</param>
        /// <param name="reference">reference.</param>
        /// <param name="maxDurationLimit">maxDurationLimit.</param>
        /// <param name="endedUtc">endedUtc.</param>
        /// <param name="stoppedBy">stoppedBy.</param>
        /// <param name="changeRequests">changeRequests.</param>
        public SessionLog(Guid? stationId = default(Guid?), Guid? sessionId = default(Guid?), RequestedByEnum? requestedBy = default(RequestedByEnum?), LatestStateEnum? latestState = default(LatestStateEnum?), DateTime? startedUtc = default(DateTime?), string reference = default(string), string maxDurationLimit = default(string), DateTime? endedUtc = default(DateTime?), StoppedByEnum? stoppedBy = default(StoppedByEnum?), List<ChangeRequest> changeRequests = default(List<ChangeRequest>))
        {
            this.StationId = stationId;
            this.SessionId = sessionId;
            this.RequestedBy = requestedBy;
            this.LatestState = latestState;
            this.StartedUtc = startedUtc;
            this.Reference = reference;
            this.MaxDurationLimit = maxDurationLimit;
            this.EndedUtc = endedUtc;
            this.StoppedBy = stoppedBy;
            this.ChangeRequests = changeRequests;
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
        /// Gets or Sets StartedUtc
        /// </summary>
        [DataMember(Name="startedUtc", EmitDefaultValue=false)]
        public DateTime? StartedUtc { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets MaxDurationLimit
        /// </summary>
        [DataMember(Name="maxDurationLimit", EmitDefaultValue=false)]
        public string MaxDurationLimit { get; set; }

        /// <summary>
        /// Gets or Sets EndedUtc
        /// </summary>
        [DataMember(Name="endedUtc", EmitDefaultValue=false)]
        public DateTime? EndedUtc { get; set; }


        /// <summary>
        /// Gets or Sets ChangeRequests
        /// </summary>
        [DataMember(Name="changeRequests", EmitDefaultValue=false)]
        public List<ChangeRequest> ChangeRequests { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionLog {\n");
            sb.Append("  StationId: ").Append(StationId).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  RequestedBy: ").Append(RequestedBy).Append("\n");
            sb.Append("  LatestState: ").Append(LatestState).Append("\n");
            sb.Append("  StartedUtc: ").Append(StartedUtc).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  MaxDurationLimit: ").Append(MaxDurationLimit).Append("\n");
            sb.Append("  EndedUtc: ").Append(EndedUtc).Append("\n");
            sb.Append("  StoppedBy: ").Append(StoppedBy).Append("\n");
            sb.Append("  ChangeRequests: ").Append(ChangeRequests).Append("\n");
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
            return this.Equals(input as SessionLog);
        }

        /// <summary>
        /// Returns true if SessionLog instances are equal
        /// </summary>
        /// <param name="input">Instance of SessionLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionLog input)
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
                ) && 
                (
                    this.RequestedBy == input.RequestedBy ||
                    (this.RequestedBy != null &&
                    this.RequestedBy.Equals(input.RequestedBy))
                ) && 
                (
                    this.LatestState == input.LatestState ||
                    (this.LatestState != null &&
                    this.LatestState.Equals(input.LatestState))
                ) && 
                (
                    this.StartedUtc == input.StartedUtc ||
                    (this.StartedUtc != null &&
                    this.StartedUtc.Equals(input.StartedUtc))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.MaxDurationLimit == input.MaxDurationLimit ||
                    (this.MaxDurationLimit != null &&
                    this.MaxDurationLimit.Equals(input.MaxDurationLimit))
                ) && 
                (
                    this.EndedUtc == input.EndedUtc ||
                    (this.EndedUtc != null &&
                    this.EndedUtc.Equals(input.EndedUtc))
                ) && 
                (
                    this.StoppedBy == input.StoppedBy ||
                    (this.StoppedBy != null &&
                    this.StoppedBy.Equals(input.StoppedBy))
                ) && 
                (
                    this.ChangeRequests == input.ChangeRequests ||
                    this.ChangeRequests != null &&
                    this.ChangeRequests.SequenceEqual(input.ChangeRequests)
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
                if (this.RequestedBy != null)
                    hashCode = hashCode * 59 + this.RequestedBy.GetHashCode();
                if (this.LatestState != null)
                    hashCode = hashCode * 59 + this.LatestState.GetHashCode();
                if (this.StartedUtc != null)
                    hashCode = hashCode * 59 + this.StartedUtc.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.MaxDurationLimit != null)
                    hashCode = hashCode * 59 + this.MaxDurationLimit.GetHashCode();
                if (this.EndedUtc != null)
                    hashCode = hashCode * 59 + this.EndedUtc.GetHashCode();
                if (this.StoppedBy != null)
                    hashCode = hashCode * 59 + this.StoppedBy.GetHashCode();
                if (this.ChangeRequests != null)
                    hashCode = hashCode * 59 + this.ChangeRequests.GetHashCode();
                return hashCode;
            }
        }
    }

}
