﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace RoleManagement.Controllers
{
    [Authorize(Roles = "HR")]
    public class HRController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
