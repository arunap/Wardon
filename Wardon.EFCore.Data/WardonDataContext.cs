using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;

namespace Wardon.EFCore.Data
{
    public class WardonDataContext : DbContext
    {
        public WardonDataContext(DbContextOptions options) : base(options)
        {
        }

        protected WardonDataContext()
        {
        }
    }
}
