﻿using ExtCore.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Entities
{
    public class ClassInfo : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsSecondary { get; set; }
        public int SectionInfo { get; set; }
        //foreign Keys
        public SectionInfo Section { get; set; }

    }
}
