using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.BuilderClass
{
    public class UserProfile
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Bio { get; set; }

        public override string ToString()
        {
            return $"Username: {Username}, Email: {Email}, Address: {Address}, Phone: {PhoneNumber}, Bio: {Bio}";
        }
    }

}
