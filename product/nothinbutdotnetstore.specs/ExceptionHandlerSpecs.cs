 using System;
 using Machine.Specifications;
 using Machine.Specifications.DevelopWithPassion.Rhino;

namespace nothinbutdotnetstore.specs
{   
    public class ExceptionHandlerSpecs
    {
        public abstract class concern : Observes<ExceptionHandler>
        {
        
        }

        [Subject(typeof(ExceptionHandler))]
        public class when_there_is_no_exception : concern
        {
            Establish e = () =>
                return_value = 1;
               
            Because b = () =>
                result = ExceptionHandler.throw_if<Exception, int>(() => return_value, (exception) => exception);

            It should_run_successfully_ = () =>
                result.Equals(return_value);

            static int result;
            static int return_value;
        }

        [Subject(typeof(ExceptionHandler))]
        public class when_there_is_callee_throws_exception : concern
        {
          
            Because b = () =>
                catch_exception(() => ExceptionHandler.throw_if<FormatException, int>(() => Convert.ToInt32("hi"), (exception) => new DummyException(exception)));

            It should_run_successfully_ = () =>
                exception_thrown_by_the_sut.ShouldBeAn<DummyException>();

        }

            
    }

    class DummyException : Exception
    {
        public DummyException(Exception exception) : base(string.Empty,exception)
        {
         
        }
    }
}
