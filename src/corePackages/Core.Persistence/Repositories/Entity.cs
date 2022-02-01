using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Repositories
{
    public class Entity
    {
        public Entity()
        {
        }

        public Entity(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
