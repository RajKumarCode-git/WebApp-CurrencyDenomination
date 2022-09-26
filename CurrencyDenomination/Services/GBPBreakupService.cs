using CurrencyDenomination.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyDenomination.Services
{
    public class GBPBreakupService : IGBPBreakupService
    {
        public GBPCurrencyModel GetBrakeupDenomination(GBPCurrencyModel model)
        {
            model.BreakUpSummary = GetBreakup(model);
            return model;
        }

        private List<string> GetBreakup(GBPCurrencyModel model)
        {
            decimal amountBalance = model.AmountBalance;

            model.Hundred = GetDenomination(amountBalance, 100);
            amountBalance = amountBalance % 100;

            model.Fifty = GetDenomination(amountBalance, 50);
            amountBalance = amountBalance % 50;

            model.Twenty = GetDenomination(amountBalance, 20);
            amountBalance = amountBalance % 20;

            model.Ten = GetDenomination(amountBalance, 10);
            amountBalance = amountBalance % 10;

            model.Five = GetDenomination(amountBalance, 5);
            amountBalance = amountBalance % 5;

            model.One = GetDenomination(amountBalance, 1);
            amountBalance = amountBalance % 1;

            model.FiftyCent = GetDenomination(amountBalance, 0.50M);
            amountBalance = amountBalance % 0.50M;

            model.TenCent = GetDenomination(amountBalance, 0.10M);
            amountBalance = amountBalance % 0.10M;

            model.FiveCent = GetDenomination(amountBalance, 0.05M);
            amountBalance = amountBalance % 0.05M;

            model.OneCent = GetDenomination(amountBalance, 0.01M);
            amountBalance = amountBalance % 0.01M;



            return GetBreakupSummary(model);
        }

        private int GetDenomination(decimal change, decimal denomination)
        {
            return (int)(change / denomination);
        }

        private int GetDenomination(decimal change, int denomination)
        {
            return (int)(change / denomination);
        }

        private List<string> GetBreakupSummary(GBPCurrencyModel model)
        {
            List<string> breakupSummary = new List<string>();

            if (model.Hundred > 0)
                breakupSummary.Add(string.Format("{0} x {1}100", model.Hundred, model.GBPSybmol));

            if (model.Fifty > 0)
                breakupSummary.Add(string.Format("{0} x {1}50", model.Fifty, model.GBPSybmol));

            if (model.Twenty > 0)
                breakupSummary.Add(string.Format("{0} x {1}20", model.Twenty, model.GBPSybmol));

            if (model.Ten > 0)
                breakupSummary.Add(string.Format("{0} x {1}10", model.Ten, model.GBPSybmol));

            if (model.Five > 0)
                breakupSummary.Add(string.Format("{0} x {1}5", model.Five, model.GBPSybmol));

            if (model.One > 0)
                breakupSummary.Add(string.Format("{0} x {1}1", model.One, model.GBPSybmol));

            if (model.FiftyCent > 0)
                breakupSummary.Add(string.Format("{0} x 50{1}", model.FiftyCent, model.PennySymbol));

            if (model.TenCent > 0)
                breakupSummary.Add(string.Format("{0} x 10{1}", model.TenCent, model.PennySymbol));

            if (model.FiveCent > 0)
                breakupSummary.Add(string.Format("{0} x 5{1}", model.FiveCent, model.PennySymbol));

            if (model.OneCent > 0)
                breakupSummary.Add(string.Format("{0} x 1{1}", model.OneCent, model.PennySymbol));

            return breakupSummary;
        }
    }
}
