using InredningOnline.Models;
using Xunit;

namespace InredningOnline.Tests
{
    public class MockRepoTests
    {
        [Fact]
        public void CorrectTotalCostOfAllProjectsShouldBeCalculated()
        {
            var projectRepo = new MockProjectRepo();
            var materialRepo = new MockMaterialRepo();
            var designerRepo = new MockDesignerRepo();

            var expected = 1676;
            var actual = projectRepo.GetTotalCost();

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CorrectTotalCostPerDesignerShouldBeCalculated()
        {
            var projectRepo = new MockProjectRepo();
            var materialRepo = new MockMaterialRepo();
            var designerRepo = new MockDesignerRepo();

            var expected = 164;
            var actual = projectRepo.GetTotalCost(1);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CorrectAverageCostOfAllProjectsShouldBeCalculated()
        {
            var projectRepo = new MockProjectRepo();
            var materialRepo = new MockMaterialRepo();
            var designerRepo = new MockDesignerRepo();

            var expected = 419;
            var actual = projectRepo.GetAverageCost();

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CorrectAverageCostPerDesignerShouldBeCalculated()
        {
            var projectRepo = new MockProjectRepo();
            var materialRepo = new MockMaterialRepo();
            var designerRepo = new MockDesignerRepo();

            var expected = 736;
            var actual = projectRepo.GetAverageCost(2);

            Assert.Equal(expected, actual);
        }
    }
}
