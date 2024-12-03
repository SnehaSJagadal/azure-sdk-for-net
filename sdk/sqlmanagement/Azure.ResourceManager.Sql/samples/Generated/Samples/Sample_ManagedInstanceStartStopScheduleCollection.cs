// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Sql.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_ManagedInstanceStartStopScheduleCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatesOrUpdatesTheManagedInstanceSStartStopScheduleWithAllOptionalParametersSpecified()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/StartStopManagedInstanceScheduleCreateOrUpdateMax.json
            // this example is just showing the usage of "StartStopManagedInstanceSchedules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "schedulerg";
            string managedInstanceName = "schedulemi";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedInstanceStartStopScheduleResource
            ManagedInstanceStartStopScheduleCollection collection = managedInstance.GetManagedInstanceStartStopSchedules();

            // invoke the operation
            ManagedInstanceStartStopScheduleName startStopScheduleName = ManagedInstanceStartStopScheduleName.Default;
            ManagedInstanceStartStopScheduleData data = new ManagedInstanceStartStopScheduleData
            {
                Description = "This is a schedule for our Dev/Test environment.",
                TimeZoneId = "Central European Standard Time",
                ScheduleList = { new SqlScheduleItem(SqlDayOfWeek.Thursday, "18:00", SqlDayOfWeek.Thursday, "17:00"), new SqlScheduleItem(SqlDayOfWeek.Thursday, "15:00", SqlDayOfWeek.Thursday, "14:00") },
            };
            ArmOperation<ManagedInstanceStartStopScheduleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, startStopScheduleName, data);
            ManagedInstanceStartStopScheduleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedInstanceStartStopScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatesOrUpdatesTheManagedInstanceSStartStopScheduleWithNoOptionalParametersSpecified()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/StartStopManagedInstanceScheduleCreateOrUpdateMin.json
            // this example is just showing the usage of "StartStopManagedInstanceSchedules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "schedulerg";
            string managedInstanceName = "schedulemi";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedInstanceStartStopScheduleResource
            ManagedInstanceStartStopScheduleCollection collection = managedInstance.GetManagedInstanceStartStopSchedules();

            // invoke the operation
            ManagedInstanceStartStopScheduleName startStopScheduleName = ManagedInstanceStartStopScheduleName.Default;
            ManagedInstanceStartStopScheduleData data = new ManagedInstanceStartStopScheduleData
            {
                ScheduleList = { new SqlScheduleItem(SqlDayOfWeek.Thursday, "18:00", SqlDayOfWeek.Thursday, "17:00"), new SqlScheduleItem(SqlDayOfWeek.Thursday, "15:00", SqlDayOfWeek.Thursday, "14:00") },
            };
            ArmOperation<ManagedInstanceStartStopScheduleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, startStopScheduleName, data);
            ManagedInstanceStartStopScheduleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedInstanceStartStopScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsTheManagedInstanceSStartStopSchedule()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/StartStopManagedInstanceScheduleGet.json
            // this example is just showing the usage of "StartStopManagedInstanceSchedules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "schedulerg";
            string managedInstanceName = "schedulemi";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedInstanceStartStopScheduleResource
            ManagedInstanceStartStopScheduleCollection collection = managedInstance.GetManagedInstanceStartStopSchedules();

            // invoke the operation
            ManagedInstanceStartStopScheduleName startStopScheduleName = ManagedInstanceStartStopScheduleName.Default;
            ManagedInstanceStartStopScheduleResource result = await collection.GetAsync(startStopScheduleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedInstanceStartStopScheduleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListsTheManagedInstanceSStartStopSchedules()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/StartStopManagedInstanceScheduleList.json
            // this example is just showing the usage of "StartStopManagedInstanceSchedules_ListByInstance" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "schedulerg";
            string managedInstanceName = "schedulemi";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedInstanceStartStopScheduleResource
            ManagedInstanceStartStopScheduleCollection collection = managedInstance.GetManagedInstanceStartStopSchedules();

            // invoke the operation and iterate over the result
            await foreach (ManagedInstanceStartStopScheduleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedInstanceStartStopScheduleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetsTheManagedInstanceSStartStopSchedule()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/StartStopManagedInstanceScheduleGet.json
            // this example is just showing the usage of "StartStopManagedInstanceSchedules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "schedulerg";
            string managedInstanceName = "schedulemi";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedInstanceStartStopScheduleResource
            ManagedInstanceStartStopScheduleCollection collection = managedInstance.GetManagedInstanceStartStopSchedules();

            // invoke the operation
            ManagedInstanceStartStopScheduleName startStopScheduleName = ManagedInstanceStartStopScheduleName.Default;
            bool result = await collection.ExistsAsync(startStopScheduleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetsTheManagedInstanceSStartStopSchedule()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-08-01-preview/examples/StartStopManagedInstanceScheduleGet.json
            // this example is just showing the usage of "StartStopManagedInstanceSchedules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "schedulerg";
            string managedInstanceName = "schedulemi";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedInstanceStartStopScheduleResource
            ManagedInstanceStartStopScheduleCollection collection = managedInstance.GetManagedInstanceStartStopSchedules();

            // invoke the operation
            ManagedInstanceStartStopScheduleName startStopScheduleName = ManagedInstanceStartStopScheduleName.Default;
            NullableResponse<ManagedInstanceStartStopScheduleResource> response = await collection.GetIfExistsAsync(startStopScheduleName);
            ManagedInstanceStartStopScheduleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedInstanceStartStopScheduleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
