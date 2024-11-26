// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_DomainOwnershipIdentifierResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetDomainOwnershipIdentifier()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.DomainRegistration/stable/2024-04-01/examples/GetDomainOwnershipIdentifier.json
            // this example is just showing the usage of "Domains_GetOwnershipIdentifier" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DomainOwnershipIdentifierResource created on azure
            // for more information of creating DomainOwnershipIdentifierResource, please refer to the document of DomainOwnershipIdentifierResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string domainName = "example.com";
            string name = "SampleOwnershipId";
            ResourceIdentifier domainOwnershipIdentifierResourceId = DomainOwnershipIdentifierResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName, name);
            DomainOwnershipIdentifierResource domainOwnershipIdentifier = client.GetDomainOwnershipIdentifierResource(domainOwnershipIdentifierResourceId);

            // invoke the operation
            DomainOwnershipIdentifierResource result = await domainOwnershipIdentifier.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DomainOwnershipIdentifierData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAppServiceDomainOwnershipIdentifier()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.DomainRegistration/stable/2024-04-01/examples/DeleteAppServiceDomainOwnershipIdentifier.json
            // this example is just showing the usage of "Domains_DeleteOwnershipIdentifier" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DomainOwnershipIdentifierResource created on azure
            // for more information of creating DomainOwnershipIdentifierResource, please refer to the document of DomainOwnershipIdentifierResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string domainName = "example.com";
            string name = "ownershipIdentifier";
            ResourceIdentifier domainOwnershipIdentifierResourceId = DomainOwnershipIdentifierResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName, name);
            DomainOwnershipIdentifierResource domainOwnershipIdentifier = client.GetDomainOwnershipIdentifierResource(domainOwnershipIdentifierResourceId);

            // invoke the operation
            await domainOwnershipIdentifier.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateAppServiceDomainOwnershipIdentifier()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.DomainRegistration/stable/2024-04-01/examples/UpdateAppServiceDomainOwnershipIdentifier.json
            // this example is just showing the usage of "Domains_UpdateOwnershipIdentifier" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DomainOwnershipIdentifierResource created on azure
            // for more information of creating DomainOwnershipIdentifierResource, please refer to the document of DomainOwnershipIdentifierResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string domainName = "example.com";
            string name = "SampleOwnershipId";
            ResourceIdentifier domainOwnershipIdentifierResourceId = DomainOwnershipIdentifierResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName, name);
            DomainOwnershipIdentifierResource domainOwnershipIdentifier = client.GetDomainOwnershipIdentifierResource(domainOwnershipIdentifierResourceId);

            // invoke the operation
            DomainOwnershipIdentifierData data = new DomainOwnershipIdentifierData()
            {
                OwnershipId = "SampleOwnershipId",
            };
            DomainOwnershipIdentifierResource result = await domainOwnershipIdentifier.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DomainOwnershipIdentifierData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
