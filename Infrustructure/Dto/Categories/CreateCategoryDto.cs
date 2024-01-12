namespace Infrustructure.Dto.Categories
{
    public record CreateCategoryDto(
        string Name,
        string Description,
        string BackgroundColor,
        string FontColor,
        string LogoUrl
    );
}