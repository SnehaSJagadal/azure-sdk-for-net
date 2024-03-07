// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Support;
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support.Samples
{
    public partial class Sample_SubscriptionResourceExtensions
    {
        // Classify list of Azure services for a subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ClassifyServicesServiceClassification_ClassifyListOfAzureServicesForASubscription()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2023-06-01-preview/examples/ClassifyServicesForSubscription.json
            // this example is just showing the usage of "ServiceClassifications_classifyServices" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            ServiceClassificationContent content = new ServiceClassificationContent()
            {
                IssueSummary = "Can not connect to Windows VM",
                ResourceId = new ResourceIdentifier("/subscriptions/76cb77fa-8b17-4eab-9493-b65dace99813/resourceGroups/rgname/providers/Microsoft.Compute/virtualMachines/vmname"),
            };
            ServiceClassificationOutput result = await subscriptionResource.ClassifyServicesServiceClassificationAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
