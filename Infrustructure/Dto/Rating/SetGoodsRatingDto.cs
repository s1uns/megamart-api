namespace Infrustructure.Dto.Rating
{
    public record SetGoodsRatingDto
    (
        Guid GoodId,
        float Value
    );
}
