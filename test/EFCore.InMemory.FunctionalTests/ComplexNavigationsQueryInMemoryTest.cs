// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.Specification.Tests;

namespace Microsoft.EntityFrameworkCore.InMemory.FunctionalTests
{
    public class ComplexNavigationsQueryInMemoryTest : ComplexNavigationsQueryTestBase<InMemoryTestStore, ComplexNavigationsQueryInMemoryFixture>
    {
        public ComplexNavigationsQueryInMemoryTest(ComplexNavigationsQueryInMemoryFixture fixture)
            : base(fixture)
        {
        }

        public override void Contains_with_subquery_optional_navigation_and_constant_item()
        {
            // issue #7787 
            ////base.Contains_with_subquery_optional_navigation_and_constant_item();
        }

        public override void Where_navigation_property_to_collection()
        {
            // issue #7787 
            ////base.Where_navigation_property_to_collection();
        }
    }
}
