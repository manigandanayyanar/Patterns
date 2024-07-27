using BuilderPattern.BuilderClass;
using BuilderPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class UserProfileBuilder
    {
        private IUserProfileBuilder _userProfileBuilder;

        public UserProfileBuilder(IUserProfileBuilder userProfileBuilder)
        {
            _userProfileBuilder = userProfileBuilder;
        }

        public UserProfile ConstructUserProfile(string username, string email, string address, string phoneNumber, string bio)
        {
            _userProfileBuilder.SetUsername(username);
            _userProfileBuilder.SetEmail(email);
            _userProfileBuilder.SetAddress(address);
            _userProfileBuilder.SetPhoneNumber(phoneNumber);
            _userProfileBuilder.SetBio(bio);
            return _userProfileBuilder.GetUserProfile();
        }
    }


}
