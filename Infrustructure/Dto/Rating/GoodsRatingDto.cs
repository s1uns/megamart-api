using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.Dto.Rating
{
    public record GoodsRatingDto
    (
        float Value,
        bool IsRatedByUser
    );
}
