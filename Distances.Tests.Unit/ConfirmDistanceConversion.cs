using Distances.Repositories;
using FluentAssertions;
using NUnit.Framework;

namespace Distances.Tests.Unit
{
    [TestFixture]
    public class ConfirmDistanceConversion
    {
        [Test]
        public void Page1()
        {
            var allPages = new PageDistanceRepository().GetAll();

            var page1 = allPages[0];

            page1.RowValue[0].Should().BeApproximately(3.68M, 0.1M);
            page1.RowValue[1].Should().BeApproximately(0.128M, 0.1M);
            page1.RowValue[2].Should().BeApproximately(32.5M, 0.1M);
            page1.RowValue[3].Should().BeApproximately(2.975M, 0.1M);
            page1.RowValue[4].Should().Be(13);
            page1.RowValue[5].Should().BeApproximately(0.637M, 0.1M);
            page1.RowValue[6].Should().BeApproximately(0.254M, 0.1M);

            var page2 = allPages[1];

            page2.RowValue[5].Should().BeApproximately(12.5M, 0.1M);
        }
    }
}
