using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class ConsoleNotification
    {
        public void NotifyUserNameChanged(User user)
        {
            Console.WriteLine($"El nombre de usuario ha cambiado a: {user.Username}");
        }
    }
}
