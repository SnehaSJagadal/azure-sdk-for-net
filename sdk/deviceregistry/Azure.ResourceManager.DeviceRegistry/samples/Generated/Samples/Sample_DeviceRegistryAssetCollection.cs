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
    public partial class Sample_DeviceRegistryAssetCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateAssetWithoutDisplayName()
        {
            // Generated from example definition: 2024-09-01-preview/Create_Asset_Without_DisplayName.json
            // this example is just showing the usage of "Asset_CreateOrReplace" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this DeviceRegistryAssetResource
            DeviceRegistryAssetCollection collection = resourceGroupResource.GetDeviceRegistryAssets();

            // invoke the operation
            string assetName = "my-asset";
            DeviceRegistryAssetData data = new DeviceRegistryAssetData(new AzureLocation("West Europe"), new DeviceRegistryExtendedLocation("CustomLocation", "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/myResourceGroup/providers/microsoft.extendedlocation/customlocations/location1"))
            {
                Properties = new AssetProperties("myAssetEndpointProfile")
                {
                    Enabled = true,
                    ExternalAssetId = "8ZBA6LRHU0A458969",
                    Description = "This is a sample Asset",
                    Manufacturer = "Contoso",
                    ManufacturerUri = new Uri("https://www.contoso.com/manufacturerUri"),
                    Model = "ContosoModel",
                    ProductCode = "SA34VDG",
                    HardwareRevision = "1.0",
                    SoftwareRevision = "2.0",
                    DocumentationUri = new Uri("https://www.example.com/manual"),
                    SerialNumber = "64-103816-519918-8",
                    DefaultDatasetsConfiguration = "{\"publishingInterval\":10,\"samplingInterval\":15,\"queueSize\":20}",
                    DefaultEventsConfiguration = "{\"publishingInterval\":10,\"samplingInterval\":15,\"queueSize\":20}",
                    DefaultTopic = new DeviceRegistryMqttTopic("/path/defaultTopic")
                    {
                        Retain = DeviceRegistryTopicRetainType.Keep,
                    },
                    Datasets = {new DeviceRegistryDataset("dataset1")
{
DatasetConfiguration = "{\"publishingInterval\":10,\"samplingInterval\":15,\"queueSize\":20}",
Topic = new DeviceRegistryMqttTopic("/path/dataset1")
{
Retain = DeviceRegistryTopicRetainType.Keep,
},
DataPoints = {new DeviceRegistryDataPoint("dataPoint1", "nsu=http://microsoft.com/Opc/OpcPlc/;s=FastUInt1")
{
ObservabilityMode = DataPointObservabilityMode.Counter,
DataPointConfiguration = "{\"publishingInterval\":8,\"samplingInterval\":8,\"queueSize\":4}",
}, new DeviceRegistryDataPoint("dataPoint2", "nsu=http://microsoft.com/Opc/OpcPlc/;s=FastUInt2")
{
ObservabilityMode = DataPointObservabilityMode.None,
DataPointConfiguration = "{\"publishingInterval\":4,\"samplingInterval\":4,\"queueSize\":7}",
}},
}},
                    Events = {new DeviceRegistryEvent("event1", "nsu=http://microsoft.com/Opc/OpcPlc/;s=FastUInt3")
{
ObservabilityMode = EventObservabilityMode.None,
EventConfiguration = "{\"publishingInterval\":7,\"samplingInterval\":1,\"queueSize\":8}",
Topic = new DeviceRegistryMqttTopic("/path/event1")
{
Retain = DeviceRegistryTopicRetainType.Keep,
},
}, new DeviceRegistryEvent("event2", "nsu=http://microsoft.com/Opc/OpcPlc/;s=FastUInt4")
{
ObservabilityMode = EventObservabilityMode.Log,
EventConfiguration = "{\"publishingInterval\":7,\"samplingInterval\":8,\"queueSize\":4}",
}},
                },
                Tags =
{
["site"] = "building-1"
},
            };
            ArmOperation<DeviceRegistryAssetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, assetName, data);
            DeviceRegistryAssetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceRegistryAssetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateAssetWithoutExternalAssetId()
        {
            // Generated from example definition: 2024-09-01-preview/Create_Asset_Without_ExternalAssetId.json
            // this example is just showing the usage of "Asset_CreateOrReplace" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this DeviceRegistryAssetResource
            DeviceRegistryAssetCollection collection = resourceGroupResource.GetDeviceRegistryAssets();

            // invoke the operation
            string assetName = "my-asset";
            DeviceRegistryAssetData data = new DeviceRegistryAssetData(new AzureLocation("West Europe"), new DeviceRegistryExtendedLocation("CustomLocation", "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/myResourceGroup/providers/microsoft.extendedlocation/customlocations/location1"))
            {
                Properties = new AssetProperties("myAssetEndpointProfile")
                {
                    Enabled = true,
                    DisplayName = "AssetDisplayName",
                    Description = "This is a sample Asset",
                    Manufacturer = "Contoso",
                    ManufacturerUri = new Uri("https://www.contoso.com/manufacturerUri"),
                    Model = "ContosoModel",
                    ProductCode = "SA34VDG",
                    HardwareRevision = "1.0",
                    SoftwareRevision = "2.0",
                    DocumentationUri = new Uri("https://www.example.com/manual"),
                    SerialNumber = "64-103816-519918-8",
                    DefaultDatasetsConfiguration = "{\"publishingInterval\":10,\"samplingInterval\":15,\"queueSize\":20}",
                    DefaultEventsConfiguration = "{\"publishingInterval\":10,\"samplingInterval\":15,\"queueSize\":20}",
                    DefaultTopic = new DeviceRegistryMqttTopic("/path/defaultTopic")
                    {
                        Retain = DeviceRegistryTopicRetainType.Keep,
                    },
                    Datasets = {new DeviceRegistryDataset("dataset1")
{
DatasetConfiguration = "{\"publishingInterval\":10,\"samplingInterval\":15,\"queueSize\":20}",
Topic = new DeviceRegistryMqttTopic("/path/dataset1")
{
Retain = DeviceRegistryTopicRetainType.Keep,
},
DataPoints = {new DeviceRegistryDataPoint("dataPoint1", "nsu=http://microsoft.com/Opc/OpcPlc/;s=FastUInt1")
{
ObservabilityMode = DataPointObservabilityMode.Counter,
DataPointConfiguration = "{\"publishingInterval\":8,\"samplingInterval\":8,\"queueSize\":4}",
}, new DeviceRegistryDataPoint("dataPoint2", "nsu=http://microsoft.com/Opc/OpcPlc/;s=FastUInt2")
{
ObservabilityMode = DataPointObservabilityMode.None,
DataPointConfiguration = "{\"publishingInterval\":4,\"samplingInterval\":4,\"queueSize\":7}",
}},
}},
                    Events = {new DeviceRegistryEvent("event1", "nsu=http://microsoft.com/Opc/OpcPlc/;s=FastUInt3")
{
ObservabilityMode = EventObservabilityMode.None,
EventConfiguration = "{\"publishingInterval\":7,\"samplingInterval\":1,\"queueSize\":8}",
Topic = new DeviceRegistryMqttTopic("/path/event1")
{
Retain = DeviceRegistryTopicRetainType.Keep,
},
}, new DeviceRegistryEvent("event2", "nsu=http://microsoft.com/Opc/OpcPlc/;s=FastUInt4")
{
ObservabilityMode = EventObservabilityMode.Log,
EventConfiguration = "{\"publishingInterval\":7,\"samplingInterval\":8,\"queueSize\":4}",
}},
                },
                Tags =
{
["site"] = "building-1"
},
            };
            ArmOperation<DeviceRegistryAssetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, assetName, data);
            DeviceRegistryAssetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceRegistryAssetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateAssetWithDiscoveredAssetRefs()
        {
            // Generated from example definition: 2024-09-01-preview/Create_Asset_With_DiscoveredAssetRef.json
            // this example is just showing the usage of "Asset_CreateOrReplace" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this DeviceRegistryAssetResource
            DeviceRegistryAssetCollection collection = resourceGroupResource.GetDeviceRegistryAssets();

            // invoke the operation
            string assetName = "my-asset";
            DeviceRegistryAssetData data = new DeviceRegistryAssetData(new AzureLocation("West Europe"), new DeviceRegistryExtendedLocation("CustomLocation", "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/myResourceGroup/providers/microsoft.extendedlocation/customlocations/location1"))
            {
                Properties = new AssetProperties("myAssetEndpointProfile")
                {
                    Enabled = true,
                    ExternalAssetId = "8ZBA6LRHU0A458969",
                    DisplayName = "AssetDisplayName",
                    Description = "This is a sample Asset",
                    Manufacturer = "Contoso",
                    ManufacturerUri = new Uri("https://www.contoso.com/manufacturerUri"),
                    Model = "ContosoModel",
                    ProductCode = "SA34VDG",
                    HardwareRevision = "1.0",
                    SoftwareRevision = "2.0",
                    DocumentationUri = new Uri("https://www.example.com/manual"),
                    SerialNumber = "64-103816-519918-8",
                    DiscoveredAssetRefs = { "discoveredAsset1", "discoveredAsset2" },
                    DefaultDatasetsConfiguration = "{\"publishingInterval\":10,\"samplingInterval\":15,\"queueSize\":20}",
                    DefaultEventsConfiguration = "{\"publishingInterval\":10,\"samplingInterval\":15,\"queueSize\":20}",
                    DefaultTopic = new DeviceRegistryMqttTopic("/path/defaultTopic")
                    {
                        Retain = DeviceRegistryTopicRetainType.Keep,
                    },
                    Datasets = {new DeviceRegistryDataset("dataset1")
{
DatasetConfiguration = "{\"publishingInterval\":10,\"samplingInterval\":15,\"queueSize\":20}",
Topic = new DeviceRegistryMqttTopic("/path/dataset1")
{
Retain = DeviceRegistryTopicRetainType.Keep,
},
DataPoints = {new DeviceRegistryDataPoint("dataPoint1", "nsu=http://microsoft.com/Opc/OpcPlc/;s=FastUInt1")
{
ObservabilityMode = DataPointObservabilityMode.Counter,
DataPointConfiguration = "{\"publishingInterval\":8,\"samplingInterval\":8,\"queueSize\":4}",
}, new DeviceRegistryDataPoint("dataPoint2", "nsu=http://microsoft.com/Opc/OpcPlc/;s=FastUInt2")
{
ObservabilityMode = DataPointObservabilityMode.None,
DataPointConfiguration = "{\"publishingInterval\":4,\"samplingInterval\":4,\"queueSize\":7}",
}},
}},
                    Events = {new DeviceRegistryEvent("event1", "nsu=http://microsoft.com/Opc/OpcPlc/;s=FastUInt3")
{
ObservabilityMode = EventObservabilityMode.None,
EventConfiguration = "{\"publishingInterval\":7,\"samplingInterval\":1,\"queueSize\":8}",
Topic = new DeviceRegistryMqttTopic("/path/event1")
{
Retain = DeviceRegistryTopicRetainType.Keep,
},
}, new DeviceRegistryEvent("event2", "nsu=http://microsoft.com/Opc/OpcPlc/;s=FastUInt4")
{
ObservabilityMode = EventObservabilityMode.Log,
EventConfiguration = "{\"publishingInterval\":7,\"samplingInterval\":8,\"queueSize\":4}",
}},
                },
                Tags =
{
["site"] = "building-1"
},
            };
            ArmOperation<DeviceRegistryAssetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, assetName, data);
            DeviceRegistryAssetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceRegistryAssetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateAssetWithExternalAssetId()
        {
            // Generated from example definition: 2024-09-01-preview/Create_Asset_With_ExternalAssetId.json
            // this example is just showing the usage of "Asset_CreateOrReplace" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this DeviceRegistryAssetResource
            DeviceRegistryAssetCollection collection = resourceGroupResource.GetDeviceRegistryAssets();

            // invoke the operation
            string assetName = "my-asset";
            DeviceRegistryAssetData data = new DeviceRegistryAssetData(new AzureLocation("West Europe"), new DeviceRegistryExtendedLocation("CustomLocation", "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/myResourceGroup/providers/microsoft.extendedlocation/customlocations/location1"))
            {
                Properties = new AssetProperties("myAssetEndpointProfile")
                {
                    Enabled = true,
                    ExternalAssetId = "8ZBA6LRHU0A458969",
                    DisplayName = "AssetDisplayName",
                    Description = "This is a sample Asset",
                    Manufacturer = "Contoso",
                    ManufacturerUri = new Uri("https://www.contoso.com/manufacturerUri"),
                    Model = "ContosoModel",
                    ProductCode = "SA34VDG",
                    HardwareRevision = "1.0",
                    SoftwareRevision = "2.0",
                    DocumentationUri = new Uri("https://www.example.com/manual"),
                    SerialNumber = "64-103816-519918-8",
                    DefaultDatasetsConfiguration = "{\"publishingInterval\":10,\"samplingInterval\":15,\"queueSize\":20}",
                    DefaultEventsConfiguration = "{\"publishingInterval\":10,\"samplingInterval\":15,\"queueSize\":20}",
                    DefaultTopic = new DeviceRegistryMqttTopic("/path/defaultTopic")
                    {
                        Retain = DeviceRegistryTopicRetainType.Keep,
                    },
                    Datasets = {new DeviceRegistryDataset("dataset1")
{
DatasetConfiguration = "{\"publishingInterval\":10,\"samplingInterval\":15,\"queueSize\":20}",
Topic = new DeviceRegistryMqttTopic("/path/dataset1")
{
Retain = DeviceRegistryTopicRetainType.Keep,
},
DataPoints = {new DeviceRegistryDataPoint("dataPoint1", "nsu=http://microsoft.com/Opc/OpcPlc/;s=FastUInt1")
{
ObservabilityMode = DataPointObservabilityMode.Counter,
DataPointConfiguration = "{\"publishingInterval\":8,\"samplingInterval\":8,\"queueSize\":4}",
}, new DeviceRegistryDataPoint("dataPoint2", "nsu=http://microsoft.com/Opc/OpcPlc/;s=FastUInt2")
{
ObservabilityMode = DataPointObservabilityMode.None,
DataPointConfiguration = "{\"publishingInterval\":4,\"samplingInterval\":4,\"queueSize\":7}",
}},
}},
                    Events = {new DeviceRegistryEvent("event1", "nsu=http://microsoft.com/Opc/OpcPlc/;s=FastUInt3")
{
ObservabilityMode = EventObservabilityMode.None,
EventConfiguration = "{\"publishingInterval\":7,\"samplingInterval\":1,\"queueSize\":8}",
Topic = new DeviceRegistryMqttTopic("/path/event1")
{
Retain = DeviceRegistryTopicRetainType.Keep,
},
}, new DeviceRegistryEvent("event2", "nsu=http://microsoft.com/Opc/OpcPlc/;s=FastUInt4")
{
ObservabilityMode = EventObservabilityMode.Log,
EventConfiguration = "{\"publishingInterval\":7,\"samplingInterval\":8,\"queueSize\":4}",
}},
                },
                Tags =
{
["site"] = "building-1"
},
            };
            ArmOperation<DeviceRegistryAssetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, assetName, data);
            DeviceRegistryAssetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceRegistryAssetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAsset()
        {
            // Generated from example definition: 2024-09-01-preview/Get_Asset.json
            // this example is just showing the usage of "Asset_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this DeviceRegistryAssetResource
            DeviceRegistryAssetCollection collection = resourceGroupResource.GetDeviceRegistryAssets();

            // invoke the operation
            string assetName = "my-asset";
            DeviceRegistryAssetResource result = await collection.GetAsync(assetName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceRegistryAssetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAssetWithSyncStatus()
        {
            // Generated from example definition: 2024-09-01-preview/Get_Asset_With_SyncStatus.json
            // this example is just showing the usage of "Asset_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this DeviceRegistryAssetResource
            DeviceRegistryAssetCollection collection = resourceGroupResource.GetDeviceRegistryAssets();

            // invoke the operation
            string assetName = "my-asset";
            DeviceRegistryAssetResource result = await collection.GetAsync(assetName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceRegistryAssetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAssetsResourceGroup()
        {
            // Generated from example definition: 2024-09-01-preview/List_Assets_ResourceGroup.json
            // this example is just showing the usage of "Asset_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this DeviceRegistryAssetResource
            DeviceRegistryAssetCollection collection = resourceGroupResource.GetDeviceRegistryAssets();

            // invoke the operation and iterate over the result
            await foreach (DeviceRegistryAssetResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DeviceRegistryAssetData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAsset()
        {
            // Generated from example definition: 2024-09-01-preview/Get_Asset.json
            // this example is just showing the usage of "Asset_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this DeviceRegistryAssetResource
            DeviceRegistryAssetCollection collection = resourceGroupResource.GetDeviceRegistryAssets();

            // invoke the operation
            string assetName = "my-asset";
            bool result = await collection.ExistsAsync(assetName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAssetWithSyncStatus()
        {
            // Generated from example definition: 2024-09-01-preview/Get_Asset_With_SyncStatus.json
            // this example is just showing the usage of "Asset_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this DeviceRegistryAssetResource
            DeviceRegistryAssetCollection collection = resourceGroupResource.GetDeviceRegistryAssets();

            // invoke the operation
            string assetName = "my-asset";
            bool result = await collection.ExistsAsync(assetName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAsset()
        {
            // Generated from example definition: 2024-09-01-preview/Get_Asset.json
            // this example is just showing the usage of "Asset_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this DeviceRegistryAssetResource
            DeviceRegistryAssetCollection collection = resourceGroupResource.GetDeviceRegistryAssets();

            // invoke the operation
            string assetName = "my-asset";
            NullableResponse<DeviceRegistryAssetResource> response = await collection.GetIfExistsAsync(assetName);
            DeviceRegistryAssetResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DeviceRegistryAssetData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAssetWithSyncStatus()
        {
            // Generated from example definition: 2024-09-01-preview/Get_Asset_With_SyncStatus.json
            // this example is just showing the usage of "Asset_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this DeviceRegistryAssetResource
            DeviceRegistryAssetCollection collection = resourceGroupResource.GetDeviceRegistryAssets();

            // invoke the operation
            string assetName = "my-asset";
            NullableResponse<DeviceRegistryAssetResource> response = await collection.GetIfExistsAsync(assetName);
            DeviceRegistryAssetResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DeviceRegistryAssetData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
