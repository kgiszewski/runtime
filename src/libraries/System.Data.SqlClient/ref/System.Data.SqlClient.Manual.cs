// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------

namespace System.Data.SqlClient
{
    public sealed partial class SqlCommand : System.Data.Common.DbCommand
    {
        // SqlCommand expects IDisposable methods to be implemented via System.ComponentModel.Component, which it no longer inherits from
        protected override void Dispose(bool disposing) { }
    }
    public sealed partial class SqlConnection : System.Data.Common.DbConnection
    {
        // SqlConection expects IDisposable methods to be implemented via System.ComponentModel.Component, which it no longer inherits from
        protected override void Dispose(bool disposing) { }
    }
    public sealed partial class SqlConnectionStringBuilder
    {
        [System.ComponentModel.TypeConverter(typeof(SqlInitialCatalogConverter))]
        public string InitialCatalog { get { throw null; } set { } }

        private sealed class SqlInitialCatalogConverter { }
    }

    [System.ComponentModel.TypeConverter(typeof(SqlParameterConverter))]
    public sealed partial class SqlParameter
    {
      internal class SqlParameterConverter { }
    }
}
