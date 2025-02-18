// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    public partial class VirtualMachineSecretsSchema :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSecretsSchema,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSecretsSchemaInternal
    {

        /// <summary>Backing field for <see cref="AdministratorAccount" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSshCredentials _administratorAccount;

        /// <summary>Admin credentials for virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSshCredentials AdministratorAccount { get => (this._administratorAccount = this._administratorAccount ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.VirtualMachineSshCredentials()); set => this._administratorAccount = value; }

        /// <summary>Password of admin account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string AdministratorAccountPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSshCredentialsInternal)AdministratorAccount).Password; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSshCredentialsInternal)AdministratorAccount).Password = value ?? null; }

        /// <summary>Private key data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string AdministratorAccountPrivateKeyData { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSshCredentialsInternal)AdministratorAccount).PrivateKeyData; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSshCredentialsInternal)AdministratorAccount).PrivateKeyData = value ?? null; }

        /// <summary>Public key data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string AdministratorAccountPublicKeyData { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSshCredentialsInternal)AdministratorAccount).PublicKeyData; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSshCredentialsInternal)AdministratorAccount).PublicKeyData = value ?? null; }

        /// <summary>Username of admin account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string AdministratorAccountUsername { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSshCredentialsInternal)AdministratorAccount).Username; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSshCredentialsInternal)AdministratorAccount).Username = value ?? null; }

        /// <summary>Internal Acessors for AdministratorAccount</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSshCredentials Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSecretsSchemaInternal.AdministratorAccount { get => (this._administratorAccount = this._administratorAccount ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.VirtualMachineSshCredentials()); set { {_administratorAccount = value;} } }

        /// <summary>Creates an new <see cref="VirtualMachineSecretsSchema" /> instance.</summary>
        public VirtualMachineSecretsSchema()
        {

        }
    }
    public partial interface IVirtualMachineSecretsSchema :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>Password of admin account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Password of admin account",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string AdministratorAccountPassword { get; set; }
        /// <summary>Private key data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Private key data",
        SerializedName = @"privateKeyData",
        PossibleTypes = new [] { typeof(string) })]
        string AdministratorAccountPrivateKeyData { get; set; }
        /// <summary>Public key data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Public key data",
        SerializedName = @"publicKeyData",
        PossibleTypes = new [] { typeof(string) })]
        string AdministratorAccountPublicKeyData { get; set; }
        /// <summary>Username of admin account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Username of admin account",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string AdministratorAccountUsername { get; set; }

    }
    internal partial interface IVirtualMachineSecretsSchemaInternal

    {
        /// <summary>Admin credentials for virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IVirtualMachineSshCredentials AdministratorAccount { get; set; }
        /// <summary>Password of admin account</summary>
        string AdministratorAccountPassword { get; set; }
        /// <summary>Private key data</summary>
        string AdministratorAccountPrivateKeyData { get; set; }
        /// <summary>Public key data</summary>
        string AdministratorAccountPublicKeyData { get; set; }
        /// <summary>Username of admin account</summary>
        string AdministratorAccountUsername { get; set; }

    }
}