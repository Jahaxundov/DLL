using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork26._07._23
{
    public abstract class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract void Sound();
    }
}
