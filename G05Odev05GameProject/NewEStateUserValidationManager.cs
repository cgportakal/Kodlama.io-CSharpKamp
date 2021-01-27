using System;
using System.Collections.Generic;
using System.Text;

namespace G05Odev05GameProject
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1994 && gamer.FirsName == "Gökmen"
                 && gamer.LastName == "Portakal"
                 && gamer.IdentityNumber == 1234567890)
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
