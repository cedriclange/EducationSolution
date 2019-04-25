using Core.Data.Abstractions;
using Core.Data.Entities;
using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.EFCore.Sqlite
{
    public class SchoolRepository : RepositoryBase<SchoolInfo>, ISchoolInfoRepository
    {
        public void Add(SchoolInfo info)
        {
            dbSet.Add(info);
        }

        public void Edit(SchoolInfo info)
        {
            storageContext.Entry(info).State = EntityState.Modified;
        }

        public async Task<SchoolInfo> WithKey(int id)
        {
            return await dbSet.FirstOrDefaultAsync(e=>e.Id == id);
        }
    }
}
