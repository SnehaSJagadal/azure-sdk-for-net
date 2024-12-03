// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_NatGatewayResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetNatGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NatGatewayGet.json
            // this example is just showing the usage of "NatGateways_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NatGatewayResource created on azure
            // for more information of creating NatGatewayResource, please refer to the document of NatGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string natGatewayName = "test-natGateway";
            ResourceIdentifier natGatewayResourceId = NatGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, natGatewayName);
            NatGatewayResource natGateway = client.GetNatGatewayResource(natGatewayResourceId);

            // invoke the operation
            NatGatewayResource result = await natGateway.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NatGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteNatGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NatGatewayDelete.json
            // this example is just showing the usage of "NatGateways_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NatGatewayResource created on azure
            // for more information of creating NatGatewayResource, please refer to the document of NatGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string natGatewayName = "test-natGateway";
            ResourceIdentifier natGatewayResourceId = NatGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, natGatewayName);
            NatGatewayResource natGateway = client.GetNatGatewayResource(natGatewayResourceId);

            // invoke the operation
            await natGateway.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateNatGatewayTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NatGatewayUpdateTags.json
            // this example is just showing the usage of "NatGateways_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NatGatewayResource created on azure
            // for more information of creating NatGatewayResource, please refer to the document of NatGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string natGatewayName = "test-natGateway";
            ResourceIdentifier natGatewayResourceId = NatGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, natGatewayName);
            NatGatewayResource natGateway = client.GetNatGatewayResource(natGatewayResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2"
},
            };
            NatGatewayResource result = await natGateway.UpdateAsync(networkTagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NatGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
