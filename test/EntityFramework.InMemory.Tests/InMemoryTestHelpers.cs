﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Framework.DependencyInjection;

namespace Microsoft.Data.Entity.Tests
{
    public class InMemoryTestHelpers : TestHelpers
    {
        protected InMemoryTestHelpers()
        {
        }

        public new static InMemoryTestHelpers Instance { get; } = new InMemoryTestHelpers();

        protected override EntityServicesBuilder AddProviderServices(EntityServicesBuilder entityServicesBuilder)
        {
            return entityServicesBuilder.AddInMemoryStore();
        }

        protected override DbContextOptions UseProviderOptions(DbContextOptions options)
        {
            return options;
        }
    }
}
