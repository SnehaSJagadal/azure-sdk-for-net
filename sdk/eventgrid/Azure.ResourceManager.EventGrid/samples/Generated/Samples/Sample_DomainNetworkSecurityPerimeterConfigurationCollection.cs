// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_DomainNetworkSecurityPerimeterConfigurationCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_NetworkSecurityPerimeterConfigurationsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/NetworkSecurityPerimeterConfigurations_Get.json
            // this example is just showing the usage of "NetworkSecurityPerimeterConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridDomainResource created on azure
            // for more information of creating EventGridDomainResource, please refer to the document of EventGridDomainResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string resourceName = "exampleResourceName";
            ResourceIdentifier eventGridDomainResourceId = EventGridDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            EventGridDomainResource eventGridDomain = client.GetEventGridDomainResource(eventGridDomainResourceId);

            // get the collection of this DomainNetworkSecurityPerimeterConfigurationResource
            DomainNetworkSecurityPerimeterConfigurationCollection collection = eventGridDomain.GetDomainNetworkSecurityPerimeterConfigurations();

            // invoke the operation
            string perimeterGuid = "8f6b6269-84f2-4d09-9e31-1127efcd1e40perimeter";
            string associationName = "someAssociation";
            DomainNetworkSecurityPerimeterConfigurationResource result = await collection.GetAsync(perimeterGuid, associationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkSecurityPerimeterConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_NetworkSecurityPerimeterConfigurationsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/NetworkSecurityPerimeterConfigurations_Get.json
            // this example is just showing the usage of "NetworkSecurityPerimeterConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridDomainResource created on azure
            // for more information of creating EventGridDomainResource, please refer to the document of EventGridDomainResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string resourceName = "exampleResourceName";
            ResourceIdentifier eventGridDomainResourceId = EventGridDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            EventGridDomainResource eventGridDomain = client.GetEventGridDomainResource(eventGridDomainResourceId);

            // get the collection of this DomainNetworkSecurityPerimeterConfigurationResource
            DomainNetworkSecurityPerimeterConfigurationCollection collection = eventGridDomain.GetDomainNetworkSecurityPerimeterConfigurations();

            // invoke the operation
            string perimeterGuid = "8f6b6269-84f2-4d09-9e31-1127efcd1e40perimeter";
            string associationName = "someAssociation";
            bool result = await collection.ExistsAsync(perimeterGuid, associationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_NetworkSecurityPerimeterConfigurationsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/NetworkSecurityPerimeterConfigurations_Get.json
            // this example is just showing the usage of "NetworkSecurityPerimeterConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridDomainResource created on azure
            // for more information of creating EventGridDomainResource, please refer to the document of EventGridDomainResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string resourceName = "exampleResourceName";
            ResourceIdentifier eventGridDomainResourceId = EventGridDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            EventGridDomainResource eventGridDomain = client.GetEventGridDomainResource(eventGridDomainResourceId);

            // get the collection of this DomainNetworkSecurityPerimeterConfigurationResource
            DomainNetworkSecurityPerimeterConfigurationCollection collection = eventGridDomain.GetDomainNetworkSecurityPerimeterConfigurations();

            // invoke the operation
            string perimeterGuid = "8f6b6269-84f2-4d09-9e31-1127efcd1e40perimeter";
            string associationName = "someAssociation";
            NullableResponse<DomainNetworkSecurityPerimeterConfigurationResource> response = await collection.GetIfExistsAsync(perimeterGuid, associationName);
            DomainNetworkSecurityPerimeterConfigurationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkSecurityPerimeterConfigurationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_NetworkSecurityPerimeterConfigurationsList()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/NetworkSecurityPerimeterConfigurations_List.json
            // this example is just showing the usage of "NetworkSecurityPerimeterConfigurations_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridDomainResource created on azure
            // for more information of creating EventGridDomainResource, please refer to the document of EventGridDomainResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string resourceName = "exampleResourceName";
            ResourceIdentifier eventGridDomainResourceId = EventGridDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            EventGridDomainResource eventGridDomain = client.GetEventGridDomainResource(eventGridDomainResourceId);

            // get the collection of this DomainNetworkSecurityPerimeterConfigurationResource
            DomainNetworkSecurityPerimeterConfigurationCollection collection = eventGridDomain.GetDomainNetworkSecurityPerimeterConfigurations();

            // invoke the operation and iterate over the result
            await foreach (NetworkSecurityPerimeterConfigurationData item in collection.GetAllAsync())
            {
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {item.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
