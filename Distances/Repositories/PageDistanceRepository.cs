using System.Collections.Generic;
using Distances.Models;

namespace Distances.Repositories
{
    public class PageDistanceRepository
    {
        public List<PageDistance> GetAll()
        {
            var page1 = GetPage1();

            return new List<PageDistance>
            {
                GetPage1(),
                GetPage2(),
                GetPage3(),
                GetPage4(),
                GetPage5(),
                GetPage6(),
                GetPage7(),
                GetPage8(),
                GetPage9(),
                GetPage10(),
                GetPage11(),
                GetPage12(),
                GetPage13(),
                GetPage14(),
                GetPage15(),
                GetPage16()
            };
        }

        private static PageDistance GetPage1()
        {
            var pageDistance = new PageDistance();

            pageDistance.SetValue(0, 6477, Unit.Yard);
            pageDistance.SetValue(1, 113, Unit.Fathom);
            pageDistance.SetValue(2, 260, Unit.Furlong);
            pageDistance.SetValue(3, 238, Unit.Chain);
            pageDistance.SetValue(4, 13, Unit.Mile);
            pageDistance.SetValue(5, 3363, Unit.Foot);
            pageDistance.SetValue(6, 16093, Unit.Inch);
            return pageDistance;
        }

        private static PageDistance GetPage2()
        {
            var pageDistance = new PageDistance();

            pageDistance.SetValue(0, 668, Unit.Chain);
            pageDistance.SetValue(1, 2077, Unit.Fathom);
            pageDistance.SetValue(2, 856, Unit.Chain);
            pageDistance.SetValue(3, 4192, Unit.Rod);
            pageDistance.SetValue(4, 15805, Unit.Yard);
            pageDistance.SetValue(5, 4000, Unit.Rod);
            pageDistance.SetValue(6, 325668, Unit.Inch);

            return pageDistance;
        }

        private static PageDistance GetPage3()
        {
            var pageDistance = new PageDistance();

            pageDistance.SetValue(0, 233, Unit.Mile);
            pageDistance.SetValue(1, 82, Unit.Furlong);
            pageDistance.SetValue(2, 633, Unit.Chain);
            pageDistance.SetValue(3, 6046, Unit.Fathom);
            pageDistance.SetValue(4, 2059, Unit.Yard);
            pageDistance.SetValue(5, 10402, Unit.Foot);
            pageDistance.SetValue(6, 87432, Unit.Inch);

            return pageDistance;
        }

        private static PageDistance GetPage4()
        {
            var pageDistance = new PageDistance();

            pageDistance.SetValue(0, 125, Unit.Mile);
            pageDistance.SetValue(1, 421, Unit.Foot);
            pageDistance.SetValue(2, 260, Unit.Chain);
            pageDistance.SetValue(3, 56, Unit.Furlong);
            pageDistance.SetValue(4, 8677, Unit.Yard);
            pageDistance.SetValue(5, 1285, Unit.Fathom);
            pageDistance.SetValue(6, 109613, Unit.Inch);

            return pageDistance;
        }

        private static PageDistance GetPage5()
        {
            var pageDistance = new PageDistance();

            pageDistance.SetValue(0, 494, Unit.Mile);
            pageDistance.SetValue(1, 27, Unit.Fathom);
            pageDistance.SetValue(2, 13, Unit.Chain);
            pageDistance.SetValue(3, 177, Unit.Furlong);
            pageDistance.SetValue(4, 9029, Unit.Yard);
            pageDistance.SetValue(5, 1927, Unit.Foot);
            pageDistance.SetValue(6, 103277, Unit.Inch);

            return pageDistance;
        }

        private static PageDistance GetPage6()
        {
            var pageDistance = new PageDistance();

            pageDistance.SetValue(0, 395, Unit.Mile);
            pageDistance.SetValue(1, 1830, Unit.Fathom);
            pageDistance.SetValue(2, 295, Unit.Chain);
            pageDistance.SetValue(3, 794, Unit.Rod);
            pageDistance.SetValue(4, 13798, Unit.Yard);
            pageDistance.SetValue(5, 15312, Unit.Foot);
            pageDistance.SetValue(6, 16854, Unit.Inch);

            return pageDistance;
        }

        private static PageDistance GetPage7()
        {
            var pageDistance = new PageDistance();

            pageDistance.SetValue(0, 214, Unit.Mile);
            pageDistance.SetValue(1, 1056, Unit.Rod);
            pageDistance.SetValue(2, 89, Unit.Chain);
            pageDistance.SetValue(3, 4162, Unit.Fathom);
            pageDistance.SetValue(4, 5262, Unit.Yard);
            pageDistance.SetValue(5, 19272, Unit.Foot);
            pageDistance.SetValue(6, 98842, Unit.Inch);

            return pageDistance;
        }

        private static PageDistance GetPage8()
        {
            var pageDistance = new PageDistance();

            pageDistance.SetValue(0, 436, Unit.Mile);
            pageDistance.SetValue(1, 4384, Unit.Rod);
            pageDistance.SetValue(2, 707, Unit.Chain);
            pageDistance.SetValue(3, 8061, Unit.Fathom);
            pageDistance.SetValue(4, 14379, Unit.Yard);
            pageDistance.SetValue(5, 19906, Unit.Foot);
            pageDistance.SetValue(6, 31490, Unit.Inch);

            return pageDistance;
        }

        private static PageDistance GetPage9()
        {
            var pageDistance = new PageDistance();

            pageDistance.SetValue(0, 298, Unit.Mile);
            pageDistance.SetValue(1, 53, Unit.Rod);
            pageDistance.SetValue(2, 410, Unit.Chain);
            pageDistance.SetValue(3, 22352, Unit.Fathom);
            pageDistance.SetValue(4, 4224, Unit.Yard);
            pageDistance.SetValue(5, 7181, Unit.Foot);
            pageDistance.SetValue(6, 42198, Unit.Inch);

            return pageDistance;
        }

        private static PageDistance GetPage10()
        {
            var pageDistance = new PageDistance();

            pageDistance.SetValue(0, 376, Unit.Mile);
            pageDistance.SetValue(1, 2227, Unit.Rod);
            pageDistance.SetValue(2, 414, Unit.Chain);
            pageDistance.SetValue(3, 1593, Unit.Fathom);
            pageDistance.SetValue(4, 660, Unit.Yard);
            pageDistance.SetValue(5, 25925, Unit.Foot);
            pageDistance.SetValue(6, 33898, Unit.Inch);

            return pageDistance;
        }

        private static PageDistance GetPage11()
        {
            var pageDistance = new PageDistance();

            pageDistance.SetValue(0, 404, Unit.Mile);
            pageDistance.SetValue(1, 18, Unit.Furlong);
            pageDistance.SetValue(2, 298, Unit.Chain);
            pageDistance.SetValue(3, 2068, Unit.Fathom);
            pageDistance.SetValue(4, 2429, Unit.Yard);
            pageDistance.SetValue(5, 842, Unit.Foot);
            pageDistance.SetValue(6, 4224, Unit.Inch);

            return pageDistance;
        }

        private static PageDistance GetPage12()
        {
            var pageDistance = new PageDistance();

            pageDistance.SetValue(0, 369, Unit.Mile);
            pageDistance.SetValue(1, 3030, Unit.Rod);
            pageDistance.SetValue(2, 595, Unit.Chain);
            pageDistance.SetValue(3, 6811, Unit.Fathom);
            pageDistance.SetValue(4, 1971, Unit.Yard);
            pageDistance.SetValue(5, 5702, Unit.Foot);
            pageDistance.SetValue(6, 152064, Unit.Inch);

            return pageDistance;
        }

        private static PageDistance GetPage13()
        {
            var pageDistance = new PageDistance();

            pageDistance.SetValue(0, 361, Unit.Mile);
            pageDistance.SetValue(1, 544, Unit.Rod);
            pageDistance.SetValue(2, 5, Unit.Chain);
            pageDistance.SetValue(3, 2024, Unit.Fathom);
            pageDistance.SetValue(4, 662, Unit.Yard);
            pageDistance.SetValue(5, 7075, Unit.Foot);
            pageDistance.SetValue(6, 13116, Unit.Inch);

            return pageDistance;
        }

        private static PageDistance GetPage14()
        {
            var pageDistance = new PageDistance();

            pageDistance.SetValue(0, 454, Unit.Mile);
            pageDistance.SetValue(1, 1296, Unit.Rod);
            pageDistance.SetValue(2, 285, Unit.Chain);
            pageDistance.SetValue(3, 2596, Unit.Fathom);
            pageDistance.SetValue(4, 6917, Unit.Yard);
            pageDistance.SetValue(5, 12989, Unit.Foot);
            pageDistance.SetValue(6, 22746, Unit.Inch);

            return pageDistance;
        }

        private static PageDistance GetPage15()
        {
            var pageDistance = new PageDistance();

            pageDistance.SetValue(0, 7008, Unit.Rod);
            pageDistance.SetValue(1, 236, Unit.Furlong);
            pageDistance.SetValue(2, 1968, Unit.Chain);
            pageDistance.SetValue(3, 43120, Unit.Fathom);
            pageDistance.SetValue(4, 26400, Unit.Yard);
            pageDistance.SetValue(5, 3305, Unit.Foot);
            pageDistance.SetValue(6, 12165, Unit.Inch);

            return pageDistance;
        }

        private static PageDistance GetPage16()
        {
            var pageDistance = new PageDistance();

            pageDistance.SetValue(0, 207, Unit.Mile);
            pageDistance.SetValue(1, 2464, Unit.Rod);
            pageDistance.SetValue(2, 350, Unit.Fathom);
            pageDistance.SetValue(3, 1197, Unit.Foot);
            pageDistance.SetValue(4, 11352, Unit.Yard);
            pageDistance.SetValue(5, 4763, Unit.Foot);
            pageDistance.SetValue(6, 28956, Unit.Inch);

            return pageDistance;
        }
    }
}