using BuilderPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.BuilderClass
{
    public class BasicUserProfileBuilder : IUserProfileBuilder
    {
        private UserProfile _userProfile = new();

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
            // Basic profile might not include address
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            // Basic profile might not include phone number
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
