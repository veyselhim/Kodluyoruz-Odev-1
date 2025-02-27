﻿using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IBlogRepository : IRepository<Blog>
    {
        List<Blog> GetAllByCategory(int categoryId);

        Task AddWithCategories(Blog blog);

        List<Blog> GetAllByTag(int tagId);

        Task AddWithTags(Blog blog);
    }
}
