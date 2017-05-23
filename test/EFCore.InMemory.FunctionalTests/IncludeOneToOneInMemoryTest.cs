// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Xunit;

namespace Microsoft.EntityFrameworkCore
{
    public class IncludeOneToOneInMemoryTest : IncludeOneToOneTestBase, IClassFixture<OneToOneQueryInMemoryFixture>
    {
        private readonly OneToOneQueryInMemoryFixture _fixture;

        public IncludeOneToOneInMemoryTest(OneToOneQueryInMemoryFixture fixture)
        {
            _fixture = fixture;
        }

        protected override DbContext CreateContext() => _fixture.CreateContext();
    }
}
