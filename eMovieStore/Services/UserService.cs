using eMovieStore.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eMovieStore.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContext;

        public UserService(IHttpContextAccessor httpContext,
            AppDbContext context)
        {
            _context = context;
            _httpContext = httpContext;
        }
        public ApplicationUser GetLoggedUser()
        {
            var userId=_httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);
            return _context.Users.Find(userId);
        }
    }
}
