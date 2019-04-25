using Barebone.Controllers;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using ControllerBase = Barebone.Controllers.ControllerBase;

namespace ES.Core.Controllers
{
    public class CoreController : ControllerBase
    {
        public CoreController(IStorage storage) : base(storage)
        {
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}
