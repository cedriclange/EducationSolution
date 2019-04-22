using ExtCore.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Entities
{
    public class SectionInfo : IEntity
    {
        public SectionInfo()
        {
            Classes = new HashSet<ClassInfo>();
        }
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ICollection<ClassInfo> Classes { get; set; }

    }
}
