using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Account_DTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public Account_DTO(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public Account_DTO(string username, string password, string displayName)
        {
            Username = username;
            Password = password;
            DisplayName = displayName;
        }
    }
}