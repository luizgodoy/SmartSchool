using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Helpers
{
    public class PageParams
    {
        public int MaxPageSize { get; set; }

        public int PageNumber { get; set; } = 1;

        private int pageSize = 10;

        public int PageSize 
        {
            get { return pageSize; }   
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value;  }
        }

        public int? Matricula { get; set; }

        public string Nome { get; set; } = string.Empty;

        public int? Ativo { get; set; } = null;

        public string Ordem { get; set; } = "ASC";
    }
}
