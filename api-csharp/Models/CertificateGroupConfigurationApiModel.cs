// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IIoT.OpcUa.Services.Vault.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CertificateGroupConfigurationApiModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CertificateGroupConfigurationApiModel class.
        /// </summary>
        public CertificateGroupConfigurationApiModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CertificateGroupConfigurationApiModel class.
        /// </summary>
        public CertificateGroupConfigurationApiModel(string name = default(string), string certificateType = default(string), string subjectName = default(string), int? defaultCertificateLifetime = default(int?), int? defaultCertificateKeySize = default(int?), int? defaultCertificateHashSize = default(int?), int? cACertificateLifetime = default(int?), int? cACertificateKeySize = default(int?), int? cACertificateHashSize = default(int?))
        {
            Name = name;
            CertificateType = certificateType;
            SubjectName = subjectName;
            DefaultCertificateLifetime = defaultCertificateLifetime;
            DefaultCertificateKeySize = defaultCertificateKeySize;
            DefaultCertificateHashSize = defaultCertificateHashSize;
            CACertificateLifetime = cACertificateLifetime;
            CACertificateKeySize = cACertificateKeySize;
            CACertificateHashSize = cACertificateHashSize;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CertificateType")]
        public string CertificateType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubjectName")]
        public string SubjectName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DefaultCertificateLifetime")]
        public int? DefaultCertificateLifetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DefaultCertificateKeySize")]
        public int? DefaultCertificateKeySize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DefaultCertificateHashSize")]
        public int? DefaultCertificateHashSize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CACertificateLifetime")]
        public int? CACertificateLifetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CACertificateKeySize")]
        public int? CACertificateKeySize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CACertificateHashSize")]
        public int? CACertificateHashSize { get; set; }

    }
}
