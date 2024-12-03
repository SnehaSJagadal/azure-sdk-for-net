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
    public partial class Sample_ExpressRouteCircuitConnectionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ExpressRouteCircuitConnectionGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ExpressRouteCircuitConnectionGet.json
            // this example is just showing the usage of "ExpressRouteCircuitConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCircuitConnectionResource created on azure
            // for more information of creating ExpressRouteCircuitConnectionResource, please refer to the document of ExpressRouteCircuitConnectionResource
            string subscriptionId = "subid1";
            string resourceGroupName = "rg1";
            string circuitName = "ExpressRouteARMCircuitA";
            string peeringName = "AzurePrivatePeering";
            string connectionName = "circuitConnectionUSAUS";
            ResourceIdentifier expressRouteCircuitConnectionResourceId = ExpressRouteCircuitConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, circuitName, peeringName, connectionName);
            ExpressRouteCircuitConnectionResource expressRouteCircuitConnection = client.GetExpressRouteCircuitConnectionResource(expressRouteCircuitConnectionResourceId);

            // invoke the operation
            ExpressRouteCircuitConnectionResource result = await expressRouteCircuitConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteCircuitConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteExpressRouteCircuit()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ExpressRouteCircuitConnectionDelete.json
            // this example is just showing the usage of "ExpressRouteCircuitConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCircuitConnectionResource created on azure
            // for more information of creating ExpressRouteCircuitConnectionResource, please refer to the document of ExpressRouteCircuitConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string circuitName = "ExpressRouteARMCircuitA";
            string peeringName = "AzurePrivatePeering";
            string connectionName = "circuitConnectionUSAUS";
            ResourceIdentifier expressRouteCircuitConnectionResourceId = ExpressRouteCircuitConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, circuitName, peeringName, connectionName);
            ExpressRouteCircuitConnectionResource expressRouteCircuitConnection = client.GetExpressRouteCircuitConnectionResource(expressRouteCircuitConnectionResourceId);

            // invoke the operation
            await expressRouteCircuitConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ExpressRouteCircuitConnectionCreate()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ExpressRouteCircuitConnectionCreate.json
            // this example is just showing the usage of "ExpressRouteCircuitConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCircuitConnectionResource created on azure
            // for more information of creating ExpressRouteCircuitConnectionResource, please refer to the document of ExpressRouteCircuitConnectionResource
            string subscriptionId = "subid1";
            string resourceGroupName = "rg1";
            string circuitName = "ExpressRouteARMCircuitA";
            string peeringName = "AzurePrivatePeering";
            string connectionName = "circuitConnectionUSAUS";
            ResourceIdentifier expressRouteCircuitConnectionResourceId = ExpressRouteCircuitConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, circuitName, peeringName, connectionName);
            ExpressRouteCircuitConnectionResource expressRouteCircuitConnection = client.GetExpressRouteCircuitConnectionResource(expressRouteCircuitConnectionResourceId);

            // invoke the operation
            ExpressRouteCircuitConnectionData data = new ExpressRouteCircuitConnectionData
            {
                ExpressRouteCircuitPeeringId = new ResourceIdentifier("/subscriptions/subid1/resourceGroups/dedharcktinit/providers/Microsoft.Network/expressRouteCircuits/dedharcktlocal/peerings/AzurePrivatePeering"),
                PeerExpressRouteCircuitPeeringId = new ResourceIdentifier("/subscriptions/subid2/resourceGroups/dedharcktpeer/providers/Microsoft.Network/expressRouteCircuits/dedharcktremote/peerings/AzurePrivatePeering"),
                AddressPrefix = "10.0.0.0/29",
                AuthorizationKey = "946a1918-b7a2-4917-b43c-8c4cdaee006a",
                IPv6CircuitConnectionConfig = new IPv6CircuitConnectionConfig
                {
                    AddressPrefix = "aa:bb::/125",
                },
            };
            ArmOperation<ExpressRouteCircuitConnectionResource> lro = await expressRouteCircuitConnection.UpdateAsync(WaitUntil.Completed, data);
            ExpressRouteCircuitConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteCircuitConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
