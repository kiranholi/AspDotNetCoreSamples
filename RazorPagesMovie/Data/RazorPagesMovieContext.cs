using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RazorPagesMovie.Data;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext(
            DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
    }

    public class RazorPagesMovieFactory : IDesignTimeDbContextFactory<RazorPagesMovieContext>
    {
        public RazorPagesMovieContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RazorPagesMovieContext>();
            optionsBuilder.UseSqlite("Data Source=MvcMovie.db");

            return new RazorPagesMovieContext(optionsBuilder.Options);
        }
    }
}