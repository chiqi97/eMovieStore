using eMovieStore.Models;

namespace eMovieStore.Services
{
    public interface IUserService
    {
        ApplicationUser GetLoggedUser();
    }
}