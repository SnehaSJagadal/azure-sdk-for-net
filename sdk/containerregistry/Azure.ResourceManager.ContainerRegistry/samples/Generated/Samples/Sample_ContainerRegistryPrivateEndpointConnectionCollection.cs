// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ContainerRegistry.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ContainerRegistry.Samples
{
    public partial class Sample_ContainerRegistryPrivateEndpointConnectionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_PrivateEndpointConnectionList()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2022-12-01/examples/PrivateEndpointConnectionList.json
            // this example is just showing the usage of "PrivateEndpointConnections_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryResource created on azure
            // for more information of creating ContainerRegistryResource, please refer to the document of ContainerRegistryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            ResourceIdentifier containerRegistryResourceId = ContainerRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            ContainerRegistryResource containerRegistry = client.GetContainerRegistryResource(containerRegistryResourceId);

            // get the collection of this ContainerRegistryPrivateEndpointConnectionResource
            ContainerRegistryPrivateEndpointConnectionCollection collection = containerRegistry.GetContainerRegistryPrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (ContainerRegistryPrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerRegistryPrivateEndpointConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_PrivateEndpointConnectionGet()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2022-12-01/examples/PrivateEndpointConnectionGet.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryResource created on azure
            // for more information of creating ContainerRegistryResource, please refer to the document of ContainerRegistryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            ResourceIdentifier containerRegistryResourceId = ContainerRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            ContainerRegistryResource containerRegistry = client.GetContainerRegistryResource(containerRegistryResourceId);

            // get the collection of this ContainerRegistryPrivateEndpointConnectionResource
            ContainerRegistryPrivateEndpointConnectionCollection collection = containerRegistry.GetContainerRegistryPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "myConnection";
            ContainerRegistryPrivateEndpointConnectionResource result = await collection.GetAsync(privateEndpointConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerRegistryPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_PrivateEndpointConnectionGet()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2022-12-01/examples/PrivateEndpointConnectionGet.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryResource created on azure
            // for more information of creating ContainerRegistryResource, please refer to the document of ContainerRegistryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            ResourceIdentifier containerRegistryResourceId = ContainerRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            ContainerRegistryResource containerRegistry = client.GetContainerRegistryResource(containerRegistryResourceId);

            // get the collection of this ContainerRegistryPrivateEndpointConnectionResource
            ContainerRegistryPrivateEndpointConnectionCollection collection = containerRegistry.GetContainerRegistryPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "myConnection";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_PrivateEndpointConnectionGet()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2022-12-01/examples/PrivateEndpointConnectionGet.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryResource created on azure
            // for more information of creating ContainerRegistryResource, please refer to the document of ContainerRegistryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            ResourceIdentifier containerRegistryResourceId = ContainerRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            ContainerRegistryResource containerRegistry = client.GetContainerRegistryResource(containerRegistryResourceId);

            // get the collection of this ContainerRegistryPrivateEndpointConnectionResource
            ContainerRegistryPrivateEndpointConnectionCollection collection = containerRegistry.GetContainerRegistryPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "myConnection";
            NullableResponse<ContainerRegistryPrivateEndpointConnectionResource> response = await collection.GetIfExistsAsync(privateEndpointConnectionName);
            ContainerRegistryPrivateEndpointConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerRegistryPrivateEndpointConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_PrivateEndpointConnectionCreateOrUpdate()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/stable/2022-12-01/examples/PrivateEndpointConnectionCreateOrUpdate.json
            // this example is just showing the usage of "PrivateEndpointConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryResource created on azure
            // for more information of creating ContainerRegistryResource, please refer to the document of ContainerRegistryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            ResourceIdentifier containerRegistryResourceId = ContainerRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            ContainerRegistryResource containerRegistry = client.GetContainerRegistryResource(containerRegistryResourceId);

            // get the collection of this ContainerRegistryPrivateEndpointConnectionResource
            ContainerRegistryPrivateEndpointConnectionCollection collection = containerRegistry.GetContainerRegistryPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "myConnection";
            ContainerRegistryPrivateEndpointConnectionData data = new ContainerRegistryPrivateEndpointConnectionData()
            {
                ConnectionState = new ContainerRegistryPrivateLinkServiceConnectionState()
                {
                    Status = ContainerRegistryPrivateLinkServiceConnectionStatus.Approved,
                    Description = "Auto-Approved",
                },
            };
            ArmOperation<ContainerRegistryPrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, data);
            ContainerRegistryPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerRegistryPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
