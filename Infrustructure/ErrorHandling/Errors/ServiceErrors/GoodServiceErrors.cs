using Infrustructure.ErrorHandling.Errors.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.ErrorHandling.Errors.ServiceErrors
{
    public static class GoodServiceErrors
    {
        public static readonly Error AddGoodError = new Error("Add Good Error", "Failed to add new good");
        public static readonly Error EditGoodError = new Error("Edit Good Error", "Failed to edit the good");
        public static readonly Error DeleteGoodError = new Error("Delete Good Error", "Failed to delete the good");
        public static readonly Error GetGoodsError = new Error("Get All Goods Error", "Failed to get the goods");
        public static readonly Error GetGoodError = new Error("Get Good Error", "Failed to get the good");
        public static readonly Error WrongSellerError = new Error("Wrong Seller Error", "You are not the seller of this good");
        public static readonly Error GetSellerInfoError = new Error("Get Seller Info Error", "Couldn't get information about the seller of this good.");
    }
}