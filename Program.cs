using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using SpaceSim;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList a = new ArrayList();

            SpaceObject solen = new Star("Sol", "Yellow", 0, 10);
            a.Add(solen);
            a.Add(new Planet("Mercury", 0, 10, 12, solen, 3, 20));
            a.Add(new Planet("Venus"));
            a.Add(new Planet("Terra"));
            a.Add(new Moon("Luna"));

            for (int i = 0; i < a.Count; i++)
            {
                SpaceObject obj = (SpaceObject)(a[i]);
                obj.Draw();
            }

            Console.ReadLine();
		
        }
    }
}
