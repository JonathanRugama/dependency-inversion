using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionChecked
{
    class User
    {
        // En este caso el User depende del ConsoleNotification class
        private INotificationService _notificationService;

        public string Username { get; private set; }

        public User(string username, INotificationService notificationService)
        {
            Username = username;

            _notificationService = notificationService;
        }
        

        public void ChangeUserName (string newUserName)
        {
            Username = newUserName;
            _notificationService.NotifyUserNameChanged(this);
        }
    }
}
