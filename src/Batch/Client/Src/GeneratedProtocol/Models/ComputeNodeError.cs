// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// An error encountered by a compute node.
    /// </summary>
    public partial class ComputeNodeError
    {
        /// <summary>
        /// Initializes a new instance of the ComputeNodeError class.
        /// </summary>
        public ComputeNodeError() { }

        /// <summary>
        /// Initializes a new instance of the ComputeNodeError class.
        /// </summary>
        /// <param name="code">An identifier for the compute node error. Codes
        /// are invariant and are intended to be consumed
        /// programmatically.</param>
        /// <param name="message">A message describing the compute node error,
        /// intended to be suitable for display in a user interface.</param>
        /// <param name="errorDetails">The list of additional error details
        /// related to the compute node error.</param>
        public ComputeNodeError(string code = default(string), string message = default(string), System.Collections.Generic.IList<NameValuePair> errorDetails = default(System.Collections.Generic.IList<NameValuePair>))
        {
            Code = code;
            Message = message;
            ErrorDetails = errorDetails;
        }

        /// <summary>
        /// Gets or sets an identifier for the compute node error. Codes are
        /// invariant and are intended to be consumed programmatically.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets a message describing the compute node error, intended
        /// to be suitable for display in a user interface.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the list of additional error details related to the
        /// compute node error.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "errorDetails")]
        public System.Collections.Generic.IList<NameValuePair> ErrorDetails { get; set; }

    }
}