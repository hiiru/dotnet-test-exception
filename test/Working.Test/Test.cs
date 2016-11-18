using SampleLibrary;
using Xunit;

namespace Working.Test
{
    public class Test
    {
        [Fact]
        public void IsTrue()
        {
            var boolProvider = new BoolProvider();
            Assert.True(boolProvider.True());
        }

        [Fact]
        public void IsFalse()
        {
            var boolProvider = new BoolProvider();
            Assert.False(boolProvider.False());
        }
    }
}