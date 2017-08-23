using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //DH dh = new DH();
            //Console.WriteLine(dh.BuilderHero());
            //POM pom = new POM();
            //Console.WriteLine(pom.BuilderHero());
            //Console.ReadLine();
            Director director = new Director();

            DHBuilder buider1 = new DHBuilder();
            director.Construct(buider1);
            Hero dh = buider1.GetResult();

            DHBuilder buider2 = new DHBuilder();
            director.Construct(buider2);
            Hero pom = buider1.GetResult();
        }
    }
}
