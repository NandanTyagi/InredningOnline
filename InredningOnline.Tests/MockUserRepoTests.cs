// using InredningOnline.Models;
// using Xunit;

// namespace InredningOnline.Tests
// {
//     public class MockUserRepoTests
//     {
//         [Fact]
//         public void DesignershouldBeCreatedWithCorrectProperties()
//         {
//             var userRepo = new MockUserRepo();

//             var user1 = new User(userRepo, "Nandan", "me@nandan.com", true);

//             var user2 = new User(userRepo, "Hadis", "me@hadis.com", false);

//             var expectedUserName1 = "Nandan";
//             var expectedUserName2 = "Hadis";

//             var expectedUserEmail1 = "me@nandan.com";
//             var expectedUserEmail2 = "me@hadis.com";


//             var actualUserName1 = user1.Name;
//             var actualUserName2 = user2.Name;

//             var actualUserEmail1 = user1.Email;
//             var actualUserEmail2 = user2.Email;


//             Assert.Equal(expectedUserName1, actualUserName1);
//             Assert.Equal(expectedUserName2, actualUserName2);

//             Assert.Equal(expectedUserEmail1, actualUserEmail1);
//             Assert.Equal(expectedUserEmail2, actualUserEmail2);

//             Assert.True(user1.IsAdmin);
//             Assert.False(user2.IsAdmin);

//         }

//         [Fact]
//         public void DesignershouldBeCreatedWithUniqueIds()
//         {
//             var userRepo = new MockUserRepo();

//             var user1 = new User(userRepo, "Nandan", "me@nandan.com", true);

//             var user2 = new User(userRepo, "Hadis", "me@hadis.com", false);


//             Assert.NotEqual(user1.Id, user2.Id);

//         }

//         [Fact]
//         public void MockUserRepoShouldContainDesigners()
//         {
//             var userRepo = new MockUserRepo();

//             var user1 = new User(userRepo, "Nandan", "me@nandan.com", true);

//             var user2 = new User(userRepo, "Hadis", "me@hadis.com", false);


//             Assert.NotEmpty(userRepo.AllDesigners);
//             Assert.Equal(2, userRepo.AllDesigners.Count);

//         }
//     }
// }
