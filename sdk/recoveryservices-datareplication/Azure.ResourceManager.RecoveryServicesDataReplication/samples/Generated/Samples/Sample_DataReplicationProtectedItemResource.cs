// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.RecoveryServicesDataReplication.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Samples
{
    public partial class Sample_DataReplicationProtectedItemResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ProtectedItemGet()
        {
            // Generated from example definition: specification/recoveryservicesdatareplication/resource-manager/Microsoft.DataReplication/preview/2021-02-16-preview/examples/ProtectedItem_Get.json
            // this example is just showing the usage of "ProtectedItem_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationProtectedItemResource created on azure
            // for more information of creating DataReplicationProtectedItemResource, please refer to the document of DataReplicationProtectedItemResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            string protectedItemName = "d";
            ResourceIdentifier dataReplicationProtectedItemResourceId = DataReplicationProtectedItemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, protectedItemName);
            DataReplicationProtectedItemResource dataReplicationProtectedItem = client.GetDataReplicationProtectedItemResource(dataReplicationProtectedItemResourceId);

            // invoke the operation
            DataReplicationProtectedItemResource result = await dataReplicationProtectedItem.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataReplicationProtectedItemData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ProtectedItemCreate()
        {
            // Generated from example definition: specification/recoveryservicesdatareplication/resource-manager/Microsoft.DataReplication/preview/2021-02-16-preview/examples/ProtectedItem_Create.json
            // this example is just showing the usage of "ProtectedItem_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationProtectedItemResource created on azure
            // for more information of creating DataReplicationProtectedItemResource, please refer to the document of DataReplicationProtectedItemResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            string protectedItemName = "d";
            ResourceIdentifier dataReplicationProtectedItemResourceId = DataReplicationProtectedItemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, protectedItemName);
            DataReplicationProtectedItemResource dataReplicationProtectedItem = client.GetDataReplicationProtectedItemResource(dataReplicationProtectedItemResourceId);

            // invoke the operation
            DataReplicationProtectedItemData data = new DataReplicationProtectedItemData(new DataReplicationProtectedItemProperties("tjoeiynplt", "jwxdo", new GeneralProtectedItemModelCustomProperties()));
            ArmOperation<DataReplicationProtectedItemResource> lro = await dataReplicationProtectedItem.UpdateAsync(WaitUntil.Completed, data);
            DataReplicationProtectedItemResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataReplicationProtectedItemData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ProtectedItemDelete()
        {
            // Generated from example definition: specification/recoveryservicesdatareplication/resource-manager/Microsoft.DataReplication/preview/2021-02-16-preview/examples/ProtectedItem_Delete.json
            // this example is just showing the usage of "ProtectedItem_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationProtectedItemResource created on azure
            // for more information of creating DataReplicationProtectedItemResource, please refer to the document of DataReplicationProtectedItemResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            string protectedItemName = "d";
            ResourceIdentifier dataReplicationProtectedItemResourceId = DataReplicationProtectedItemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, protectedItemName);
            DataReplicationProtectedItemResource dataReplicationProtectedItem = client.GetDataReplicationProtectedItemResource(dataReplicationProtectedItemResourceId);

            // invoke the operation
            bool? forceDelete = true;
            await dataReplicationProtectedItem.DeleteAsync(WaitUntil.Completed, forceDelete: forceDelete);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task PlannedFailover_ProtectedItemPlannedFailover()
        {
            // Generated from example definition: specification/recoveryservicesdatareplication/resource-manager/Microsoft.DataReplication/preview/2021-02-16-preview/examples/ProtectedItem_PlannedFailover.json
            // this example is just showing the usage of "ProtectedItem_PlannedFailover" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationProtectedItemResource created on azure
            // for more information of creating DataReplicationProtectedItemResource, please refer to the document of DataReplicationProtectedItemResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            string protectedItemName = "d";
            ResourceIdentifier dataReplicationProtectedItemResourceId = DataReplicationProtectedItemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, protectedItemName);
            DataReplicationProtectedItemResource dataReplicationProtectedItem = client.GetDataReplicationProtectedItemResource(dataReplicationProtectedItemResourceId);

            // invoke the operation
            PlannedFailoverModel body = new PlannedFailoverModel(new PlannedFailoverModelProperties(new GeneralPlannedFailoverModelCustomProperties()));
            ArmOperation<PlannedFailoverModel> lro = await dataReplicationProtectedItem.PlannedFailoverAsync(WaitUntil.Completed, body: body);
            PlannedFailoverModel result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
