namespace SilverlightUnitTestAdapter.Helpers
{
    internal interface IVsShell
    {
        void Initialize(bool clearOutput = false);
        void Trace(string message);
    }
}