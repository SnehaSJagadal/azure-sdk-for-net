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
    public partial class Sample_ApiIssueAttachmentResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetEntityTag_ApiManagementHeadApiIssueAttachment()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementHeadApiIssueAttachment.json
            // this example is just showing the usage of "ApiIssueAttachment_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiIssueAttachmentResource created on azure
            // for more information of creating ApiIssueAttachmentResource, please refer to the document of ApiIssueAttachmentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "57d2ef278aa04f0888cba3f3";
            string issueId = "57d2ef278aa04f0ad01d6cdc";
            string attachmentId = "57d2ef278aa04f0888cba3f3";
            ResourceIdentifier apiIssueAttachmentResourceId = ApiIssueAttachmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, issueId, attachmentId);
            ApiIssueAttachmentResource apiIssueAttachment = client.GetApiIssueAttachmentResource(apiIssueAttachmentResourceId);

            // invoke the operation
            bool result = await apiIssueAttachment.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetApiIssueAttachment()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetApiIssueAttachment.json
            // this example is just showing the usage of "ApiIssueAttachment_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiIssueAttachmentResource created on azure
            // for more information of creating ApiIssueAttachmentResource, please refer to the document of ApiIssueAttachmentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "57d2ef278aa04f0888cba3f3";
            string issueId = "57d2ef278aa04f0ad01d6cdc";
            string attachmentId = "57d2ef278aa04f0888cba3f3";
            ResourceIdentifier apiIssueAttachmentResourceId = ApiIssueAttachmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, issueId, attachmentId);
            ApiIssueAttachmentResource apiIssueAttachment = client.GetApiIssueAttachmentResource(apiIssueAttachmentResourceId);

            // invoke the operation
            ApiIssueAttachmentResource result = await apiIssueAttachment.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiIssueAttachmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementCreateApiIssueAttachment()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateApiIssueAttachment.json
            // this example is just showing the usage of "ApiIssueAttachment_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiIssueAttachmentResource created on azure
            // for more information of creating ApiIssueAttachmentResource, please refer to the document of ApiIssueAttachmentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "57d1f7558aa04f15146d9d8a";
            string issueId = "57d2ef278aa04f0ad01d6cdc";
            string attachmentId = "57d2ef278aa04f0888cba3f3";
            ResourceIdentifier apiIssueAttachmentResourceId = ApiIssueAttachmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, issueId, attachmentId);
            ApiIssueAttachmentResource apiIssueAttachment = client.GetApiIssueAttachmentResource(apiIssueAttachmentResourceId);

            // invoke the operation
            ApiIssueAttachmentData data = new ApiIssueAttachmentData()
            {
                Title = "Issue attachment.",
                ContentFormat = "image/jpeg",
                Content = "IEJhc2U2NA==",
            };
            ArmOperation<ApiIssueAttachmentResource> lro = await apiIssueAttachment.UpdateAsync(WaitUntil.Completed, data);
            ApiIssueAttachmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiIssueAttachmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ApiManagementDeleteApiIssueAttachment()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementDeleteApiIssueAttachment.json
            // this example is just showing the usage of "ApiIssueAttachment_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiIssueAttachmentResource created on azure
            // for more information of creating ApiIssueAttachmentResource, please refer to the document of ApiIssueAttachmentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "57d1f7558aa04f15146d9d8a";
            string issueId = "57d2ef278aa04f0ad01d6cdc";
            string attachmentId = "57d2ef278aa04f0888cba3f3";
            ResourceIdentifier apiIssueAttachmentResourceId = ApiIssueAttachmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, issueId, attachmentId);
            ApiIssueAttachmentResource apiIssueAttachment = client.GetApiIssueAttachmentResource(apiIssueAttachmentResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await apiIssueAttachment.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine("Succeeded");
        }
    }
}
