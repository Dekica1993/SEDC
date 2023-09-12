using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManagerApp9000.Domain.Enums;

namespace TaxiManagerApp9000.Domain.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty ;
        public Role Role { get; set; }
        
        public User(string username, string password, Role role)
        {
            UserName = username;
            Password = password;
            Role = role;
        }
        public override string Print()
        {
            return $"User with username {UserName} and Role: [{Role}]";
        }
    }
}
