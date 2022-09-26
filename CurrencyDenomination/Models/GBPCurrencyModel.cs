using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyDenomination.Models
{
    public class GBPCurrencyModel:AmountPriceModel
    {
        public GBPCurrencyModel()
        {
        }
        public string GBPSybmol 
        {
            get 
            {
                return "£";
            } 
        }
        public string PennySymbol
        {
            get
            {
                return "p";
            }
        }
        public int Hundred { get; set; }
        public int  Fifty { get; set; }
        public int Twenty { get; set; }
        public int Ten { get; set; }
        public int Five { get; set; }
        public int One { get; set; }
        public int FiftyCent { get; set; }
        public int TenCent { get; set; }
        public int FiveCent { get; set; }
        public int OneCent { get; set; }


    }
}
