// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AssetStorageEncryptionFormat.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AssetStorageEncryptionFormat
    {
        /// <summary>
        /// The Asset does not use client-side storage encryption (this is the
        /// only allowed value for new Assets).
        /// </summary>
        [EnumMember(Value = "None")]
        None,
        /// <summary>
        /// The Asset is encrypted with Media Services client-side encryption.
        /// </summary>
        [EnumMember(Value = "MediaStorageClientEncryption")]
        MediaStorageClientEncryption
    }
    internal static class AssetStorageEncryptionFormatEnumExtension
    {
        internal static string ToSerializedValue(this AssetStorageEncryptionFormat? value)
        {
            return value == null ? null : ((AssetStorageEncryptionFormat)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AssetStorageEncryptionFormat value)
        {
            switch( value )
            {
                case AssetStorageEncryptionFormat.None:
                    return "None";
                case AssetStorageEncryptionFormat.MediaStorageClientEncryption:
                    return "MediaStorageClientEncryption";
            }
            return null;
        }

        internal static AssetStorageEncryptionFormat? ParseAssetStorageEncryptionFormat(this string value)
        {
            switch( value )
            {
                case "None":
                    return AssetStorageEncryptionFormat.None;
                case "MediaStorageClientEncryption":
                    return AssetStorageEncryptionFormat.MediaStorageClientEncryption;
            }
            return null;
        }
    }
}
