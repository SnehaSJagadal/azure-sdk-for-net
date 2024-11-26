// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ServiceWorkspaceProductApiLinkCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ApiManagementListWorkspaceProductApiLinks()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementListWorkspaceProductApiLinks.json
            // this example is just showing the usage of "WorkspaceProductApiLink_ListByProduct" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceProductResource created on azure
            // for more information of creating ServiceWorkspaceProductResource, please refer to the document of ServiceWorkspaceProductResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string productId = "product1";
            ResourceIdentifier serviceWorkspaceProductResourceId = ServiceWorkspaceProductResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, productId);
            ServiceWorkspaceProductResource serviceWorkspaceProduct = client.GetServiceWorkspaceProductResource(serviceWorkspaceProductResourceId);

            // get the collection of this ServiceWorkspaceProductApiLinkResource
            ServiceWorkspaceProductApiLinkCollection collection = serviceWorkspaceProduct.GetServiceWorkspaceProductApiLinks();

            // invoke the operation and iterate over the result
            await foreach (ServiceWorkspaceProductApiLinkResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ProductApiLinkContractData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetWorkspaceProductApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetWorkspaceProductApiLink.json
            // this example is just showing the usage of "WorkspaceProductApiLink_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceProductResource created on azure
            // for more information of creating ServiceWorkspaceProductResource, please refer to the document of ServiceWorkspaceProductResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string productId = "testproduct";
            ResourceIdentifier serviceWorkspaceProductResourceId = ServiceWorkspaceProductResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, productId);
            ServiceWorkspaceProductResource serviceWorkspaceProduct = client.GetServiceWorkspaceProductResource(serviceWorkspaceProductResourceId);

            // get the collection of this ServiceWorkspaceProductApiLinkResource
            ServiceWorkspaceProductApiLinkCollection collection = serviceWorkspaceProduct.GetServiceWorkspaceProductApiLinks();

            // invoke the operation
            string apiLinkId = "link1";
            ServiceWorkspaceProductApiLinkResource result = await collection.GetAsync(apiLinkId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProductApiLinkContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ApiManagementGetWorkspaceProductApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetWorkspaceProductApiLink.json
            // this example is just showing the usage of "WorkspaceProductApiLink_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceProductResource created on azure
            // for more information of creating ServiceWorkspaceProductResource, please refer to the document of ServiceWorkspaceProductResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string productId = "testproduct";
            ResourceIdentifier serviceWorkspaceProductResourceId = ServiceWorkspaceProductResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, productId);
            ServiceWorkspaceProductResource serviceWorkspaceProduct = client.GetServiceWorkspaceProductResource(serviceWorkspaceProductResourceId);

            // get the collection of this ServiceWorkspaceProductApiLinkResource
            ServiceWorkspaceProductApiLinkCollection collection = serviceWorkspaceProduct.GetServiceWorkspaceProductApiLinks();

            // invoke the operation
            string apiLinkId = "link1";
            bool result = await collection.ExistsAsync(apiLinkId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ApiManagementGetWorkspaceProductApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetWorkspaceProductApiLink.json
            // this example is just showing the usage of "WorkspaceProductApiLink_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceProductResource created on azure
            // for more information of creating ServiceWorkspaceProductResource, please refer to the document of ServiceWorkspaceProductResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string productId = "testproduct";
            ResourceIdentifier serviceWorkspaceProductResourceId = ServiceWorkspaceProductResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, productId);
            ServiceWorkspaceProductResource serviceWorkspaceProduct = client.GetServiceWorkspaceProductResource(serviceWorkspaceProductResourceId);

            // get the collection of this ServiceWorkspaceProductApiLinkResource
            ServiceWorkspaceProductApiLinkCollection collection = serviceWorkspaceProduct.GetServiceWorkspaceProductApiLinks();

            // invoke the operation
            string apiLinkId = "link1";
            NullableResponse<ServiceWorkspaceProductApiLinkResource> response = await collection.GetIfExistsAsync(apiLinkId);
            ServiceWorkspaceProductApiLinkResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ProductApiLinkContractData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ApiManagementCreateWorkspaceProductApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateWorkspaceProductApiLink.json
            // this example is just showing the usage of "WorkspaceProductApiLink_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceProductResource created on azure
            // for more information of creating ServiceWorkspaceProductResource, please refer to the document of ServiceWorkspaceProductResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string productId = "testproduct";
            ResourceIdentifier serviceWorkspaceProductResourceId = ServiceWorkspaceProductResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, productId);
            ServiceWorkspaceProductResource serviceWorkspaceProduct = client.GetServiceWorkspaceProductResource(serviceWorkspaceProductResourceId);

            // get the collection of this ServiceWorkspaceProductApiLinkResource
            ServiceWorkspaceProductApiLinkCollection collection = serviceWorkspaceProduct.GetServiceWorkspaceProductApiLinks();

            // invoke the operation
            string apiLinkId = "link1";
            ProductApiLinkContractData data = new ProductApiLinkContractData()
            {
                ApiId = "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.ApiManagement/service/apimService1/workspaces/wks1/apis/echo-api",
            };
            ArmOperation<ServiceWorkspaceProductApiLinkResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, apiLinkId, data);
            ServiceWorkspaceProductApiLinkResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProductApiLinkContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
