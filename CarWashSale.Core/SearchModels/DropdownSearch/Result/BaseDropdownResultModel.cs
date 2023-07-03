using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashSale.Core.SearchModels.DropdownSearch.Result
{
    public class BaseDropdownResultModel<T>
    {
        public List<T> Result { get; set; } = new List<T>();
        public DropdownPaginationModel Pagination { get; set; } = new DropdownPaginationModel();
    }
}
