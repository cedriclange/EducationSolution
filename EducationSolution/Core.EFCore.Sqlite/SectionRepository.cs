using Core.Data.Abstractions;
using Core.Data.Entities;
using ExtCore.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Core.EFCore.Sqlite
{
    public class SectionRepository : RepositoryBase<SectionInfo>, ISectionRepository
    {
        public void Create(SectionInfo section)
        {
            dbSet.Add(section);
        }

        public async Task<IEnumerable<SectionInfo>> All()
        {
            return await dbSet.OrderBy(e => e.Name).ToListAsync();
        }

        public void Edit(SectionInfo section)
        {
            storageContext.Entry(section).State = EntityState.Modified;
        }

        public async Task<SectionInfo> WithKey(int id)
        {
            return await dbSet.FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
