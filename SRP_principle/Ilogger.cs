namespace SolidPrinciples.SRP_Compliant
{
    public interface ILogger
    {
        void Info(string message);
        void Error(string message);
    }
}