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
    public partial class Sample_SchemaCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateSchema()
        {
            // Generated from example definition: 2024-09-01-preview/Create_Schema.json
            // this example is just showing the usage of "Schema_CreateOrReplace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SchemaRegistryResource created on azure
            // for more information of creating SchemaRegistryResource, please refer to the document of SchemaRegistryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string schemaRegistryName = "my-schema-registry";
            ResourceIdentifier schemaRegistryResourceId = SchemaRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, schemaRegistryName);
            SchemaRegistryResource schemaRegistry = client.GetSchemaRegistryResource(schemaRegistryResourceId);

            // get the collection of this SchemaResource
            SchemaCollection collection = schemaRegistry.GetSchemas();

            // invoke the operation
            string schemaName = "my-schema";
            SchemaData data = new SchemaData
            {
                Properties = new SchemaProperties(Format.JsonSchemaDraft7, SchemaType.MessageSchema)
                {
                    DisplayName = "My Schema",
                    Description = "This is a sample Schema",
                    Tags =
{
["sampleKey"] = "sampleValue"
},
                },
            };
            ArmOperation<SchemaResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, schemaName, data);
            SchemaResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SchemaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SchemasGet()
        {
            // Generated from example definition: 2024-09-01-preview/Get_Schema.json
            // this example is just showing the usage of "Schema_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SchemaRegistryResource created on azure
            // for more information of creating SchemaRegistryResource, please refer to the document of SchemaRegistryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string schemaRegistryName = "my-schema-registry";
            ResourceIdentifier schemaRegistryResourceId = SchemaRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, schemaRegistryName);
            SchemaRegistryResource schemaRegistry = client.GetSchemaRegistryResource(schemaRegistryResourceId);

            // get the collection of this SchemaResource
            SchemaCollection collection = schemaRegistry.GetSchemas();

            // invoke the operation
            string schemaName = "my-schema";
            SchemaResource result = await collection.GetAsync(schemaName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SchemaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListSchemasSchemaRegistry()
        {
            // Generated from example definition: 2024-09-01-preview/List_Schemas_SchemaRegistry.json
            // this example is just showing the usage of "Schema_ListBySchemaRegistry" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SchemaRegistryResource created on azure
            // for more information of creating SchemaRegistryResource, please refer to the document of SchemaRegistryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string schemaRegistryName = "my-schema-registry";
            ResourceIdentifier schemaRegistryResourceId = SchemaRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, schemaRegistryName);
            SchemaRegistryResource schemaRegistry = client.GetSchemaRegistryResource(schemaRegistryResourceId);

            // get the collection of this SchemaResource
            SchemaCollection collection = schemaRegistry.GetSchemas();

            // invoke the operation and iterate over the result
            await foreach (SchemaResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SchemaData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_SchemasGet()
        {
            // Generated from example definition: 2024-09-01-preview/Get_Schema.json
            // this example is just showing the usage of "Schema_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SchemaRegistryResource created on azure
            // for more information of creating SchemaRegistryResource, please refer to the document of SchemaRegistryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string schemaRegistryName = "my-schema-registry";
            ResourceIdentifier schemaRegistryResourceId = SchemaRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, schemaRegistryName);
            SchemaRegistryResource schemaRegistry = client.GetSchemaRegistryResource(schemaRegistryResourceId);

            // get the collection of this SchemaResource
            SchemaCollection collection = schemaRegistry.GetSchemas();

            // invoke the operation
            string schemaName = "my-schema";
            bool result = await collection.ExistsAsync(schemaName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_SchemasGet()
        {
            // Generated from example definition: 2024-09-01-preview/Get_Schema.json
            // this example is just showing the usage of "Schema_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SchemaRegistryResource created on azure
            // for more information of creating SchemaRegistryResource, please refer to the document of SchemaRegistryResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string schemaRegistryName = "my-schema-registry";
            ResourceIdentifier schemaRegistryResourceId = SchemaRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, schemaRegistryName);
            SchemaRegistryResource schemaRegistry = client.GetSchemaRegistryResource(schemaRegistryResourceId);

            // get the collection of this SchemaResource
            SchemaCollection collection = schemaRegistry.GetSchemas();

            // invoke the operation
            string schemaName = "my-schema";
            NullableResponse<SchemaResource> response = await collection.GetIfExistsAsync(schemaName);
            SchemaResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SchemaData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
