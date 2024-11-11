using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_n_Share.Class
{
    class Discussion
    {
        // Instance variables
        private string _discussionId;
        private string _transactionId;
        private string _description;
        private string _userId;

        // Properties
        public string DiscussionId
        {
            get { return _discussionId; }
        }
        public string UserId
        {
            get { return _userId; }
        }
        public string TransactionId
        {
            get { return _transactionId; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        // Methods
        public void InputDiscussion(string description, string userId, string discussionId)
        {
            _discussionId = discussionId;
            _userId = userId;
            _description = description;
            Console.WriteLine($"Discussion with {_discussionId} input: {_description} by {_userId}");
        }

        public void DeleteDiscussion(string discussionId)
        {
            _discussionId = discussionId;
            Console.WriteLine($"Discussion {_discussionId} deleted.");
        }

        public void EditDiscussion(string newDescription, string discussionId, string userId)
        {
            _discussionId = discussionId;
            _userId = userId;
            _description = newDescription;
            Console.WriteLine($"Discussion {_discussionId} updated by {_userId}. New description: {Description}");
        }
    }
}
