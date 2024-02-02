using Infrustructure.ErrorHandling.Errors.Base;
namespace Infrustructure.ErrorHandling.Errors.ServiceErrors
{
    public static class CategoryServiceErrors
    {
        public static readonly Error AddCategoryError = new Error("Add Category Error", "Failed to add new category");
        public static readonly Error EditCategoryError = new Error("Edit Category Error", "Failed to edit the category");
        public static readonly Error DeleteCategoryError = new Error("Delete Category Error", "Failed to delete the category");
        public static readonly Error GetCategoriesError = new Error("Get All Categories Error", "Failed to get the categories");
        public static readonly Error GetCategoryError = new Error("Get Category Error", "Failed to get the category");
        public static readonly Error WrongSellerError = new Error("Wrong Seller Error", "You are not the seller of this category");
    }
}