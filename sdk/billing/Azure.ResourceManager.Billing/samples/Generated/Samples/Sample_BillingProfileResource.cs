// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Billing.Models;

namespace Azure.ResourceManager.Billing.Samples
{
    public partial class Sample_BillingProfileResource
    {
        // AvailableBalanceGetByBillingProfile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetBillingProfileAvailableBalance_AvailableBalanceGetByBillingProfile()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/availableBalanceGetByBillingProfile.json
            // this example is just showing the usage of "AvailableBalances_GetByBillingProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // invoke the operation
            BillingAvailableBalanceData result = await billingProfile.GetBillingProfileAvailableBalanceAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // BillingPermissionsListByBillingProfile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetBillingPermissions_BillingPermissionsListByBillingProfile()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingPermissionsListByBillingProfile.json
            // this example is just showing the usage of "BillingPermissions_ListByBillingProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "10000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // invoke the operation and iterate over the result
            await foreach (BillingPermission item in billingProfile.GetBillingPermissionsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // CheckAccessByBillingProfile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckAccessBillingPermissions_CheckAccessByBillingProfile()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/checkAccessByBillingProfile.json
            // this example is just showing the usage of "BillingPermissions_CheckAccessByBillingProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "10000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // invoke the operation and iterate over the result
            BillingCheckAccessContent content = new BillingCheckAccessContent()
            {
                Actions =
{
"Microsoft.Billing/billingAccounts/read","Microsoft.Subscription/subscriptions/write"
},
            };
            await foreach (BillingCheckAccessResult item in billingProfile.CheckAccessBillingPermissionsAsync(content))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // BillingProfilesValidateDeleteEligibilityFailure
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ValidateDeleteEligibility_BillingProfilesValidateDeleteEligibilityFailure()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingProfilesValidateDeleteEligibilityFailure.json
            // this example is just showing the usage of "BillingProfiles_ValidateDeleteEligibility" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // invoke the operation
            DeleteBillingProfileEligibilityResult result = await billingProfile.ValidateDeleteEligibilityAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // BillingProfilesValidateDeleteEligibilitySuccess
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ValidateDeleteEligibility_BillingProfilesValidateDeleteEligibilitySuccess()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingProfilesValidateDeleteEligibilitySuccess.json
            // this example is just showing the usage of "BillingProfiles_ValidateDeleteEligibility" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // invoke the operation
            DeleteBillingProfileEligibilityResult result = await billingProfile.ValidateDeleteEligibilityAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // BillingProfilesDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_BillingProfilesDelete()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingProfilesDelete.json
            // this example is just showing the usage of "BillingProfiles_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // invoke the operation
            await billingProfile.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // BillingProfilesGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_BillingProfilesGet()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingProfilesGet.json
            // this example is just showing the usage of "BillingProfiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // invoke the operation
            BillingProfileResource result = await billingProfile.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // BillingProfilesCreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_BillingProfilesCreateOrUpdate()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingProfilesCreateOrUpdate.json
            // this example is just showing the usage of "BillingProfiles_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // invoke the operation
            BillingProfileData data = new BillingProfileData()
            {
                Properties = new BillingProfileProperties()
                {
                    BillTo = new BillingAddressDetails("Test Address1", "US")
                    {
                        AddressLine2 = "Test Address2",
                        AddressLine3 = "Test Address3",
                        City = "City",
                        CompanyName = "Contoso",
                        Email = "abc@contoso.com",
                        FirstName = "Test",
                        LastName = "User",
                        PhoneNumber = "000-000-0000",
                        PostalCode = "00000",
                        Region = "WA",
                        IsValidAddress = true,
                    },
                    DisplayName = "Billing Profile 1",
                    EnabledAzurePlans =
{
new BillingAzurePlan()
{
SkuId = "0001",
},new BillingAzurePlan()
{
SkuId = "0002",
}
},
                    IsInvoiceEmailOptIn = true,
                    PoNumber = "ABC12345",
                    ShipTo = new BillingAddressDetails("Test Address1", "US")
                    {
                        AddressLine2 = "Test Address2",
                        AddressLine3 = "Test Address3",
                        City = "City",
                        CompanyName = "Contoso",
                        Email = "abc@contoso.com",
                        FirstName = "Test",
                        LastName = "User",
                        PhoneNumber = "000-000-0000",
                        PostalCode = "00000",
                        Region = "WA",
                        IsValidAddress = true,
                    },
                },
            };
            ArmOperation<BillingProfileResource> lro = await billingProfile.UpdateAsync(WaitUntil.Completed, data);
            BillingProfileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // BillingRequestsListByBillingProfile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetBillingRequests_BillingRequestsListByBillingProfile()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingRequestsListByBillingProfile.json
            // this example is just showing the usage of "BillingRequests_ListByBillingProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // invoke the operation and iterate over the result
            BillingProfileResourceGetBillingRequestsOptions options = new BillingProfileResourceGetBillingRequestsOptions() { };
            await foreach (BillingRequestResource item in billingProfile.GetBillingRequestsAsync(options))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingRequestData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // BillingRoleAssignmentCreateByBillingProfile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateByBillingProfileBillingRoleAssignment_BillingRoleAssignmentCreateByBillingProfile()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingRoleAssignmentCreateByBillingProfile.json
            // this example is just showing the usage of "BillingRoleAssignments_CreateByBillingProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2018-09-30";
            string billingProfileName = "BKM6-54VH-BG7-PGB";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // invoke the operation
            BillingRoleAssignmentProperties billingRoleAssignmentProperties = new BillingRoleAssignmentProperties(new ResourceIdentifier("/providers/Microsoft.Billing/billingAccounts/00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2018-09-30/billingProfiles/BKM6-54VH-BG7-PGB/billingRoleDefinitions/10000000-aaaa-bbbb-cccc-100000000000"))
            {
                PrincipalId = "00000000-0000-0000-0000-000000000000",
                PrincipalTenantId = Guid.Parse("076915e7-de10-4323-bb34-a58c904068bb"),
                UserEmailAddress = "john@contoso.com",
            };
            ArmOperation<BillingRoleAssignmentData> lro = await billingProfile.CreateByBillingProfileBillingRoleAssignmentAsync(WaitUntil.Completed, billingRoleAssignmentProperties);
            BillingRoleAssignmentData result = lro.Value;

            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {result.Id}");
        }

        // ResolveBillingRoleAssignmentByBillingProfile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ResolveByBillingProfileBillingRoleAssignment_ResolveBillingRoleAssignmentByBillingProfile()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/resolveBillingRoleAssignmentByBillingProfile.json
            // this example is just showing the usage of "BillingRoleAssignments_ResolveByBillingProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2018-09-30";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // invoke the operation
            ArmOperation<BillingRoleAssignmentListResult> lro = await billingProfile.ResolveByBillingProfileBillingRoleAssignmentAsync(WaitUntil.Completed);
            BillingRoleAssignmentListResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // InvoicesListByBillingProfile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetInvoices_InvoicesListByBillingProfile()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/invoicesListByBillingProfile.json
            // this example is just showing the usage of "Invoices_ListByBillingProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // invoke the operation and iterate over the result
            BillingProfileResourceGetInvoicesOptions options = new BillingProfileResourceGetInvoicesOptions() { PeriodStartDate = DateTimeOffset.Parse("2023-01-01"), PeriodEndDate = DateTimeOffset.Parse("2023-06-30") };
            await foreach (BillingInvoiceData item in billingProfile.GetInvoicesAsync(options))
            {
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {item.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ProductsListByBillingProfile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetProducts_ProductsListByBillingProfile()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/productsListByBillingProfile.json
            // this example is just showing the usage of "Products_ListByBillingProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "a1a9c77e-4cec-4a6c-a089-867d973a6074:a80d3b1f-c626-4e5e-82ed-1173bd91c838_2019-05-31";
            string billingProfileName = "ea36e548-1505-41db-bebc-46fff3d37998";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // invoke the operation and iterate over the result
            BillingProfileResourceGetProductsOptions options = new BillingProfileResourceGetProductsOptions() { };
            await foreach (BillingProductResource item in billingProfile.GetProductsAsync(options))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingProductData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ReservationsListByBillingProfile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetReservations_ReservationsListByBillingProfile()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/reservationsListByBillingProfile.json
            // this example is just showing the usage of "Reservations_ListByBillingProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "AAAA-AAAA-AAA-AAA";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // invoke the operation and iterate over the result
            BillingProfileResourceGetReservationsOptions options = new BillingProfileResourceGetReservationsOptions() { SelectedState = "Succeeded" };
            await foreach (BillingReservationResource item in billingProfile.GetReservationsAsync(options))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingReservationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // TransactionsListByBillingProfile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetTransactions_TransactionsListByBillingProfile()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/transactionsListByBillingProfile.json
            // this example is just showing the usage of "Transactions_ListByBillingProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingProfileResource created on azure
            // for more information of creating BillingProfileResource, please refer to the document of BillingProfileResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            ResourceIdentifier billingProfileResourceId = BillingProfileResource.CreateResourceIdentifier(billingAccountName, billingProfileName);
            BillingProfileResource billingProfile = client.GetBillingProfileResource(billingProfileResourceId);

            // invoke the operation and iterate over the result
            BillingProfileResourceGetTransactionsOptions options = new BillingProfileResourceGetTransactionsOptions(periodStartDate: DateTimeOffset.Parse("2024-04-01"), periodEndDate: DateTimeOffset.Parse("2023-05-30"), type: TransactionType.Billed) { Filter = "properties/date gt '2020-10-01'", Search = "storage" };
            await foreach (BillingTransactionData item in billingProfile.GetTransactionsAsync(options))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
