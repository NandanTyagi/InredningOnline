using InredningOnline.Models;
using Xunit;

namespace InredningOnline.Tests
{
    public class MockProjectRepoTests
    {
        [Fact]
        public void ProjectAndMaterialsShouldBeCreatedAndAddedToRepo()
        {
            var repo1 = new MockProjectRepo();

            var user1 = new User();
            user1.Name = "Nandan";
            user1.Email = "me@nandan.com";

            var testProject = new Project("Test Project", user1, repo1);
            testProject.Materials.Add(new Material { Name = "Table", Price = 20, Amount = 1, Details = "N/A" });
            testProject.Materials.Add(new Material { Name = "Chair", Price = 10, Amount = 2, Details = "N/A" });
            testProject.Materials.Add(new Material { Name = "Phone", Price = 50, Amount = 5, Details = "N/A" });

            var expectedProjectName = "Test Project";
            var expectedUserName = "Nandan";
            var expectedMaterialName = "Phone";
            var expectedCount = 3;
            var expectedRepoCount = 1;


            var actualProjectName = testProject.Name;
            var actualUserName = user1.Name;
            var actualMaterialName = testProject.Materials[2].Name;
            var actualCount = testProject.Materials.Count;
            var actualRepoCount = repo1.AllProjects.Count;



            Assert.Equal(expectedProjectName, actualProjectName);
            Assert.Equal(expectedUserName, actualUserName);
            Assert.Equal(expectedMaterialName, actualMaterialName);
            Assert.Equal(expectedCount, actualCount);
            Assert.Equal(expectedRepoCount, actualRepoCount);
        }
    }
}
