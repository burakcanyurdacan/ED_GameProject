using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract.Interface
{
    public interface IUserControlService
    {
        bool CheckRealPerson(User user);
    }
}
