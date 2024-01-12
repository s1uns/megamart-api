namespace Infrustructure.Dto.Categories
{
    public record CategoryShortInfoDto (
        Guid Id, 
        string Name,
        string BackgroundColor,
        string FontColor     
        );
}