﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Data.Context;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class TagRepository : Repository<Tag> , ITagRepository
    {
        public TagRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
