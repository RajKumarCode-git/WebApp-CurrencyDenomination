using CurrencyDenomination.Models;
using CurrencyDenomination.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CurrencyDenominationTest
{
    [TestClass]
    public class GBPBreakupServiceTest
    {
        [TestMethod]
        public void GetBrakeupDenominationTest()
        {
            GBPCurrencyModel model = new GBPCurrencyModel();
            model.Price = 12.12M;
            model.AmountPaid = 100;
            decimal amountBalance = model.AmountPaid - model.Price;

            GBPBreakupService service = new GBPBreakupService();
            model = service.GetBrakeupDenomination(model);

            Assert.AreEqual(amountBalance, model.AmountBalance);
            Assert.IsTrue(model.Hundred < 1);
            Assert.IsTrue(model.Fifty == 1);
            Assert.IsTrue(model.Twenty == 1);
            Assert.IsTrue(model.Ten == 1);
            Assert.IsTrue(model.Five == 1);
            Assert.IsTrue(model.One == 2);

            Assert.IsTrue(model.FiftyCent == 1);
            Assert.IsTrue(model.TenCent == 3);
            Assert.IsTrue(model.FiveCent == 1);
            Assert.IsTrue(model.OneCent == 3);

        }
    }
}
