﻿using CryptoMarketClient.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMarketClient.Bittrex {
    public class BittrexAccountBalanceInfo : BalanceBase {
        public override string Exchange => "Bittrex";
        public double Balance { get; set; }
        public double Pending { get; set; }
        public bool Requested { get; set; }
        public string Uuid { get; set; }
    }
}
