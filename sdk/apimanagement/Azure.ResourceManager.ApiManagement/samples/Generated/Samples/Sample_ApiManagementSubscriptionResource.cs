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
    public partial class Sample_ApiManagementSubscriptionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetEntityTag_ApiManagementHeadSubscription()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementHeadSubscription.json
            // this example is just showing the usage of "Subscription_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementSubscriptionResource created on azure
            // for more information of creating ApiManagementSubscriptionResource, please refer to the document of ApiManagementSubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string sid = "5931a769d8d14f0ad8ce13b8";
            ResourceIdentifier apiManagementSubscriptionResourceId = ApiManagementSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, sid);
            ApiManagementSubscriptionResource apiManagementSubscription = client.GetApiManagementSubscriptionResource(apiManagementSubscriptionResourceId);

            // invoke the operation
            bool result = await apiManagementSubscription.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetSubscription()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetSubscription.json
            // this example is just showing the usage of "Subscription_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementSubscriptionResource created on azure
            // for more information of creating ApiManagementSubscriptionResource, please refer to the document of ApiManagementSubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string sid = "5931a769d8d14f0ad8ce13b8";
            ResourceIdentifier apiManagementSubscriptionResourceId = ApiManagementSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, sid);
            ApiManagementSubscriptionResource apiManagementSubscription = client.GetApiManagementSubscriptionResource(apiManagementSubscriptionResourceId);

            // invoke the operation
            ApiManagementSubscriptionResource result = await apiManagementSubscription.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SubscriptionContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementUpdateSubscription()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementUpdateSubscription.json
            // this example is just showing the usage of "Subscription_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementSubscriptionResource created on azure
            // for more information of creating ApiManagementSubscriptionResource, please refer to the document of ApiManagementSubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string sid = "testsub";
            ResourceIdentifier apiManagementSubscriptionResourceId = ApiManagementSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, sid);
            ApiManagementSubscriptionResource apiManagementSubscription = client.GetApiManagementSubscriptionResource(apiManagementSubscriptionResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            ApiManagementSubscriptionPatch patch = new ApiManagementSubscriptionPatch()
            {
                DisplayName = "testsub",
            };
            ApiManagementSubscriptionResource result = await apiManagementSubscription.UpdateAsync(ifMatch, patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SubscriptionContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ApiManagementDeleteSubscription()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementDeleteSubscription.json
            // this example is just showing the usage of "Subscription_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementSubscriptionResource created on azure
            // for more information of creating ApiManagementSubscriptionResource, please refer to the document of ApiManagementSubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string sid = "testsub";
            ResourceIdentifier apiManagementSubscriptionResourceId = ApiManagementSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, sid);
            ApiManagementSubscriptionResource apiManagementSubscription = client.GetApiManagementSubscriptionResource(apiManagementSubscriptionResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await apiManagementSubscription.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task RegeneratePrimaryKey_ApiManagementSubscriptionRegeneratePrimaryKey()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementSubscriptionRegeneratePrimaryKey.json
            // this example is just showing the usage of "Subscription_RegeneratePrimaryKey" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementSubscriptionResource created on azure
            // for more information of creating ApiManagementSubscriptionResource, please refer to the document of ApiManagementSubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string sid = "testsub";
            ResourceIdentifier apiManagementSubscriptionResourceId = ApiManagementSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, sid);
            ApiManagementSubscriptionResource apiManagementSubscription = client.GetApiManagementSubscriptionResource(apiManagementSubscriptionResourceId);

            // invoke the operation
            await apiManagementSubscription.RegeneratePrimaryKeyAsync();

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task RegenerateSecondaryKey_ApiManagementSubscriptionRegenerateSecondaryKey()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementSubscriptionRegenerateSecondaryKey.json
            // this example is just showing the usage of "Subscription_RegenerateSecondaryKey" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementSubscriptionResource created on azure
            // for more information of creating ApiManagementSubscriptionResource, please refer to the document of ApiManagementSubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string sid = "testsub";
            ResourceIdentifier apiManagementSubscriptionResourceId = ApiManagementSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, sid);
            ApiManagementSubscriptionResource apiManagementSubscription = client.GetApiManagementSubscriptionResource(apiManagementSubscriptionResourceId);

            // invoke the operation
            await apiManagementSubscription.RegenerateSecondaryKeyAsync();

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetSecrets_ApiManagementSubscriptionListSecrets()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementSubscriptionListSecrets.json
            // this example is just showing the usage of "Subscription_ListSecrets" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementSubscriptionResource created on azure
            // for more information of creating ApiManagementSubscriptionResource, please refer to the document of ApiManagementSubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string sid = "5931a769d8d14f0ad8ce13b8";
            ResourceIdentifier apiManagementSubscriptionResourceId = ApiManagementSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, sid);
            ApiManagementSubscriptionResource apiManagementSubscription = client.GetApiManagementSubscriptionResource(apiManagementSubscriptionResourceId);

            // invoke the operation
            SubscriptionKeysContract result = await apiManagementSubscription.GetSecretsAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
