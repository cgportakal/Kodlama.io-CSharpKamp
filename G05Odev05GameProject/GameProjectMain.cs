using System;

namespace G05Odev05GameProject
{
    class GameProjectMain
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            //GamerManager gamerManager1 = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer {
                Id = 1,
                BirthYear = 1994,
                FirsName = "Cafer",
                LastName = "Portakal",
                IdentityNumber = 1234567890
            });

        }
    }
}
