﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Couchbase.N1QL
{
    /// <summary>
    /// Thrown when an attempt is made to access a property or methods before reading the request stream via iteration.
    /// </summary>
    /// <seealso cref="System.InvalidOperationException" />
    [Obsolete]
    public class StreamMustBeReadException : InvalidOperationException
    {
        public StreamMustBeReadException()
        {
        }

        public StreamMustBeReadException(string message) : base(message)
        {
        }

        public StreamMustBeReadException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}

#region [ License information          ]

/* ************************************************************
 *
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2015 Couchbase, Inc.
 *
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *
 * ************************************************************/

#endregion
