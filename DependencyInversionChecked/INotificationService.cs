using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionChecked
{
    interface INotificationService
    {
        void NotifyUserNameChanged(User user);
    }
}
