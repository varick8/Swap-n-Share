using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Swap_n_Share.Class
{
    class Item
    {
        // Instance variables
        private string _itemId;
        private string _name;
        private string _userId;
        private bool _borrow;
        private bool _swap;

        // Properties
        public string ItemId
        {
            get { return _itemId; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string UserId
        {
            get { return _userId; }
        }
        public bool Borrow
        {
            get { return _borrow; }
            set { _borrow = value; }
        }
        public bool Swap
        {
            get { return _swap; }
            set { _swap = value; }
        }

        // Methods
        public void Insert(string itemId, string name, string userId, bool borrow, bool swap )
        {
            _itemId = itemId;
            _name = name;
            _userId = userId;
            _borrow = borrow;
            _swap = swap;
            Console.WriteLine($"Item {_name} with {_itemId} inserted by user {_userId}.");
        }

        public void Update(string newName, string itemId, bool newBorrow, bool newSwap)
        {
            _itemId = itemId;
            _name = newName;
            _borrow= newBorrow;
            _swap = newSwap;
            Console.WriteLine($"Item {_itemId} updated. New name: {_name}");
        }

        public void Delete(string itemId)
        {
            _itemId = itemId;
            Console.WriteLine($"Item {_itemId} deleted.");
        }

        public void SearchByUser(string userId, string name)
        {
            _userId = userId;
            _name = name;
            if (_userId == userId)
                Console.WriteLine($"Item {_name} found for user {_userId}.");
            else
                Console.WriteLine($"Item not found for user {_userId}.");
        }
    }

}
