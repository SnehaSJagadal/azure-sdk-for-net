// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.ManagedServices.Samples
{
    public partial class Sample_ManagedServicesMarketplaceRegistrationResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetRegistrationDefinitions()
        {
            // Generated from example definition: specification/managedservices/resource-manager/Microsoft.ManagedServices/stable/2022-10-01/examples/GetMarketplaceRegistrationDefinition.json
            // this example is just showing the usage of "MarketplaceRegistrationDefinitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedServicesMarketplaceRegistrationResource created on azure
            // for more information of creating ManagedServicesMarketplaceRegistrationResource, please refer to the document of ManagedServicesMarketplaceRegistrationResource
            string scope = "subscription/0afefe50-734e-4610-8a82-a144ahf49dea";
            string marketplaceIdentifier = "publisher.product.planName.version";
            ResourceIdentifier managedServicesMarketplaceRegistrationResourceId = ManagedServicesMarketplaceRegistrationResource.CreateResourceIdentifier(scope, marketplaceIdentifier);
            ManagedServicesMarketplaceRegistrationResource managedServicesMarketplaceRegistration = client.GetManagedServicesMarketplaceRegistrationResource(managedServicesMarketplaceRegistrationResourceId);

            // invoke the operation
            ManagedServicesMarketplaceRegistrationResource result = await managedServicesMarketplaceRegistration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedServicesMarketplaceRegistrationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
