using System.Threading.Tasks;
using UltimateTeam.Toolkit.Constants;

namespace UltimateTeam.Toolkit.Services
{
    public interface ITwoFactorCodeProvider
    {
        AuthenticationType AuthType { get; set; }
        string AuthKey { get; set; }

        Task<string> GetTwoFactorCodeAsync(AuthenticationType authType);
    }
}
