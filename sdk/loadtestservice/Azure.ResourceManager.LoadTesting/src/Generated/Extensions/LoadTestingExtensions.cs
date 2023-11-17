// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.LoadTesting.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.LoadTesting
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.LoadTesting. </summary>
    public static partial class LoadTestingExtensions
    {
        private static MockableLoadTestingArmClient GetMockableLoadTestingArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableLoadTestingArmClient(client0));
        }

        private static MockableLoadTestingResourceGroupResource GetMockableLoadTestingResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableLoadTestingResourceGroupResource(client, resource.Id));
        }

        private static MockableLoadTestingSubscriptionResource GetMockableLoadTestingSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableLoadTestingSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="LoadTestingQuotaResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LoadTestingQuotaResource.CreateResourceIdentifier" /> to create a <see cref="LoadTestingQuotaResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLoadTestingArmClient.GetLoadTestingQuotaResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="LoadTestingQuotaResource" /> object. </returns>
        public static LoadTestingQuotaResource GetLoadTestingQuotaResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableLoadTestingArmClient(client).GetLoadTestingQuotaResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="LoadTestingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LoadTestingResource.CreateResourceIdentifier" /> to create a <see cref="LoadTestingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLoadTestingArmClient.GetLoadTestingResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="LoadTestingResource" /> object. </returns>
        public static LoadTestingResource GetLoadTestingResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableLoadTestingArmClient(client).GetLoadTestingResource(id);
        }

        /// <summary>
        /// Gets a collection of LoadTestingResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLoadTestingResourceGroupResource.GetLoadTestingResources()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of LoadTestingResources and their operations over a LoadTestingResource. </returns>
        public static LoadTestingResourceCollection GetLoadTestingResources(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableLoadTestingResourceGroupResource(resourceGroupResource).GetLoadTestingResources();
        }

        /// <summary>
        /// Get a LoadTest resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/loadTests/{loadTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadTests_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLoadTestingResourceGroupResource.GetLoadTestingResourceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="loadTestName"> Load Test name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="loadTestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="loadTestName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<LoadTestingResource>> GetLoadTestingResourceAsync(this ResourceGroupResource resourceGroupResource, string loadTestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableLoadTestingResourceGroupResource(resourceGroupResource).GetLoadTestingResourceAsync(loadTestName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a LoadTest resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/loadTests/{loadTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadTests_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLoadTestingResourceGroupResource.GetLoadTestingResource(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="loadTestName"> Load Test name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="loadTestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="loadTestName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<LoadTestingResource> GetLoadTestingResource(this ResourceGroupResource resourceGroupResource, string loadTestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableLoadTestingResourceGroupResource(resourceGroupResource).GetLoadTestingResource(loadTestName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of LoadTestingQuotaResources in the SubscriptionResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLoadTestingSubscriptionResource.GetAllLoadTestingQuota(AzureLocation)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An object representing collection of LoadTestingQuotaResources and their operations over a LoadTestingQuotaResource. </returns>
        public static LoadTestingQuotaCollection GetAllLoadTestingQuota(this SubscriptionResource subscriptionResource, AzureLocation location)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableLoadTestingSubscriptionResource(subscriptionResource).GetAllLoadTestingQuota(location);
        }

        /// <summary>
        /// Get the available quota for a quota bucket per region per subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas/{quotaBucketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLoadTestingSubscriptionResource.GetLoadTestingQuotaAsync(AzureLocation,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="quotaBucketName"> Quota Bucket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="quotaBucketName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="quotaBucketName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<LoadTestingQuotaResource>> GetLoadTestingQuotaAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string quotaBucketName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableLoadTestingSubscriptionResource(subscriptionResource).GetLoadTestingQuotaAsync(location, quotaBucketName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the available quota for a quota bucket per region per subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/locations/{location}/quotas/{quotaBucketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quotas_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLoadTestingSubscriptionResource.GetLoadTestingQuota(AzureLocation,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="quotaBucketName"> Quota Bucket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="quotaBucketName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="quotaBucketName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<LoadTestingQuotaResource> GetLoadTestingQuota(this SubscriptionResource subscriptionResource, AzureLocation location, string quotaBucketName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableLoadTestingSubscriptionResource(subscriptionResource).GetLoadTestingQuota(location, quotaBucketName, cancellationToken);
        }

        /// <summary>
        /// Lists loadtests resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/loadTests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadTests_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLoadTestingSubscriptionResource.GetLoadTestingResources(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="LoadTestingResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<LoadTestingResource> GetLoadTestingResourcesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableLoadTestingSubscriptionResource(subscriptionResource).GetLoadTestingResourcesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists loadtests resources in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.LoadTestService/loadTests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadTests_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableLoadTestingSubscriptionResource.GetLoadTestingResources(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="LoadTestingResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<LoadTestingResource> GetLoadTestingResources(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableLoadTestingSubscriptionResource(subscriptionResource).GetLoadTestingResources(cancellationToken);
        }
    }
}
