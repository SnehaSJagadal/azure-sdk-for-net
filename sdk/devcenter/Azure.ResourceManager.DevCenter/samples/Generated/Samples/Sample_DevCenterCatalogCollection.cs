// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DevCenter.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.DevCenter.Samples
{
    public partial class Sample_DevCenterCatalogCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CatalogsCreateOrUpdateAdo()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/Catalogs_CreateAdo.json
            // this example is just showing the usage of "Catalogs_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterResource created on azure
            // for more information of creating DevCenterResource, please refer to the document of DevCenterResource
            string subscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c58ffff";
            string resourceGroupName = "rg1";
            string devCenterName = "Contoso";
            ResourceIdentifier devCenterResourceId = DevCenterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, devCenterName);
            DevCenterResource devCenter = client.GetDevCenterResource(devCenterResourceId);

            // get the collection of this DevCenterCatalogResource
            DevCenterCatalogCollection collection = devCenter.GetDevCenterCatalogs();

            // invoke the operation
            string catalogName = "CentralCatalog";
            DevCenterCatalogData data = new DevCenterCatalogData
            {
                AdoGit = new DevCenterGitCatalog
                {
                    Uri = new Uri("https://contoso@dev.azure.com/contoso/contosoOrg/_git/centralrepo-fakecontoso"),
                    Branch = "main",
                    SecretIdentifier = "https://contosokv.vault.azure.net/secrets/CentralRepoPat",
                    Path = "/templates",
                },
            };
            ArmOperation<DevCenterCatalogResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, catalogName, data);
            DevCenterCatalogResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevCenterCatalogData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CatalogsCreateOrUpdateGitHub()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/Catalogs_CreateGitHub.json
            // this example is just showing the usage of "Catalogs_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterResource created on azure
            // for more information of creating DevCenterResource, please refer to the document of DevCenterResource
            string subscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c58ffff";
            string resourceGroupName = "rg1";
            string devCenterName = "Contoso";
            ResourceIdentifier devCenterResourceId = DevCenterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, devCenterName);
            DevCenterResource devCenter = client.GetDevCenterResource(devCenterResourceId);

            // get the collection of this DevCenterCatalogResource
            DevCenterCatalogCollection collection = devCenter.GetDevCenterCatalogs();

            // invoke the operation
            string catalogName = "CentralCatalog";
            DevCenterCatalogData data = new DevCenterCatalogData
            {
                GitHub = new DevCenterGitCatalog
                {
                    Uri = new Uri("https://github.com/Contoso/centralrepo-fake.git"),
                    Branch = "main",
                    SecretIdentifier = "https://contosokv.vault.azure.net/secrets/CentralRepoPat",
                    Path = "/templates",
                },
            };
            ArmOperation<DevCenterCatalogResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, catalogName, data);
            DevCenterCatalogResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevCenterCatalogData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_CatalogsGet()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/Catalogs_Get.json
            // this example is just showing the usage of "Catalogs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterResource created on azure
            // for more information of creating DevCenterResource, please refer to the document of DevCenterResource
            string subscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c58ffff";
            string resourceGroupName = "rg1";
            string devCenterName = "Contoso";
            ResourceIdentifier devCenterResourceId = DevCenterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, devCenterName);
            DevCenterResource devCenter = client.GetDevCenterResource(devCenterResourceId);

            // get the collection of this DevCenterCatalogResource
            DevCenterCatalogCollection collection = devCenter.GetDevCenterCatalogs();

            // invoke the operation
            string catalogName = "CentralCatalog";
            DevCenterCatalogResource result = await collection.GetAsync(catalogName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevCenterCatalogData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_CatalogsListByDevCenter()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/Catalogs_List.json
            // this example is just showing the usage of "Catalogs_ListByDevCenter" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterResource created on azure
            // for more information of creating DevCenterResource, please refer to the document of DevCenterResource
            string subscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c58ffff";
            string resourceGroupName = "rg1";
            string devCenterName = "Contoso";
            ResourceIdentifier devCenterResourceId = DevCenterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, devCenterName);
            DevCenterResource devCenter = client.GetDevCenterResource(devCenterResourceId);

            // get the collection of this DevCenterCatalogResource
            DevCenterCatalogCollection collection = devCenter.GetDevCenterCatalogs();

            // invoke the operation and iterate over the result
            await foreach (DevCenterCatalogResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DevCenterCatalogData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_CatalogsGet()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/Catalogs_Get.json
            // this example is just showing the usage of "Catalogs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterResource created on azure
            // for more information of creating DevCenterResource, please refer to the document of DevCenterResource
            string subscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c58ffff";
            string resourceGroupName = "rg1";
            string devCenterName = "Contoso";
            ResourceIdentifier devCenterResourceId = DevCenterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, devCenterName);
            DevCenterResource devCenter = client.GetDevCenterResource(devCenterResourceId);

            // get the collection of this DevCenterCatalogResource
            DevCenterCatalogCollection collection = devCenter.GetDevCenterCatalogs();

            // invoke the operation
            string catalogName = "CentralCatalog";
            bool result = await collection.ExistsAsync(catalogName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_CatalogsGet()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/Catalogs_Get.json
            // this example is just showing the usage of "Catalogs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterResource created on azure
            // for more information of creating DevCenterResource, please refer to the document of DevCenterResource
            string subscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c58ffff";
            string resourceGroupName = "rg1";
            string devCenterName = "Contoso";
            ResourceIdentifier devCenterResourceId = DevCenterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, devCenterName);
            DevCenterResource devCenter = client.GetDevCenterResource(devCenterResourceId);

            // get the collection of this DevCenterCatalogResource
            DevCenterCatalogCollection collection = devCenter.GetDevCenterCatalogs();

            // invoke the operation
            string catalogName = "CentralCatalog";
            NullableResponse<DevCenterCatalogResource> response = await collection.GetIfExistsAsync(catalogName);
            DevCenterCatalogResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DevCenterCatalogData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
