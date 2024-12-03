// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HybridNetwork.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.HybridNetwork.Samples
{
    public partial class Sample_NetworkFunctionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetNetworkFunctionResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/NetworkFunctionGet.json
            // this example is just showing the usage of "NetworkFunctions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionResource created on azure
            // for more information of creating NetworkFunctionResource, please refer to the document of NetworkFunctionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string networkFunctionName = "testNf";
            ResourceIdentifier networkFunctionResourceId = NetworkFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFunctionName);
            NetworkFunctionResource networkFunction = client.GetNetworkFunctionResource(networkFunctionResourceId);

            // invoke the operation
            NetworkFunctionResource result = await networkFunction.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFunctionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetVirtualNetworkFunctionResourceOnAzureCore()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/AzureCore/VirtualNetworkFunctionGet.json
            // this example is just showing the usage of "NetworkFunctions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionResource created on azure
            // for more information of creating NetworkFunctionResource, please refer to the document of NetworkFunctionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string networkFunctionName = "testNf";
            ResourceIdentifier networkFunctionResourceId = NetworkFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFunctionName);
            NetworkFunctionResource networkFunction = client.GetNetworkFunctionResource(networkFunctionResourceId);

            // invoke the operation
            NetworkFunctionResource result = await networkFunction.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFunctionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetVirtualNetworkFunctionResourceOnAzureOperatorNexus()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/AzureOperatorNexus/VirtualNetworkFunctionGet.json
            // this example is just showing the usage of "NetworkFunctions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionResource created on azure
            // for more information of creating NetworkFunctionResource, please refer to the document of NetworkFunctionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string networkFunctionName = "testNf";
            ResourceIdentifier networkFunctionResourceId = NetworkFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFunctionName);
            NetworkFunctionResource networkFunction = client.GetNetworkFunctionResource(networkFunctionResourceId);

            // invoke the operation
            NetworkFunctionResource result = await networkFunction.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFunctionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteNetworkFunctionResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/NetworkFunctionDelete.json
            // this example is just showing the usage of "NetworkFunctions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionResource created on azure
            // for more information of creating NetworkFunctionResource, please refer to the document of NetworkFunctionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string networkFunctionName = "testNf";
            ResourceIdentifier networkFunctionResourceId = NetworkFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFunctionName);
            NetworkFunctionResource networkFunction = client.GetNetworkFunctionResource(networkFunctionResourceId);

            // invoke the operation
            await networkFunction.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteVirtualNetworkFunctionResourceOnAzureCore()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/AzureCore/VirtualNetworkFunctionDelete.json
            // this example is just showing the usage of "NetworkFunctions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionResource created on azure
            // for more information of creating NetworkFunctionResource, please refer to the document of NetworkFunctionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string networkFunctionName = "testNf";
            ResourceIdentifier networkFunctionResourceId = NetworkFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFunctionName);
            NetworkFunctionResource networkFunction = client.GetNetworkFunctionResource(networkFunctionResourceId);

            // invoke the operation
            await networkFunction.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteVirtualNetworkFunctionResourceOnAzureOperatorNexus()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/AzureOperatorNexus/VirtualNetworkFunctionDelete.json
            // this example is just showing the usage of "NetworkFunctions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionResource created on azure
            // for more information of creating NetworkFunctionResource, please refer to the document of NetworkFunctionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string networkFunctionName = "testNf";
            ResourceIdentifier networkFunctionResourceId = NetworkFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFunctionName);
            NetworkFunctionResource networkFunction = client.GetNetworkFunctionResource(networkFunctionResourceId);

            // invoke the operation
            await networkFunction.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateTagsForNetworkFunctionResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/NetworkFunctionUpdateTags.json
            // this example is just showing the usage of "NetworkFunctions_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionResource created on azure
            // for more information of creating NetworkFunctionResource, please refer to the document of NetworkFunctionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string networkFunctionName = "testNf";
            ResourceIdentifier networkFunctionResourceId = NetworkFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFunctionName);
            NetworkFunctionResource networkFunction = client.GetNetworkFunctionResource(networkFunctionResourceId);

            // invoke the operation
            TagsObject tagsObject = new TagsObject
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2"
},
            };
            NetworkFunctionResource result = await networkFunction.UpdateAsync(tagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFunctionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ExecuteRequest_SendRequestToNetworkFunctionServices()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/NetworkFunctionsExecuteRequest.json
            // this example is just showing the usage of "NetworkFunctions_ExecuteRequest" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionResource created on azure
            // for more information of creating NetworkFunctionResource, please refer to the document of NetworkFunctionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string networkFunctionName = "testNetworkfunction";
            ResourceIdentifier networkFunctionResourceId = NetworkFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFunctionName);
            NetworkFunctionResource networkFunction = client.GetNetworkFunctionResource(networkFunctionResourceId);

            // invoke the operation
            ExecuteRequestContent content = new ExecuteRequestContent("serviceEndpoint", new RequestMetadata("/simProfiles/testSimProfile", HttpMethod.Post, "{\"subscriptionProfile\":\"ChantestSubscription15\",\"permanentKey\":\"00112233445566778899AABBCCDDEEFF\",\"opcOperatorCode\":\"63bfa50ee6523365ff14c1f45f88737d\",\"staticIpAddresses\":{\"internet\":{\"ipv4Addr\":\"198.51.100.1\",\"ipv6Prefix\":\"2001:db8:abcd:12::0/64\"},\"another_network\":{\"ipv6Prefix\":\"2001:111:cdef:22::0/64\"}}}")
            {
                ApiVersion = "apiVersionQueryString",
            });
            await networkFunction.ExecuteRequestAsync(WaitUntil.Completed, content);

            Console.WriteLine("Succeeded");
        }
    }
}
