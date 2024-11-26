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
    public partial class Sample_AuthorizationAccessPolicyContractCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ApiManagementListAuthorizationAccessPolicies()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementListAuthorizationAccessPolicies.json
            // this example is just showing the usage of "AuthorizationAccessPolicy_ListByAuthorization" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AuthorizationContractResource created on azure
            // for more information of creating AuthorizationContractResource, please refer to the document of AuthorizationContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authorizationProviderId = "aadwithauthcode";
            string authorizationId = "authz1";
            ResourceIdentifier authorizationContractResourceId = AuthorizationContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authorizationProviderId, authorizationId);
            AuthorizationContractResource authorizationContract = client.GetAuthorizationContractResource(authorizationContractResourceId);

            // get the collection of this AuthorizationAccessPolicyContractResource
            AuthorizationAccessPolicyContractCollection collection = authorizationContract.GetAuthorizationAccessPolicyContracts();

            // invoke the operation and iterate over the result
            await foreach (AuthorizationAccessPolicyContractResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AuthorizationAccessPolicyContractData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetAuthorizationAccessPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetAuthorizationAccessPolicy.json
            // this example is just showing the usage of "AuthorizationAccessPolicy_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AuthorizationContractResource created on azure
            // for more information of creating AuthorizationContractResource, please refer to the document of AuthorizationContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authorizationProviderId = "aadwithauthcode";
            string authorizationId = "authz1";
            ResourceIdentifier authorizationContractResourceId = AuthorizationContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authorizationProviderId, authorizationId);
            AuthorizationContractResource authorizationContract = client.GetAuthorizationContractResource(authorizationContractResourceId);

            // get the collection of this AuthorizationAccessPolicyContractResource
            AuthorizationAccessPolicyContractCollection collection = authorizationContract.GetAuthorizationAccessPolicyContracts();

            // invoke the operation
            string authorizationAccessPolicyId = "fe0bed83-631f-4149-bd0b-0464b1bc7cab";
            AuthorizationAccessPolicyContractResource result = await collection.GetAsync(authorizationAccessPolicyId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AuthorizationAccessPolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ApiManagementGetAuthorizationAccessPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetAuthorizationAccessPolicy.json
            // this example is just showing the usage of "AuthorizationAccessPolicy_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AuthorizationContractResource created on azure
            // for more information of creating AuthorizationContractResource, please refer to the document of AuthorizationContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authorizationProviderId = "aadwithauthcode";
            string authorizationId = "authz1";
            ResourceIdentifier authorizationContractResourceId = AuthorizationContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authorizationProviderId, authorizationId);
            AuthorizationContractResource authorizationContract = client.GetAuthorizationContractResource(authorizationContractResourceId);

            // get the collection of this AuthorizationAccessPolicyContractResource
            AuthorizationAccessPolicyContractCollection collection = authorizationContract.GetAuthorizationAccessPolicyContracts();

            // invoke the operation
            string authorizationAccessPolicyId = "fe0bed83-631f-4149-bd0b-0464b1bc7cab";
            bool result = await collection.ExistsAsync(authorizationAccessPolicyId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ApiManagementGetAuthorizationAccessPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetAuthorizationAccessPolicy.json
            // this example is just showing the usage of "AuthorizationAccessPolicy_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AuthorizationContractResource created on azure
            // for more information of creating AuthorizationContractResource, please refer to the document of AuthorizationContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authorizationProviderId = "aadwithauthcode";
            string authorizationId = "authz1";
            ResourceIdentifier authorizationContractResourceId = AuthorizationContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authorizationProviderId, authorizationId);
            AuthorizationContractResource authorizationContract = client.GetAuthorizationContractResource(authorizationContractResourceId);

            // get the collection of this AuthorizationAccessPolicyContractResource
            AuthorizationAccessPolicyContractCollection collection = authorizationContract.GetAuthorizationAccessPolicyContracts();

            // invoke the operation
            string authorizationAccessPolicyId = "fe0bed83-631f-4149-bd0b-0464b1bc7cab";
            NullableResponse<AuthorizationAccessPolicyContractResource> response = await collection.GetIfExistsAsync(authorizationAccessPolicyId);
            AuthorizationAccessPolicyContractResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AuthorizationAccessPolicyContractData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ApiManagementCreateAuthorizationAccessPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateAuthorizationAccessPolicy.json
            // this example is just showing the usage of "AuthorizationAccessPolicy_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AuthorizationContractResource created on azure
            // for more information of creating AuthorizationContractResource, please refer to the document of AuthorizationContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authorizationProviderId = "aadwithauthcode";
            string authorizationId = "authz1";
            ResourceIdentifier authorizationContractResourceId = AuthorizationContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authorizationProviderId, authorizationId);
            AuthorizationContractResource authorizationContract = client.GetAuthorizationContractResource(authorizationContractResourceId);

            // get the collection of this AuthorizationAccessPolicyContractResource
            AuthorizationAccessPolicyContractCollection collection = authorizationContract.GetAuthorizationAccessPolicyContracts();

            // invoke the operation
            string authorizationAccessPolicyId = "fe0bed83-631f-4149-bd0b-0464b1bc7cab";
            AuthorizationAccessPolicyContractData data = new AuthorizationAccessPolicyContractData()
            {
                AppIds =
{
"d5f04bb0-ba78-4878-a43e-35a0b74fe315"
},
                TenantId = Guid.Parse("13932a0d-5c63-4d37-901d-1df9c97722ff"),
                ObjectId = "fe0bed83-631f-4149-bd0b-0464b1bc7cab",
            };
            ArmOperation<AuthorizationAccessPolicyContractResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, authorizationAccessPolicyId, data);
            AuthorizationAccessPolicyContractResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AuthorizationAccessPolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
