using Cam.Test.Converters;
using Newtonsoft.Json;

namespace Cam.Test.Types
{
    public class VMUTScriptEntry
    {
        [JsonProperty, JsonConverter(typeof(ScriptConverter))]
        public byte[] Script { get; set; }
    }
}