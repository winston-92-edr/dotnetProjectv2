using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace dotNetChallange.Models
{
    public class JSONModel
    {
        
        public class Rootobject
        {
            public string status { get; set; }
            public Data data { get; set; }
        }

        public class Data
        {
            public int id { get; set; }
            public string market_code { get; set; }
            public Ticker ticker { get; set; }
            public Buyer[] buyers { get; set; }
            public Seller[] sellers { get; set; }
            public Last_Transactions[] last_transactions { get; set; }
            public string timestamp { get; set; }
        }

        public class Ticker
        {
            public Market market { get; set; }
            public string bid { get; set; }
            public string ask { get; set; }
            public string last_price { get; set; }
            public string last_size { get; set; }
            public string volume_24h { get; set; }
            public string change_24h { get; set; }
            public string low_24h { get; set; }
            public string high_24h { get; set; }
            public string avg_24h { get; set; }
            public string timestamp { get; set; }
        }

        public class Market
        {
            public string market_code { get; set; }
            public string base_currency_code { get; set; }
            public string counter_currency_code { get; set; }
        }

        public class Buyer
        {
            public string orders_total_amount { get; set; }
            public string orders_price { get; set; }
        }

        public class Seller
        {
            public string orders_total_amount { get; set; }
            public string orders_price { get; set; }
        }

        public class Last_Transactions
        {
            public string amount { get; set; }
            public string price { get; set; }
            public string time { get; set; }
            public string type { get; set; }
        }


    }
}