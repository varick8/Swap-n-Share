using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Swap_n_Share.Class
{
    class User
    {
        // Instance variables
        private string _userId;
        private string _userName;
        private string _password;
        private string _email;
        private string _phone;
        private string _address;
        private string _itemId;
        private string _offerId;

        // Static list to store existing user names
        private static List<string> existingUserNames = new List<string>();

        // Properties
        public string UserId
        {
            get { return _userId; }
        }
        public string ItemId
        {
            get { return _itemId; }
        }
        public string OfferId
        {
            get { return _offerId; }
        }
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        // Methods
        public void Delete(string userId)
        {
            _userId = userId;
            Console.WriteLine($"User {_userId} deleted.");
        }

        public void ConfirmItem(string itemId, string userId)
        {
            _userId = userId;
            _itemId = itemId;
            Console.WriteLine($"Item {_itemId} confirmed by {_userId}.");
        }

        public void CreateOffer(string offerId, string userId)
        {
            _offerId = offerId;
            _userId = userId;
            Console.WriteLine($"Offer {_offerId} created by {_userId}.");
        }

        public void EditProfile(string userId, string userName, string password, string email, string phone, string address)
        {
            // Check if the user name is unique
            if (existingUserNames.Contains(userName))
            {
                Console.WriteLine($"Error: User name {userName} already exists.");
            }
            else
            {
                existingUserNames.Add(userName);
                _userId = userId;
                _userName = userName;
                _password = password;
                _email = email;
                _phone = phone;
                _address = address;
                Console.WriteLine($"Profile updated. New email: {_email}, New phone: {_phone}, New Username: {_userName}, New Password: {_password}, New Address: {_address}");
            }
        }

        public void Login(string password, string userName)
        {
            if (_password == password && _userName == userName)
                Console.WriteLine($"Login Succesfull.");
            else
                Console.WriteLine("Login failed.");
        }

        public void SignUp(string userId, string userName, string password, string email, string phone, string address)
        {
            // Check if the user name is unique
            if (existingUserNames.Contains(userName))
            {
                Console.WriteLine($"Error: User name '{userName}' already exists.");
            }
            else
            {
                existingUserNames.Add(userName);
                _userId = userId;
                _userName = userName;
                _password = password;
                _email = email;
                _phone = phone;
                _address = address;
                Console.WriteLine($"User '{_userName}' created successfully with ID: {_userId}.");
            }
        }

    }
}
