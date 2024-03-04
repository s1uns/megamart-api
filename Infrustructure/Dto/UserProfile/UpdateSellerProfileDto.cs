namespace Infrustructure.Dto.UserProfile
{
    public record UpdateSellerProfileDto
    (
        string PhoneNumber,
        string ProfilePicUrl,
        string Name,
        string WebsiteUrl
    );
}
