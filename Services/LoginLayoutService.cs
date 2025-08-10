﻿using PROJECT_CAREERCIN.Interfaces;

namespace PROJECT_CAREERCIN.Services
{
    public class LoginLayoutService : ILoginLayout
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoginLayoutService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetLayout()
        {
            var user = _httpContextAccessor.HttpContext.User;

            if (user.IsInRole("Admin"))
            {
                return "~/Views/Shared/_LayoutAdmin.cshtml";
            }
            else if (user.IsInRole("User"))
            {
                return "~/Views/Shared/_LayoutUser.cshtml";
            }
            else if (user.IsInRole("company"))
            {
                return "~/Views/Shared/_LayoutPerusahaan.cshtml";
            }

            return "~/Views/Shared/_Layout.cshtml";
        }
    }
}
