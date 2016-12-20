using System;
using System.Collections.Generic;
using System.Linq;
using Distances.Models;

namespace Distances
{
    public static class DistanceCalculator
    {
        public static double CalculateMaximum(List<Location> from, List<Location> to)
        {
            double maxDistance = 0;
            foreach (var fromLocation in from)
            {
                maxDistance = to.Select(toLocation => CalculateDistance(fromLocation, toLocation)).Concat(new[] {maxDistance}).Max();
            }
            return maxDistance;
        }

        public static double CalculateDistance(Location from, Location to)
        {
            var theta = from.Longitude - to.Longitude;
            var thetaRad = Math.PI * theta / 180;

            var dist =
                Math.Sin(from.Rad) * Math.Sin(to.Rad) + Math.Cos(from.Rad) *
                Math.Cos(to.Rad) * Math.Cos(thetaRad);
            dist = Math.Acos(dist);

            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

            return dist;
        }
    }
}
