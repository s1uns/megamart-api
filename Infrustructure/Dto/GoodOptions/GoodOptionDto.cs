using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.Dto.GoodOptions
{
    public record GoodOptionDto( 
        Guid Id,
        string OptionName
    );
}