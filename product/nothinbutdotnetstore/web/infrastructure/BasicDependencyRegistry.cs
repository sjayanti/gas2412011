using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nothinbutdotnetstore.infrastructure.containers;

namespace nothinbutdotnetstore.web.infrastructure
{
    public class BasicDependencyRegistry : DependencyRegistry
    {
        readonly IDictionary<Type, DependencyFactory> contract_factory_map;

        public BasicDependencyRegistry(IDictionary<Type,DependencyFactory> contract_factory_map)
        {
            this.contract_factory_map = contract_factory_map;
        }

        public DependencyFactory get_the_factory_for<DependencyContract>()
        {
           return this.contract_factory_map[typeof(DependencyFactory)];
        }
    }
}
