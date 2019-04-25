using Core.Data.Abstractions;
using Core.Data.Entities;
using ExtCore.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Core.EFCore.Sqlite
{
    public class ClassRepository : RepositoryBase<ClassInfo>, IClassInfoRepository
    {
        public async Task<IEnumerable<ClassInfo>> All()
        {
            return await dbSet.OrderBy(e => e.Grade)
                .ToListAsync();  
        }

        public void Create(ClassInfo info)
        {
            dbSet.Add(info);
        }

        public async Task<IEnumerable<ClassInfo>> FromSection(int id)
        {
            return await dbSet.Where(e => e.SectionId == id)
                .OrderBy(e => e.Grade)
                .ToListAsync();
        }

        public async Task<ClassInfo> WithKey(int id)
        {
            return await dbSet.FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
