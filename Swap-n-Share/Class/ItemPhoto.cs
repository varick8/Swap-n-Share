using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_n_Share.Class
{
    class ItemPhoto
    {
        // Instance variables
        private string _photoId;
        private string _photo;
        private string _userId;

        // Properties
        public string PhotoId
        {
            get { return _photoId; }
        }
        public string userId
        {
            get { return _userId; }
        }
        public string Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }

        // Methods
        public void Update(string photoId, string photo, string userId)
        {
            _userId = userId;
            _photoId = photoId;
            _photo = photo;
            Console.WriteLine($"Photo {_photo} in {_userId} updated with ID {PhotoId}.");
        }

        public void Delete(string photoId)
        {
            _photoId = photoId;
            Console.WriteLine($"Photo {_photoId} deleted.");
        }
    }

}
