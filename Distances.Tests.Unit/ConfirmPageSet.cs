using Distances.Repositories;
using FluentAssertions;
using NUnit.Framework;

namespace Distances.Tests.Unit
{
    [TestFixture]
    public class ConfirmPageSet
    {
        [Test]
        public void ConfirmSixteenPages()
        {
            var allPages = new PageDistanceRepository().GetAll();

            allPages.Count.Should().Be(16);
        }
    }
}
