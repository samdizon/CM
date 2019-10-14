using CM.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CM.Web.Models
{
    public class CustomerDepartmentViewModel
    {
        public Customer Customer { get; set; }

        public IEnumerable<Department> Departments { get; set; }
    }
}
