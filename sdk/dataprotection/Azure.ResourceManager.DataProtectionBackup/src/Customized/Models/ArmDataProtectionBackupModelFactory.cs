// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    [CodeGenSuppress("BackupVaultSecuritySettings", typeof(BackupVaultSoftDeleteSettings), typeof(ImmutabilitySettings), typeof(BackupVaultEncryptionSettings))]
    public static partial class ArmDataProtectionBackupModelFactory
    {
    }
}