﻿namespace Cam.VM
{
    public interface IScriptTable
    {
        byte[] GetScript(byte[] script_hash);
    }
}
