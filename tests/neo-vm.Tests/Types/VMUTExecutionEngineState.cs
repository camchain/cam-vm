using Cam.VM;
using Newtonsoft.Json;

namespace Cam.Test.Types
{
    public class VMUTExecutionEngineState
    {
        [JsonProperty]
        public VMState State { get; set; }

        [JsonProperty]
        public VMUTStackItem[] ResultStack { get; set; }

        [JsonProperty]
        public VMUTExecutionContextState[] InvocationStack { get; set; }
    }
}