// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The storage configuration profile for the provisioned cluster. </summary>
    public partial class StorageProfile
    {
        /// <summary> Initializes a new instance of <see cref="StorageProfile"/>. </summary>
        public StorageProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageProfile"/>. </summary>
        /// <param name="smbCsiDriver"> SMB CSI Driver settings for the storage profile. </param>
        /// <param name="nfsCsiDriver"> NFS CSI Driver settings for the storage profile. </param>
        internal StorageProfile(StorageProfileSmbCSIDriver smbCsiDriver, StorageProfileNfsCSIDriver nfsCsiDriver)
        {
            SmbCsiDriver = smbCsiDriver;
            NfsCsiDriver = nfsCsiDriver;
        }

        /// <summary> SMB CSI Driver settings for the storage profile. </summary>
        internal StorageProfileSmbCSIDriver SmbCsiDriver { get; set; }
        /// <summary> Indicates whether to enable SMB CSI Driver. The default value is true. </summary>
        public bool? IsSmbCsiDriverEnabled
        {
            get => SmbCsiDriver is null ? default : SmbCsiDriver.IsSmbCsiDriverEnabled;
            set
            {
                if (SmbCsiDriver is null)
                    SmbCsiDriver = new StorageProfileSmbCSIDriver();
                SmbCsiDriver.IsSmbCsiDriverEnabled = value;
            }
        }

        /// <summary> NFS CSI Driver settings for the storage profile. </summary>
        internal StorageProfileNfsCSIDriver NfsCsiDriver { get; set; }
        /// <summary> Indicates whether to enable NFS CSI Driver. The default value is true. </summary>
        public bool? IsNfsCsiDriverEnabled
        {
            get => NfsCsiDriver is null ? default : NfsCsiDriver.IsNfsCsiDriverEnabled;
            set
            {
                if (NfsCsiDriver is null)
                    NfsCsiDriver = new StorageProfileNfsCSIDriver();
                NfsCsiDriver.IsNfsCsiDriverEnabled = value;
            }
        }
    }
}
