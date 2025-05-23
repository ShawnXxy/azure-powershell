// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Extensions;

    /// <summary>Defines a TCP port on which a `BrokerListener` listens.</summary>
    public partial class ListenerPort :
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IListenerPort,
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IListenerPortInternal
    {

        /// <summary>Backing field for <see cref="AuthenticationRef" /> property.</summary>
        private string _authenticationRef;

        /// <summary>Reference to client authentication settings. Omit to disable authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        public string AuthenticationRef { get => this._authenticationRef; set => this._authenticationRef = value; }

        /// <summary>Backing field for <see cref="AuthorizationRef" /> property.</summary>
        private string _authorizationRef;

        /// <summary>Reference to client authorization settings. Omit to disable authorization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        public string AuthorizationRef { get => this._authorizationRef; set => this._authorizationRef = value; }

        /// <summary>
        /// Lifetime of certificate. Must be specified using a Go time.Duration format (h|m|s). E.g. 240h for 240 hours and 45m for
        /// 45 minutes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string CertManagerCertificateSpecDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).CertManagerCertificateSpecDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).CertManagerCertificateSpecDuration = value ?? null; }

        /// <summary>
        /// When to begin renewing certificate. Must be specified using a Go time.Duration format (h|m|s). E.g. 240h for 240 hours
        /// and 45m for 45 minutes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string CertManagerCertificateSpecRenewBefore { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).CertManagerCertificateSpecRenewBefore; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).CertManagerCertificateSpecRenewBefore = value ?? null; }

        /// <summary>
        /// Secret for storing server certificate. Any existing data will be overwritten. This is a reference to the secret through
        /// an identifying name, not the secret itself.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string CertManagerCertificateSpecSecretName { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).CertManagerCertificateSpecSecretName; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).CertManagerCertificateSpecSecretName = value ?? null; }

        /// <summary>group of issuer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string IssuerRefGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).IssuerRefGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).IssuerRefGroup = value ?? null; }

        /// <summary>kind of issuer (Issuer or ClusterIssuer).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string IssuerRefKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).IssuerRefKind; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).IssuerRefKind = value ?? null; }

        /// <summary>name of issuer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string IssuerRefName { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).IssuerRefName; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).IssuerRefName = value ?? null; }

        /// <summary>
        /// Kubernetes secret containing an X.509 client certificate. This is a reference to the secret through an identifying name,
        /// not the secret itself.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string ManualSecretRef { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).ManualSecretRef; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).ManualSecretRef = value ?? null; }

        /// <summary>Internal Acessors for CertManagerCertificateSpecIssuerRef</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ICertManagerIssuerRef Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IListenerPortInternal.CertManagerCertificateSpecIssuerRef { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).CertManagerCertificateSpecIssuerRef; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).CertManagerCertificateSpecIssuerRef = value; }

        /// <summary>Internal Acessors for CertManagerCertificateSpecPrivateKey</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ICertManagerPrivateKey Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IListenerPortInternal.CertManagerCertificateSpecPrivateKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).CertManagerCertificateSpecPrivateKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).CertManagerCertificateSpecPrivateKey = value; }

        /// <summary>Internal Acessors for CertManagerCertificateSpecSan</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ISanForCert Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IListenerPortInternal.CertManagerCertificateSpecSan { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).CertManagerCertificateSpecSan; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).CertManagerCertificateSpecSan = value; }

        /// <summary>Internal Acessors for Tl</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethod Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IListenerPortInternal.Tl { get => (this._tl = this._tl ?? new Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.TlsCertMethod()); set { {_tl = value;} } }

        /// <summary>Internal Acessors for TlCertManagerCertificateSpec</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ICertManagerCertificateSpec Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IListenerPortInternal.TlCertManagerCertificateSpec { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).CertManagerCertificateSpec; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).CertManagerCertificateSpec = value; }

        /// <summary>Internal Acessors for TlManual</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IX509ManualCertificate Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IListenerPortInternal.TlManual { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).Manual; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).Manual = value; }

        /// <summary>Backing field for <see cref="NodePort" /> property.</summary>
        private int? _nodePort;

        /// <summary>
        /// Kubernetes node port. Only relevant when this port is associated with a `NodePort` listener.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        public int? NodePort { get => this._nodePort; set => this._nodePort = value; }

        /// <summary>Backing field for <see cref="Port" /> property.</summary>
        private int _port;

        /// <summary>TCP port for accepting client connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        public int Port { get => this._port; set => this._port = value; }

        /// <summary>algorithm for private key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string PrivateKeyAlgorithm { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).PrivateKeyAlgorithm; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).PrivateKeyAlgorithm = value ?? null; }

        /// <summary>cert-manager private key rotationPolicy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string PrivateKeyRotationPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).PrivateKeyRotationPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).PrivateKeyRotationPolicy = value ?? null; }

        /// <summary>Backing field for <see cref="Protocol" /> property.</summary>
        private string _protocol;

        /// <summary>Protocol to use for client connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        public string Protocol { get => this._protocol; set => this._protocol = value; }

        /// <summary>DNS SANs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> SanDns { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).SanDns; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).SanDns = value ?? null /* arrayOf */; }

        /// <summary>IP address SANs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> SanIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).SanIP; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).SanIP = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Tl" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethod _tl;

        /// <summary>TLS server certificate settings for this port. Omit to disable TLS.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethod Tl { get => (this._tl = this._tl ?? new Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.TlsCertMethod()); set => this._tl = value; }

        /// <summary>Mode of TLS server certificate management.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Inlined)]
        public string TlMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).Mode; set => ((Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethodInternal)Tl).Mode = value ?? null; }

        /// <summary>Creates an new <see cref="ListenerPort" /> instance.</summary>
        public ListenerPort()
        {

        }
    }
    /// Defines a TCP port on which a `BrokerListener` listens.
    public partial interface IListenerPort :
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.IJsonSerializable
    {
        /// <summary>Reference to client authentication settings. Omit to disable authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Reference to client authentication settings. Omit to disable authentication.",
        SerializedName = @"authenticationRef",
        PossibleTypes = new [] { typeof(string) })]
        string AuthenticationRef { get; set; }
        /// <summary>Reference to client authorization settings. Omit to disable authorization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Reference to client authorization settings. Omit to disable authorization.",
        SerializedName = @"authorizationRef",
        PossibleTypes = new [] { typeof(string) })]
        string AuthorizationRef { get; set; }
        /// <summary>
        /// Lifetime of certificate. Must be specified using a Go time.Duration format (h|m|s). E.g. 240h for 240 hours and 45m for
        /// 45 minutes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Lifetime of certificate. Must be specified using a Go time.Duration format (h|m|s). E.g. 240h for 240 hours and 45m for 45 minutes.",
        SerializedName = @"duration",
        PossibleTypes = new [] { typeof(string) })]
        string CertManagerCertificateSpecDuration { get; set; }
        /// <summary>
        /// When to begin renewing certificate. Must be specified using a Go time.Duration format (h|m|s). E.g. 240h for 240 hours
        /// and 45m for 45 minutes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"When to begin renewing certificate. Must be specified using a Go time.Duration format (h|m|s). E.g. 240h for 240 hours and 45m for 45 minutes.",
        SerializedName = @"renewBefore",
        PossibleTypes = new [] { typeof(string) })]
        string CertManagerCertificateSpecRenewBefore { get; set; }
        /// <summary>
        /// Secret for storing server certificate. Any existing data will be overwritten. This is a reference to the secret through
        /// an identifying name, not the secret itself.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Secret for storing server certificate. Any existing data will be overwritten. This is a reference to the secret through an identifying name, not the secret itself.",
        SerializedName = @"secretName",
        PossibleTypes = new [] { typeof(string) })]
        string CertManagerCertificateSpecSecretName { get; set; }
        /// <summary>group of issuer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"group of issuer.",
        SerializedName = @"group",
        PossibleTypes = new [] { typeof(string) })]
        string IssuerRefGroup { get; set; }
        /// <summary>kind of issuer (Issuer or ClusterIssuer).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"kind of issuer (Issuer or ClusterIssuer).",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("Issuer", "ClusterIssuer")]
        string IssuerRefKind { get; set; }
        /// <summary>name of issuer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"name of issuer.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string IssuerRefName { get; set; }
        /// <summary>
        /// Kubernetes secret containing an X.509 client certificate. This is a reference to the secret through an identifying name,
        /// not the secret itself.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Kubernetes secret containing an X.509 client certificate. This is a reference to the secret through an identifying name, not the secret itself.",
        SerializedName = @"secretRef",
        PossibleTypes = new [] { typeof(string) })]
        string ManualSecretRef { get; set; }
        /// <summary>
        /// Kubernetes node port. Only relevant when this port is associated with a `NodePort` listener.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Kubernetes node port. Only relevant when this port is associated with a `NodePort` listener.",
        SerializedName = @"nodePort",
        PossibleTypes = new [] { typeof(int) })]
        int? NodePort { get; set; }
        /// <summary>TCP port for accepting client connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"TCP port for accepting client connections.",
        SerializedName = @"port",
        PossibleTypes = new [] { typeof(int) })]
        int Port { get; set; }
        /// <summary>algorithm for private key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"algorithm for private key.",
        SerializedName = @"algorithm",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("Ec256", "Ec384", "Ec521", "Ed25519", "Rsa2048", "Rsa4096", "Rsa8192")]
        string PrivateKeyAlgorithm { get; set; }
        /// <summary>cert-manager private key rotationPolicy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"cert-manager private key rotationPolicy.",
        SerializedName = @"rotationPolicy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("Always", "Never")]
        string PrivateKeyRotationPolicy { get; set; }
        /// <summary>Protocol to use for client connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Protocol to use for client connections.",
        SerializedName = @"protocol",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("Mqtt", "WebSockets")]
        string Protocol { get; set; }
        /// <summary>DNS SANs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"DNS SANs.",
        SerializedName = @"dns",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SanDns { get; set; }
        /// <summary>IP address SANs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"IP address SANs.",
        SerializedName = @"ip",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SanIP { get; set; }
        /// <summary>Mode of TLS server certificate management.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Mode of TLS server certificate management.",
        SerializedName = @"mode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("Automatic", "Manual")]
        string TlMode { get; set; }

    }
    /// Defines a TCP port on which a `BrokerListener` listens.
    internal partial interface IListenerPortInternal

    {
        /// <summary>Reference to client authentication settings. Omit to disable authentication.</summary>
        string AuthenticationRef { get; set; }
        /// <summary>Reference to client authorization settings. Omit to disable authorization.</summary>
        string AuthorizationRef { get; set; }
        /// <summary>
        /// Lifetime of certificate. Must be specified using a Go time.Duration format (h|m|s). E.g. 240h for 240 hours and 45m for
        /// 45 minutes.
        /// </summary>
        string CertManagerCertificateSpecDuration { get; set; }
        /// <summary>cert-manager issuerRef.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ICertManagerIssuerRef CertManagerCertificateSpecIssuerRef { get; set; }
        /// <summary>Type of certificate private key.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ICertManagerPrivateKey CertManagerCertificateSpecPrivateKey { get; set; }
        /// <summary>
        /// When to begin renewing certificate. Must be specified using a Go time.Duration format (h|m|s). E.g. 240h for 240 hours
        /// and 45m for 45 minutes.
        /// </summary>
        string CertManagerCertificateSpecRenewBefore { get; set; }
        /// <summary>Additional Subject Alternative Names (SANs) to include in the certificate.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ISanForCert CertManagerCertificateSpecSan { get; set; }
        /// <summary>
        /// Secret for storing server certificate. Any existing data will be overwritten. This is a reference to the secret through
        /// an identifying name, not the secret itself.
        /// </summary>
        string CertManagerCertificateSpecSecretName { get; set; }
        /// <summary>group of issuer.</summary>
        string IssuerRefGroup { get; set; }
        /// <summary>kind of issuer (Issuer or ClusterIssuer).</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("Issuer", "ClusterIssuer")]
        string IssuerRefKind { get; set; }
        /// <summary>name of issuer.</summary>
        string IssuerRefName { get; set; }
        /// <summary>
        /// Kubernetes secret containing an X.509 client certificate. This is a reference to the secret through an identifying name,
        /// not the secret itself.
        /// </summary>
        string ManualSecretRef { get; set; }
        /// <summary>
        /// Kubernetes node port. Only relevant when this port is associated with a `NodePort` listener.
        /// </summary>
        int? NodePort { get; set; }
        /// <summary>TCP port for accepting client connections.</summary>
        int Port { get; set; }
        /// <summary>algorithm for private key.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("Ec256", "Ec384", "Ec521", "Ed25519", "Rsa2048", "Rsa4096", "Rsa8192")]
        string PrivateKeyAlgorithm { get; set; }
        /// <summary>cert-manager private key rotationPolicy.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("Always", "Never")]
        string PrivateKeyRotationPolicy { get; set; }
        /// <summary>Protocol to use for client connections.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("Mqtt", "WebSockets")]
        string Protocol { get; set; }
        /// <summary>DNS SANs.</summary>
        System.Collections.Generic.List<string> SanDns { get; set; }
        /// <summary>IP address SANs.</summary>
        System.Collections.Generic.List<string> SanIP { get; set; }
        /// <summary>TLS server certificate settings for this port. Omit to disable TLS.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ITlsCertMethod Tl { get; set; }
        /// <summary>Option 1 - Automatic TLS server certificate management with cert-manager.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ICertManagerCertificateSpec TlCertManagerCertificateSpec { get; set; }
        /// <summary>Option 2 - Manual TLS server certificate management through a defined secret.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IX509ManualCertificate TlManual { get; set; }
        /// <summary>Mode of TLS server certificate management.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("Automatic", "Manual")]
        string TlMode { get; set; }

    }
}