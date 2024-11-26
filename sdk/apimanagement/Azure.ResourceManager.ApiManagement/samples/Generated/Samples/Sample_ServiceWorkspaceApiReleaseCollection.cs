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
    public partial class Sample_ServiceWorkspaceApiReleaseCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ApiManagementListWorkspaceApiReleases()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementListWorkspaceApiReleases.json
            // this example is just showing the usage of "WorkspaceApiRelease_ListByService" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceApiResource created on azure
            // for more information of creating ServiceWorkspaceApiResource, please refer to the document of ServiceWorkspaceApiResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string apiId = "a1";
            ResourceIdentifier serviceWorkspaceApiResourceId = ServiceWorkspaceApiResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, apiId);
            ServiceWorkspaceApiResource serviceWorkspaceApi = client.GetServiceWorkspaceApiResource(serviceWorkspaceApiResourceId);

            // get the collection of this ServiceWorkspaceApiReleaseResource
            ServiceWorkspaceApiReleaseCollection collection = serviceWorkspaceApi.GetServiceWorkspaceApiReleases();

            // invoke the operation and iterate over the result
            await foreach (ServiceWorkspaceApiReleaseResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApiReleaseData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetWorkspaceApiRelease()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetWorkspaceApiRelease.json
            // this example is just showing the usage of "WorkspaceApiRelease_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceApiResource created on azure
            // for more information of creating ServiceWorkspaceApiResource, please refer to the document of ServiceWorkspaceApiResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string apiId = "a1";
            ResourceIdentifier serviceWorkspaceApiResourceId = ServiceWorkspaceApiResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, apiId);
            ServiceWorkspaceApiResource serviceWorkspaceApi = client.GetServiceWorkspaceApiResource(serviceWorkspaceApiResourceId);

            // get the collection of this ServiceWorkspaceApiReleaseResource
            ServiceWorkspaceApiReleaseCollection collection = serviceWorkspaceApi.GetServiceWorkspaceApiReleases();

            // invoke the operation
            string releaseId = "5a7cb545298324c53224a799";
            ServiceWorkspaceApiReleaseResource result = await collection.GetAsync(releaseId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiReleaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ApiManagementGetWorkspaceApiRelease()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetWorkspaceApiRelease.json
            // this example is just showing the usage of "WorkspaceApiRelease_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceApiResource created on azure
            // for more information of creating ServiceWorkspaceApiResource, please refer to the document of ServiceWorkspaceApiResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string apiId = "a1";
            ResourceIdentifier serviceWorkspaceApiResourceId = ServiceWorkspaceApiResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, apiId);
            ServiceWorkspaceApiResource serviceWorkspaceApi = client.GetServiceWorkspaceApiResource(serviceWorkspaceApiResourceId);

            // get the collection of this ServiceWorkspaceApiReleaseResource
            ServiceWorkspaceApiReleaseCollection collection = serviceWorkspaceApi.GetServiceWorkspaceApiReleases();

            // invoke the operation
            string releaseId = "5a7cb545298324c53224a799";
            bool result = await collection.ExistsAsync(releaseId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ApiManagementGetWorkspaceApiRelease()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetWorkspaceApiRelease.json
            // this example is just showing the usage of "WorkspaceApiRelease_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceApiResource created on azure
            // for more information of creating ServiceWorkspaceApiResource, please refer to the document of ServiceWorkspaceApiResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string apiId = "a1";
            ResourceIdentifier serviceWorkspaceApiResourceId = ServiceWorkspaceApiResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, apiId);
            ServiceWorkspaceApiResource serviceWorkspaceApi = client.GetServiceWorkspaceApiResource(serviceWorkspaceApiResourceId);

            // get the collection of this ServiceWorkspaceApiReleaseResource
            ServiceWorkspaceApiReleaseCollection collection = serviceWorkspaceApi.GetServiceWorkspaceApiReleases();

            // invoke the operation
            string releaseId = "5a7cb545298324c53224a799";
            NullableResponse<ServiceWorkspaceApiReleaseResource> response = await collection.GetIfExistsAsync(releaseId);
            ServiceWorkspaceApiReleaseResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApiReleaseData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ApiManagementCreateWorkspaceApiRelease()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateWorkspaceApiRelease.json
            // this example is just showing the usage of "WorkspaceApiRelease_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceApiResource created on azure
            // for more information of creating ServiceWorkspaceApiResource, please refer to the document of ServiceWorkspaceApiResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string apiId = "a1";
            ResourceIdentifier serviceWorkspaceApiResourceId = ServiceWorkspaceApiResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, apiId);
            ServiceWorkspaceApiResource serviceWorkspaceApi = client.GetServiceWorkspaceApiResource(serviceWorkspaceApiResourceId);

            // get the collection of this ServiceWorkspaceApiReleaseResource
            ServiceWorkspaceApiReleaseCollection collection = serviceWorkspaceApi.GetServiceWorkspaceApiReleases();

            // invoke the operation
            string releaseId = "testrev";
            ApiReleaseData data = new ApiReleaseData()
            {
                ApiId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.ApiManagement/service/apimService1/workspaces/wks1/apis/a1"),
                Notes = "yahooagain",
            };
            ArmOperation<ServiceWorkspaceApiReleaseResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, releaseId, data);
            ServiceWorkspaceApiReleaseResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiReleaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
