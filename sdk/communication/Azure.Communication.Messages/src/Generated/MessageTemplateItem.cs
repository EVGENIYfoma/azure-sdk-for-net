// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Communication.Messages.Models.Channels;
using Azure.Core;

namespace Azure.Communication.Messages
{
    /// <summary>
    /// The message template as returned from the service.
    /// Please note <see cref="MessageTemplateItem"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="WhatsAppMessageTemplateItem"/>.
    /// </summary>
    public abstract partial class MessageTemplateItem
    {
        /// <summary> Initializes a new instance of <see cref="MessageTemplateItem"/>. </summary>
        /// <param name="language"> The template's language. </param>
        /// <param name="status"> The aggregated template status. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="language"/> is null. </exception>
        protected MessageTemplateItem(string language, MessageTemplateStatus status)
        {
            Argument.AssertNotNull(language, nameof(language));

            Language = language;
            Status = status;
        }

        /// <summary> Initializes a new instance of <see cref="MessageTemplateItem"/>. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="name"> The template's name. </param>
        /// <param name="language"> The template's language. </param>
        /// <param name="status"> The aggregated template status. </param>
        internal MessageTemplateItem(string kind, string name, string language, MessageTemplateStatus status)
        {
            Kind = kind;
            Name = name;
            Language = language;
            Status = status;
        }

        /// <summary> Discriminator. </summary>
        internal string Kind { get; set; }
        /// <summary> The template's name. </summary>
        public string Name { get; }
        /// <summary> The template's language. </summary>
        public string Language { get; }
        /// <summary> The aggregated template status. </summary>
        public MessageTemplateStatus Status { get; }
    }
}
