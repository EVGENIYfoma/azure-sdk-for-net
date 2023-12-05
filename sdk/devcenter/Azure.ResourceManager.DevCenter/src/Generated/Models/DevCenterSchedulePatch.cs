// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> The schedule properties for partial update. Properties not provided in the update request will not be changed. </summary>
    public partial class DevCenterSchedulePatch : DevCenterTrackedResourceUpdate
    {
        /// <summary> Initializes a new instance of <see cref="DevCenterSchedulePatch"/>. </summary>
        public DevCenterSchedulePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterSchedulePatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="scheduledType"> Supported type this scheduled task represents. </param>
        /// <param name="frequency"> The frequency of this scheduled task. </param>
        /// <param name="time"> The target time to trigger the action. The format is HH:MM. </param>
        /// <param name="timeZone"> The IANA timezone id at which the schedule should execute. </param>
        /// <param name="state"> Indicates whether or not this scheduled task is enabled. </param>
        internal DevCenterSchedulePatch(IDictionary<string, string> tags, AzureLocation? location, DevCenterScheduledType? scheduledType, DevCenterScheduledFrequency? frequency, string time, string timeZone, DevCenterScheduleEnableStatus? state) : base(tags, location)
        {
            ScheduledType = scheduledType;
            Frequency = frequency;
            Time = time;
            TimeZone = timeZone;
            State = state;
        }

        /// <summary> Supported type this scheduled task represents. </summary>
        public DevCenterScheduledType? ScheduledType { get; set; }
        /// <summary> The frequency of this scheduled task. </summary>
        public DevCenterScheduledFrequency? Frequency { get; set; }
        /// <summary> The target time to trigger the action. The format is HH:MM. </summary>
        public string Time { get; set; }
        /// <summary> The IANA timezone id at which the schedule should execute. </summary>
        public string TimeZone { get; set; }
        /// <summary> Indicates whether or not this scheduled task is enabled. </summary>
        public DevCenterScheduleEnableStatus? State { get; set; }
    }
}
