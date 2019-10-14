using System;
using System.Collections.Generic;
using System.Text;
using CM.Core.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace CM.Core.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        //[Column("Gender",TypeName = "nvarchar(10)")]
        public Gender Gender { get; set; }

        public Department Department { get; set; }

        public int DepartmentId { get; set; }
    }
}
