using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class User
    {
        // En este caso el User depende del ConsoleNotification class
        private ConsoleNotification _notificationService;

        public User(string username)
        {
            Username = username;

            _notificationService = new ConsoleNotification();
        }
        public string Username { get; private set; }

        public void ChangeUserName (string newUserName)
        {
            Username = newUserName;
            _notificationService.NotifyUserNameChanged(this);
        }
    }
}
