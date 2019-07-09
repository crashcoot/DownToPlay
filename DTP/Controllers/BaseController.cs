using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DTP.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DTP.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly ApplicationDbContext _context;
        protected readonly IHttpContextAccessor _httpContextAccessor;

        public BaseController(ApplicationDbContext db, IHttpContextAccessor httpContextAccessor)
        {
            _context = db;
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetCurrentUserID()
        {
            return _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}