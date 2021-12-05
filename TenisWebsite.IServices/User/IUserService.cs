using System.Threading.Tasks;
using TenisWebsite.IServices.Request;

namespace TenisWebsite.IServices.User
{
    public interface IUserService
    {
        Task<int> CreateUser(CreatUser createUser);
    }
}
