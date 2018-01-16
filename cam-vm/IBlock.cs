namespace Cam.VM
{
    public interface IBlock
    {





        byte[] GetScript(byte[] script_hash);




        uint GetTimestamp();
    }
}
