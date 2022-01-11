using Microsoft.EntityFrameworkCore;
using MvcNetCoreEF2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreEF2022.Data
{
    //hay que heredar de DbContext (importante)
    public class DoctoresContext: DbContext
    {
        //creamos el constructor con la option de doctores context
        public DoctoresContext(DbContextOptions<DoctoresContext> options) : base(options) { }
        public DbSet<Doctor> Doctores { get; set; }
    }
}
