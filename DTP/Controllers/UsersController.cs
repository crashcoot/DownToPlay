﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DTP.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}