﻿using Microsoft.EntityFrameworkCore;
using MoiveApi.Persistence.Context;
using MovieApp.Application.Features.Results.CategoryResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Features.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly MovieContext _context;

        public GetCategoryQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var values = await _context.Categories.ToListAsync();
            return values.Select(x => new GetCategoryQueryResult
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName
            }).ToList();
        }
    }
}
