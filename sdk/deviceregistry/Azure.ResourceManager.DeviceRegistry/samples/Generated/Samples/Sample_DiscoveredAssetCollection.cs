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
    public partial class Sample_DiscoveredAssetCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateDiscoveredAsset()
        {
            // Generated from example definition: 2024-09-01-preview/Create_DiscoveredAsset.json
            // this example is just showing the usage of "DiscoveredAsset_CreateOrReplace" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this DiscoveredAssetResource
            DiscoveredAssetCollection collection = resourceGroupResource.GetDiscoveredAssets();

            // invoke the operation
            string discoveredAssetName = "my-discoveredasset";
            DiscoveredAssetData data = new DiscoveredAssetData(new AzureLocation("West Europe"), new ExtendedLocation("CustomLocation", "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/myResourceGroup/providers/microsoft.extendedlocation/customlocations/location1"))
            {
                Properties = new DiscoveredAssetProperties("myAssetEndpointProfile", "11111111-1111-1111-1111-111111111111", 73766L)
                {
                    Manufacturer = "Contoso",
                    ManufacturerUri = "https://www.contoso.com/manufacturerUri",
                    Model = "ContosoModel",
                    ProductCode = "SA34VDG",
                    HardwareRevision = "1.0",
                    SoftwareRevision = "2.0",
                    DocumentationUri = "https://www.example.com/manual",
                    SerialNumber = "64-103816-519918-8",
                    DefaultDatasetsConfiguration = "{\"publishingInterval\":10,\"samplingInterval\":15,\"queueSize\":20}",
                    DefaultEventsConfiguration = "{\"publishingInterval\":10,\"samplingInterval\":15,\"queueSize\":20}",
                    DefaultTopic = new Topic("/path/defaultTopic")
                    {
                        Retain = TopicRetainType.Keep,
                    },
                    Datasets = {new DiscoveredDataset("dataset1")
{
DatasetConfiguration = "{\"publishingInterval\":10,\"samplingInterval\":15,\"queueSize\":20}",
Topic = new Topic("/path/dataset1")
{
Retain = TopicRetainType.Keep,
},
DataPoints = {new DiscoveredDataPoint("dataPoint1", "nsu=http://microsoft.com/Opc/OpcPlc/;s=FastUInt1")
{
DataPointConfiguration = "{\"publishingInterval\":8,\"samplingInterval\":8,\"queueSize\":4}",
}, new DiscoveredDataPoint("dataPoint2", "nsu=http://microsoft.com/Opc/OpcPlc/;s=FastUInt2")
{
DataPointConfiguration = "{\"publishingInterval\":4,\"samplingInterval\":4,\"queueSize\":7}",
}},
}},
                    Events = {new DiscoveredEvent("event1", "nsu=http://microsoft.com/Opc/OpcPlc/;s=FastUInt3")
{
EventConfiguration = "{\"publishingInterval\":7,\"samplingInterval\":1,\"queueSize\":8}",
Topic = new Topic("/path/event1")
{
Retain = TopicRetainType.Keep,
},
}, new DiscoveredEvent("event2", "nsu=http://microsoft.com/Opc/OpcPlc/;s=FastUInt4")
{
EventConfiguration = "{\"publishingInterval\":7,\"samplingInterval\":8,\"queueSize\":4}",
}},
                },
                Tags =
{
["site"] = "building-1"
},
            };
            ArmOperation<DiscoveredAssetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, discoveredAssetName, data);
            DiscoveredAssetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiscoveredAssetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetDiscoveredAsset()
        {
            // Generated from example definition: 2024-09-01-preview/Get_DiscoveredAsset.json
            // this example is just showing the usage of "DiscoveredAsset_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this DiscoveredAssetResource
            DiscoveredAssetCollection collection = resourceGroupResource.GetDiscoveredAssets();

            // invoke the operation
            string discoveredAssetName = "my-discoveredasset";
            DiscoveredAssetResource result = await collection.GetAsync(discoveredAssetName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiscoveredAssetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListDiscoveredAssetsResourceGroup()
        {
            // Generated from example definition: 2024-09-01-preview/List_DiscoveredAssets_ResourceGroup.json
            // this example is just showing the usage of "DiscoveredAsset_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this DiscoveredAssetResource
            DiscoveredAssetCollection collection = resourceGroupResource.GetDiscoveredAssets();

            // invoke the operation and iterate over the result
            await foreach (DiscoveredAssetResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DiscoveredAssetData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetDiscoveredAsset()
        {
            // Generated from example definition: 2024-09-01-preview/Get_DiscoveredAsset.json
            // this example is just showing the usage of "DiscoveredAsset_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this DiscoveredAssetResource
            DiscoveredAssetCollection collection = resourceGroupResource.GetDiscoveredAssets();

            // invoke the operation
            string discoveredAssetName = "my-discoveredasset";
            bool result = await collection.ExistsAsync(discoveredAssetName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetDiscoveredAsset()
        {
            // Generated from example definition: 2024-09-01-preview/Get_DiscoveredAsset.json
            // this example is just showing the usage of "DiscoveredAsset_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this DiscoveredAssetResource
            DiscoveredAssetCollection collection = resourceGroupResource.GetDiscoveredAssets();

            // invoke the operation
            string discoveredAssetName = "my-discoveredasset";
            NullableResponse<DiscoveredAssetResource> response = await collection.GetIfExistsAsync(discoveredAssetName);
            DiscoveredAssetResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DiscoveredAssetData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
