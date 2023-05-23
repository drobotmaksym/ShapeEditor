namespace ShapeEditor.DataAccess;

public class DataAccessException : Exception
{
    public DataAccessException(string message, Exception cause) : base(message)
    {
        Cause = cause;
    }

    public DataAccessException(string message) : base(message)
    {
        Cause = null;
    }

    public Exception? Cause { get; }
}