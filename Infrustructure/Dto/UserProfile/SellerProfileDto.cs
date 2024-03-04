using Infrustructure.Dto.Goods;

namespace Infrustructure.Dto.UserProfile
{
    public record SellerProfileDto
    (
        Guid Id,
        string Email,
        string PhoneNumber,
        DateTime CreatedAt,
        string ProfilePicUrl,
        string Name,
        string WebsiteUrl,
        List<GoodShortInfoDto> Goods,
        bool IsVerified
    );
}
