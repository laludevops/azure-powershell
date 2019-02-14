﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Commands.StorageSync.Interop.Enums
{
    /// <summary>
    /// Enum ServerRegistrationErrorCode
    /// </summary>
    public enum ServerRegistrationErrorCode
    {
        /// <summary>
        /// The generic error
        /// </summary>
        GenericError,
        /// <summary>
        /// The co create instance failed
        /// </summary>
        CoCreateInstanceFailed,
        /// <summary>
        /// The monitoring data path is null or empty
        /// </summary>
        MonitoringDataPathIsNullOrEmpty,
        /// <summary>
        /// The monitoring data path is invalid
        /// </summary>
        MonitoringDataPathIsInvalid,
        /// <summary>
        /// The register synchronize server error
        /// </summary>
        RegisterSyncServerError,
        /// <summary>
        /// The get synchronize server certificate error
        /// </summary>
        GetSyncServerCertificateError,
        /// <summary>
        /// The convert server certificate error
        /// </summary>
        ConvertServerCertificateError,
        /// <summary>
        /// The server name is null or empty
        /// </summary>
        ServerNameIsNullOrEmpty,
        /// <summary>
        /// The server identifier is null or empty
        /// </summary>
        ServerIdIsNullOrEmpty,
        /// <summary>
        /// The invalid registration response
        /// </summary>
        InvalidRegistrationResponse,
        /// <summary>
        /// The unable to get agent installer path registry key value
        /// </summary>
        UnableToGetAgentInstallerPathRegistryKeyValue,
        /// <summary>
        /// The server resource is null
        /// </summary>
        ServerResourceIsNull,
        /// <summary>
        /// The service endpoint is not set
        /// </summary>
        ServiceEndpointIsNotSet,
        /// <summary>
        /// The validate synchronize server failed
        /// </summary>
        ValidateSyncServerFailed,
        /// <summary>
        /// The ensure synchronize server certificate failed
        /// </summary>
        EnsureSyncServerCertificateFailed,
        /// <summary>
        /// The get synchronize server certificate failed
        /// </summary>
        GetSyncServerCertificateFailed,
        /// <summary>
        /// The get synchronize server identifier failed
        /// </summary>
        GetSyncServerIdFailed,
        /// <summary>
        /// The get cluster information failed
        /// </summary>
        GetClusterInfoFailed,
        /// <summary>
        /// The persist synchronize server registration failed
        /// </summary>
        PersistSyncServerRegistrationFailed,
        /// <summary>
        /// The register online synchronize registration failed
        /// </summary>
        RegisterOnlineSyncRegistrationFailed,
        /// <summary>
        /// The process synchronize registration failed
        /// </summary>
        ProcessSyncRegistrationFailed,
        /// <summary>
        /// The synchronize server already exists
        /// </summary>
        SyncServerAlreadyExists,
        /// <summary>
        /// The register monitoring agent failed
        /// </summary>
        RegisterMonitoringAgentFailed,
        /// <summary>
        /// The register synchronize server access denied
        /// </summary>
        RegisterSyncServerAccessDenied,
        /// <summary>
        /// The synchronize server not found
        /// </summary>
        SyncServerNotFound,

    }
}
