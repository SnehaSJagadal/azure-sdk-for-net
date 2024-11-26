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
    public partial class Sample_ApiPolicyCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ApiManagementListApiPolicies()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementListApiPolicies.json
            // this example is just showing the usage of "ApiPolicy_ListByApi" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiResource created on azure
            // for more information of creating ApiResource, please refer to the document of ApiResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "5600b59475ff190048040001";
            ResourceIdentifier apiResourceId = ApiResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId);
            ApiResource api = client.GetApiResource(apiResourceId);

            // get the collection of this ApiPolicyResource
            ApiPolicyCollection collection = api.GetApiPolicies();

            // invoke the operation and iterate over the result
            await foreach (ApiPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PolicyContractData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetApiPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetApiPolicy.json
            // this example is just showing the usage of "ApiPolicy_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiResource created on azure
            // for more information of creating ApiResource, please refer to the document of ApiResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "5600b59475ff190048040001";
            ResourceIdentifier apiResourceId = ApiResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId);
            ApiResource api = client.GetApiResource(apiResourceId);

            // get the collection of this ApiPolicyResource
            ApiPolicyCollection collection = api.GetApiPolicies();

            // invoke the operation
            PolicyName policyId = PolicyName.Policy;
            ApiPolicyResource result = await collection.GetAsync(policyId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ApiManagementGetApiPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetApiPolicy.json
            // this example is just showing the usage of "ApiPolicy_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiResource created on azure
            // for more information of creating ApiResource, please refer to the document of ApiResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "5600b59475ff190048040001";
            ResourceIdentifier apiResourceId = ApiResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId);
            ApiResource api = client.GetApiResource(apiResourceId);

            // get the collection of this ApiPolicyResource
            ApiPolicyCollection collection = api.GetApiPolicies();

            // invoke the operation
            PolicyName policyId = PolicyName.Policy;
            bool result = await collection.ExistsAsync(policyId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ApiManagementGetApiPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetApiPolicy.json
            // this example is just showing the usage of "ApiPolicy_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiResource created on azure
            // for more information of creating ApiResource, please refer to the document of ApiResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "5600b59475ff190048040001";
            ResourceIdentifier apiResourceId = ApiResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId);
            ApiResource api = client.GetApiResource(apiResourceId);

            // get the collection of this ApiPolicyResource
            ApiPolicyCollection collection = api.GetApiPolicies();

            // invoke the operation
            PolicyName policyId = PolicyName.Policy;
            NullableResponse<ApiPolicyResource> response = await collection.GetIfExistsAsync(policyId);
            ApiPolicyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PolicyContractData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ApiManagementCreateApiPolicy()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateApiPolicy.json
            // this example is just showing the usage of "ApiPolicy_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiResource created on azure
            // for more information of creating ApiResource, please refer to the document of ApiResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "5600b57e7e8880006a040001";
            ResourceIdentifier apiResourceId = ApiResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId);
            ApiResource api = client.GetApiResource(apiResourceId);

            // get the collection of this ApiPolicyResource
            ApiPolicyCollection collection = api.GetApiPolicies();

            // invoke the operation
            PolicyName policyId = PolicyName.Policy;
            PolicyContractData data = new PolicyContractData()
            {
                Value = "<policies> <inbound /> <backend>    <forward-request />  </backend>  <outbound /></policies>",
                Format = PolicyContentFormat.Xml,
            };
            ETag? ifMatch = new ETag("*");
            ArmOperation<ApiPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, policyId, data, ifMatch: ifMatch);
            ApiPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ApiManagementCreateApiPolicyNonXmlEncoded()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateApiPolicyNonXmlEncoded.json
            // this example is just showing the usage of "ApiPolicy_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiResource created on azure
            // for more information of creating ApiResource, please refer to the document of ApiResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "5600b57e7e8880006a040001";
            ResourceIdentifier apiResourceId = ApiResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId);
            ApiResource api = client.GetApiResource(apiResourceId);

            // get the collection of this ApiPolicyResource
            ApiPolicyCollection collection = api.GetApiPolicies();

            // invoke the operation
            PolicyName policyId = PolicyName.Policy;
            PolicyContractData data = new PolicyContractData()
            {
                Value = "<policies>\r\n     <inbound>\r\n     <base />\r\n  <set-header name=\"newvalue\" exists-action=\"override\">\r\n   <value>\"@(context.Request.Headers.FirstOrDefault(h => h.Ke==\"Via\"))\" </value>\r\n    </set-header>\r\n  </inbound>\r\n      </policies>",
                Format = PolicyContentFormat.RawXml,
            };
            ETag? ifMatch = new ETag("*");
            ArmOperation<ApiPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, policyId, data, ifMatch: ifMatch);
            ApiPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
