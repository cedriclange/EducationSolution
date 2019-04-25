using Core.Data.Entities;
using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Abstractions
{
    public interface ISchoolInfoRepository : IRepository
    {
        void Add(SchoolInfo info);
        void Edit(SchoolInfo info);
        Task<SchoolInfo> WithKey(int id);
    }
}
