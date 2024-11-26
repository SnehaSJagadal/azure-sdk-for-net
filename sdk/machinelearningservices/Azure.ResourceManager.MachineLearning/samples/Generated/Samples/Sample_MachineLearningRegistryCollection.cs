// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearning.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningRegistryCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListRegistriesWithSystemCreatedAccounts()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registries/list-SystemCreated.json
            // this example is just showing the usage of "Registries_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MachineLearningRegistryResource
            MachineLearningRegistryCollection collection = resourceGroupResource.GetMachineLearningRegistries();

            // invoke the operation and iterate over the result
            await foreach (MachineLearningRegistryResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningRegistryData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListRegistriesWithUserCreatedAccounts()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registries/list-UserCreated.json
            // this example is just showing the usage of "Registries_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MachineLearningRegistryResource
            MachineLearningRegistryCollection collection = resourceGroupResource.GetMachineLearningRegistries();

            // invoke the operation and iterate over the result
            await foreach (MachineLearningRegistryResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningRegistryData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetRegistryWithSystemCreatedAccounts()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registries/get-SystemCreated.json
            // this example is just showing the usage of "Registries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MachineLearningRegistryResource
            MachineLearningRegistryCollection collection = resourceGroupResource.GetMachineLearningRegistries();

            // invoke the operation
            string registryName = "string";
            MachineLearningRegistryResource result = await collection.GetAsync(registryName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningRegistryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetRegistryWithSystemCreatedAccounts()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registries/get-SystemCreated.json
            // this example is just showing the usage of "Registries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MachineLearningRegistryResource
            MachineLearningRegistryCollection collection = resourceGroupResource.GetMachineLearningRegistries();

            // invoke the operation
            string registryName = "string";
            bool result = await collection.ExistsAsync(registryName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetRegistryWithSystemCreatedAccounts()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registries/get-SystemCreated.json
            // this example is just showing the usage of "Registries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MachineLearningRegistryResource
            MachineLearningRegistryCollection collection = resourceGroupResource.GetMachineLearningRegistries();

            // invoke the operation
            string registryName = "string";
            NullableResponse<MachineLearningRegistryResource> response = await collection.GetIfExistsAsync(registryName);
            MachineLearningRegistryResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningRegistryData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetRegistryWithUserCreatedAccounts()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registries/get-UserCreated.json
            // this example is just showing the usage of "Registries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MachineLearningRegistryResource
            MachineLearningRegistryCollection collection = resourceGroupResource.GetMachineLearningRegistries();

            // invoke the operation
            string registryName = "string";
            MachineLearningRegistryResource result = await collection.GetAsync(registryName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningRegistryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetRegistryWithUserCreatedAccounts()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registries/get-UserCreated.json
            // this example is just showing the usage of "Registries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MachineLearningRegistryResource
            MachineLearningRegistryCollection collection = resourceGroupResource.GetMachineLearningRegistries();

            // invoke the operation
            string registryName = "string";
            bool result = await collection.ExistsAsync(registryName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetRegistryWithUserCreatedAccounts()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registries/get-UserCreated.json
            // this example is just showing the usage of "Registries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MachineLearningRegistryResource
            MachineLearningRegistryCollection collection = resourceGroupResource.GetMachineLearningRegistries();

            // invoke the operation
            string registryName = "string";
            NullableResponse<MachineLearningRegistryResource> response = await collection.GetIfExistsAsync(registryName);
            MachineLearningRegistryResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningRegistryData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateRegistryWithSystemCreatedAccounts()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registries/createOrUpdate-SystemCreated.json
            // this example is just showing the usage of "Registries_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MachineLearningRegistryResource
            MachineLearningRegistryCollection collection = resourceGroupResource.GetMachineLearningRegistries();

            // invoke the operation
            string registryName = "string";
            MachineLearningRegistryData data = new MachineLearningRegistryData(new AzureLocation("string"))
            {
                Identity = new ManagedServiceIdentity("None")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("string")] = new UserAssignedIdentity(),
},
                },
                Kind = "string",
                Sku = new MachineLearningSku("string")
                {
                    Tier = MachineLearningSkuTier.Free,
                    Size = "string",
                    Family = "string",
                    Capacity = 1,
                },
                DiscoveryUri = new Uri("string"),
                IntellectualPropertyPublisher = "string",
                ManagedResourceId = new ResourceIdentifier("string"),
                MlFlowRegistryUri = new Uri("string"),
                RegistryPrivateEndpointConnections =
{
new RegistryPrivateEndpointConnection()
{
Id = new ResourceIdentifier("string"),
Location = new AzureLocation("string"),
GroupIds =
{
"string"
},
PrivateEndpoint = new RegistryPrivateEndpoint()
{
SubnetArmId = new ResourceIdentifier("string"),
},
RegistryPrivateLinkServiceConnectionState = new RegistryPrivateLinkServiceConnectionState()
{
ActionsRequired = "string",
Description = "string",
Status = EndpointServiceConnectionStatus.Approved,
},
ProvisioningState = "string",
}
},
                PublicNetworkAccess = "string",
                RegionDetails =
{
new RegistryRegionArmDetails()
{
AcrDetails =
{
new RegistryAcrDetails()
{
SystemCreatedAcrAccount = new SystemCreatedAcrAccount()
{
AcrAccountName = "string",
AcrAccountSku = "string",
ArmResourceId = new ResourceIdentifier("string"),
},
}
},
Location = new AzureLocation("string"),
StorageAccountDetails =
{
new StorageAccountDetails()
{
SystemCreatedStorageAccount = new SystemCreatedStorageAccount()
{
AllowBlobPublicAccess = false,
ArmResourceId = new ResourceIdentifier("string"),
StorageAccountHnsEnabled = false,
StorageAccountName = "string",
StorageAccountType = "string",
},
}
},
}
},
                Tags =
{
},
            };
            ArmOperation<MachineLearningRegistryResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, registryName, data);
            MachineLearningRegistryResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningRegistryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateRegistryWithUserCreatedAccounts()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registries/createOrUpdate-UserCreated.json
            // this example is just showing the usage of "Registries_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this MachineLearningRegistryResource
            MachineLearningRegistryCollection collection = resourceGroupResource.GetMachineLearningRegistries();

            // invoke the operation
            string registryName = "string";
            MachineLearningRegistryData data = new MachineLearningRegistryData(new AzureLocation("string"))
            {
                Identity = new ManagedServiceIdentity("None")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("string")] = new UserAssignedIdentity(),
},
                },
                Kind = "string",
                Sku = new MachineLearningSku("string")
                {
                    Tier = MachineLearningSkuTier.Free,
                    Size = "string",
                    Family = "string",
                    Capacity = 1,
                },
                DiscoveryUri = new Uri("string"),
                IntellectualPropertyPublisher = "string",
                ManagedResourceId = new ResourceIdentifier("string"),
                MlFlowRegistryUri = new Uri("string"),
                RegistryPrivateEndpointConnections =
{
new RegistryPrivateEndpointConnection()
{
Id = new ResourceIdentifier("string"),
Location = new AzureLocation("string"),
GroupIds =
{
"string"
},
PrivateEndpoint = new RegistryPrivateEndpoint()
{
SubnetArmId = new ResourceIdentifier("string"),
},
RegistryPrivateLinkServiceConnectionState = new RegistryPrivateLinkServiceConnectionState()
{
ActionsRequired = "string",
Description = "string",
Status = EndpointServiceConnectionStatus.Approved,
},
ProvisioningState = "string",
}
},
                PublicNetworkAccess = "string",
                RegionDetails =
{
new RegistryRegionArmDetails()
{
AcrDetails =
{
new RegistryAcrDetails()
{
ArmResourceId = new ResourceIdentifier("string"),
}
},
Location = new AzureLocation("string"),
StorageAccountDetails =
{
new StorageAccountDetails()
{
ArmResourceId = new ResourceIdentifier("string"),
}
},
}
},
                Tags =
{
},
            };
            ArmOperation<MachineLearningRegistryResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, registryName, data);
            MachineLearningRegistryResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningRegistryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
