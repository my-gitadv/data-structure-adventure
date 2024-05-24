using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exp2
{
    public class Sphere
    {
        public String name;
        public int stat;
        public int nextI;
        public int nextJ;

        public Sphere( String name, int stat, int ni, int nj) {
        
            this.name = name;
            this.stat = stat;
            this.nextI = ni;
            this.nextJ = nj;
        }
    }
}
