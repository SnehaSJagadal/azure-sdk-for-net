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
    public partial class Sample_ServiceProductApiLinkResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetProductApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetProductApiLink.json
            // this example is just showing the usage of "ProductApiLink_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceProductApiLinkResource created on azure
            // for more information of creating ServiceProductApiLinkResource, please refer to the document of ServiceProductApiLinkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string productId = "testproduct";
            string apiLinkId = "link1";
            ResourceIdentifier serviceProductApiLinkResourceId = ServiceProductApiLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, productId, apiLinkId);
            ServiceProductApiLinkResource serviceProductApiLink = client.GetServiceProductApiLinkResource(serviceProductApiLinkResourceId);

            // invoke the operation
            ServiceProductApiLinkResource result = await serviceProductApiLink.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProductApiLinkContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementCreateProductApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateProductApiLink.json
            // this example is just showing the usage of "ProductApiLink_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceProductApiLinkResource created on azure
            // for more information of creating ServiceProductApiLinkResource, please refer to the document of ServiceProductApiLinkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string productId = "testproduct";
            string apiLinkId = "link1";
            ResourceIdentifier serviceProductApiLinkResourceId = ServiceProductApiLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, productId, apiLinkId);
            ServiceProductApiLinkResource serviceProductApiLink = client.GetServiceProductApiLinkResource(serviceProductApiLinkResourceId);

            // invoke the operation
            ProductApiLinkContractData data = new ProductApiLinkContractData()
            {
                ApiId = "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.ApiManagement/service/apimService1/apis/echo-api",
            };
            ArmOperation<ServiceProductApiLinkResource> lro = await serviceProductApiLink.UpdateAsync(WaitUntil.Completed, data);
            ServiceProductApiLinkResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProductApiLinkContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ApiManagementDeleteProductApiLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementDeleteProductApiLink.json
            // this example is just showing the usage of "ProductApiLink_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceProductApiLinkResource created on azure
            // for more information of creating ServiceProductApiLinkResource, please refer to the document of ServiceProductApiLinkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string productId = "testproduct";
            string apiLinkId = "link1";
            ResourceIdentifier serviceProductApiLinkResourceId = ServiceProductApiLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, productId, apiLinkId);
            ServiceProductApiLinkResource serviceProductApiLink = client.GetServiceProductApiLinkResource(serviceProductApiLinkResourceId);

            // invoke the operation
            await serviceProductApiLink.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
