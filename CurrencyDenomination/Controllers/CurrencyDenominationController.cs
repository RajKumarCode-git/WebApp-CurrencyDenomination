using CurrencyDenomination.Models;
using CurrencyDenomination.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyDenomination.Controllers
{
    public class CurrencyDenominationController : Controller
    {
        private readonly IGBPBreakupService _repository = null;
        public CurrencyDenominationController(IGBPBreakupService repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult CalculateBreakup(GBPCurrencyModel model)
        {
            GBPCurrencyModel updateModel=_repository.GetBrakeupDenomination(model);
            return Json(new { summary = updateModel.BreakUpSummary, balance = updateModel.AmountBalance });
        }
    }
}
