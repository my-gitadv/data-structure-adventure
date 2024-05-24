using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exp2
{

    public class SphereGrid

    {
        Sphere[,] arr;
        int size;
        int cap;

        public SphereGrid(int cap) {

            arr = new Sphere[cap,cap];
            size = 0;
            this.cap = cap;
        }

        public void insertSphere(Sphere s, int i, int j)
        {
            arr[i,j] = s;
        }
        public void run()
        {
            Sphere ss = arr[0,0];
            while(ss.nextI != -1)
            {
                Console.WriteLine(ss.name + " +" + ss.stat);
                ss = arr[ss.nextI, ss.nextJ];
            }
            Console.WriteLine(ss.name + " +" + ss.stat);

        }


    }
}
