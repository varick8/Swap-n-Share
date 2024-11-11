using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_n_Share.Class
{
    class Community
    {
        // Instance variables
        private string _communityId;
        private string _communityName;
        private string _member;
        private string _postId;

        private static List<string> existingCommunityNames = new List<string>();
        // Properties
        public string CommunityId
        {
            get { return _communityId; }
        }
        public string PostId
        {
            get { return _postId; }
        }
        public string CommunityName
        {
            get { return _communityName; }
            set { _communityName = value; }
        }
        public string Member
        {
            get { return _member; }
            set { _member = value; }
        }

        // Methods
        public void JoinCommunity(string userId)
        {
            _member = userId;
            Console.WriteLine($"User {_member} joined the community.");
        }

        public void LeaveCommunity(string userId)
        {
            _member = userId;
            Console.WriteLine($"User {_member} left the community.");
            _member = null;
        }

        public void SharePost(string postId, string communityName)
        {
            _communityName = communityName;
            _postId = postId;
            Console.WriteLine($"Post {_postId} shared in community {_communityName}.");
        }

        public void DeletePost(string postId, string communityName)
        {
            _communityName=communityName;
            _postId = postId;
            Console.WriteLine($"Post {_postId} deleted from community {_communityName}.");
        }
    }
}
