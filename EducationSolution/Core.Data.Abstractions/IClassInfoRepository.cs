using Core.Data.Entities;
using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Abstractions
{
    public interface IClassInfoRepository : IRepository
    {
        IEnumerable<ClassInfo> All();
        IEnumerable<ClassInfo> FromSection(int id);
        ClassInfo WithKey(int id);
        void Add(ClassInfo info); 
    }
}
