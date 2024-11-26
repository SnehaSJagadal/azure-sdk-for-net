// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ServiceWorkspaceDiagnosticCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ApiManagementListWorkspaceDiagnostics()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementListWorkspaceDiagnostics.json
            // this example is just showing the usage of "WorkspaceDiagnostic_ListByWorkspace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceContractResource created on azure
            // for more information of creating WorkspaceContractResource, please refer to the document of WorkspaceContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            ResourceIdentifier workspaceContractResourceId = WorkspaceContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId);
            WorkspaceContractResource workspaceContract = client.GetWorkspaceContractResource(workspaceContractResourceId);

            // get the collection of this ServiceWorkspaceDiagnosticResource
            ServiceWorkspaceDiagnosticCollection collection = workspaceContract.GetServiceWorkspaceDiagnostics();

            // invoke the operation and iterate over the result
            await foreach (ServiceWorkspaceDiagnosticResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DiagnosticContractData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetWorkspaceDiagnostic()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetWorkspaceDiagnostic.json
            // this example is just showing the usage of "WorkspaceDiagnostic_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceContractResource created on azure
            // for more information of creating WorkspaceContractResource, please refer to the document of WorkspaceContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            ResourceIdentifier workspaceContractResourceId = WorkspaceContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId);
            WorkspaceContractResource workspaceContract = client.GetWorkspaceContractResource(workspaceContractResourceId);

            // get the collection of this ServiceWorkspaceDiagnosticResource
            ServiceWorkspaceDiagnosticCollection collection = workspaceContract.GetServiceWorkspaceDiagnostics();

            // invoke the operation
            string diagnosticId = "applicationinsights";
            ServiceWorkspaceDiagnosticResource result = await collection.GetAsync(diagnosticId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiagnosticContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ApiManagementGetWorkspaceDiagnostic()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetWorkspaceDiagnostic.json
            // this example is just showing the usage of "WorkspaceDiagnostic_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceContractResource created on azure
            // for more information of creating WorkspaceContractResource, please refer to the document of WorkspaceContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            ResourceIdentifier workspaceContractResourceId = WorkspaceContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId);
            WorkspaceContractResource workspaceContract = client.GetWorkspaceContractResource(workspaceContractResourceId);

            // get the collection of this ServiceWorkspaceDiagnosticResource
            ServiceWorkspaceDiagnosticCollection collection = workspaceContract.GetServiceWorkspaceDiagnostics();

            // invoke the operation
            string diagnosticId = "applicationinsights";
            bool result = await collection.ExistsAsync(diagnosticId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ApiManagementGetWorkspaceDiagnostic()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetWorkspaceDiagnostic.json
            // this example is just showing the usage of "WorkspaceDiagnostic_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceContractResource created on azure
            // for more information of creating WorkspaceContractResource, please refer to the document of WorkspaceContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            ResourceIdentifier workspaceContractResourceId = WorkspaceContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId);
            WorkspaceContractResource workspaceContract = client.GetWorkspaceContractResource(workspaceContractResourceId);

            // get the collection of this ServiceWorkspaceDiagnosticResource
            ServiceWorkspaceDiagnosticCollection collection = workspaceContract.GetServiceWorkspaceDiagnostics();

            // invoke the operation
            string diagnosticId = "applicationinsights";
            NullableResponse<ServiceWorkspaceDiagnosticResource> response = await collection.GetIfExistsAsync(diagnosticId);
            ServiceWorkspaceDiagnosticResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DiagnosticContractData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ApiManagementCreateWorkspaceDiagnostic()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateWorkspaceDiagnostic.json
            // this example is just showing the usage of "WorkspaceDiagnostic_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceContractResource created on azure
            // for more information of creating WorkspaceContractResource, please refer to the document of WorkspaceContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            ResourceIdentifier workspaceContractResourceId = WorkspaceContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId);
            WorkspaceContractResource workspaceContract = client.GetWorkspaceContractResource(workspaceContractResourceId);

            // get the collection of this ServiceWorkspaceDiagnosticResource
            ServiceWorkspaceDiagnosticCollection collection = workspaceContract.GetServiceWorkspaceDiagnostics();

            // invoke the operation
            string diagnosticId = "applicationinsights";
            DiagnosticContractData data = new DiagnosticContractData()
            {
                AlwaysLog = AlwaysLog.AllErrors,
                LoggerId = "/workspaces/wks1/loggers/azuremonitor",
                Sampling = new SamplingSettings()
                {
                    SamplingType = SamplingType.Fixed,
                    Percentage = 50,
                },
                Frontend = new PipelineDiagnosticSettings()
                {
                    Request = new HttpMessageDiagnostic()
                    {
                        Headers =
{
"Content-type"
},
                        BodyBytes = 512,
                    },
                    Response = new HttpMessageDiagnostic()
                    {
                        Headers =
{
"Content-type"
},
                        BodyBytes = 512,
                    },
                },
                Backend = new PipelineDiagnosticSettings()
                {
                    Request = new HttpMessageDiagnostic()
                    {
                        Headers =
{
"Content-type"
},
                        BodyBytes = 512,
                    },
                    Response = new HttpMessageDiagnostic()
                    {
                        Headers =
{
"Content-type"
},
                        BodyBytes = 512,
                    },
                },
            };
            ArmOperation<ServiceWorkspaceDiagnosticResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, diagnosticId, data);
            ServiceWorkspaceDiagnosticResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiagnosticContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
