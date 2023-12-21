// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.Messages
{
    /// <summary> The Message Template Response. </summary>
    internal partial class MessageTemplateResponse
    {
        /// <summary> Initializes a new instance of <see cref="MessageTemplateResponse"/>. </summary>
        /// <param name="name"> Get the template's Name. </param>
        /// <param name="language"> Get the template's language. </param>
        /// <param name="channelType"> The Communication Messages Channel. </param>
        /// <param name="status"> The aggregated template status. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="language"/> is null. </exception>
        internal MessageTemplateResponse(string name, string language, CommunicationMessagesChannel channelType, MessageTemplateStatus status)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(language, nameof(language));

            Name = name;
            Language = language;
            ChannelType = channelType;
            Status = status;
        }

        /// <summary> Initializes a new instance of <see cref="MessageTemplateResponse"/>. </summary>
        /// <param name="name"> Get the template's Name. </param>
        /// <param name="language"> Get the template's language. </param>
        /// <param name="channelType"> The Communication Messages Channel. </param>
        /// <param name="status"> The aggregated template status. </param>
        /// <param name="whatsApp"> The WhatsApp-specific template response contract. </param>
        internal MessageTemplateResponse(string name, string language, CommunicationMessagesChannel channelType, MessageTemplateStatus status, WhatsAppMessageTemplateResponse whatsApp)
        {
            Name = name;
            Language = language;
            ChannelType = channelType;
            Status = status;
            WhatsApp = whatsApp;
        }

        /// <summary> Get the template's Name. </summary>
        public string Name { get; }
        /// <summary> Get the template's language. </summary>
        public string Language { get; }
        /// <summary> The Communication Messages Channel. </summary>
        public CommunicationMessagesChannel ChannelType { get; }
        /// <summary> The aggregated template status. </summary>
        public MessageTemplateStatus Status { get; }
        /// <summary> The WhatsApp-specific template response contract. </summary>
        public WhatsAppMessageTemplateResponse WhatsApp { get; }
    }
}
