// using InredningOnline.Models;
// using Xunit;

// namespace InredningOnline.Tests
// {
//     public class MockProjectRepoTests
//     {
//         [Fact]
//         public void ProjectAndMaterialsShouldBeCreatedAndAddedToMockRepo()
//         {
//             var repo1 = new MockProjectRepo();
//             var userRepo = new MockUserRepo();

//             var user1 = new User("Nandan","me@nandan.com",true);

//             var user2 = new User("Hadis","me@hadis.com",false);

//             var testProject = new Project("Test Project", user1, repo1);
//             testProject.AddMaterial(new Material { Name = "Table", Price = 20, Amount = 2, Details = "N/A" });
//             testProject.AddMaterial(new Material { Name = "Chair", Price = 10, Amount = 2, Details = "N/A" });
//             testProject.AddMaterial(new Material { Name = "Phone", Price = 50, Amount = 5, Details = "N/A" });

//             var testProject1 = new Project("Test Project1", user2, repo1);
//             testProject1.AddMaterial(new Material { Name = "Table1", Price = 200, Amount = 20, Details = "N/A" });
//             testProject1.AddMaterial(new Material { Name = "Chair1", Price = 100, Amount = 25, Details = "N/A" });
//             testProject1.AddMaterial(new Material { Name = "Phone1", Price = 500, Amount = 56, Details = "N/A" });

//             var expectedProjectName = "Test Project";
//             var expectedUserName = "Nandan";
//             var expectedMaterialName = "Phone";
//             var expectedMaterialCount = 3;
//             var expectedRepoCount = 2;
//             var expectedTotalCostOfProject = 310;
//             var expectedTotalCostOfProject1 = 34500;


//             var expectedTotalCostOfAllProjects = 34810;


//             var actualProjectName = testProject.Name;
//             var actualUserName = user1.Name;
//             var actualMaterialName = testProject.Materials[2].Name;
//             var actualMaterialCount = testProject.Materials.Count;
//             var actualRepoCount = repo1.AllProjects.Count;
//             var actualTotalCostOfProject = testProject.GetTotalCost();
//             var actualTotalCostOfProject1 = testProject1.GetTotalCost();

//             var actualTotalCostOfAllProjects = repo1.GetTotalCost();

//             Assert.Equal(expectedProjectName, actualProjectName);
//             Assert.Equal(expectedUserName, actualUserName);
//             Assert.Equal(expectedMaterialName, actualMaterialName);
//             Assert.Equal(expectedMaterialCount, actualMaterialCount);
//             Assert.Equal(expectedRepoCount, actualRepoCount);
//             Assert.Equal(expectedTotalCostOfProject, actualTotalCostOfProject);
//             Assert.Equal(expectedTotalCostOfProject1, actualTotalCostOfProject1);

//             Assert.Equal(expectedTotalCostOfAllProjects, actualTotalCostOfAllProjects);


//         }

//         [Fact]
//         void CorrectAverageShouldBeCalcualated()
//         {
//             var repo1 = new MockProjectRepo();
//             var userRepo = new MockUserRepo();

//             var user1 = new User(userRepo, "Nandan", "me@nandan.com", true);

//             var user2 = new User(userRepo, "Hadis", "me@hadis.com", false);

//             var testProject = new Project("Test Project", user1, repo1);
//             testProject.AddMaterial(new Material { Name = "Table", Price = 20, Amount = 2, Details = "N/A" });
//             testProject.AddMaterial(new Material { Name = "Chair", Price = 10, Amount = 2, Details = "N/A" });
//             testProject.AddMaterial(new Material { Name = "Phone", Price = 50, Amount = 5, Details = "N/A" });

//             var testProject1 = new Project("Test Project1", user2, repo1);
//             testProject1.AddMaterial(new Material { Name = "Table1", Price = 200, Amount = 20, Details = "N/A" });
//             testProject1.AddMaterial(new Material { Name = "Chair1", Price = 100, Amount = 25, Details = "N/A" });
//             testProject1.AddMaterial(new Material { Name = "Phone1", Price = 500, Amount = 56, Details = "N/A" });

//             var expectedAverage = 17405;

//             var actualAverage = repo1.GetAverageCost();

//             Assert.Equal(expectedAverage, actualAverage);


//         }
//         [Fact]
//         void CorrectDesignersShouldBeFiltered()
//         {
//             var repo1 = new MockProjectRepo();
//             var userRepo = new MockUserRepo();

//             var user1 = new User(userRepo, "Nandan", "me@nandan.com", true);

//             var user2 = new User(userRepo, "Hadis", "me@hadis.com", false);

//             var user3 = new User(userRepo, "Ali", "me@ali.com", false);

//             var testProject1 = new Project("Test Project", user1, repo1);
//             testProject1.AddMaterial(new Material { Name = "Table", Price = 20, Amount = 2, Details = "N/A" });
//             testProject1.AddMaterial(new Material { Name = "Chair", Price = 10, Amount = 2, Details = "N/A" });
//             testProject1.AddMaterial(new Material { Name = "Phone", Price = 50, Amount = 5, Details = "N/A" });

//             var testProject2 = new Project("Test Project1", user2, repo1);
//             testProject2.AddMaterial(new Material { Name = "Table1", Price = 200, Amount = 20, Details = "N/A" });
//             testProject2.AddMaterial(new Material { Name = "Chair1", Price = 100, Amount = 25, Details = "N/A" });
//             testProject2.AddMaterial(new Material { Name = "Phone1", Price = 500, Amount = 56, Details = "N/A" });

//             var testProject3 = new Project("Test Project1", user2, repo1);
//             testProject3.AddMaterial(new Material { Name = "Table1", Price = 200, Amount = 20, Details = "N/A" });
//             testProject3.AddMaterial(new Material { Name = "Chair1", Price = 100, Amount = 25, Details = "N/A" });
//             testProject3.AddMaterial(new Material { Name = "Phone1", Price = 500, Amount = 56, Details = "N/A" });

//             var expectedUserProjectListCount = 2;
//             var expectedUserName = "Hadis";

//             var actualUserProjectListCount = repo1.GetProjectsByUser(user2).Count;
//             var actualUserName = repo1.GetProjectsByUser(user2)[0].User.Name;

//             Assert.Equal(expectedUserProjectListCount, actualUserProjectListCount);
//             Assert.Equal(expectedUserName, actualUserName);
//         }


//     }
// }
