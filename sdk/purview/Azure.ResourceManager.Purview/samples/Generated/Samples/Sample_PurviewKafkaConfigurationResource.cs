// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Purview;
using Azure.ResourceManager.Purview.Models;

namespace Azure.ResourceManager.Purview.Samples
{
    public partial class Sample_PurviewKafkaConfigurationResource
    {
        // KafkaConfigurations_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_KafkaConfigurationsGet()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/preview/2023-05-01-preview/examples/KafkaConfigurations_Get.json
            // this example is just showing the usage of "KafkaConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PurviewKafkaConfigurationResource created on azure
            // for more information of creating PurviewKafkaConfigurationResource, please refer to the document of PurviewKafkaConfigurationResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rgpurview";
            string accountName = "account1";
            string kafkaConfigurationName = "kafkaConfigName";
            ResourceIdentifier purviewKafkaConfigurationResourceId = PurviewKafkaConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, kafkaConfigurationName);
            PurviewKafkaConfigurationResource purviewKafkaConfiguration = client.GetPurviewKafkaConfigurationResource(purviewKafkaConfigurationResourceId);

            // invoke the operation
            PurviewKafkaConfigurationResource result = await purviewKafkaConfiguration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PurviewKafkaConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // KafkaConfigurations_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_KafkaConfigurationsCreateOrUpdate()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/preview/2023-05-01-preview/examples/KafkaConfigurations_CreateOrUpdate.json
            // this example is just showing the usage of "KafkaConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PurviewKafkaConfigurationResource created on azure
            // for more information of creating PurviewKafkaConfigurationResource, please refer to the document of PurviewKafkaConfigurationResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rgpurview";
            string accountName = "account1";
            string kafkaConfigurationName = "kafkaConfigName";
            ResourceIdentifier purviewKafkaConfigurationResourceId = PurviewKafkaConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, kafkaConfigurationName);
            PurviewKafkaConfigurationResource purviewKafkaConfiguration = client.GetPurviewKafkaConfigurationResource(purviewKafkaConfigurationResourceId);

            // invoke the operation
            PurviewKafkaConfigurationData data = new PurviewKafkaConfigurationData()
            {
                ConsumerGroup = "consumerGroup",
                Credentials = new PurviewCredentials()
                {
                    IdentityId = "/subscriptions/47e8596d-ee73-4eb2-b6b4-cc13c2b87ssd/resourceGroups/testRG/providers/Microsoft.ManagedIdentity/userAssignedIdentities/testId",
                    CredentialsType = PurviewCredentialsType.UserAssigned,
                },
                EventHubPartitionId = "partitionId",
                EventHubResourceId = new ResourceIdentifier("/subscriptions/225be6fe-ec1c-4d51-a368-f69348d2e6c5/resourceGroups/testRG/providers/Microsoft.EventHub/namespaces/eventHubNameSpaceName"),
                EventHubType = PurviewKafkaEventHubType.Notification,
                EventStreamingState = PurviewEventStreamingState.Enabled,
                EventStreamingType = PurviewEventStreamingType.Azure,
            };
            ArmOperation<PurviewKafkaConfigurationResource> lro = await purviewKafkaConfiguration.UpdateAsync(WaitUntil.Completed, data);
            PurviewKafkaConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PurviewKafkaConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // KafkaConfigurations_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_KafkaConfigurationsDelete()
        {
            // Generated from example definition: specification/purview/resource-manager/Microsoft.Purview/preview/2023-05-01-preview/examples/KafkaConfigurations_Delete.json
            // this example is just showing the usage of "KafkaConfigurations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PurviewKafkaConfigurationResource created on azure
            // for more information of creating PurviewKafkaConfigurationResource, please refer to the document of PurviewKafkaConfigurationResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rgpurview";
            string accountName = "account1";
            string kafkaConfigurationName = "kafkaConfigName";
            ResourceIdentifier purviewKafkaConfigurationResourceId = PurviewKafkaConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, kafkaConfigurationName);
            PurviewKafkaConfigurationResource purviewKafkaConfiguration = client.GetPurviewKafkaConfigurationResource(purviewKafkaConfigurationResourceId);

            // invoke the operation
            await purviewKafkaConfiguration.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
