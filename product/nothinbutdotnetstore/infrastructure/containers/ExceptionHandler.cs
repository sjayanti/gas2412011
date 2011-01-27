using System;

public class ExceptionHandler
{
    public static TResult throw_if<ExceptionToCatch, TResult>(Func<TResult> call_back, Func<Exception, Exception> delegate_for_exception) where ExceptionToCatch : Exception
    {
        try
        {
            return call_back();
        }
        catch (ExceptionToCatch innerException)
        {
            throw delegate_for_exception(innerException);
        }
    }
   

}