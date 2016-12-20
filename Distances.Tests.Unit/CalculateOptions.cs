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
    }
}
