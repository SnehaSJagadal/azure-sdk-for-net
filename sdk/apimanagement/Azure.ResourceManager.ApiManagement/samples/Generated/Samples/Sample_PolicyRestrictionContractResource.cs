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
    public partial class Sample_PolicyRestrictionContractResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetEntityTag_ApiManagementHeadPolicyRestriction()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementHeadPolicyRestriction.json
            // this example is just showing the usage of "PolicyRestriction_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PolicyRestrictionContractResource created on azure
            // for more information of creating PolicyRestrictionContractResource, please refer to the document of PolicyRestrictionContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string policyRestrictionId = "policyRestriction1";
            ResourceIdentifier policyRestrictionContractResourceId = PolicyRestrictionContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, policyRestrictionId);
            PolicyRestrictionContractResource policyRestrictionContract = client.GetPolicyRestrictionContractResource(policyRestrictionContractResourceId);

            // invoke the operation
            bool result = await policyRestrictionContract.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetPolicyRestriction()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetPolicyRestriction.json
            // this example is just showing the usage of "PolicyRestriction_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PolicyRestrictionContractResource created on azure
            // for more information of creating PolicyRestrictionContractResource, please refer to the document of PolicyRestrictionContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string policyRestrictionId = "policyRestriction1";
            ResourceIdentifier policyRestrictionContractResourceId = PolicyRestrictionContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, policyRestrictionId);
            PolicyRestrictionContractResource policyRestrictionContract = client.GetPolicyRestrictionContractResource(policyRestrictionContractResourceId);

            // invoke the operation
            PolicyRestrictionContractResource result = await policyRestrictionContract.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyRestrictionContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementUpdatePolicyRestriction()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementUpdatePolicyRestriction.json
            // this example is just showing the usage of "PolicyRestriction_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PolicyRestrictionContractResource created on azure
            // for more information of creating PolicyRestrictionContractResource, please refer to the document of PolicyRestrictionContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string policyRestrictionId = "policyRestriction1";
            ResourceIdentifier policyRestrictionContractResourceId = PolicyRestrictionContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, policyRestrictionId);
            PolicyRestrictionContractResource policyRestrictionContract = client.GetPolicyRestrictionContractResource(policyRestrictionContractResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            PolicyRestrictionContractPatch patch = new PolicyRestrictionContractPatch()
            {
                Scope = "Sample Path 2 to the policy document.",
            };
            PolicyRestrictionContractResource result = await policyRestrictionContract.UpdateAsync(ifMatch, patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyRestrictionContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ApiManagementDeletePolicyRestriction()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementDeletePolicyRestriction.json
            // this example is just showing the usage of "PolicyRestriction_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PolicyRestrictionContractResource created on azure
            // for more information of creating PolicyRestrictionContractResource, please refer to the document of PolicyRestrictionContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string policyRestrictionId = "policyRestriction1";
            ResourceIdentifier policyRestrictionContractResourceId = PolicyRestrictionContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, policyRestrictionId);
            PolicyRestrictionContractResource policyRestrictionContract = client.GetPolicyRestrictionContractResource(policyRestrictionContractResourceId);

            // invoke the operation
            ETag? ifMatch = new ETag("*");
            await policyRestrictionContract.DeleteAsync(WaitUntil.Completed, ifMatch: ifMatch);

            Console.WriteLine("Succeeded");
        }
    }
}
