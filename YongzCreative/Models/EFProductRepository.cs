﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YongzCreative.Models
{
    public class EFProductRepository : IProductRepository
    {
        private AppDbContext _context;
    }
}