// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.Messages
{
    /// <summary> The WhatsApp button sub type. </summary>
    public readonly partial struct WhatsAppMessageTemplateValueSubType : IEquatable<WhatsAppMessageTemplateValueSubType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WhatsAppMessageTemplateValueSubType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WhatsAppMessageTemplateValueSubType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string QuickReplyValue = "quickReply";
        private const string UrlValue = "url";

        /// <summary> quickReply. </summary>
        public static WhatsAppMessageTemplateValueSubType QuickReply { get; } = new WhatsAppMessageTemplateValueSubType(QuickReplyValue);
        /// <summary> url. </summary>
        public static WhatsAppMessageTemplateValueSubType Url { get; } = new WhatsAppMessageTemplateValueSubType(UrlValue);
        /// <summary> Determines if two <see cref="WhatsAppMessageTemplateValueSubType"/> values are the same. </summary>
        public static bool operator ==(WhatsAppMessageTemplateValueSubType left, WhatsAppMessageTemplateValueSubType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WhatsAppMessageTemplateValueSubType"/> values are not the same. </summary>
        public static bool operator !=(WhatsAppMessageTemplateValueSubType left, WhatsAppMessageTemplateValueSubType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WhatsAppMessageTemplateValueSubType"/>. </summary>
        public static implicit operator WhatsAppMessageTemplateValueSubType(string value) => new WhatsAppMessageTemplateValueSubType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WhatsAppMessageTemplateValueSubType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WhatsAppMessageTemplateValueSubType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
