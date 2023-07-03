using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashSale.Core.SearchModels.DropDownSearch.Param
{
    public class BaseDropdownModel
    {
        public string termTemp { get; set; } = "";
        public string term { get; set; } = "";
        public int page { get; set; } = 1;
        public int pageSize { get; set; } = 10;
        public int Skip()
        {
            return (page - 1) * pageSize;
        }
    }
}
