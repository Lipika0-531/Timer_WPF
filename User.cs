using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SollyTracker
{
    public class User
    {
        public User(string userName, string password)
        {
            UserName = userName;
            Password = new Password(password);
            Parameters = new ObservableCollection<Task>();
        }

        public string UserName { get; set; }

        public Password Password { get; set; }

        public ObservableCollection<Task> Parameters { get; set; }

    }
}
