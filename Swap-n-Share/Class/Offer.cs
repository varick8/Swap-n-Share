using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_n_Share.Class
{
    class Offer
    {
        // Instance variables
        private string _offerId;
        private DateTime _offerTime;
        private string _itemId;

        // Properties
        public string OfferId
        {
            get { return _offerId; }
        }
        public DateTime OfferTime
        {
            get { return _offerTime; }
            set { _offerTime = value; }
        }
        public string ItemId
        {
            get { return _itemId; }
        }

    }
}
