using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.Dto.Categories
{
    public record CategoryFullInfoDto(
        Guid Id, 
        string Name, 
        string Description,
        string Color, 
        string LogoUrl
    );
}