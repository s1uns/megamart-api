﻿using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.Dto.Goods
{
    public record EditGoodDto(
        Guid Id,
        string Name,
        string Description,
        decimal Price,
        string ImgUrl,
        List<Guid> CategoryIds, 
        List<GoodOption> GoodOptions
    );
}