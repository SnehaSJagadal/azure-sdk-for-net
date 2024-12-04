// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DeviceRegistry.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.DeviceRegistry.Samples
{
    public partial class Sample_AssetEndpointProfileCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateAssetEndpointProfile()
        {
            // Generated from example definition: 2024-09-01-preview/Create_AssetEndpointProfile.json
            // this example is just showing the usage of "AssetEndpointProfile_CreateOrReplace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AssetEndpointProfileResource
            AssetEndpointProfileCollection collection = resourceGroupResource.GetAssetEndpointProfiles();

            // invoke the operation
            string assetEndpointProfileName = "my-assetendpointprofile";
            AssetEndpointProfileData data = new AssetEndpointProfileData(new AzureLocation("West Europe"), new ExtendedLocation("CustomLocation", "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/myResourceGroup/providers/microsoft.extendedlocation/customlocations/location1"))
            {
                Properties = new AssetEndpointProfileProperties(new Uri("https://www.example.com/myTargetAddress"), "myEndpointProfileType")
                {
                    Authentication = new Authentication(AuthenticationMethod.Anonymous),
                },
                Tags =
{
["site"] = "building-1"
},
            };
            ArmOperation<AssetEndpointProfileResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, assetEndpointProfileName, data);
            AssetEndpointProfileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AssetEndpointProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateAssetEndpointProfileWithDiscoveredAepRef()
        {
            // Generated from example definition: 2024-09-01-preview/Create_AssetEndpointProfile_With_DiscoveredAepRef.json
            // this example is just showing the usage of "AssetEndpointProfile_CreateOrReplace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AssetEndpointProfileResource
            AssetEndpointProfileCollection collection = resourceGroupResource.GetAssetEndpointProfiles();

            // invoke the operation
            string assetEndpointProfileName = "my-assetendpointprofile";
            AssetEndpointProfileData data = new AssetEndpointProfileData(new AzureLocation("West Europe"), new ExtendedLocation("CustomLocation", "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/myResourceGroup/providers/microsoft.extendedlocation/customlocations/location1"))
            {
                Properties = new AssetEndpointProfileProperties(new Uri("https://www.example.com/myTargetAddress"), "myEndpointProfileType")
                {
                    Authentication = new Authentication(AuthenticationMethod.Anonymous),
                    DiscoveredAssetEndpointProfileRef = "discoveredAssetEndpointProfile1",
                },
                Tags =
{
["site"] = "building-1"
},
            };
            ArmOperation<AssetEndpointProfileResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, assetEndpointProfileName, data);
            AssetEndpointProfileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AssetEndpointProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAssetEndpointProfile()
        {
            // Generated from example definition: 2024-09-01-preview/Get_AssetEndpointProfile.json
            // this example is just showing the usage of "AssetEndpointProfile_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AssetEndpointProfileResource
            AssetEndpointProfileCollection collection = resourceGroupResource.GetAssetEndpointProfiles();

            // invoke the operation
            string assetEndpointProfileName = "my-assetendpointprofile";
            AssetEndpointProfileResource result = await collection.GetAsync(assetEndpointProfileName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AssetEndpointProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAssetEndpointProfileWithSyncStatus()
        {
            // Generated from example definition: 2024-09-01-preview/Get_AssetEndpointProfile_With_SyncStatus.json
            // this example is just showing the usage of "AssetEndpointProfile_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AssetEndpointProfileResource
            AssetEndpointProfileCollection collection = resourceGroupResource.GetAssetEndpointProfiles();

            // invoke the operation
            string assetEndpointProfileName = "my-assetendpointprofile";
            AssetEndpointProfileResource result = await collection.GetAsync(assetEndpointProfileName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AssetEndpointProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAssetEndpointProfilesResourceGroup()
        {
            // Generated from example definition: 2024-09-01-preview/List_AssetEndpointProfiles_ResourceGroup.json
            // this example is just showing the usage of "AssetEndpointProfile_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AssetEndpointProfileResource
            AssetEndpointProfileCollection collection = resourceGroupResource.GetAssetEndpointProfiles();

            // invoke the operation and iterate over the result
            await foreach (AssetEndpointProfileResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AssetEndpointProfileData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAssetEndpointProfile()
        {
            // Generated from example definition: 2024-09-01-preview/Get_AssetEndpointProfile.json
            // this example is just showing the usage of "AssetEndpointProfile_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AssetEndpointProfileResource
            AssetEndpointProfileCollection collection = resourceGroupResource.GetAssetEndpointProfiles();

            // invoke the operation
            string assetEndpointProfileName = "my-assetendpointprofile";
            bool result = await collection.ExistsAsync(assetEndpointProfileName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAssetEndpointProfileWithSyncStatus()
        {
            // Generated from example definition: 2024-09-01-preview/Get_AssetEndpointProfile_With_SyncStatus.json
            // this example is just showing the usage of "AssetEndpointProfile_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AssetEndpointProfileResource
            AssetEndpointProfileCollection collection = resourceGroupResource.GetAssetEndpointProfiles();

            // invoke the operation
            string assetEndpointProfileName = "my-assetendpointprofile";
            bool result = await collection.ExistsAsync(assetEndpointProfileName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAssetEndpointProfile()
        {
            // Generated from example definition: 2024-09-01-preview/Get_AssetEndpointProfile.json
            // this example is just showing the usage of "AssetEndpointProfile_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AssetEndpointProfileResource
            AssetEndpointProfileCollection collection = resourceGroupResource.GetAssetEndpointProfiles();

            // invoke the operation
            string assetEndpointProfileName = "my-assetendpointprofile";
            NullableResponse<AssetEndpointProfileResource> response = await collection.GetIfExistsAsync(assetEndpointProfileName);
            AssetEndpointProfileResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AssetEndpointProfileData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAssetEndpointProfileWithSyncStatus()
        {
            // Generated from example definition: 2024-09-01-preview/Get_AssetEndpointProfile_With_SyncStatus.json
            // this example is just showing the usage of "AssetEndpointProfile_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AssetEndpointProfileResource
            AssetEndpointProfileCollection collection = resourceGroupResource.GetAssetEndpointProfiles();

            // invoke the operation
            string assetEndpointProfileName = "my-assetendpointprofile";
            NullableResponse<AssetEndpointProfileResource> response = await collection.GetIfExistsAsync(assetEndpointProfileName);
            AssetEndpointProfileResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AssetEndpointProfileData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
