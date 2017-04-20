// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The properties of the create cerdential operation.
    /// </summary>
    public partial class CredentialCreateOrUpdateProperties
    {
        private string _description;
        
        /// <summary>
        /// Optional. Gets or sets the description of the credential.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _password;
        
        /// <summary>
        /// Required. Gets or sets the password of the credential.
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }
        
        private string _userName;
        
        /// <summary>
        /// Required. Gets or sets the user name of the credential.
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// CredentialCreateOrUpdateProperties class.
        /// </summary>
        public CredentialCreateOrUpdateProperties()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// CredentialCreateOrUpdateProperties class with required arguments.
        /// </summary>
        public CredentialCreateOrUpdateProperties(string userName, string password)
            : this()
        {
            if (userName == null)
            {
                throw new ArgumentNullException("userName");
            }
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            this.UserName = userName;
            this.Password = password;
        }
    }
}