using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_n_Share.Class
{
    class Transaction
    {
        // Instance variables
        private string _transactionId;
        private string _type;
        private string _itemId;
        private DateTime _transactionDate;
        private string _status;
        private string _userId;

        // Properties
        public string TransactionId
        {
            get { return _transactionId; }
        }
        public string UserId
        {
            get { return _userId; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string ItemId
        {
            get { return _itemId; }
        }
        public DateTime TransactionDate
        {
            get { return _transactionDate; }
            set { _transactionDate = value; }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        // Methods
        public void Confirm(string transactionId)
        {
            _transactionId = transactionId;
            _status = "Confirmed";
            Console.WriteLine($"Transaction {TransactionId} confirmed.");
        }

        public void AddTransaction(string ItemId, string transactionId, string userId)
        {
            _userId = userId;
            _itemId = ItemId;
            _transactionId = transactionId;
            _status = "Pending";
            Console.WriteLine($"item {_itemId} waiting confirm from {_userId}.");
        }
    }
}
