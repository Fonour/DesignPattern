using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hero dh = new Hero("DH");
            //dh.ShowSkills();

            //Hero wd = new Hero("WD");
            //wd.ShowSkills();

            //Hero kog = new Hero("KOG");
            //kog.ShowSkills();

            //Hero pom = new Hero("POM");
            //pom.ShowSkills();

            //IHero dh = new DH();
            //dh.ShowSkills();

            //IHero wd = new WD();
            //wd.ShowSkills();

            //IHero kog = new KOG();
            //kog.ShowSkills();

            //IHero pom = new POM();
            //pom.ShowSkills();

            IHero dh = Factory.CreateHero("DH");
            dh.ShowSkills();

            IHero wd = Factory.CreateHero("WD");
            wd.ShowSkills();

            IHero kog = Factory.CreateHero("KOG");
            kog.ShowSkills();

            IHero pom =  Factory.CreateHero("POM");
            pom.ShowSkills();

            Console.ReadLine();
        }
    }
}
