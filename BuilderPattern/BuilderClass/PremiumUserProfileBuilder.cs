using BuilderPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.BuilderClass
{
    public class PremiumUserProfileBuilder : IUserProfileBuilder
    {
        private UserProfile _userProfile = new UserProfile();

        public void SetUsername(string username)
        {
            _userProfile.Username = username;
        }

        public void SetEmail(string email)
        {
            _userProfile.Email = email;
        }

        public void SetAddress(string address)
        {
            _userProfile.Address = address;
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            _userProfile.PhoneNumber = phoneNumber;
        }

        public void SetBio(string bio)
        {
            _userProfile.Bio = bio;
        }

        public UserProfile GetUserProfile()
        {
            return _userProfile;
        }
    }

}
