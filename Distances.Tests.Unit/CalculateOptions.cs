using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using Distances.Models;
using Distances.Repositories;
using FluentAssertions;
using NUnit.Framework;

namespace Distances.Tests.Unit
{
    [TestFixture]
    public class CalculateOptions
    {
        [Test]
        public void Calculate()
        {
            // Beer - Pub: 172.105399940837
            // Pub - Lion: 412.185224238556
            // Lion - Beacon: 449.450582127326
            // Beacon - Quarry: 278.880630283756
            // Quarry - CarPark: 291.072136774405

            var pageDistances = new PageDistanceRepository().GetAll();

            var page1Distances = pageDistances[0];
            var rowA = page1Distances.RowValue[0];
            var rowB = page1Distances.RowValue[1];
            var rowC = page1Distances.RowValue[2];
            var rowD = page1Distances.RowValue[3];
            var rowE = page1Distances.RowValue[4];
            var rowF = page1Distances.RowValue[5];
            var rowG = page1Distances.RowValue[6];

            for (var pageIdx = 1; pageIdx < pageDistances.Count; ++pageIdx)
            {
                
            }
        }

        [Test]
        public void CalculateDistanceForLeg()
        {
            var locations = new LocationRepository().GetAll();

            var hookNorton = locations.First(l => l.Name.StartsWith("Hook Norton"));
            var theBridge = locations.First(l => l.Name.StartsWith("The Bridge"));

            var dist = DistanceCalculator.CalculateDistance(hookNorton, theBridge);

            dist.Should().BeApproximately(144.738, 0.1);
        }

        [Test]
        public void CalculateMaxDistanceForBeerToPubLeg()
        {
            // HN - TB 144.738
            // HN - BSwan 65.5
            // StA - TB 172.1
            // StA - BSwan 31.6

            var locations = new LocationRepository().GetAll();

            var hookNorton = locations.First(l => l.Name.StartsWith("Hook Norton"));
            var stAlbans = locations.First(l => l.Name.StartsWith("St Albans"));

            var theBridge = locations.First(l => l.Name.StartsWith("The Bridge"));
            var blackSwan = locations.First(l => l.Name.StartsWith("Black Swan"));

            var maxDist = DistanceCalculator.CalculateMaximum(new List<Location> {hookNorton, stAlbans},
                new List<Location> {theBridge, blackSwan});

            maxDist.Should().BeApproximately(172.1, 0.1);
        }

        [Test]
        public void FindMaxDistanceForEachLeg()
        {
            var locations = new LocationRepository().GetAll();

            // Beer
            var hookNorton = locations.First(l => l.Name.StartsWith("Hook Norton"));
            var stAlbans = locations.First(l => l.Name.StartsWith("St Albans"));

            // Pub
            var theBridge = locations.First(l => l.Name.StartsWith("The Bridge"));
            var blackSwan = locations.First(l => l.Name.StartsWith("Black Swan"));

            // Lion
            var kidstone = locations.First(l => l.Name.StartsWith("Kidstone"));
            var balmoral = locations.First(l => l.Name.StartsWith("Balmoral"));

            // Beacon
            var firle = locations.First(l => l.Name.StartsWith("Firle"));
            var kington = locations.First(l => l.Name.StartsWith("The Beacon Kington"));

            // Quarry
            var coniston = locations.First(l => l.Name.StartsWith("Coniston"));
            var pitstone = locations.First(l => l.Name.StartsWith("Pitstone"));

            // Car Park
            var perranporth = locations.First(l => l.Name.StartsWith("Perranporth"));
            var orford = locations.First(l => l.Name.StartsWith("Orford"));

            var beer = new List<Location> {hookNorton, stAlbans};
            var pub = new List<Location> {theBridge, blackSwan};
            var lion = new List<Location> {kidstone, balmoral};
            var beacon = new List<Location> {firle, kington};
            var quarry = new List<Location> {coniston, pitstone};
            var carPark = new List<Location> {perranporth, orford};

            var beerToPub = DistanceCalculator.CalculateMaximum(beer, pub);
            var pubToLion = DistanceCalculator.CalculateMaximum(pub, lion);
            var lionToBeacon = DistanceCalculator.CalculateMaximum(lion, beacon);
            var beaconToQuarry = DistanceCalculator.CalculateMaximum(beacon, quarry);
            var quarryToCarPark = DistanceCalculator.CalculateMaximum(quarry, carPark);

            Console.WriteLine($"Beer-Pub: {beerToPub}");
            Console.WriteLine($"Pub-Lion: {pubToLion}");
            Console.WriteLine($"Lion-Beacon: {lionToBeacon}");
            Console.WriteLine($"Beacon-Quarry: {beaconToQuarry}");
            Console.WriteLine($"Quarry-CarPark: {quarryToCarPark}");
        }

        [Test]
        public void FrequencyAnalysis()
        {
            const string p2 = "3718337923432353171371353293675373519132379235377351967231954743253513435353113435371432112337236767253113";
            const string p5 = "2967534757117367593671131537359835937137717367567371196727923713723567331325371234367535191337537313235357153593713731537153295367117972934343235716723231323367173779729591323151347367112319832713743";
            const string p10 = "377171536759255315373591371672334723313717351171531371535937152523712323571372677197767219312313233671737257167537331375233674371311238323434322313";
            const string p13 = "29534343538331753675593713713296753474753573472357113233671737735192367523371371328971377235173747367112319832713743";
            const string p14 = "296753473753439777324319253171311232953537159371378337217371353535415325133553713723677173675673153257153716723231313233671737371713767232371677351123197167232347367112319832713743";

            Console.WriteLine($" 2: {p2.Length}");
            Console.WriteLine($" 5: {p5.Length}"); // 1 and 199
            Console.WriteLine($"10: {p10.Length}");
            Console.WriteLine($"13: {p13.Length}");
            Console.WriteLine($"14: {p14.Length}");

            var all = $"{p2}{p5}{p10}{p13}{p14}";
            Console.WriteLine($"Total: {all.Length}"); // 748: 1,2,4,11,17,22,34,44,68,187,374,748

            var ch = new Dictionary<char, int>();
            for (var idx = 0; idx < all.Length; ++idx)
            {
                var c = all[idx];
                if (!ch.ContainsKey(c)) ch.Add(c, 0);
                ch[c]++;
            }
            var orderedChars = ch.OrderByDescending(c => c.Value);
            foreach (var c in orderedChars)
            {
                Console.WriteLine($"{c.Key} - {c.Value}");
            }

            var pairs = new Dictionary<string, int>();
            for (var idx = 0; idx < all.Length; idx += 2)
            {
                var chPair = all.Substring(idx, 2);
                if (!pairs.ContainsKey(chPair)) pairs.Add(chPair, 0);
                pairs[chPair]++;
            }

            var orderedPairs = pairs.OrderByDescending(p => p.Value);
            Console.WriteLine($"Total pairs: {pairs.Keys.Count}");
            foreach (var orderedPair in orderedPairs)
            {
                Console.WriteLine($"{orderedPair.Key} - {orderedPair.Value}");
            }

            var quads = new Dictionary<string, int>();
            for (var idx = 0; idx < all.Length; idx += 4)
            {
                var quad = all.Substring(idx, 4);
                if (!quads.ContainsKey(quad)) quads.Add(quad, 0);
                quads[quad]++;
            }

            var orderedQuads = quads.OrderByDescending(q => q.Value);
            Console.WriteLine($"Total quads: {quads.Keys.Count}");
            foreach (var orderedQuad in orderedQuads)
            {
                Console.WriteLine($"{orderedQuad.Key} - {orderedQuad.Value}");
            }
        }
    }
}
