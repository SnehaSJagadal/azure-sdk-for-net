// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.KeyVault.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.KeyVault.Samples
{
    public partial class Sample_ManagedHsmPrivateEndpointConnectionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ManagedHsmPutPrivateEndpointConnection()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2023-07-01/examples/ManagedHsm_putPrivateEndpointConnection.json
            // this example is just showing the usage of "MHSMPrivateEndpointConnections_Put" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedHsmResource created on azure
            // for more information of creating ManagedHsmResource, please refer to the document of ManagedHsmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-group";
            string name = "sample-mhsm";
            ResourceIdentifier managedHsmResourceId = ManagedHsmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            ManagedHsmResource managedHsm = client.GetManagedHsmResource(managedHsmResourceId);

            // get the collection of this ManagedHsmPrivateEndpointConnectionResource
            ManagedHsmPrivateEndpointConnectionCollection collection = managedHsm.GetManagedHsmPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "sample-pec";
            ManagedHsmPrivateEndpointConnectionData data = new ManagedHsmPrivateEndpointConnectionData(default)
            {
                PrivateLinkServiceConnectionState = new ManagedHsmPrivateLinkServiceConnectionState
                {
                    Status = ManagedHsmPrivateEndpointServiceConnectionStatus.Approved,
                    Description = "My name is Joe and I'm approving this.",
                },
            };
            ArmOperation<ManagedHsmPrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, data);
            ManagedHsmPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedHsmPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ManagedHsmGetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2023-07-01/examples/ManagedHsm_getPrivateEndpointConnection.json
            // this example is just showing the usage of "MHSMPrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedHsmResource created on azure
            // for more information of creating ManagedHsmResource, please refer to the document of ManagedHsmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-group";
            string name = "sample-mhsm";
            ResourceIdentifier managedHsmResourceId = ManagedHsmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            ManagedHsmResource managedHsm = client.GetManagedHsmResource(managedHsmResourceId);

            // get the collection of this ManagedHsmPrivateEndpointConnectionResource
            ManagedHsmPrivateEndpointConnectionCollection collection = managedHsm.GetManagedHsmPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "sample-pec";
            ManagedHsmPrivateEndpointConnectionResource result = await collection.GetAsync(privateEndpointConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedHsmPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListManagedHSMPoolsInASubscription()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2023-07-01/examples/ManagedHsm_ListPrivateEndpointConnectionsByResource.json
            // this example is just showing the usage of "MHSMPrivateEndpointConnections_ListByResource" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedHsmResource created on azure
            // for more information of creating ManagedHsmResource, please refer to the document of ManagedHsmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-group";
            string name = "sample-mhsm";
            ResourceIdentifier managedHsmResourceId = ManagedHsmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            ManagedHsmResource managedHsm = client.GetManagedHsmResource(managedHsmResourceId);

            // get the collection of this ManagedHsmPrivateEndpointConnectionResource
            ManagedHsmPrivateEndpointConnectionCollection collection = managedHsm.GetManagedHsmPrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (ManagedHsmPrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedHsmPrivateEndpointConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ManagedHsmGetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2023-07-01/examples/ManagedHsm_getPrivateEndpointConnection.json
            // this example is just showing the usage of "MHSMPrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedHsmResource created on azure
            // for more information of creating ManagedHsmResource, please refer to the document of ManagedHsmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-group";
            string name = "sample-mhsm";
            ResourceIdentifier managedHsmResourceId = ManagedHsmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            ManagedHsmResource managedHsm = client.GetManagedHsmResource(managedHsmResourceId);

            // get the collection of this ManagedHsmPrivateEndpointConnectionResource
            ManagedHsmPrivateEndpointConnectionCollection collection = managedHsm.GetManagedHsmPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "sample-pec";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ManagedHsmGetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/keyvault/resource-manager/Microsoft.KeyVault/stable/2023-07-01/examples/ManagedHsm_getPrivateEndpointConnection.json
            // this example is just showing the usage of "MHSMPrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedHsmResource created on azure
            // for more information of creating ManagedHsmResource, please refer to the document of ManagedHsmResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-group";
            string name = "sample-mhsm";
            ResourceIdentifier managedHsmResourceId = ManagedHsmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            ManagedHsmResource managedHsm = client.GetManagedHsmResource(managedHsmResourceId);

            // get the collection of this ManagedHsmPrivateEndpointConnectionResource
            ManagedHsmPrivateEndpointConnectionCollection collection = managedHsm.GetManagedHsmPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "sample-pec";
            NullableResponse<ManagedHsmPrivateEndpointConnectionResource> response = await collection.GetIfExistsAsync(privateEndpointConnectionName);
            ManagedHsmPrivateEndpointConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedHsmPrivateEndpointConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
