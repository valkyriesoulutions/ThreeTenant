namespace ThreeTenant.Auditing
{
    public interface INamespaceStripper
    {
        string StripNameSpace(string serviceName);
    }
}