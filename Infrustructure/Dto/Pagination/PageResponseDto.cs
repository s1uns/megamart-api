using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.Dto.Pagination
{
    public class PageResponseDto<T>
    {
        public List<T> Data { get; set; }
        public int TotalPages { get; set; }
    }
}