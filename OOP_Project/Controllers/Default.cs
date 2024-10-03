using Microsoft.AspNetCore.Mvc;
using OOP_Project.Example;

namespace OOP_Project.Controllers
{
    public class Default : Controller
    {
        //void process()
        //{
        //    Class1 class1 = new Class1();
        //    class1.sum();
        //    class1.mlt();
        //}

        void messages()
        {
            ViewBag.m1 = "Hello world, this is a core project";
            ViewBag.m2 = "Programming is fun";
            ViewBag.m3 = "Selamlar, Hi, Hallo, Bonjour";
        }

        int sum()
        {
            int num1, num2, sum;
            num1 = 3;
            num2 = 4;
            sum = num1 + num2;
            return sum;
        }

        int rectangleArea()
        {
            int shortSide, longSide, area;
            shortSide = 3;
            longSide = 4;
            area = 2 * (shortSide + longSide);
            return area;
        }

        int rectangleEnvironment()
        {
            int shortSide, longSide, environment;
            shortSide = 3;
            longSide = 4;
            environment = shortSide * longSide;
            return environment;
        }

        int factorial()
        {
            int num, resut = 1;
            num = 5;
            for (int i = 1; i <= num; i++)
            {
                resut *= i;
            }
            return resut;
        }

        string sentence()
        {
            string c = "Hello";
            string c2 = "World";
            string snt = c + " " + c2;
            return snt;
        }

        int factorialParameter(int num1)
        {
            int num, resut = 1;
            num = num1;
            for (int i = 1; i <= num; i++)
            {
                resut *= i;
            }
            return resut;
        }

        string sentenceParameter(string sent)
        {
            string snt = sent;
            return snt;
        }

        public IActionResult Index()
        {
            messages();
            return View();
        }

        public IActionResult Products()
        {
            messages();
            ViewBag.sum = sum();
            ViewBag.rctArea = rectangleArea();
            ViewBag.rctEnvironment = rectangleEnvironment();
            ViewBag.fct = factorial();
            return View();
        }

        public IActionResult Customer()
        {
            ViewBag.snt = sentence();
            ViewBag.sntp = sentenceParameter("Parameter");
            ViewBag.fctp = factorialParameter(5);
            return View();
        }

        public IActionResult tyrCity()
        {
            Cities cities = new Cities();

            cities.CityId = 1;
            cities.RegionName = "Gaziantep";
            cities.RegionPopulation = 3000000;
            cities.RegionCountyr = "Türkiye";
            cities.FlagColor1 = "Red";
            cities.FlagColor2 = "White";

            ViewBag.infoId = cities.CityId;
            ViewBag.infoName = cities.RegionName;
            ViewBag.infoPop = cities.RegionPopulation;
            ViewBag.infoCon = cities.RegionCountyr;
            ViewBag.flagc1 = cities.FlagColor1;
            ViewBag.flagc2 = cities.FlagColor2;
            ViewBag.flagc3 = cities.FlagColor3;

            cities.CityId = 2;
            cities.RegionName = "Berlin";
            cities.RegionPopulation = 2700000;
            cities.RegionCountyr = "Germany";
            cities.FlagColor1 = "Black";
            cities.FlagColor2 = "Red";
            cities.FlagColor3 = "Yellow";

            ViewBag.infoId1 = cities.CityId;
            ViewBag.infoName1 = cities.RegionName;
            ViewBag.infoPop1 = cities.RegionPopulation;
            ViewBag.infoCon1 = cities.RegionCountyr;
            ViewBag.flagc11 = cities.FlagColor1;
            ViewBag.flagc21 = cities.FlagColor2;
            ViewBag.flagc31 = cities.FlagColor3;

            return View();
        }
    }
}
