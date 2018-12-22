using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Wardon.Domain.Entities;

namespace Wardon.EFCore.Data.Configurations
{
   public class AuthorConfiguration
    {
        public AuthorConfiguration(EntityTypeBuilder<Author> entity)
        {

        }
    }
}
