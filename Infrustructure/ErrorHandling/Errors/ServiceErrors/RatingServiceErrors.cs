using Infrustructure.ErrorHandling.Errors.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.ErrorHandling.Errors.ServiceErrors
{
    public static class RatingServiceErrors
    {
        public static Error SetGoodsRatingError = new Error("Set Good's Rating Error", "Couldn't set this good's rating");
        public static Error ClearGoodsRatingError = new Error("Clear Good's Rating Error", "Couldn't clear this good's rating");
        public static Error GetSellersRatingError = new Error("Get Seller's Rating Error", "Couldn't get this seller's rating");
        public static Error RatingNotFoundError = new Error("Rating Not Found Error", "Couldn't find this rating");
        public static Error TooBigRatingValueError = new Error("Too Big Rating Value Error", "Can't set the rating higher than 5.0");
    }
}
