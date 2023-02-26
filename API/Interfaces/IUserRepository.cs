using API.DTOs;
using API.Entities;
using API.Helpers;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAysnc();
        Task<IEnumerable<AppUser>> GetUsersAysnc();
        Task<AppUser> GetUserByIdAysnc(int id);
        Task<AppUser> GetUserByUserNameAysnc(string username);
        Task<PagedList<MemberDto>> GetMembersAsync(UserParams userParams);
        Task<MemberDto> GetMemberAsync(string username);
    }
}
