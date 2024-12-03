// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DataFactory.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.DataFactory.Samples
{
    public partial class Sample_DataFactoryPrivateEndpointCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ManagedVirtualNetworksCreate()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/ManagedPrivateEndpoints_Create.json
            // this example is just showing the usage of "ManagedPrivateEndpoints_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryManagedVirtualNetworkResource created on azure
            // for more information of creating DataFactoryManagedVirtualNetworkResource, please refer to the document of DataFactoryManagedVirtualNetworkResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string managedVirtualNetworkName = "exampleManagedVirtualNetworkName";
            ResourceIdentifier dataFactoryManagedVirtualNetworkResourceId = DataFactoryManagedVirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, managedVirtualNetworkName);
            DataFactoryManagedVirtualNetworkResource dataFactoryManagedVirtualNetwork = client.GetDataFactoryManagedVirtualNetworkResource(dataFactoryManagedVirtualNetworkResourceId);

            // get the collection of this DataFactoryPrivateEndpointResource
            DataFactoryPrivateEndpointCollection collection = dataFactoryManagedVirtualNetwork.GetDataFactoryPrivateEndpoints();

            // invoke the operation
            string managedPrivateEndpointName = "exampleManagedPrivateEndpointName";
            DataFactoryPrivateEndpointData data = new DataFactoryPrivateEndpointData(new DataFactoryPrivateEndpointProperties
            {
                Fqdns = { },
                GroupId = "blob",
                PrivateLinkResourceId = new ResourceIdentifier("/subscriptions/12345678-1234-1234-1234-12345678abc/resourceGroups/exampleResourceGroup/providers/Microsoft.Storage/storageAccounts/exampleBlobStorage"),
            });
            ArmOperation<DataFactoryPrivateEndpointResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, managedPrivateEndpointName, data);
            DataFactoryPrivateEndpointResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryPrivateEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ManagedPrivateEndpointsGet()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/ManagedPrivateEndpoints_Get.json
            // this example is just showing the usage of "ManagedPrivateEndpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryManagedVirtualNetworkResource created on azure
            // for more information of creating DataFactoryManagedVirtualNetworkResource, please refer to the document of DataFactoryManagedVirtualNetworkResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string managedVirtualNetworkName = "exampleManagedVirtualNetworkName";
            ResourceIdentifier dataFactoryManagedVirtualNetworkResourceId = DataFactoryManagedVirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, managedVirtualNetworkName);
            DataFactoryManagedVirtualNetworkResource dataFactoryManagedVirtualNetwork = client.GetDataFactoryManagedVirtualNetworkResource(dataFactoryManagedVirtualNetworkResourceId);

            // get the collection of this DataFactoryPrivateEndpointResource
            DataFactoryPrivateEndpointCollection collection = dataFactoryManagedVirtualNetwork.GetDataFactoryPrivateEndpoints();

            // invoke the operation
            string managedPrivateEndpointName = "exampleManagedPrivateEndpointName";
            DataFactoryPrivateEndpointResource result = await collection.GetAsync(managedPrivateEndpointName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryPrivateEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ManagedPrivateEndpointsListByFactory()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/ManagedPrivateEndpoints_ListByFactory.json
            // this example is just showing the usage of "ManagedPrivateEndpoints_ListByFactory" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryManagedVirtualNetworkResource created on azure
            // for more information of creating DataFactoryManagedVirtualNetworkResource, please refer to the document of DataFactoryManagedVirtualNetworkResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string managedVirtualNetworkName = "exampleManagedVirtualNetworkName";
            ResourceIdentifier dataFactoryManagedVirtualNetworkResourceId = DataFactoryManagedVirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, managedVirtualNetworkName);
            DataFactoryManagedVirtualNetworkResource dataFactoryManagedVirtualNetwork = client.GetDataFactoryManagedVirtualNetworkResource(dataFactoryManagedVirtualNetworkResourceId);

            // get the collection of this DataFactoryPrivateEndpointResource
            DataFactoryPrivateEndpointCollection collection = dataFactoryManagedVirtualNetwork.GetDataFactoryPrivateEndpoints();

            // invoke the operation and iterate over the result
            await foreach (DataFactoryPrivateEndpointResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataFactoryPrivateEndpointData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ManagedPrivateEndpointsGet()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/ManagedPrivateEndpoints_Get.json
            // this example is just showing the usage of "ManagedPrivateEndpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryManagedVirtualNetworkResource created on azure
            // for more information of creating DataFactoryManagedVirtualNetworkResource, please refer to the document of DataFactoryManagedVirtualNetworkResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string managedVirtualNetworkName = "exampleManagedVirtualNetworkName";
            ResourceIdentifier dataFactoryManagedVirtualNetworkResourceId = DataFactoryManagedVirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, managedVirtualNetworkName);
            DataFactoryManagedVirtualNetworkResource dataFactoryManagedVirtualNetwork = client.GetDataFactoryManagedVirtualNetworkResource(dataFactoryManagedVirtualNetworkResourceId);

            // get the collection of this DataFactoryPrivateEndpointResource
            DataFactoryPrivateEndpointCollection collection = dataFactoryManagedVirtualNetwork.GetDataFactoryPrivateEndpoints();

            // invoke the operation
            string managedPrivateEndpointName = "exampleManagedPrivateEndpointName";
            bool result = await collection.ExistsAsync(managedPrivateEndpointName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ManagedPrivateEndpointsGet()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/ManagedPrivateEndpoints_Get.json
            // this example is just showing the usage of "ManagedPrivateEndpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryManagedVirtualNetworkResource created on azure
            // for more information of creating DataFactoryManagedVirtualNetworkResource, please refer to the document of DataFactoryManagedVirtualNetworkResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string managedVirtualNetworkName = "exampleManagedVirtualNetworkName";
            ResourceIdentifier dataFactoryManagedVirtualNetworkResourceId = DataFactoryManagedVirtualNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, managedVirtualNetworkName);
            DataFactoryManagedVirtualNetworkResource dataFactoryManagedVirtualNetwork = client.GetDataFactoryManagedVirtualNetworkResource(dataFactoryManagedVirtualNetworkResourceId);

            // get the collection of this DataFactoryPrivateEndpointResource
            DataFactoryPrivateEndpointCollection collection = dataFactoryManagedVirtualNetwork.GetDataFactoryPrivateEndpoints();

            // invoke the operation
            string managedPrivateEndpointName = "exampleManagedPrivateEndpointName";
            NullableResponse<DataFactoryPrivateEndpointResource> response = await collection.GetIfExistsAsync(managedPrivateEndpointName);
            DataFactoryPrivateEndpointResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataFactoryPrivateEndpointData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
