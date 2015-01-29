// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.Data.Entity.Metadata.ModelConventions
{
    public class ConventionSet
    {
        public ConventionSet()
        {
            EntityTypeAddedConventions = new List<IEntityTypeConvention>();
            ForeignKeyAddedConventions = new List<IRelationshipConvention>();
        }

        public virtual IList<IEntityTypeConvention> EntityTypeAddedConventions { get; }

        public virtual IList<IRelationshipConvention> ForeignKeyAddedConventions { get; }
    }
}
