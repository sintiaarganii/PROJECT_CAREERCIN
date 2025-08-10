﻿using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using PROJECT_CAREERCIN.Interfaces;

namespace PROJECT_CAREERCIN.Controllers
{
    public class UserController : Controller
    {
        private readonly IUser _userService;

        public UserController(IUser userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }


        [Authorize]
        public IActionResult Profile()
        {
            try
            {
                var userData = new
                {
                    Username = User.FindFirst(ClaimTypes.Name)?.Value,
                    Email = User.FindFirst(ClaimTypes.Email)?.Value,
                    UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value
                };

                return View(userData); // Kirim data ke View
            }
            catch (Exception ex)
            {
                TempData["Error"] = $"Gagal memuat profil: {ex.Message}";
                return RedirectToAction("Index", "Home");
            }
        }


    }
}
