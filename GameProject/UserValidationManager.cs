using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2000 && gamer.FirstName == "UĞUR" && gamer.LastName == "SAĞLAM" && gamer.IdentityNumber == 123)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
