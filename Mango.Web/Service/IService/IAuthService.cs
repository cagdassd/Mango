using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface IAuthService
    {
        Task<ResponseDto> LoginAsync(LoginRequestDto loginRequestDto);
        Task<ResponseDto> RegisterAsync(RegistrationRequestDto registarionRequestDto);
        Task<ResponseDto> AssignRoleAsync(RegistrationRequestDto registarionRequestDto);
    }
}
