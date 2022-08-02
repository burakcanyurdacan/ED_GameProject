using GameProject.Abstract.Interface;
using GameProject.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Adapters
{
    public class MernisControlManager : IUserControlService
    {
        public bool CheckRealPerson(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var request = client.TCKimlikNoDogrulaAsync(user.IdentityNumber, user.Name, user.Surname, user.BirthDate.Year).GetAwaiter().GetResult();
            return request.Body.TCKimlikNoDogrulaResult;
        }
    }
}
