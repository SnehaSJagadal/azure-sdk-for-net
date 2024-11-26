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
    public partial class Sample_ServiceWorkspaceTagApiLinkCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ApiManagementListWorkspaceTagApiLinks()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementListWorkspaceTagApiLinks.json
            // this example is just showing the usage of "WorkspaceTagApiLink_ListByProduct" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceTagResource created on azure
            // for more information of creating ServiceWorkspaceTagResource, please refer to the document of ServiceWorkspaceTagResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string tagId = "tag1";
            ResourceIdentifier serviceWorkspaceTagResourceId = ServiceWorkspaceTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, tagId);
            ServiceWorkspaceTagResource serviceWorkspaceTag = client.GetServiceWorkspaceTagResource(serviceWorkspaceTagResourceId);

            // get the collection of this ServiceWorkspaceTagApiLinkResource
            ServiceWorkspaceTagApiLinkCollection collection = serviceWorkspaceTag.GetServiceWorkspaceTagApiLinks();

            // invoke the operation and iterate over the result
            await foreach (ServiceWorkspaceTagApiLinkResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                TagApiLinkContractData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetWorkspaceTagApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetWorkspaceTagApiLink.json
            // this example is just showing the usage of "WorkspaceTagApiLink_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceTagResource created on azure
            // for more information of creating ServiceWorkspaceTagResource, please refer to the document of ServiceWorkspaceTagResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string tagId = "tag1";
            ResourceIdentifier serviceWorkspaceTagResourceId = ServiceWorkspaceTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, tagId);
            ServiceWorkspaceTagResource serviceWorkspaceTag = client.GetServiceWorkspaceTagResource(serviceWorkspaceTagResourceId);

            // get the collection of this ServiceWorkspaceTagApiLinkResource
            ServiceWorkspaceTagApiLinkCollection collection = serviceWorkspaceTag.GetServiceWorkspaceTagApiLinks();

            // invoke the operation
            string apiLinkId = "link1";
            ServiceWorkspaceTagApiLinkResource result = await collection.GetAsync(apiLinkId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagApiLinkContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ApiManagementGetWorkspaceTagApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetWorkspaceTagApiLink.json
            // this example is just showing the usage of "WorkspaceTagApiLink_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceTagResource created on azure
            // for more information of creating ServiceWorkspaceTagResource, please refer to the document of ServiceWorkspaceTagResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string tagId = "tag1";
            ResourceIdentifier serviceWorkspaceTagResourceId = ServiceWorkspaceTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, tagId);
            ServiceWorkspaceTagResource serviceWorkspaceTag = client.GetServiceWorkspaceTagResource(serviceWorkspaceTagResourceId);

            // get the collection of this ServiceWorkspaceTagApiLinkResource
            ServiceWorkspaceTagApiLinkCollection collection = serviceWorkspaceTag.GetServiceWorkspaceTagApiLinks();

            // invoke the operation
            string apiLinkId = "link1";
            bool result = await collection.ExistsAsync(apiLinkId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ApiManagementGetWorkspaceTagApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetWorkspaceTagApiLink.json
            // this example is just showing the usage of "WorkspaceTagApiLink_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceTagResource created on azure
            // for more information of creating ServiceWorkspaceTagResource, please refer to the document of ServiceWorkspaceTagResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string tagId = "tag1";
            ResourceIdentifier serviceWorkspaceTagResourceId = ServiceWorkspaceTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, tagId);
            ServiceWorkspaceTagResource serviceWorkspaceTag = client.GetServiceWorkspaceTagResource(serviceWorkspaceTagResourceId);

            // get the collection of this ServiceWorkspaceTagApiLinkResource
            ServiceWorkspaceTagApiLinkCollection collection = serviceWorkspaceTag.GetServiceWorkspaceTagApiLinks();

            // invoke the operation
            string apiLinkId = "link1";
            NullableResponse<ServiceWorkspaceTagApiLinkResource> response = await collection.GetIfExistsAsync(apiLinkId);
            ServiceWorkspaceTagApiLinkResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                TagApiLinkContractData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ApiManagementCreateWorkspaceTagApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateWorkspaceTagApiLink.json
            // this example is just showing the usage of "WorkspaceTagApiLink_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceTagResource created on azure
            // for more information of creating ServiceWorkspaceTagResource, please refer to the document of ServiceWorkspaceTagResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string tagId = "tag1";
            ResourceIdentifier serviceWorkspaceTagResourceId = ServiceWorkspaceTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, tagId);
            ServiceWorkspaceTagResource serviceWorkspaceTag = client.GetServiceWorkspaceTagResource(serviceWorkspaceTagResourceId);

            // get the collection of this ServiceWorkspaceTagApiLinkResource
            ServiceWorkspaceTagApiLinkCollection collection = serviceWorkspaceTag.GetServiceWorkspaceTagApiLinks();

            // invoke the operation
            string apiLinkId = "link1";
            TagApiLinkContractData data = new TagApiLinkContractData()
            {
                ApiId = "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.ApiManagement/service/apimService1/workspaces/wks1/apis/echo-api",
            };
            ArmOperation<ServiceWorkspaceTagApiLinkResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, apiLinkId, data);
            ServiceWorkspaceTagApiLinkResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagApiLinkContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
