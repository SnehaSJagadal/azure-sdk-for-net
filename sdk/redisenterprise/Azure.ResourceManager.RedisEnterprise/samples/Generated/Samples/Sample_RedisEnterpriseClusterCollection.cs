// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RedisEnterprise.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.RedisEnterprise.Samples
{
    public partial class Sample_RedisEnterpriseClusterCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_RedisEnterpriseCreate()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/preview/2024-09-01-preview/examples/RedisEnterpriseCreate.json
            // this example is just showing the usage of "RedisEnterprise_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "e7b5a9d2-6b6a-4d2f-9143-20d9a10f5b8f";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this RedisEnterpriseClusterResource
            RedisEnterpriseClusterCollection collection = resourceGroupResource.GetRedisEnterpriseClusters();

            // invoke the operation
            string clusterName = "cache1";
            RedisEnterpriseClusterData data = new RedisEnterpriseClusterData(new AzureLocation("West US"), new RedisEnterpriseSku(RedisEnterpriseSkuName.EnterpriseFlashF300)
            {
                Capacity = 3,
            })
            {
                Zones =
{
"1","2","3"
},
                Identity = new ManagedServiceIdentity("UserAssigned")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/your-subscription/resourceGroups/your-rg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/your-identity")] = new UserAssignedIdentity(),
},
                },
                MinimumTlsVersion = RedisEnterpriseTlsVersion.Tls1_2,
                CustomerManagedKeyEncryption = new RedisEnterpriseCustomerManagedKeyEncryption()
                {
                    KeyEncryptionKeyIdentity = new RedisEnterpriseCustomerManagedKeyEncryptionKeyIdentity()
                    {
                        UserAssignedIdentityResourceId = new ResourceIdentifier("/subscriptions/your-subscription/resourceGroups/your-rg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/your-identity"),
                        IdentityType = RedisEnterpriseCustomerManagedKeyIdentityType.UserAssignedIdentity,
                    },
                    KeyEncryptionKeyUri = new Uri("https://your-kv.vault.azure.net/keys/your-key/your-key-version"),
                },
                Tags =
{
["tag1"] = "value1",
},
            };
            ArmOperation<RedisEnterpriseClusterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, clusterName, data);
            RedisEnterpriseClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RedisEnterpriseClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_RedisEnterpriseGet()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/preview/2024-09-01-preview/examples/RedisEnterpriseGet.json
            // this example is just showing the usage of "RedisEnterprise_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "e7b5a9d2-6b6a-4d2f-9143-20d9a10f5b8f";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this RedisEnterpriseClusterResource
            RedisEnterpriseClusterCollection collection = resourceGroupResource.GetRedisEnterpriseClusters();

            // invoke the operation
            string clusterName = "cache1";
            RedisEnterpriseClusterResource result = await collection.GetAsync(clusterName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RedisEnterpriseClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_RedisEnterpriseGet()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/preview/2024-09-01-preview/examples/RedisEnterpriseGet.json
            // this example is just showing the usage of "RedisEnterprise_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "e7b5a9d2-6b6a-4d2f-9143-20d9a10f5b8f";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this RedisEnterpriseClusterResource
            RedisEnterpriseClusterCollection collection = resourceGroupResource.GetRedisEnterpriseClusters();

            // invoke the operation
            string clusterName = "cache1";
            bool result = await collection.ExistsAsync(clusterName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_RedisEnterpriseGet()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/preview/2024-09-01-preview/examples/RedisEnterpriseGet.json
            // this example is just showing the usage of "RedisEnterprise_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "e7b5a9d2-6b6a-4d2f-9143-20d9a10f5b8f";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this RedisEnterpriseClusterResource
            RedisEnterpriseClusterCollection collection = resourceGroupResource.GetRedisEnterpriseClusters();

            // invoke the operation
            string clusterName = "cache1";
            NullableResponse<RedisEnterpriseClusterResource> response = await collection.GetIfExistsAsync(clusterName);
            RedisEnterpriseClusterResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RedisEnterpriseClusterData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_RedisEnterpriseListByResourceGroup()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/preview/2024-09-01-preview/examples/RedisEnterpriseListByResourceGroup.json
            // this example is just showing the usage of "RedisEnterprise_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "e7b5a9d2-6b6a-4d2f-9143-20d9a10f5b8f";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this RedisEnterpriseClusterResource
            RedisEnterpriseClusterCollection collection = resourceGroupResource.GetRedisEnterpriseClusters();

            // invoke the operation and iterate over the result
            await foreach (RedisEnterpriseClusterResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RedisEnterpriseClusterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
