// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for task that migrates SQL Server databases to Azure SQL Database Managed Instance online scenario. </summary>
    public partial class MigrateSqlServerSqlMISyncTaskInput : SqlServerSqlMISyncTaskInput
    {
        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlMISyncTaskInput"/>. </summary>
        /// <param name="selectedDatabases"> Databases to migrate. </param>
        /// <param name="storageResourceId"> Fully qualified resourceId of storage. </param>
        /// <param name="sourceConnectionInfo"> Connection information for source SQL Server. </param>
        /// <param name="targetConnectionInfo"> Connection information for Azure SQL Database Managed Instance. </param>
        /// <param name="azureApp"> Azure Active Directory Application the DMS instance will use to connect to the target instance of Azure SQL Database Managed Instance and the Azure Storage Account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="selectedDatabases"/>, <paramref name="storageResourceId"/>, <paramref name="sourceConnectionInfo"/>, <paramref name="targetConnectionInfo"/> or <paramref name="azureApp"/> is null. </exception>
        public MigrateSqlServerSqlMISyncTaskInput(IEnumerable<MigrateSqlServerSqlMIDatabaseInput> selectedDatabases, string storageResourceId, SqlConnectionInfo sourceConnectionInfo, MISqlConnectionInfo targetConnectionInfo, AzureActiveDirectoryApp azureApp) : base(selectedDatabases, storageResourceId, sourceConnectionInfo, targetConnectionInfo, azureApp)
        {
            Argument.AssertNotNull(selectedDatabases, nameof(selectedDatabases));
            Argument.AssertNotNull(storageResourceId, nameof(storageResourceId));
            Argument.AssertNotNull(sourceConnectionInfo, nameof(sourceConnectionInfo));
            Argument.AssertNotNull(targetConnectionInfo, nameof(targetConnectionInfo));
            Argument.AssertNotNull(azureApp, nameof(azureApp));
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlMISyncTaskInput"/>. </summary>
        /// <param name="selectedDatabases"> Databases to migrate. </param>
        /// <param name="backupFileShare"> Backup file share information for all selected databases. </param>
        /// <param name="storageResourceId"> Fully qualified resourceId of storage. </param>
        /// <param name="sourceConnectionInfo"> Connection information for source SQL Server. </param>
        /// <param name="targetConnectionInfo"> Connection information for Azure SQL Database Managed Instance. </param>
        /// <param name="azureApp"> Azure Active Directory Application the DMS instance will use to connect to the target instance of Azure SQL Database Managed Instance and the Azure Storage Account. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="numberOfParallelDatabaseMigrations"> Number of database migrations to start in parallel. </param>
        internal MigrateSqlServerSqlMISyncTaskInput(IList<MigrateSqlServerSqlMIDatabaseInput> selectedDatabases, FileShare backupFileShare, string storageResourceId, SqlConnectionInfo sourceConnectionInfo, MISqlConnectionInfo targetConnectionInfo, AzureActiveDirectoryApp azureApp, IDictionary<string, BinaryData> serializedAdditionalRawData, float? numberOfParallelDatabaseMigrations) : base(selectedDatabases, backupFileShare, storageResourceId, sourceConnectionInfo, targetConnectionInfo, azureApp, serializedAdditionalRawData)
        {
            NumberOfParallelDatabaseMigrations = numberOfParallelDatabaseMigrations;
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlMISyncTaskInput"/> for deserialization. </summary>
        internal MigrateSqlServerSqlMISyncTaskInput()
        {
        }

        /// <summary> Number of database migrations to start in parallel. </summary>
        public float? NumberOfParallelDatabaseMigrations { get; set; }
    }
}
