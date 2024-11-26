// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ServiceWorkspaceTagResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetEntityState_ApiManagementHeadWorkspaceTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementHeadWorkspaceTag.json
            // this example is just showing the usage of "WorkspaceTag_GetEntityState" operation, for the dependent resources, they will have to be created separately.

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
            string tagId = "59306a29e4bbd510dc24e5f9";
            ResourceIdentifier serviceWorkspaceTagResourceId = ServiceWorkspaceTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, tagId);
            ServiceWorkspaceTagResource serviceWorkspaceTag = client.GetServiceWorkspaceTagResource(serviceWorkspaceTagResourceId);

            // invoke the operation
            bool result = await serviceWorkspaceTag.GetEntityStateAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetWorkspaceTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetWorkspaceTag.json
            // this example is just showing the usage of "WorkspaceTag_Get" operation, for the dependent resources, they will have to be created separately.

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
            string tagId = "59306a29e4bbd510dc24e5f9";
            ResourceIdentifier serviceWorkspaceTagResourceId = ServiceWorkspaceTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, tagId);
            ServiceWorkspaceTagResource serviceWorkspaceTag = client.GetServiceWorkspaceTagResource(serviceWorkspaceTagResourceId);

            // invoke the operation
            ServiceWorkspaceTagResource result = await serviceWorkspaceTag.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementUpdateWorkspaceTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementUpdateWorkspaceTag.json
            // this example is just showing the usage of "WorkspaceTag_Update" operation, for the dependent resources, they will have to be created separately.

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
            string tagId = "temptag";
            ResourceIdentifier serviceWorkspaceTagResourceId = ServiceWorkspaceTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, tagId);
            ServiceWorkspaceTagResource serviceWorkspaceTag = client.GetServiceWorkspaceTagResource(serviceWorkspaceTagResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            ApiManagementTagCreateOrUpdateContent content = new ApiManagementTagCreateOrUpdateContent()
            {
                DisplayName = "temp tag",
            };
            ServiceWorkspaceTagResource result = await serviceWorkspaceTag.UpdateAsync(ifMatch, content);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ApiManagementDeleteWorkspaceTag()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementDeleteWorkspaceTag.json
            // this example is just showing the usage of "WorkspaceTag_Delete" operation, for the dependent resources, they will have to be created separately.

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
            string tagId = "tagId1";
            ResourceIdentifier serviceWorkspaceTagResourceId = ServiceWorkspaceTagResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, tagId);
            ServiceWorkspaceTagResource serviceWorkspaceTag = client.GetServiceWorkspaceTagResource(serviceWorkspaceTagResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await serviceWorkspaceTag.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine("Succeeded");
        }
    }
}
