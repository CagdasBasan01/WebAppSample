using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Core.Configuration;
using WebApp.Core.DTOs;
using WebApp.Core.Models;

namespace WebApp.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(UserApp userApp);

        ClientTokenDto CreateTokenByClient(Client client);
    }
}