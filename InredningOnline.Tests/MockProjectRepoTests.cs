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
//             var designerRepo = new MockDesignerRepo();

//             var designer1 = new Designer("Nandan","me@nandan.com",true);

//             var designer2 = new Designer("Hadis","me@hadis.com",false);

//             var testProject = new Project("Test Project", designer1, repo1);
//             testProject.AddMaterial(new Material { Name = "Table", Price = 20, Amount = 2, Details = "N/A" });
//             testProject.AddMaterial(new Material { Name = "Chair", Price = 10, Amount = 2, Details = "N/A" });
//             testProject.AddMaterial(new Material { Name = "Phone", Price = 50, Amount = 5, Details = "N/A" });

//             var testProject1 = new Project("Test Project1", designer2, repo1);
//             testProject1.AddMaterial(new Material { Name = "Table1", Price = 200, Amount = 20, Details = "N/A" });
//             testProject1.AddMaterial(new Material { Name = "Chair1", Price = 100, Amount = 25, Details = "N/A" });
//             testProject1.AddMaterial(new Material { Name = "Phone1", Price = 500, Amount = 56, Details = "N/A" });

//             var expectedProjectName = "Test Project";
//             var expectedDesignerName = "Nandan";
//             var expectedMaterialName = "Phone";
//             var expectedMaterialCount = 3;
//             var expectedRepoCount = 2;
//             var expectedTotalCostOfProject = 310;
//             var expectedTotalCostOfProject1 = 34500;


//             var expectedTotalCostOfAllProjects = 34810;


//             var actualProjectName = testProject.Name;
//             var actualDesignerName = designer1.Name;
//             var actualMaterialName = testProject.Materials[2].Name;
//             var actualMaterialCount = testProject.Materials.Count;
//             var actualRepoCount = repo1.AllProjects.Count;
//             var actualTotalCostOfProject = testProject.GetTotalCost();
//             var actualTotalCostOfProject1 = testProject1.GetTotalCost();

//             var actualTotalCostOfAllProjects = repo1.GetTotalCost();

//             Assert.Equal(expectedProjectName, actualProjectName);
//             Assert.Equal(expectedDesignerName, actualDesignerName);
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
//             var designerRepo = new MockDesignerRepo();

//             var designer1 = new Designer(designerRepo, "Nandan", "me@nandan.com", true);

//             var designer2 = new Designer(designerRepo, "Hadis", "me@hadis.com", false);

//             var testProject = new Project("Test Project", designer1, repo1);
//             testProject.AddMaterial(new Material { Name = "Table", Price = 20, Amount = 2, Details = "N/A" });
//             testProject.AddMaterial(new Material { Name = "Chair", Price = 10, Amount = 2, Details = "N/A" });
//             testProject.AddMaterial(new Material { Name = "Phone", Price = 50, Amount = 5, Details = "N/A" });

//             var testProject1 = new Project("Test Project1", designer2, repo1);
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
//             var designerRepo = new MockDesignerRepo();

//             var designer1 = new Designer(designerRepo, "Nandan", "me@nandan.com", true);

//             var designer2 = new Designer(designerRepo, "Hadis", "me@hadis.com", false);

//             var designer3 = new Designer(designerRepo, "Ali", "me@ali.com", false);

//             var testProject1 = new Project("Test Project", designer1, repo1);
//             testProject1.AddMaterial(new Material { Name = "Table", Price = 20, Amount = 2, Details = "N/A" });
//             testProject1.AddMaterial(new Material { Name = "Chair", Price = 10, Amount = 2, Details = "N/A" });
//             testProject1.AddMaterial(new Material { Name = "Phone", Price = 50, Amount = 5, Details = "N/A" });

//             var testProject2 = new Project("Test Project1", designer2, repo1);
//             testProject2.AddMaterial(new Material { Name = "Table1", Price = 200, Amount = 20, Details = "N/A" });
//             testProject2.AddMaterial(new Material { Name = "Chair1", Price = 100, Amount = 25, Details = "N/A" });
//             testProject2.AddMaterial(new Material { Name = "Phone1", Price = 500, Amount = 56, Details = "N/A" });

//             var testProject3 = new Project("Test Project1", designer2, repo1);
//             testProject3.AddMaterial(new Material { Name = "Table1", Price = 200, Amount = 20, Details = "N/A" });
//             testProject3.AddMaterial(new Material { Name = "Chair1", Price = 100, Amount = 25, Details = "N/A" });
//             testProject3.AddMaterial(new Material { Name = "Phone1", Price = 500, Amount = 56, Details = "N/A" });

//             var expectedDesignerProjectListCount = 2;
//             var expectedDesignerName = "Hadis";

//             var actualDesignerProjectListCount = repo1.GetProjectsByDesigner(designer2).Count;
//             var actualDesignerName = repo1.GetProjectsByDesigner(designer2)[0].Designer.Name;

//             Assert.Equal(expectedDesignerProjectListCount, actualDesignerProjectListCount);
//             Assert.Equal(expectedDesignerName, actualDesignerName);
//         }


//     }
// }
