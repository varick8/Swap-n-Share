using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_n_Share.Class
{
    class Admin
    {
        // Instance variables
        private string _adminId;
        private string _userName;
        private string _password;
        private string _email;
        private string _phone;
        private string _address;
        private string _itemId;
        private string _communityId;
        private string _userId;

        // Properties
        public string AdminId
        {
            get { return _adminId; }
        }
        public string ItemId
        {
            get { return _itemId; }
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
        public void Verification(string adminId)
        {
            _adminId = adminId;
            Console.WriteLine($"Admin {_adminId} verified.");
        }

        public void EditItem(string itemId, string adminId)
        {
            _adminId = adminId;
            _itemId = itemId;
            Console.WriteLine($"Item {_itemId} edited by Admin {_adminId}.");
        }

        public void EditCommunity(string communityId, string adminId)
        {
            _adminId = adminId;
            _communityId = communityId;
            Console.WriteLine($"Community {_communityId} edited by Admin {_adminId}.");
        }

        public void EditUser(string userId, string adminId)
        {
            _userId = userId;
            _adminId = adminId;
            Console.WriteLine($"User {_userId} edited by Admin {_adminId}.");
        }
    }
}
