// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiManagementGatewayCertificateAuthorityCollection
    {
        // ApiManagementListGatewaycertificateAuthorities
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ApiManagementListGatewaycertificateAuthorities()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementListGatewayCertificateAuthorities.json
            // this example is just showing the usage of "GatewayCertificateAuthority_ListByService" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementGatewayResource created on azure
            // for more information of creating ApiManagementGatewayResource, please refer to the document of ApiManagementGatewayResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string gatewayId = "gw1";
            ResourceIdentifier apiManagementGatewayResourceId = ApiManagementGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, gatewayId);
            ApiManagementGatewayResource apiManagementGateway = client.GetApiManagementGatewayResource(apiManagementGatewayResourceId);

            // get the collection of this ApiManagementGatewayCertificateAuthorityResource
            ApiManagementGatewayCertificateAuthorityCollection collection = apiManagementGateway.GetApiManagementGatewayCertificateAuthorities();

            // invoke the operation and iterate over the result
            await foreach (ApiManagementGatewayCertificateAuthorityResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApiManagementGatewayCertificateAuthorityData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ApiManagementGetGatewayCertificateAuthority
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetGatewayCertificateAuthority()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetGatewayCertificateAuthority.json
            // this example is just showing the usage of "GatewayCertificateAuthority_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementGatewayResource created on azure
            // for more information of creating ApiManagementGatewayResource, please refer to the document of ApiManagementGatewayResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string gatewayId = "gw1";
            ResourceIdentifier apiManagementGatewayResourceId = ApiManagementGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, gatewayId);
            ApiManagementGatewayResource apiManagementGateway = client.GetApiManagementGatewayResource(apiManagementGatewayResourceId);

            // get the collection of this ApiManagementGatewayCertificateAuthorityResource
            ApiManagementGatewayCertificateAuthorityCollection collection = apiManagementGateway.GetApiManagementGatewayCertificateAuthorities();

            // invoke the operation
            string certificateId = "cert1";
            ApiManagementGatewayCertificateAuthorityResource result = await collection.GetAsync(certificateId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementGatewayCertificateAuthorityData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementGetGatewayCertificateAuthority
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ApiManagementGetGatewayCertificateAuthority()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetGatewayCertificateAuthority.json
            // this example is just showing the usage of "GatewayCertificateAuthority_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementGatewayResource created on azure
            // for more information of creating ApiManagementGatewayResource, please refer to the document of ApiManagementGatewayResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string gatewayId = "gw1";
            ResourceIdentifier apiManagementGatewayResourceId = ApiManagementGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, gatewayId);
            ApiManagementGatewayResource apiManagementGateway = client.GetApiManagementGatewayResource(apiManagementGatewayResourceId);

            // get the collection of this ApiManagementGatewayCertificateAuthorityResource
            ApiManagementGatewayCertificateAuthorityCollection collection = apiManagementGateway.GetApiManagementGatewayCertificateAuthorities();

            // invoke the operation
            string certificateId = "cert1";
            bool result = await collection.ExistsAsync(certificateId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetGatewayCertificateAuthority
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ApiManagementGetGatewayCertificateAuthority()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetGatewayCertificateAuthority.json
            // this example is just showing the usage of "GatewayCertificateAuthority_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementGatewayResource created on azure
            // for more information of creating ApiManagementGatewayResource, please refer to the document of ApiManagementGatewayResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string gatewayId = "gw1";
            ResourceIdentifier apiManagementGatewayResourceId = ApiManagementGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, gatewayId);
            ApiManagementGatewayResource apiManagementGateway = client.GetApiManagementGatewayResource(apiManagementGatewayResourceId);

            // get the collection of this ApiManagementGatewayCertificateAuthorityResource
            ApiManagementGatewayCertificateAuthorityCollection collection = apiManagementGateway.GetApiManagementGatewayCertificateAuthorities();

            // invoke the operation
            string certificateId = "cert1";
            NullableResponse<ApiManagementGatewayCertificateAuthorityResource> response = await collection.GetIfExistsAsync(certificateId);
            ApiManagementGatewayCertificateAuthorityResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApiManagementGatewayCertificateAuthorityData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ApiManagementCreateGatewayCertificateAuthority
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ApiManagementCreateGatewayCertificateAuthority()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementCreateGatewayCertificateAuthority.json
            // this example is just showing the usage of "GatewayCertificateAuthority_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementGatewayResource created on azure
            // for more information of creating ApiManagementGatewayResource, please refer to the document of ApiManagementGatewayResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string gatewayId = "gw1";
            ResourceIdentifier apiManagementGatewayResourceId = ApiManagementGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, gatewayId);
            ApiManagementGatewayResource apiManagementGateway = client.GetApiManagementGatewayResource(apiManagementGatewayResourceId);

            // get the collection of this ApiManagementGatewayCertificateAuthorityResource
            ApiManagementGatewayCertificateAuthorityCollection collection = apiManagementGateway.GetApiManagementGatewayCertificateAuthorities();

            // invoke the operation
            string certificateId = "cert1";
            ApiManagementGatewayCertificateAuthorityData data = new ApiManagementGatewayCertificateAuthorityData()
            {
                IsTrusted = false,
            };
            ArmOperation<ApiManagementGatewayCertificateAuthorityResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, certificateId, data);
            ApiManagementGatewayCertificateAuthorityResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementGatewayCertificateAuthorityData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
