// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DeviceRegistry.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.DeviceRegistry.Samples
{
    public partial class Sample_SchemaVersionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetSchemaVersion()
        {
            // Generated from example definition: 2024-09-01-preview/Get_SchemaVersion.json
            // this example is just showing the usage of "SchemaVersion_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SchemaVersionResource created on azure
            // for more information of creating SchemaVersionResource, please refer to the document of SchemaVersionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string schemaRegistryName = "my-schema-registry";
            string schemaName = "my-schema";
            string schemaVersionName = "1";
            ResourceIdentifier schemaVersionResourceId = SchemaVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, schemaRegistryName, schemaName, schemaVersionName);
            SchemaVersionResource schemaVersion = client.GetSchemaVersionResource(schemaVersionResourceId);

            // invoke the operation
            SchemaVersionResource result = await schemaVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SchemaVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteSchemaVersion()
        {
            // Generated from example definition: 2024-09-01-preview/Delete_SchemaVersion.json
            // this example is just showing the usage of "SchemaVersion_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SchemaVersionResource created on azure
            // for more information of creating SchemaVersionResource, please refer to the document of SchemaVersionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string schemaRegistryName = "my-schema-registry";
            string schemaName = "my-schema";
            string schemaVersionName = "1";
            ResourceIdentifier schemaVersionResourceId = SchemaVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, schemaRegistryName, schemaName, schemaVersionName);
            SchemaVersionResource schemaVersion = client.GetSchemaVersionResource(schemaVersionResourceId);

            // invoke the operation
            await schemaVersion.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateSchemaVersion()
        {
            // Generated from example definition: 2024-09-01-preview/Create_SchemaVersion.json
            // this example is just showing the usage of "SchemaVersion_CreateOrReplace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SchemaVersionResource created on azure
            // for more information of creating SchemaVersionResource, please refer to the document of SchemaVersionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string schemaRegistryName = "my-schema-registry";
            string schemaName = "my-schema";
            string schemaVersionName = "1";
            ResourceIdentifier schemaVersionResourceId = SchemaVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, schemaRegistryName, schemaName, schemaVersionName);
            SchemaVersionResource schemaVersion = client.GetSchemaVersionResource(schemaVersionResourceId);

            // invoke the operation
            SchemaVersionData data = new SchemaVersionData
            {
                Properties = new SchemaVersionProperties("{\"$schema\": \"http://json-schema.org/draft-07/schema#\",\"type\": \"object\",\"properties\": {\"humidity\": {\"type\": \"string\"},\"temperature\": {\"type\":\"number\"}}}")
                {
                    Description = "Schema version 1",
                },
            };
            ArmOperation<SchemaVersionResource> lro = await schemaVersion.UpdateAsync(WaitUntil.Completed, data);
            SchemaVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SchemaVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
