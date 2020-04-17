using System;
using Xunit;

namespace MySuperImportantService.Tests
{
    public class MySuperImportantServiceTests
    {
        [Fact]
        public void WhenOneIsComparedToOneTheResultIsTrue()
        {
            Assert.Equal(1, 1);
        }
		
		[Fact]
        public void WhenTwoIsComparedToTwoTheResultIsTrue()
        {
            Assert.Equal(2, 2);
        }
    }
}
