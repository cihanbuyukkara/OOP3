using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2000 && gamer.FirstName == "Cihan" && gamer.LastName == "Büyükkara" && gamer.IdentityNumber == 123456789 )
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
