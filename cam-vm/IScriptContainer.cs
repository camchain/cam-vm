namespace Cam.VM
{
    public interface IScriptContainer : IInteropInterface
    {
        byte[] GetMessage();
    }
}
