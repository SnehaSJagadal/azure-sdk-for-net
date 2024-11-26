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
    public partial class Sample_ServiceWorkspaceApiOperationResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetEntityTag_ApiManagementHeadWorkspaceApiOperation()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementHeadWorkspaceApiOperation.json
            // this example is just showing the usage of "WorkspaceApiOperation_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceApiOperationResource created on azure
            // for more information of creating ServiceWorkspaceApiOperationResource, please refer to the document of ServiceWorkspaceApiOperationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string apiId = "57d2ef278aa04f0888cba3f3";
            string operationId = "57d2ef278aa04f0ad01d6cdc";
            ResourceIdentifier serviceWorkspaceApiOperationResourceId = ServiceWorkspaceApiOperationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, apiId, operationId);
            ServiceWorkspaceApiOperationResource serviceWorkspaceApiOperation = client.GetServiceWorkspaceApiOperationResource(serviceWorkspaceApiOperationResourceId);

            // invoke the operation
            bool result = await serviceWorkspaceApiOperation.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetWorkspaceApiOperation()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetWorkspaceApiOperation.json
            // this example is just showing the usage of "WorkspaceApiOperation_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceApiOperationResource created on azure
            // for more information of creating ServiceWorkspaceApiOperationResource, please refer to the document of ServiceWorkspaceApiOperationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string apiId = "57d2ef278aa04f0888cba3f3";
            string operationId = "57d2ef278aa04f0ad01d6cdc";
            ResourceIdentifier serviceWorkspaceApiOperationResourceId = ServiceWorkspaceApiOperationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, apiId, operationId);
            ServiceWorkspaceApiOperationResource serviceWorkspaceApiOperation = client.GetServiceWorkspaceApiOperationResource(serviceWorkspaceApiOperationResourceId);

            // invoke the operation
            ServiceWorkspaceApiOperationResource result = await serviceWorkspaceApiOperation.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiOperationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementUpdateWorkspaceApiOperation()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementUpdateWorkspaceApiOperation.json
            // this example is just showing the usage of "WorkspaceApiOperation_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceApiOperationResource created on azure
            // for more information of creating ServiceWorkspaceApiOperationResource, please refer to the document of ServiceWorkspaceApiOperationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string apiId = "echo-api";
            string operationId = "operationId";
            ResourceIdentifier serviceWorkspaceApiOperationResourceId = ServiceWorkspaceApiOperationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, apiId, operationId);
            ServiceWorkspaceApiOperationResource serviceWorkspaceApiOperation = client.GetServiceWorkspaceApiOperationResource(serviceWorkspaceApiOperationResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            ApiOperationPatch patch = new ApiOperationPatch()
            {
                TemplateParameters =
{
},
                Request = new RequestContract()
                {
                    QueryParameters =
{
new ParameterContract("param1","string")
{
Description = "A sample parameter that is required and has a default value of \"sample\".",
DefaultValue = "sample",
IsRequired = true,
Values =
{
"sample"
},
}
},
                },
                Responses =
{
new ResponseContract(200)
{
Description = "Returned in all cases.",
Representations =
{
},
Headers =
{
},
},new ResponseContract(500)
{
Description = "Server Error.",
Representations =
{
},
Headers =
{
},
}
},
                DisplayName = "Retrieve resource",
                Method = "GET",
                UriTemplate = "/resource",
            };
            ServiceWorkspaceApiOperationResource result = await serviceWorkspaceApiOperation.UpdateAsync(ifMatch, patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiOperationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ApiManagementDeleteWorkspaceApiOperation()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementDeleteWorkspaceApiOperation.json
            // this example is just showing the usage of "WorkspaceApiOperation_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceApiOperationResource created on azure
            // for more information of creating ServiceWorkspaceApiOperationResource, please refer to the document of ServiceWorkspaceApiOperationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string apiId = "57d2ef278aa04f0888cba3f3";
            string operationId = "57d2ef278aa04f0ad01d6cdc";
            ResourceIdentifier serviceWorkspaceApiOperationResourceId = ServiceWorkspaceApiOperationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, apiId, operationId);
            ServiceWorkspaceApiOperationResource serviceWorkspaceApiOperation = client.GetServiceWorkspaceApiOperationResource(serviceWorkspaceApiOperationResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await serviceWorkspaceApiOperation.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine("Succeeded");
        }
    }
}
