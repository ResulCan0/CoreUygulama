using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CoreUygulama.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreUygulama.Data.Seed
{
    public class PersonSeed : IEntityTypeConfiguration<Person>
    {
        private readonly int[] _ids;

        public PersonSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(new Person { Id = _ids[0], Name = "Can", Surname = "Çördük" },new Person {Id=_ids[1],Name="Çağla",Surname="Turgut" });
        }
    }
}
