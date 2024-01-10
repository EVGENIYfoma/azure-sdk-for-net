// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Communication.Messages;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Communication.Messages.Samples
{
    public partial class Samples_MessageTemplateClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_MessageTemplateItem_GetMessageTemplateItems_ShortVersion()
        {
            MessageTemplateClient client = new MessageTemplateClient((string)null);

            foreach (BinaryData item in client.GetMessageTemplateItems("<channelId>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("kind").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("language").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_MessageTemplateItem_GetMessageTemplateItems_ShortVersion_Async()
        {
            MessageTemplateClient client = new MessageTemplateClient((string)null);

            await foreach (BinaryData item in client.GetMessageTemplateItemsAsync("<channelId>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("kind").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("language").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_MessageTemplateItem_GetMessageTemplateItems_ShortVersion_Convenience()
        {
            MessageTemplateClient client = new MessageTemplateClient((string)null);

            foreach (MessageTemplateItem item in client.GetMessageTemplateItems("<channelId>"))
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_MessageTemplateItem_GetMessageTemplateItems_ShortVersion_Convenience_Async()
        {
            MessageTemplateClient client = new MessageTemplateClient((string)null);

            await foreach (MessageTemplateItem item in client.GetMessageTemplateItemsAsync("<channelId>"))
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_MessageTemplateItem_GetMessageTemplateItems_AllParameters()
        {
            MessageTemplateClient client = new MessageTemplateClient((string)null);

            foreach (BinaryData item in client.GetMessageTemplateItems("<channelId>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("kind").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("language").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_MessageTemplateItem_GetMessageTemplateItems_AllParameters_Async()
        {
            MessageTemplateClient client = new MessageTemplateClient((string)null);

            await foreach (BinaryData item in client.GetMessageTemplateItemsAsync("<channelId>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("kind").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("language").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_MessageTemplateItem_GetMessageTemplateItems_AllParameters_Convenience()
        {
            MessageTemplateClient client = new MessageTemplateClient((string)null);

            foreach (MessageTemplateItem item in client.GetMessageTemplateItems("<channelId>"))
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_MessageTemplateItem_GetMessageTemplateItems_AllParameters_Convenience_Async()
        {
            MessageTemplateClient client = new MessageTemplateClient((string)null);

            await foreach (MessageTemplateItem item in client.GetMessageTemplateItemsAsync("<channelId>"))
            {
            }
        }
    }
}
