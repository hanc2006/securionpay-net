﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecurionPay.Request
{
    public class CustomerListRequest
    {
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("startingAfterId")]
        public String StartingAfterId { get; set; }

        [JsonProperty("endingBeforeId")]
        public String EndingBeforeId { get; set; }

        [JsonProperty("includeTotalCount")]
        public bool? IncludeTotalCount { get; set; }

        [JsonProperty("created")]
        public CreatedFilter Created { get; set; }

        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        [JsonExtensionData]
        public IDictionary<string, JToken> Other;
    }
}
