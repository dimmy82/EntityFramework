﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Data.SqlClient;
using Microsoft.Framework.DependencyInjection;

namespace Microsoft.Data.Entity.Tests
{
    public class SqlServerTestHelpers : TestHelpers
    {
        protected SqlServerTestHelpers()
        {
        }

        public new static SqlServerTestHelpers Instance { get; } = new SqlServerTestHelpers();
        
        protected override EntityServicesBuilder AddProviderServices(EntityServicesBuilder entityServicesBuilder)
        {
            return entityServicesBuilder.AddSqlServer();
        }

        protected override DbContextOptions UseProviderOptions(DbContextOptions options)
        {
            options.UseSqlServer(new SqlConnection("Database=DummyDatabase"));

            return options;
        }
    }
}
