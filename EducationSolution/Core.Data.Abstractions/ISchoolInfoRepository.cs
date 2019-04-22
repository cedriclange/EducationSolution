using Core.Data.Entities;
using ExtCore.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Abstractions
{
    public interface ISchoolInfoRepository : IRepository
    {
        void Add(SchoolInfo info);
        void Edit(SchoolInfo info);
    }
}
