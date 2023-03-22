using Portal.DTO;
using Portal.MODEL;
using System.Linq.Expressions;

namespace Portal.SERVICE.IService
{
    public interface IUserService
    {
        Task<IEnumerable<SignUpModelDTO>> GetUser();

        Task<SignUpModelDTO> GetUserById(int id);

        Task<int> AddUser(SignUpModelDTO Model);
        Task<int> UpdateUser(SignUpModelDTO Model);
        Task<int> DeleteUser(SignUpModelDTO Model);
        Task<SignUpModelDTO> FindUser(Expression<Func<SignUpModelDTO, bool>> predicate);
    }
}
