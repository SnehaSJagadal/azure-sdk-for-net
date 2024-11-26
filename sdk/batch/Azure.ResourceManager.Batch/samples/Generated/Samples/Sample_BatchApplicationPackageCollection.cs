// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Batch.Samples
{
    public partial class Sample_BatchApplicationPackageCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ApplicationPackageCreate()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/ApplicationPackageCreate.json
            // this example is just showing the usage of "ApplicationPackage_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchApplicationResource created on azure
            // for more information of creating BatchApplicationResource, please refer to the document of BatchApplicationResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string applicationName = "app1";
            ResourceIdentifier batchApplicationResourceId = BatchApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, applicationName);
            BatchApplicationResource batchApplication = client.GetBatchApplicationResource(batchApplicationResourceId);

            // get the collection of this BatchApplicationPackageResource
            BatchApplicationPackageCollection collection = batchApplication.GetBatchApplicationPackages();

            // invoke the operation
            string versionName = "1";
            BatchApplicationPackageData data = new BatchApplicationPackageData();
            ArmOperation<BatchApplicationPackageResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, versionName, data);
            BatchApplicationPackageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchApplicationPackageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApplicationPackageGet()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/ApplicationPackageGet.json
            // this example is just showing the usage of "ApplicationPackage_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchApplicationResource created on azure
            // for more information of creating BatchApplicationResource, please refer to the document of BatchApplicationResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string applicationName = "app1";
            ResourceIdentifier batchApplicationResourceId = BatchApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, applicationName);
            BatchApplicationResource batchApplication = client.GetBatchApplicationResource(batchApplicationResourceId);

            // get the collection of this BatchApplicationPackageResource
            BatchApplicationPackageCollection collection = batchApplication.GetBatchApplicationPackages();

            // invoke the operation
            string versionName = "1";
            BatchApplicationPackageResource result = await collection.GetAsync(versionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BatchApplicationPackageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ApplicationPackageGet()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/ApplicationPackageGet.json
            // this example is just showing the usage of "ApplicationPackage_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchApplicationResource created on azure
            // for more information of creating BatchApplicationResource, please refer to the document of BatchApplicationResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string applicationName = "app1";
            ResourceIdentifier batchApplicationResourceId = BatchApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, applicationName);
            BatchApplicationResource batchApplication = client.GetBatchApplicationResource(batchApplicationResourceId);

            // get the collection of this BatchApplicationPackageResource
            BatchApplicationPackageCollection collection = batchApplication.GetBatchApplicationPackages();

            // invoke the operation
            string versionName = "1";
            bool result = await collection.ExistsAsync(versionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ApplicationPackageGet()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/ApplicationPackageGet.json
            // this example is just showing the usage of "ApplicationPackage_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchApplicationResource created on azure
            // for more information of creating BatchApplicationResource, please refer to the document of BatchApplicationResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string applicationName = "app1";
            ResourceIdentifier batchApplicationResourceId = BatchApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, applicationName);
            BatchApplicationResource batchApplication = client.GetBatchApplicationResource(batchApplicationResourceId);

            // get the collection of this BatchApplicationPackageResource
            BatchApplicationPackageCollection collection = batchApplication.GetBatchApplicationPackages();

            // invoke the operation
            string versionName = "1";
            NullableResponse<BatchApplicationPackageResource> response = await collection.GetIfExistsAsync(versionName);
            BatchApplicationPackageResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BatchApplicationPackageData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ApplicationPackageList()
        {
            // Generated from example definition: specification/batch/resource-manager/Microsoft.Batch/stable/2024-07-01/examples/ApplicationPackageList.json
            // this example is just showing the usage of "ApplicationPackage_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BatchApplicationResource created on azure
            // for more information of creating BatchApplicationResource, please refer to the document of BatchApplicationResource
            string subscriptionId = "subid";
            string resourceGroupName = "default-azurebatch-japaneast";
            string accountName = "sampleacct";
            string applicationName = "app1";
            ResourceIdentifier batchApplicationResourceId = BatchApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, applicationName);
            BatchApplicationResource batchApplication = client.GetBatchApplicationResource(batchApplicationResourceId);

            // get the collection of this BatchApplicationPackageResource
            BatchApplicationPackageCollection collection = batchApplication.GetBatchApplicationPackages();

            // invoke the operation and iterate over the result
            await foreach (BatchApplicationPackageResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BatchApplicationPackageData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
