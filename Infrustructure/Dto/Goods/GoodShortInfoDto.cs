﻿using Infrustructure.Dto.Categories;
using Infrustructure.Dto.GoodOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.Dto.Goods
{
    public record GoodShortInfoDto(
        Guid Id,
        string Name, 
        decimal Price, 
        string ImgUrl, 
        string SellerName,
        int Rating,
        List<GoodOptionDto> GoodOptions,
        List<Guid> Categories
    );
}