// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp.Samples
{
    public partial class Sample_NetAppVolumeGroupResource
    {
        // VolumeGroups_Get_Oracle
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VolumeGroupsGetOracle()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-03-01/examples/VolumeGroups_Get_Oracle.json
            // this example is just showing the usage of "VolumeGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeGroupResource created on azure
            // for more information of creating NetAppVolumeGroupResource, please refer to the document of NetAppVolumeGroupResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string volumeGroupName = "group1";
            ResourceIdentifier netAppVolumeGroupResourceId = NetAppVolumeGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, volumeGroupName);
            NetAppVolumeGroupResource netAppVolumeGroup = client.GetNetAppVolumeGroupResource(netAppVolumeGroupResourceId);

            // invoke the operation
            NetAppVolumeGroupResource result = await netAppVolumeGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppVolumeGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VolumeGroups_Get_SapHana
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VolumeGroupsGetSapHana()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-03-01/examples/VolumeGroups_Get_SapHana.json
            // this example is just showing the usage of "VolumeGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeGroupResource created on azure
            // for more information of creating NetAppVolumeGroupResource, please refer to the document of NetAppVolumeGroupResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string volumeGroupName = "group1";
            ResourceIdentifier netAppVolumeGroupResourceId = NetAppVolumeGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, volumeGroupName);
            NetAppVolumeGroupResource netAppVolumeGroup = client.GetNetAppVolumeGroupResource(netAppVolumeGroupResourceId);

            // invoke the operation
            NetAppVolumeGroupResource result = await netAppVolumeGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppVolumeGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VolumeGroups_Create_Oracle
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_VolumeGroupsCreateOracle()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-03-01/examples/VolumeGroups_Create_Oracle.json
            // this example is just showing the usage of "VolumeGroups_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeGroupResource created on azure
            // for more information of creating NetAppVolumeGroupResource, please refer to the document of NetAppVolumeGroupResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string volumeGroupName = "group1";
            ResourceIdentifier netAppVolumeGroupResourceId = NetAppVolumeGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, volumeGroupName);
            NetAppVolumeGroupResource netAppVolumeGroup = client.GetNetAppVolumeGroupResource(netAppVolumeGroupResourceId);

            // invoke the operation
            NetAppVolumeGroupData data = new NetAppVolumeGroupData()
            {
                Location = new AzureLocation("westus"),
                GroupMetaData = new NetAppVolumeGroupMetadata()
                {
                    GroupDescription = "Volume group",
                    ApplicationType = NetAppApplicationType.Oracle,
                    ApplicationIdentifier = "OR2",
                },
                Volumes =
{
new NetAppVolumeGroupVolume("test-ora-data1",107374182400L,new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRP/providers/Microsoft.Network/virtualNetworks/testvnet3/subnets/testsubnet3"))
{
Name = "test-ora-data1",
Zones =
{
"1"
},
ServiceLevel = NetAppFileServiceLevel.Premium,
ExportRules =
{
new NetAppVolumeExportPolicyRule()
{
RuleIndex = 1,
IsUnixReadOnly = true,
IsUnixReadWrite = true,
IsKerberos5ReadOnly = false,
IsKerberos5ReadWrite = false,
IsKerberos5iReadOnly = false,
IsKerberos5iReadWrite = false,
IsKerberos5pReadOnly = false,
IsKerberos5pReadWrite = false,
AllowCifsProtocol = false,
AllowNfsV3Protocol = false,
AllowNfsV41Protocol = true,
AllowedClients = "0.0.0.0/0",
HasRootAccess = true,
}
},
ProtocolTypes =
{
"NFSv4.1"
},
ThroughputMibps = 10,
CapacityPoolResourceId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPools/pool1"),
VolumeSpecName = "ora-data1",
},new NetAppVolumeGroupVolume("test-ora-data2",107374182400L,new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRP/providers/Microsoft.Network/virtualNetworks/testvnet3/subnets/testsubnet3"))
{
Name = "test-ora-data2",
Zones =
{
"1"
},
ServiceLevel = NetAppFileServiceLevel.Premium,
ExportRules =
{
new NetAppVolumeExportPolicyRule()
{
RuleIndex = 1,
IsUnixReadOnly = true,
IsUnixReadWrite = true,
IsKerberos5ReadOnly = false,
IsKerberos5ReadWrite = false,
IsKerberos5iReadOnly = false,
IsKerberos5iReadWrite = false,
IsKerberos5pReadOnly = false,
IsKerberos5pReadWrite = false,
AllowCifsProtocol = false,
AllowNfsV3Protocol = false,
AllowNfsV41Protocol = true,
AllowedClients = "0.0.0.0/0",
HasRootAccess = true,
}
},
ProtocolTypes =
{
"NFSv4.1"
},
ThroughputMibps = 10,
CapacityPoolResourceId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPools/pool1"),
VolumeSpecName = "ora-data2",
},new NetAppVolumeGroupVolume("test-ora-data3",107374182400L,new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRP/providers/Microsoft.Network/virtualNetworks/testvnet3/subnets/testsubnet3"))
{
Name = "test-ora-data3",
Zones =
{
"1"
},
ServiceLevel = NetAppFileServiceLevel.Premium,
ExportRules =
{
new NetAppVolumeExportPolicyRule()
{
RuleIndex = 1,
IsUnixReadOnly = true,
IsUnixReadWrite = true,
IsKerberos5ReadOnly = false,
IsKerberos5ReadWrite = false,
IsKerberos5iReadOnly = false,
IsKerberos5iReadWrite = false,
IsKerberos5pReadOnly = false,
IsKerberos5pReadWrite = false,
AllowCifsProtocol = false,
AllowNfsV3Protocol = false,
AllowNfsV41Protocol = true,
AllowedClients = "0.0.0.0/0",
HasRootAccess = true,
}
},
ProtocolTypes =
{
"NFSv4.1"
},
ThroughputMibps = 10,
CapacityPoolResourceId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPools/pool1"),
VolumeSpecName = "ora-data3",
},new NetAppVolumeGroupVolume("test-ora-data4",107374182400L,new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRP/providers/Microsoft.Network/virtualNetworks/testvnet3/subnets/testsubnet3"))
{
Name = "test-ora-data4",
Zones =
{
"1"
},
ServiceLevel = NetAppFileServiceLevel.Premium,
ExportRules =
{
new NetAppVolumeExportPolicyRule()
{
RuleIndex = 1,
IsUnixReadOnly = true,
IsUnixReadWrite = true,
IsKerberos5ReadOnly = false,
IsKerberos5ReadWrite = false,
IsKerberos5iReadOnly = false,
IsKerberos5iReadWrite = false,
IsKerberos5pReadOnly = false,
IsKerberos5pReadWrite = false,
AllowCifsProtocol = false,
AllowNfsV3Protocol = false,
AllowNfsV41Protocol = true,
AllowedClients = "0.0.0.0/0",
HasRootAccess = true,
}
},
ProtocolTypes =
{
"NFSv4.1"
},
ThroughputMibps = 10,
CapacityPoolResourceId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPools/pool1"),
VolumeSpecName = "ora-data4",
},new NetAppVolumeGroupVolume("test-ora-data5",107374182400L,new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRP/providers/Microsoft.Network/virtualNetworks/testvnet3/subnets/testsubnet3"))
{
Name = "test-ora-data5",
Zones =
{
"1"
},
ServiceLevel = NetAppFileServiceLevel.Premium,
ExportRules =
{
new NetAppVolumeExportPolicyRule()
{
RuleIndex = 1,
IsUnixReadOnly = true,
IsUnixReadWrite = true,
IsKerberos5ReadOnly = false,
IsKerberos5ReadWrite = false,
IsKerberos5iReadOnly = false,
IsKerberos5iReadWrite = false,
IsKerberos5pReadOnly = false,
IsKerberos5pReadWrite = false,
AllowCifsProtocol = false,
AllowNfsV3Protocol = false,
AllowNfsV41Protocol = true,
AllowedClients = "0.0.0.0/0",
HasRootAccess = true,
}
},
ProtocolTypes =
{
"NFSv4.1"
},
ThroughputMibps = 10,
CapacityPoolResourceId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPools/pool1"),
VolumeSpecName = "ora-data5",
},new NetAppVolumeGroupVolume("test-ora-data6",107374182400L,new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRP/providers/Microsoft.Network/virtualNetworks/testvnet3/subnets/testsubnet3"))
{
Name = "test-ora-data6",
Zones =
{
"1"
},
ServiceLevel = NetAppFileServiceLevel.Premium,
ExportRules =
{
new NetAppVolumeExportPolicyRule()
{
RuleIndex = 1,
IsUnixReadOnly = true,
IsUnixReadWrite = true,
IsKerberos5ReadOnly = false,
IsKerberos5ReadWrite = false,
IsKerberos5iReadOnly = false,
IsKerberos5iReadWrite = false,
IsKerberos5pReadOnly = false,
IsKerberos5pReadWrite = false,
AllowCifsProtocol = false,
AllowNfsV3Protocol = false,
AllowNfsV41Protocol = true,
AllowedClients = "0.0.0.0/0",
HasRootAccess = true,
}
},
ProtocolTypes =
{
"NFSv4.1"
},
ThroughputMibps = 10,
CapacityPoolResourceId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPools/pool1"),
VolumeSpecName = "ora-data6",
},new NetAppVolumeGroupVolume("test-ora-data7",107374182400L,new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRP/providers/Microsoft.Network/virtualNetworks/testvnet3/subnets/testsubnet3"))
{
Name = "test-ora-data7",
Zones =
{
"1"
},
ServiceLevel = NetAppFileServiceLevel.Premium,
ExportRules =
{
new NetAppVolumeExportPolicyRule()
{
RuleIndex = 1,
IsUnixReadOnly = true,
IsUnixReadWrite = true,
IsKerberos5ReadOnly = false,
IsKerberos5ReadWrite = false,
IsKerberos5iReadOnly = false,
IsKerberos5iReadWrite = false,
IsKerberos5pReadOnly = false,
IsKerberos5pReadWrite = false,
AllowCifsProtocol = false,
AllowNfsV3Protocol = false,
AllowNfsV41Protocol = true,
AllowedClients = "0.0.0.0/0",
HasRootAccess = true,
}
},
ProtocolTypes =
{
"NFSv4.1"
},
ThroughputMibps = 10,
CapacityPoolResourceId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPools/pool1"),
VolumeSpecName = "ora-data7",
},new NetAppVolumeGroupVolume("test-ora-data8",107374182400L,new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRP/providers/Microsoft.Network/virtualNetworks/testvnet3/subnets/testsubnet3"))
{
Name = "test-ora-data8",
Zones =
{
"1"
},
ServiceLevel = NetAppFileServiceLevel.Premium,
ExportRules =
{
new NetAppVolumeExportPolicyRule()
{
RuleIndex = 1,
IsUnixReadOnly = true,
IsUnixReadWrite = true,
IsKerberos5ReadOnly = false,
IsKerberos5ReadWrite = false,
IsKerberos5iReadOnly = false,
IsKerberos5iReadWrite = false,
IsKerberos5pReadOnly = false,
IsKerberos5pReadWrite = false,
AllowCifsProtocol = false,
AllowNfsV3Protocol = false,
AllowNfsV41Protocol = true,
AllowedClients = "0.0.0.0/0",
HasRootAccess = true,
}
},
ProtocolTypes =
{
"NFSv4.1"
},
ThroughputMibps = 10,
CapacityPoolResourceId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPools/pool1"),
VolumeSpecName = "ora-data8",
},new NetAppVolumeGroupVolume("test-ora-log",107374182400L,new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRP/providers/Microsoft.Network/virtualNetworks/testvnet3/subnets/testsubnet3"))
{
Name = "test-ora-log",
Zones =
{
"1"
},
ServiceLevel = NetAppFileServiceLevel.Premium,
ExportRules =
{
new NetAppVolumeExportPolicyRule()
{
RuleIndex = 1,
IsUnixReadOnly = true,
IsUnixReadWrite = true,
IsKerberos5ReadOnly = false,
IsKerberos5ReadWrite = false,
IsKerberos5iReadOnly = false,
IsKerberos5iReadWrite = false,
IsKerberos5pReadOnly = false,
IsKerberos5pReadWrite = false,
AllowCifsProtocol = false,
AllowNfsV3Protocol = false,
AllowNfsV41Protocol = true,
AllowedClients = "0.0.0.0/0",
HasRootAccess = true,
}
},
ProtocolTypes =
{
"NFSv4.1"
},
ThroughputMibps = 10,
CapacityPoolResourceId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPools/pool1"),
VolumeSpecName = "ora-log",
},new NetAppVolumeGroupVolume("test-ora-log-mirror",107374182400L,new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRP/providers/Microsoft.Network/virtualNetworks/testvnet3/subnets/testsubnet3"))
{
Name = "test-ora-log-mirror",
Zones =
{
"1"
},
ServiceLevel = NetAppFileServiceLevel.Premium,
ExportRules =
{
new NetAppVolumeExportPolicyRule()
{
RuleIndex = 1,
IsUnixReadOnly = true,
IsUnixReadWrite = true,
IsKerberos5ReadOnly = false,
IsKerberos5ReadWrite = false,
IsKerberos5iReadOnly = false,
IsKerberos5iReadWrite = false,
IsKerberos5pReadOnly = false,
IsKerberos5pReadWrite = false,
AllowCifsProtocol = false,
AllowNfsV3Protocol = false,
AllowNfsV41Protocol = true,
AllowedClients = "0.0.0.0/0",
HasRootAccess = true,
}
},
ProtocolTypes =
{
"NFSv4.1"
},
ThroughputMibps = 10,
CapacityPoolResourceId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPools/pool1"),
VolumeSpecName = "ora-log-mirror",
},new NetAppVolumeGroupVolume("test-ora-binary",107374182400L,new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRP/providers/Microsoft.Network/virtualNetworks/testvnet3/subnets/testsubnet3"))
{
Name = "test-ora-binary",
Zones =
{
"1"
},
ServiceLevel = NetAppFileServiceLevel.Premium,
ExportRules =
{
new NetAppVolumeExportPolicyRule()
{
RuleIndex = 1,
IsUnixReadOnly = true,
IsUnixReadWrite = true,
IsKerberos5ReadOnly = false,
IsKerberos5ReadWrite = false,
IsKerberos5iReadOnly = false,
IsKerberos5iReadWrite = false,
IsKerberos5pReadOnly = false,
IsKerberos5pReadWrite = false,
AllowCifsProtocol = false,
AllowNfsV3Protocol = false,
AllowNfsV41Protocol = true,
AllowedClients = "0.0.0.0/0",
HasRootAccess = true,
}
},
ProtocolTypes =
{
"NFSv4.1"
},
ThroughputMibps = 10,
CapacityPoolResourceId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPools/pool1"),
VolumeSpecName = "ora-binary",
},new NetAppVolumeGroupVolume("test-ora-backup",107374182400L,new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRP/providers/Microsoft.Network/virtualNetworks/testvnet3/subnets/testsubnet3"))
{
Name = "test-ora-backup",
Zones =
{
"1"
},
ServiceLevel = NetAppFileServiceLevel.Premium,
ExportRules =
{
new NetAppVolumeExportPolicyRule()
{
RuleIndex = 1,
IsUnixReadOnly = true,
IsUnixReadWrite = true,
IsKerberos5ReadOnly = false,
IsKerberos5ReadWrite = false,
IsKerberos5iReadOnly = false,
IsKerberos5iReadWrite = false,
IsKerberos5pReadOnly = false,
IsKerberos5pReadWrite = false,
AllowCifsProtocol = false,
AllowNfsV3Protocol = false,
AllowNfsV41Protocol = true,
AllowedClients = "0.0.0.0/0",
HasRootAccess = true,
}
},
ProtocolTypes =
{
"NFSv4.1"
},
ThroughputMibps = 10,
CapacityPoolResourceId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPools/pool1"),
VolumeSpecName = "ora-backup",
}
},
            };
            ArmOperation<NetAppVolumeGroupResource> lro = await netAppVolumeGroup.UpdateAsync(WaitUntil.Completed, data);
            NetAppVolumeGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppVolumeGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VolumeGroups_Create_SapHana
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_VolumeGroupsCreateSapHana()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-03-01/examples/VolumeGroups_Create_SapHana.json
            // this example is just showing the usage of "VolumeGroups_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeGroupResource created on azure
            // for more information of creating NetAppVolumeGroupResource, please refer to the document of NetAppVolumeGroupResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string volumeGroupName = "group1";
            ResourceIdentifier netAppVolumeGroupResourceId = NetAppVolumeGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, volumeGroupName);
            NetAppVolumeGroupResource netAppVolumeGroup = client.GetNetAppVolumeGroupResource(netAppVolumeGroupResourceId);

            // invoke the operation
            NetAppVolumeGroupData data = new NetAppVolumeGroupData()
            {
                Location = new AzureLocation("westus"),
                GroupMetaData = new NetAppVolumeGroupMetadata()
                {
                    GroupDescription = "Volume group",
                    ApplicationType = NetAppApplicationType.SapHana,
                    ApplicationIdentifier = "SH9",
                },
                Volumes =
{
new NetAppVolumeGroupVolume("test-data-mnt00001",107374182400L,new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRP/providers/Microsoft.Network/virtualNetworks/testvnet3/subnets/testsubnet3"))
{
Name = "test-data-mnt00001",
ServiceLevel = NetAppFileServiceLevel.Premium,
ExportRules =
{
new NetAppVolumeExportPolicyRule()
{
RuleIndex = 1,
IsUnixReadOnly = true,
IsUnixReadWrite = true,
IsKerberos5ReadOnly = false,
IsKerberos5ReadWrite = false,
IsKerberos5iReadOnly = false,
IsKerberos5iReadWrite = false,
IsKerberos5pReadOnly = false,
IsKerberos5pReadWrite = false,
AllowCifsProtocol = false,
AllowNfsV3Protocol = false,
AllowNfsV41Protocol = true,
AllowedClients = "0.0.0.0/0",
HasRootAccess = true,
}
},
ProtocolTypes =
{
"NFSv4.1"
},
ThroughputMibps = 10,
CapacityPoolResourceId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPools/pool1"),
ProximityPlacementGroupId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/cys_sjain_fcp_rg/providers/Microsoft.Compute/proximityPlacementGroups/svlqa_sjain_multivolume_ppg"),
VolumeSpecName = "data",
},new NetAppVolumeGroupVolume("test-log-mnt00001",107374182400L,new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRP/providers/Microsoft.Network/virtualNetworks/testvnet3/subnets/testsubnet3"))
{
Name = "test-log-mnt00001",
ServiceLevel = NetAppFileServiceLevel.Premium,
ExportRules =
{
new NetAppVolumeExportPolicyRule()
{
RuleIndex = 1,
IsUnixReadOnly = true,
IsUnixReadWrite = true,
IsKerberos5ReadOnly = false,
IsKerberos5ReadWrite = false,
IsKerberos5iReadOnly = false,
IsKerberos5iReadWrite = false,
IsKerberos5pReadOnly = false,
IsKerberos5pReadWrite = false,
AllowCifsProtocol = false,
AllowNfsV3Protocol = false,
AllowNfsV41Protocol = true,
AllowedClients = "0.0.0.0/0",
HasRootAccess = true,
}
},
ProtocolTypes =
{
"NFSv4.1"
},
ThroughputMibps = 10,
CapacityPoolResourceId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPools/pool1"),
ProximityPlacementGroupId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/cys_sjain_fcp_rg/providers/Microsoft.Compute/proximityPlacementGroups/svlqa_sjain_multivolume_ppg"),
VolumeSpecName = "log",
},new NetAppVolumeGroupVolume("test-shared",107374182400L,new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRP/providers/Microsoft.Network/virtualNetworks/testvnet3/subnets/testsubnet3"))
{
Name = "test-shared",
ServiceLevel = NetAppFileServiceLevel.Premium,
ExportRules =
{
new NetAppVolumeExportPolicyRule()
{
RuleIndex = 1,
IsUnixReadOnly = true,
IsUnixReadWrite = true,
IsKerberos5ReadOnly = false,
IsKerberos5ReadWrite = false,
IsKerberos5iReadOnly = false,
IsKerberos5iReadWrite = false,
IsKerberos5pReadOnly = false,
IsKerberos5pReadWrite = false,
AllowCifsProtocol = false,
AllowNfsV3Protocol = false,
AllowNfsV41Protocol = true,
AllowedClients = "0.0.0.0/0",
HasRootAccess = true,
}
},
ProtocolTypes =
{
"NFSv4.1"
},
ThroughputMibps = 10,
CapacityPoolResourceId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPools/pool1"),
ProximityPlacementGroupId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/cys_sjain_fcp_rg/providers/Microsoft.Compute/proximityPlacementGroups/svlqa_sjain_multivolume_ppg"),
VolumeSpecName = "shared",
},new NetAppVolumeGroupVolume("test-data-backup",107374182400L,new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRP/providers/Microsoft.Network/virtualNetworks/testvnet3/subnets/testsubnet3"))
{
Name = "test-data-backup",
ServiceLevel = NetAppFileServiceLevel.Premium,
ExportRules =
{
new NetAppVolumeExportPolicyRule()
{
RuleIndex = 1,
IsUnixReadOnly = true,
IsUnixReadWrite = true,
IsKerberos5ReadOnly = false,
IsKerberos5ReadWrite = false,
IsKerberos5iReadOnly = false,
IsKerberos5iReadWrite = false,
IsKerberos5pReadOnly = false,
IsKerberos5pReadWrite = false,
AllowCifsProtocol = false,
AllowNfsV3Protocol = false,
AllowNfsV41Protocol = true,
AllowedClients = "0.0.0.0/0",
HasRootAccess = true,
}
},
ProtocolTypes =
{
"NFSv4.1"
},
ThroughputMibps = 10,
CapacityPoolResourceId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPools/pool1"),
ProximityPlacementGroupId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/cys_sjain_fcp_rg/providers/Microsoft.Compute/proximityPlacementGroups/svlqa_sjain_multivolume_ppg"),
VolumeSpecName = "data-backup",
},new NetAppVolumeGroupVolume("test-log-backup",107374182400L,new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRP/providers/Microsoft.Network/virtualNetworks/testvnet3/subnets/testsubnet3"))
{
Name = "test-log-backup",
ServiceLevel = NetAppFileServiceLevel.Premium,
ExportRules =
{
new NetAppVolumeExportPolicyRule()
{
RuleIndex = 1,
IsUnixReadOnly = true,
IsUnixReadWrite = true,
IsKerberos5ReadOnly = false,
IsKerberos5ReadWrite = false,
IsKerberos5iReadOnly = false,
IsKerberos5iReadWrite = false,
IsKerberos5pReadOnly = false,
IsKerberos5pReadWrite = false,
AllowCifsProtocol = false,
AllowNfsV3Protocol = false,
AllowNfsV41Protocol = true,
AllowedClients = "0.0.0.0/0",
HasRootAccess = true,
}
},
ProtocolTypes =
{
"NFSv4.1"
},
ThroughputMibps = 10,
CapacityPoolResourceId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/myRG/providers/Microsoft.NetApp/netAppAccounts/account1/capacityPools/pool1"),
ProximityPlacementGroupId = new ResourceIdentifier("/subscriptions/d633cc2e-722b-4ae1-b636-bbd9e4c60ed9/resourceGroups/cys_sjain_fcp_rg/providers/Microsoft.Compute/proximityPlacementGroups/svlqa_sjain_multivolume_ppg"),
VolumeSpecName = "log-backup",
}
},
            };
            ArmOperation<NetAppVolumeGroupResource> lro = await netAppVolumeGroup.UpdateAsync(WaitUntil.Completed, data);
            NetAppVolumeGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppVolumeGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VolumeGroups_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_VolumeGroupsDelete()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-03-01/examples/VolumeGroups_Delete.json
            // this example is just showing the usage of "VolumeGroups_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeGroupResource created on azure
            // for more information of creating NetAppVolumeGroupResource, please refer to the document of NetAppVolumeGroupResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string volumeGroupName = "group1";
            ResourceIdentifier netAppVolumeGroupResourceId = NetAppVolumeGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, volumeGroupName);
            NetAppVolumeGroupResource netAppVolumeGroup = client.GetNetAppVolumeGroupResource(netAppVolumeGroupResourceId);

            // invoke the operation
            await netAppVolumeGroup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
