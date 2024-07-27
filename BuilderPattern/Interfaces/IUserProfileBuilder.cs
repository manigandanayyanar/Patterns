using BuilderPattern.BuilderClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Interfaces
{
    public interface IUserProfileBuilder
    {
        void SetUsername(string username);
        void SetEmail(string email);
        void SetAddress(string address);
        void SetPhoneNumber(string phoneNumber);
        void SetBio(string bio);
        UserProfile GetUserProfile();
    }

}
