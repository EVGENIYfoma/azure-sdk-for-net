// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Communication.Messages.Models.Channels;

namespace Azure.Communication.Messages
{
    /// <summary> Model factory for models. </summary>
    public static partial class CommunicationMessagesModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Messages.SendMessageResult"/>. </summary>
        /// <param name="receipts"> Receipts of the send message operation. </param>
        /// <returns> A new <see cref="Messages.SendMessageResult"/> instance for mocking. </returns>
        public static SendMessageResult SendMessageResult(IEnumerable<MessageReceipt> receipts = null)
        {
            receipts ??= new List<MessageReceipt>();

            return new SendMessageResult(receipts?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Messages.MessageReceipt"/>. </summary>
        /// <param name="messageId"> The message id. </param>
        /// <param name="to"> The native external platform user identifier of the recipient. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messageId"/> or <paramref name="to"/> is null. </exception>
        /// <returns> A new <see cref="Messages.MessageReceipt"/> instance for mocking. </returns>
        public static MessageReceipt MessageReceipt(string messageId = null, string to = null)
        {
            if (messageId == null)
            {
                throw new ArgumentNullException(nameof(messageId));
            }
            if (to == null)
            {
                throw new ArgumentNullException(nameof(to));
            }

            return new MessageReceipt(messageId, to);
        }

        /// <summary> Initializes a new instance of <see cref="Messages.MessageTemplateItem"/>. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="name"> Get the template's Name. </param>
        /// <param name="language"> Get the template's language. </param>
        /// <param name="status"> The aggregated template status. </param>
        /// <returns> A new <see cref="Messages.MessageTemplateItem"/> instance for mocking. </returns>
        public static MessageTemplateItem MessageTemplateItem(string kind = null, string name = null, string language = null, MessageTemplateStatus status = default)
        {
            return new UnknownMessageTemplateResponse(kind, name, language, status);
        }

        /// <summary> Initializes a new instance of <see cref="Models.Channels.WhatsAppMessageTemplateItem"/>. </summary>
        /// <param name="name"> Get the template's Name. </param>
        /// <param name="language"> Get the template's language. </param>
        /// <param name="status"> The aggregated template status. </param>
        /// <param name="content">
        /// WhatsApp platform's template content
        /// This is the payload returned from WhatsApp
        /// API.
        /// </param>
        /// <returns> A new <see cref="Models.Channels.WhatsAppMessageTemplateItem"/> instance for mocking. </returns>
        public static WhatsAppMessageTemplateItem WhatsAppMessageTemplateItem(string name = null, string language = null, MessageTemplateStatus status = default, BinaryData content = null)
        {
            return new WhatsAppMessageTemplateItem("whatsApp", name, language, status, content);
        }
    }
}
