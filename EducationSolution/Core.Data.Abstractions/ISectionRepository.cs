using Core.Data.Entities;
using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Abstractions
{
    public interface ISectionRepository : IRepository
    {
        IEnumerable<SectionInfo> All();
        SectionInfo WithKey(int id);
        void Add(SectionInfo section);
        void Edit(SectionInfo section);
    }
}
