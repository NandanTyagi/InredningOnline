// using InredningOnline.Models;
// using Xunit;

// namespace InredningOnline.Tests
// {
//     public class MockDesignerRepoTests
//     {
//         [Fact]
//         public void DesignershouldBeCreatedWithCorrectProperties()
//         {
//             var designerRepo = new MockDesignerRepo();

//             var designer1 = new Designer(designerRepo, "Nandan", "me@nandan.com", true);

//             var designer2 = new Designer(designerRepo, "Hadis", "me@hadis.com", false);

//             var expectedDesignerName1 = "Nandan";
//             var expectedDesignerName2 = "Hadis";

//             var expectedDesignerEmail1 = "me@nandan.com";
//             var expectedDesignerEmail2 = "me@hadis.com";


//             var actualDesignerName1 = designer1.Name;
//             var actualDesignerName2 = designer2.Name;

//             var actualDesignerEmail1 = designer1.Email;
//             var actualDesignerEmail2 = designer2.Email;


//             Assert.Equal(expectedDesignerName1, actualDesignerName1);
//             Assert.Equal(expectedDesignerName2, actualDesignerName2);

//             Assert.Equal(expectedDesignerEmail1, actualDesignerEmail1);
//             Assert.Equal(expectedDesignerEmail2, actualDesignerEmail2);

//             Assert.True(designer1.IsAdmin);
//             Assert.False(designer2.IsAdmin);

//         }

//         [Fact]
//         public void DesignershouldBeCreatedWithUniqueIds()
//         {
//             var designerRepo = new MockDesignerRepo();

//             var designer1 = new Designer(designerRepo, "Nandan", "me@nandan.com", true);

//             var designer2 = new Designer(designerRepo, "Hadis", "me@hadis.com", false);


//             Assert.NotEqual(designer1.Id, designer2.Id);

//         }

//         [Fact]
//         public void MockDesignerRepoShouldContainDesigners()
//         {
//             var designerRepo = new MockDesignerRepo();

//             var designer1 = new Designer(designerRepo, "Nandan", "me@nandan.com", true);

//             var designer2 = new Designer(designerRepo, "Hadis", "me@hadis.com", false);


//             Assert.NotEmpty(designerRepo.AllDesigners);
//             Assert.Equal(2, designerRepo.AllDesigners.Count);

//         }
//     }
// }
