using System;
using Microsoft.VisualBasic.CompilerServices;
using Xunit;

namespace InredningOnline.Tests
{
    public class ProjectsTests
    {
        [Fact]
        public void ProjectShouldBeCreated()
        {
            var project = new Project("Test Project");

            var expected = "Test Project";
            var actual = project.Name;

            Assert.Equal(expected, actual);
        }
    }
}
