using System;
using System.Collections.Generic;
using System.Data;
using Machine.Specifications;
using Machine.Specifications.DevelopWithPassion.Rhino;
using nothinbutdotnetstore.infrastructure.containers;
using nothinbutdotnetstore.web.infrastructure;
using Rhino.Mocks;


namespace nothinbutdotnetstore.specs.infrastructure
{
    public class DependencyRegistrySpecs
    {
        public abstract class concern : Observes<DependencyRegistry,
                                    BasicDependencyRegistry>
        {

        }

        [Subject(typeof(BasicDependencyRegistry))]
        public class when_fetching_a_factory : concern
        {

            Establish e = () =>
            {
                dummy_factory = an<DependencyFactory>();
                var map = new Dictionary<Type, DependencyFactory>();
                map.Add(typeof(IDummy), dummy_factory);
                provide_a_basic_sut_constructor_argument(map);
            };

            Because b = () =>
                result = sut.get_the_factory_for<IDummy>();

            It should_have_factory = () =>
            {
                result.ShouldEqual(dummy_factory);
            };

            static DependencyFactory result,dummy_factory;
            
        }
        public interface IDummy {}
        public class Dummy:IDummy
        {
            
        }
    }

    
}
