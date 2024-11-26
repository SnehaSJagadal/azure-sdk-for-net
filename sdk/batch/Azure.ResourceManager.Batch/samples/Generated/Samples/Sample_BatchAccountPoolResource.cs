// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using System.Xml;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Batch.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Batch.Samples
{
    public partial class Sample_BatchAccountPoolResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdatePoolEnableAutoscale()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/PoolUpdate_EnableAutoScale.json
            // this example is just showing the usage of "Pool_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountPoolResource created on azure
            // for more information of creating BatchAccountPoolResource, please refer to the document of BatchAccountPoolResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string poolName = "testpool";
            ResourceIdentifier batchAccountPoolResourceId = BatchAccountPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            BatchAccountPoolResource batchAccountPool = client.GetBatchAccountPoolResource(batchAccountPoolResourceId);

            // invoke the operation
            BatchAccountPoolData data = new BatchAccountPoolData()
            {
                ScaleSettings = new BatchAccountPoolScaleSettings()
                {
                    AutoScale = new BatchAccountAutoScaleSettings("$TargetDedicatedNodes=34"),
                },
            };
            BatchAccountPoolResource result = await batchAccountPool.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchAccountPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdatePoolOtherProperties()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/PoolUpdate_OtherProperties.json
            // this example is just showing the usage of "Pool_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountPoolResource created on azure
            // for more information of creating BatchAccountPoolResource, please refer to the document of BatchAccountPoolResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string poolName = "testpool";
            ResourceIdentifier batchAccountPoolResourceId = BatchAccountPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            BatchAccountPoolResource batchAccountPool = client.GetBatchAccountPoolResource(batchAccountPoolResourceId);

            // invoke the operation
            BatchAccountPoolData data = new BatchAccountPoolData()
            {
                Metadata =
{
new BatchAccountPoolMetadataItem("key1","value1")
},
                Certificates =
{
new BatchCertificateReference(new ResourceIdentifier("/subscriptions/subid/resourceGroups/default-azurebatch-japaneast/providers/Microsoft.Batch/batchAccounts/sampleacct/pools/testpool/certificates/sha1-1234567"))
{
StoreLocation = BatchCertificateStoreLocation.LocalMachine,
StoreName = "MY",
}
},
                ApplicationPackages =
{
new BatchApplicationPackageReference(new ResourceIdentifier("/subscriptions/subid/resourceGroups/default-azurebatch-japaneast/providers/Microsoft.Batch/batchAccounts/sampleacct/pools/testpool/applications/app_1234")),new BatchApplicationPackageReference(new ResourceIdentifier("/subscriptions/subid/resourceGroups/default-azurebatch-japaneast/providers/Microsoft.Batch/batchAccounts/sampleacct/pools/testpool/applications/app_5678"))
{
Version = "1.0",
}
},
                TargetNodeCommunicationMode = NodeCommunicationMode.Simplified,
            };
            BatchAccountPoolResource result = await batchAccountPool.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchAccountPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdatePoolRemoveStartTask()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/PoolUpdate_RemoveStartTask.json
            // this example is just showing the usage of "Pool_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountPoolResource created on azure
            // for more information of creating BatchAccountPoolResource, please refer to the document of BatchAccountPoolResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string poolName = "testpool";
            ResourceIdentifier batchAccountPoolResourceId = BatchAccountPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            BatchAccountPoolResource batchAccountPool = client.GetBatchAccountPoolResource(batchAccountPoolResourceId);

            // invoke the operation
            BatchAccountPoolData data = new BatchAccountPoolData()
            {
                StartTask = new BatchAccountPoolStartTask(),
            };
            BatchAccountPoolResource result = await batchAccountPool.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchAccountPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdatePoolResizePool()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/PoolUpdate_ResizePool.json
            // this example is just showing the usage of "Pool_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountPoolResource created on azure
            // for more information of creating BatchAccountPoolResource, please refer to the document of BatchAccountPoolResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string poolName = "testpool";
            ResourceIdentifier batchAccountPoolResourceId = BatchAccountPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            BatchAccountPoolResource batchAccountPool = client.GetBatchAccountPoolResource(batchAccountPoolResourceId);

            // invoke the operation
            BatchAccountPoolData data = new BatchAccountPoolData()
            {
                ScaleSettings = new BatchAccountPoolScaleSettings()
                {
                    FixedScale = new BatchAccountFixedScaleSettings()
                    {
                        ResizeTimeout = XmlConvert.ToTimeSpan("PT8M"),
                        TargetDedicatedNodes = 5,
                        TargetLowPriorityNodes = 0,
                        NodeDeallocationOption = BatchNodeDeallocationOption.TaskCompletion,
                    },
                },
            };
            BatchAccountPoolResource result = await batchAccountPool.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchAccountPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeletePool()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/PoolDelete.json
            // this example is just showing the usage of "Pool_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountPoolResource created on azure
            // for more information of creating BatchAccountPoolResource, please refer to the document of BatchAccountPoolResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string poolName = "testpool";
            ResourceIdentifier batchAccountPoolResourceId = BatchAccountPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            BatchAccountPoolResource batchAccountPool = client.GetBatchAccountPoolResource(batchAccountPoolResourceId);

            // invoke the operation
            await batchAccountPool.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPool()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/PoolGet.json
            // this example is just showing the usage of "Pool_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountPoolResource created on azure
            // for more information of creating BatchAccountPoolResource, please refer to the document of BatchAccountPoolResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string poolName = "testpool";
            ResourceIdentifier batchAccountPoolResourceId = BatchAccountPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            BatchAccountPoolResource batchAccountPool = client.GetBatchAccountPoolResource(batchAccountPoolResourceId);

            // invoke the operation
            BatchAccountPoolResource result = await batchAccountPool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchAccountPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPoolAcceleratedNetworking()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/PoolGet_AcceleratedNetworking.json
            // this example is just showing the usage of "Pool_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountPoolResource created on azure
            // for more information of creating BatchAccountPoolResource, please refer to the document of BatchAccountPoolResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string poolName = "testpool";
            ResourceIdentifier batchAccountPoolResourceId = BatchAccountPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            BatchAccountPoolResource batchAccountPool = client.GetBatchAccountPoolResource(batchAccountPoolResourceId);

            // invoke the operation
            BatchAccountPoolResource result = await batchAccountPool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchAccountPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPoolSecurityProfile()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/PoolGet_SecurityProfile.json
            // this example is just showing the usage of "Pool_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountPoolResource created on azure
            // for more information of creating BatchAccountPoolResource, please refer to the document of BatchAccountPoolResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string poolName = "testpool";
            ResourceIdentifier batchAccountPoolResourceId = BatchAccountPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            BatchAccountPoolResource batchAccountPool = client.GetBatchAccountPoolResource(batchAccountPoolResourceId);

            // invoke the operation
            BatchAccountPoolResource result = await batchAccountPool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchAccountPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPoolUpgradePolicy()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/PoolGet_UpgradePolicy.json
            // this example is just showing the usage of "Pool_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountPoolResource created on azure
            // for more information of creating BatchAccountPoolResource, please refer to the document of BatchAccountPoolResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string poolName = "testpool";
            ResourceIdentifier batchAccountPoolResourceId = BatchAccountPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            BatchAccountPoolResource batchAccountPool = client.GetBatchAccountPoolResource(batchAccountPoolResourceId);

            // invoke the operation
            BatchAccountPoolResource result = await batchAccountPool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchAccountPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPoolVirtualMachineConfigurationExtensions()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/PoolGet_VirtualMachineConfiguration_Extensions.json
            // this example is just showing the usage of "Pool_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountPoolResource created on azure
            // for more information of creating BatchAccountPoolResource, please refer to the document of BatchAccountPoolResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string poolName = "testpool";
            ResourceIdentifier batchAccountPoolResourceId = BatchAccountPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            BatchAccountPoolResource batchAccountPool = client.GetBatchAccountPoolResource(batchAccountPoolResourceId);

            // invoke the operation
            BatchAccountPoolResource result = await batchAccountPool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchAccountPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPoolVirtualMachineConfigurationOSDisk()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/PoolGet_VirtualMachineConfiguration_MangedOSDisk.json
            // this example is just showing the usage of "Pool_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountPoolResource created on azure
            // for more information of creating BatchAccountPoolResource, please refer to the document of BatchAccountPoolResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string poolName = "testpool";
            ResourceIdentifier batchAccountPoolResourceId = BatchAccountPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            BatchAccountPoolResource batchAccountPool = client.GetBatchAccountPoolResource(batchAccountPoolResourceId);

            // invoke the operation
            BatchAccountPoolResource result = await batchAccountPool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchAccountPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPoolVirtualMachineConfigurationServiceArtifactReference()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/PoolGet_VirtualMachineConfiguration_ServiceArtifactReference.json
            // this example is just showing the usage of "Pool_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountPoolResource created on azure
            // for more information of creating BatchAccountPoolResource, please refer to the document of BatchAccountPoolResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string poolName = "testpool";
            ResourceIdentifier batchAccountPoolResourceId = BatchAccountPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            BatchAccountPoolResource batchAccountPool = client.GetBatchAccountPoolResource(batchAccountPoolResourceId);

            // invoke the operation
            BatchAccountPoolResource result = await batchAccountPool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchAccountPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task DisableAutoScale_DisableAutoScale()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/PoolDisableAutoScale.json
            // this example is just showing the usage of "Pool_DisableAutoScale" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountPoolResource created on azure
            // for more information of creating BatchAccountPoolResource, please refer to the document of BatchAccountPoolResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string poolName = "testpool";
            ResourceIdentifier batchAccountPoolResourceId = BatchAccountPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            BatchAccountPoolResource batchAccountPool = client.GetBatchAccountPoolResource(batchAccountPoolResourceId);

            // invoke the operation
            BatchAccountPoolResource result = await batchAccountPool.DisableAutoScaleAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchAccountPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task StopResize_StopPoolResize()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/PoolStopResize.json
            // this example is just showing the usage of "Pool_StopResize" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchAccountPoolResource created on azure
            // for more information of creating BatchAccountPoolResource, please refer to the document of BatchAccountPoolResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string poolName = "testpool";
            ResourceIdentifier batchAccountPoolResourceId = BatchAccountPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            BatchAccountPoolResource batchAccountPool = client.GetBatchAccountPoolResource(batchAccountPoolResourceId);

            // invoke the operation
            BatchAccountPoolResource result = await batchAccountPool.StopResizeAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchAccountPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
