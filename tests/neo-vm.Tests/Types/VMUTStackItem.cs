﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Cam.Test.Types
{
    public class VMUTStackItem
    {
        [JsonProperty]
        public VMUTStackItemType Type { get; set; }

        [JsonProperty]
        public JToken Value { get; set; }
    }
}