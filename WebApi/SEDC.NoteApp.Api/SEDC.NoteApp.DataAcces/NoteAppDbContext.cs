using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.NoteApp.DataAcces
{
    public class NoteAppDbContext : DbContext
    {
        public NoteAppDbContext(DbContextOptions option) : base(option) {}


    }
}
