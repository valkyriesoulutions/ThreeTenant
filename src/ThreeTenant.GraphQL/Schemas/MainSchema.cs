using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using ThreeTenant.Queries.Container;
using System;

namespace ThreeTenant.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}