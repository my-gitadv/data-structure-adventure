using System;
namespace exp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            SphereGrid grid = new SphereGrid(5);
            grid.insertSphere(new Sphere("Atk", 3, 2, 1), 0, 0);
            grid.insertSphere(new Sphere("Def", 5, 1, 3), 2, 1);
            grid.insertSphere(new Sphere("Mag Def", 2, 3, 2), 1, 3);
            grid.insertSphere(new Sphere("At2", 5, 2, 2), 3, 2);
            grid.insertSphere(new Sphere("At2", 4, -1, -1), 2, 2);

            grid.run();

        }
    }
}
