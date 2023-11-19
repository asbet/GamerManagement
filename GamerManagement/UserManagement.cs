using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagement
{
    internal class UserManagement : IGamerManagement
    {
        bool _isAdded = false;

        public bool Add(Gamer gamer)
        {
            if (gamer.birthDate == new DateTime(1999, 11, 05) && gamer.surName == "As" && gamer.name == "Betul")
            {
                Console.WriteLine("Gamer added");
                _isAdded = false;
                return true;
            }
            else
            {
                Console.WriteLine("Gamer does not added");
                _isAdded = true;
                return false;
            }
        }

        public void Delete(Gamer gamer)
        {
            if (_isAdded)
            {
                Console.WriteLine("User " + gamer.name + " is deleted");
            }
        }

        public void Update(Gamer gamer)
        {
            if (_isAdded)
            {
                Console.WriteLine("User " +gamer.name+ " is updated");
            }
        }
    }
}
