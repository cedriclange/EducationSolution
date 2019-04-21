using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Entities
{
    public class SchoolInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsSecondary { get; set; }
        public DateTime Created { get; set; }


    }
}
