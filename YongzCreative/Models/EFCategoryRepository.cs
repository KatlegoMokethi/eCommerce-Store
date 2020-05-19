using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YongzCreative.Models
{
    public class EFCategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public EFCategoryRepository(AppDbContext appDbContext)
            : base(appDbContext)
        {
        }

    }
}
