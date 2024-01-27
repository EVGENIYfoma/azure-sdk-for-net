// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Messages
{
    /// <summary> A request to send a text notification. </summary>
    public partial class TextNotificationContent : NotificationContent
    {
        /// <summary> Initializes a new instance of <see cref="TextNotificationContent"/>. </summary>
        /// <param name="channelRegistrationId"> The Channel Registration ID for the Business Identifier. </param>
        /// <param name="to"> The native external platform user identifiers of the recipient. </param>
        /// <param name="content"> Message content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="to"/> or <paramref name="content"/> is null. </exception>
        public TextNotificationContent(Guid channelRegistrationId, IEnumerable<string> to, string content) : base(channelRegistrationId, to)
        {
            Argument.AssertNotNull(to, nameof(to));
            Argument.AssertNotNull(content, nameof(content));

            Kind = CommunicationMessageKind.Text;
            Content = content;
        }

        /// <summary> Initializes a new instance of <see cref="TextNotificationContent"/>. </summary>
        /// <param name="channelRegistrationId"> The Channel Registration ID for the Business Identifier. </param>
        /// <param name="to"> The native external platform user identifiers of the recipient. </param>
        /// <param name="kind"> The type discriminator describing a notification type. </param>
        /// <param name="content"> Message content. </param>
        internal TextNotificationContent(Guid channelRegistrationId, IList<string> to, CommunicationMessageKind kind, string content) : base(channelRegistrationId, to, kind)
        {
            Content = content;
        }

        /// <summary> Message content. </summary>
        public string Content { get; }
    }
}
