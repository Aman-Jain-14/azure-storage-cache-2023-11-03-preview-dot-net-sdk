// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the task that validates connection to Azure SQL Database Managed Instance online scenario. </summary>
    public partial class ConnectToTargetSqlMISyncTaskInput
    {
        /// <summary> Initializes a new instance of <see cref="ConnectToTargetSqlMISyncTaskInput"/>. </summary>
        /// <param name="targetConnectionInfo"> Connection information for Azure SQL Database Managed Instance. </param>
        /// <param name="azureApp"> Azure Active Directory Application the DMS instance will use to connect to the target instance of Azure SQL Database Managed Instance and the Azure Storage Account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetConnectionInfo"/> or <paramref name="azureApp"/> is null. </exception>
        public ConnectToTargetSqlMISyncTaskInput(MISqlConnectionInfo targetConnectionInfo, AzureActiveDirectoryApp azureApp)
        {
            Argument.AssertNotNull(targetConnectionInfo, nameof(targetConnectionInfo));
            Argument.AssertNotNull(azureApp, nameof(azureApp));

            TargetConnectionInfo = targetConnectionInfo;
            AzureApp = azureApp;
        }

        /// <summary> Connection information for Azure SQL Database Managed Instance. </summary>
        public MISqlConnectionInfo TargetConnectionInfo { get; set; }
        /// <summary> Azure Active Directory Application the DMS instance will use to connect to the target instance of Azure SQL Database Managed Instance and the Azure Storage Account. </summary>
        public AzureActiveDirectoryApp AzureApp { get; set; }
    }
}
