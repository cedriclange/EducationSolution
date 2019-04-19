using Barebone.ViewModels.Barebone;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barebone.Controllers
{
    public class BareboneController : ControllerBase
    {
        public BareboneController(IStorage storage) : base(storage) { }

        public ActionResult Index()
        {
            return View(new IndexViewModelFactory().Create());
        }
    }
}
