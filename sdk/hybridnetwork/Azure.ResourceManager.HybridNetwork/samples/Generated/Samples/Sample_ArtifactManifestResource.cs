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
    public partial class Sample_ArtifactManifestResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAArtifactManifestResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/ArtifactManifestGet.json
            // this example is just showing the usage of "ArtifactManifests_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArtifactManifestResource created on azure
            // for more information of creating ArtifactManifestResource, please refer to the document of ArtifactManifestResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string artifactStoreName = "TestArtifactStore";
            string artifactManifestName = "TestManifest";
            ResourceIdentifier artifactManifestResourceId = ArtifactManifestResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, artifactStoreName, artifactManifestName);
            ArtifactManifestResource artifactManifest = client.GetArtifactManifestResource(artifactManifestResourceId);

            // invoke the operation
            ArtifactManifestResource result = await artifactManifest.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArtifactManifestData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAArtifactManifestResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/ArtifactManifestDelete.json
            // this example is just showing the usage of "ArtifactManifests_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArtifactManifestResource created on azure
            // for more information of creating ArtifactManifestResource, please refer to the document of ArtifactManifestResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string artifactStoreName = "TestArtifactStore";
            string artifactManifestName = "TestManifest";
            ResourceIdentifier artifactManifestResourceId = ArtifactManifestResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, artifactStoreName, artifactManifestName);
            ArtifactManifestResource artifactManifest = client.GetArtifactManifestResource(artifactManifestResourceId);

            // invoke the operation
            await artifactManifest.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateAArtifactManifestResourceTags()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/ArtifactManifestUpdateTags.json
            // this example is just showing the usage of "ArtifactManifests_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArtifactManifestResource created on azure
            // for more information of creating ArtifactManifestResource, please refer to the document of ArtifactManifestResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string artifactStoreName = "TestArtifactStore";
            string artifactManifestName = "TestManifest";
            ResourceIdentifier artifactManifestResourceId = ArtifactManifestResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, artifactStoreName, artifactManifestName);
            ArtifactManifestResource artifactManifest = client.GetArtifactManifestResource(artifactManifestResourceId);

            // invoke the operation
            TagsObject tagsObject = new TagsObject
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2"
},
            };
            ArtifactManifestResource result = await artifactManifest.UpdateAsync(tagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArtifactManifestData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetCredential_ListACredentialForArtifactManifest()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/ArtifactManifestListCredential.json
            // this example is just showing the usage of "ArtifactManifests_ListCredential" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArtifactManifestResource created on azure
            // for more information of creating ArtifactManifestResource, please refer to the document of ArtifactManifestResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string artifactStoreName = "TestArtifactStore";
            string artifactManifestName = "TestArtifactManifestName";
            ResourceIdentifier artifactManifestResourceId = ArtifactManifestResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, artifactStoreName, artifactManifestName);
            ArtifactManifestResource artifactManifest = client.GetArtifactManifestResource(artifactManifestResourceId);

            // invoke the operation
            ArtifactAccessCredential result = await artifactManifest.GetCredentialAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task UpdateState_UpdateArtifactManifestState()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/ArtifactManifestUpdateState.json
            // this example is just showing the usage of "ArtifactManifests_UpdateState" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArtifactManifestResource created on azure
            // for more information of creating ArtifactManifestResource, please refer to the document of ArtifactManifestResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string artifactStoreName = "TestArtifactStore";
            string artifactManifestName = "TestArtifactManifestName";
            ResourceIdentifier artifactManifestResourceId = ArtifactManifestResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, artifactStoreName, artifactManifestName);
            ArtifactManifestResource artifactManifest = client.GetArtifactManifestResource(artifactManifestResourceId);

            // invoke the operation
            ArtifactManifestUpdateState artifactManifestUpdateState = new ArtifactManifestUpdateState
            {
                ArtifactManifestState = ArtifactManifestState.Uploaded,
            };
            ArmOperation<ArtifactManifestUpdateState> lro = await artifactManifest.UpdateStateAsync(WaitUntil.Completed, artifactManifestUpdateState);
            ArtifactManifestUpdateState result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
