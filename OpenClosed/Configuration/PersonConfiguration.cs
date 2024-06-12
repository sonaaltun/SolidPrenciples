using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenClosed.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Configuration
{
    public class PersonConfiguration : BaseConfiguration<Person>
    {
        public override void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(x => x.Department).IsRequired();
            base.Configure(builder);
        }
    }
}
