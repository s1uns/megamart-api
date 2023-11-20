using Core.Models;


namespace Infrustructure.Dto.Categories
{
    public record CreateCategoryDto(
        string Name,
        string Description,
        string Color,
        string LogoUrl
    );
}