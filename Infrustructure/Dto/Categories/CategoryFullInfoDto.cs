namespace Infrustructure.Dto.Categories
{
    public record CategoryFullInfoDto(
        Guid Id, 
        string Name, 
        string Description,
        string BackgroundColor, 
        string FontColor, 
        string LogoUrl
    );
}