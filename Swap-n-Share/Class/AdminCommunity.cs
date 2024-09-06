using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_n_Share.Class
{
    class AdminCommunity
    {
        // Instance variables
        private string _adminCommunityId;
        private string _communityName;
        private string _userId;
        private string _communityId;

        // Static list to store community names
        private static List<string> existingCommunityNames = new List<string>();

        // Properties
        public string AdminCommunityId
        {
            get { return _adminCommunityId; }
        }

        public string UserId
        {
            get { return _userId; }
        }
        public string CommunityId
        {
            get { return _communityId; }
        }

        public string CommunityName
        {
            get { return _communityName; }
            set { _communityName = value; }
        }

        // Method to create a community with a unique name
        public void CreateCommunity(string admincommunityId, string name, string communityId)
        {
            // Check if the community name is unique
            if (existingCommunityNames.Contains(name))
            {
                Console.WriteLine($"Error: Community name {name} already exists.");
            }
            else
            {
                existingCommunityNames.Add(name);
                _adminCommunityId = admincommunityId;
                _communityName = name;
                _communityId = communityId;
                Console.WriteLine($"Community {_communityName} with {_communityId} created by: {_adminCommunityId}");
            }
        }

        // Method to edit a community name (with uniqueness check)
        public void EditCommunity(string newName, string communityId)
        {
            if (existingCommunityNames.Contains(newName))
            {
                Console.WriteLine($"Error: Community name {newName} already exists.");
            }
            else
            {
                // Remove the old community name and add the new one
                existingCommunityNames.Remove(_communityName);
                existingCommunityNames.Add(newName);

                _communityName = newName;
                _communityId = communityId;
                Console.WriteLine($"Community with {_communityId} renamed to: {_communityName}");
            }
        }

        // Method to remove a community
        public void RemoveCommunity(string communityId)
        {
            if (existingCommunityNames.Contains(_communityName))
            {
                existingCommunityNames.Remove(_communityName);
                _communityId = communityId;
                Console.WriteLine($"Community {_communityName} with {_communityId} removed.");
            }
        }

        // Method to edit a community member (additional functionality)
        public void EditMember(string userId)
        {
            _userId = userId;
            Console.WriteLine($"Member with ID: {_userId} removed.");
        }
    }
}
