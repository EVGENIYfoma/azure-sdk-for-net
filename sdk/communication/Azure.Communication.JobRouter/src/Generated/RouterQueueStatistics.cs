// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> Statistics for the queue. </summary>
    public partial class RouterQueueStatistics
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RouterQueueStatistics"/>. </summary>
        /// <param name="queueId"> Id of the queue these details are about. </param>
        /// <param name="length"> Length of the queue: total number of enqueued jobs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="queueId"/> is null. </exception>
        internal RouterQueueStatistics(string queueId, int length)
        {
            Argument.AssertNotNull(queueId, nameof(queueId));

            QueueId = queueId;
            Length = length;
            EstimatedWaitTimes = new ChangeTrackingDictionary<int, TimeSpan>();
        }

        /// <summary> Initializes a new instance of <see cref="RouterQueueStatistics"/>. </summary>
        /// <param name="queueId"> Id of the queue these details are about. </param>
        /// <param name="length"> Length of the queue: total number of enqueued jobs. </param>
        /// <param name="estimatedWaitTimes"> The estimated wait time of this queue rounded up to the nearest minute, grouped by job priority. </param>
        /// <param name="longestJobWaitTimeMinutes"> The wait time of the job that has been enqueued in this queue for the longest. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RouterQueueStatistics(string queueId, int length, IDictionary<int, TimeSpan> estimatedWaitTimes, double? longestJobWaitTimeMinutes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            QueueId = queueId;
            Length = length;
            EstimatedWaitTimes = estimatedWaitTimes;
            LongestJobWaitTimeMinutes = longestJobWaitTimeMinutes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RouterQueueStatistics"/> for deserialization. </summary>
        internal RouterQueueStatistics()
        {
        }

        /// <summary> Id of the queue these details are about. </summary>
        public string QueueId { get; }
        /// <summary> Length of the queue: total number of enqueued jobs. </summary>
        public int Length { get; }
        /// <summary> The wait time of the job that has been enqueued in this queue for the longest. </summary>
        public double? LongestJobWaitTimeMinutes { get; }
    }
}
