// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// MariaDB server linked service properties.
    /// </summary>
    public partial class MariaDBLinkedServiceTypeProperties
    {
        /// <summary>
        /// Initializes a new instance of the MariaDBLinkedServiceTypeProperties class.
        /// </summary>
        public MariaDBLinkedServiceTypeProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MariaDBLinkedServiceTypeProperties class.
        /// </summary>

        /// <param name="driverVersion">The version of the MariaDB driver. Type: string. V1 or empty for legacy
        /// driver, V2 for new driver. V1 can support connection string and property
        /// bag, V2 can only support connection string.
        /// </param>

        /// <param name="connectionString">An ODBC connection string. Type: string, SecureString or
        /// AzureKeyVaultSecretReference.
        /// </param>

        /// <param name="server">Server name for connection. Type: string.
        /// </param>

        /// <param name="port">The port for the connection. Type: integer.
        /// </param>

        /// <param name="username">Username for authentication. Type: string.
        /// </param>

        /// <param name="database">Database name for connection. Type: string.
        /// </param>

        /// <param name="password">The Azure key vault secret reference of password in connection string.
        /// </param>

        /// <param name="encryptedCredential">The encrypted credential used for authentication. Credentials are encrypted
        /// using the integration runtime credential manager. Type: string.
        /// </param>
        public MariaDBLinkedServiceTypeProperties(object driverVersion = default(object), object connectionString = default(object), object server = default(object), object port = default(object), object username = default(object), object database = default(object), AzureKeyVaultSecretReference password = default(AzureKeyVaultSecretReference), string encryptedCredential = default(string))

        {
            this.DriverVersion = driverVersion;
            this.ConnectionString = connectionString;
            this.Server = server;
            this.Port = port;
            this.Username = username;
            this.Database = database;
            this.Password = password;
            this.EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the version of the MariaDB driver. Type: string. V1 or empty
        /// for legacy driver, V2 for new driver. V1 can support connection string and
        /// property bag, V2 can only support connection string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "driverVersion")]
        public object DriverVersion {get; set; }

        /// <summary>
        /// Gets or sets an ODBC connection string. Type: string, SecureString or
        /// AzureKeyVaultSecretReference.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "connectionString")]
        public object ConnectionString {get; set; }

        /// <summary>
        /// Gets or sets server name for connection. Type: string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "server")]
        public object Server {get; set; }

        /// <summary>
        /// Gets or sets the port for the connection. Type: integer.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "port")]
        public object Port {get; set; }

        /// <summary>
        /// Gets or sets username for authentication. Type: string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "username")]
        public object Username {get; set; }

        /// <summary>
        /// Gets or sets database name for connection. Type: string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "database")]
        public object Database {get; set; }

        /// <summary>
        /// Gets or sets the Azure key vault secret reference of password in connection
        /// string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "password")]
        public AzureKeyVaultSecretReference Password {get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication. Credentials
        /// are encrypted using the integration runtime credential manager. Type:
        /// string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "encryptedCredential")]
        public string EncryptedCredential {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {






            if (this.Password != null)
            {
                this.Password.Validate();
            }

        }
    }
}