﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Jojatekok.MoneroAPI.RpcManagers.AccountManager.Json.Responses
{
    class TransactionListValueContainer : RpcResponse, IValueContainer<IList<Transaction>>
    {
        [JsonProperty("transfers")]
        public IList<Transaction> Value { get; private set; }
    }
}