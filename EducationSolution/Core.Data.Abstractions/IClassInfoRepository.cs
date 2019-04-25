using Core.Data.Entities;
using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Abstractions
{
    public interface IClassInfoRepository : IRepository
    {
        Task<IEnumerable<ClassInfo>> All();
        Task<IEnumerable<ClassInfo>> FromSection(int id);
        Task<ClassInfo> WithKey(int id);
        void Create(ClassInfo info); 
    }
}
