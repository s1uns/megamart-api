namespace Infrustructure.Dto.Categories
{
    public record EditCategoryDto (
        Guid Id, 
        string Name,
        string Description, 
        string Color,
        string LogoUrl
    );
}