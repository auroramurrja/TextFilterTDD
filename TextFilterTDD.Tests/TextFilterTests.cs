using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFilterTDD.Console.Filters;

namespace TextFilterTDD.Tests
{
    internal class TextFilterTests
    { 
        [SetUp]
        public void SetUp()
        {

        }
       
        [Test]
        public void CheckVowelInTheMiddleFilter()
        {
            string[] sampleData = { "clean","what","rather","the","to" };
            VowelInTheMiddleFilter filter = new VowelInTheMiddleFilter();
            var result = filter.Filter(sampleData);
            Assert.Multiple(() =>
            {
                Assert.That(result.Contains("clean"));
                Assert.That(result.Contains("what"));
                Assert.That(!result.Contains("rather"));
                Assert.That(!result.Contains("the"));
                Assert.That(result.Contains("to"));
            });
        }

        [Test]
        public void CheckLengthLessThanXFilter()
        {
            string[] sampleData = { "clean", "what", "rather", "the", "to" };
            LengthLessThanXFilter filter = new LengthLessThanXFilter(3);
            var result = filter.Filter(sampleData);
            Assert.Multiple(() =>
            {
                Assert.That(!result.Contains("clean"));
                Assert.That(!result.Contains("what"));
                Assert.That(!result.Contains("rather"));
                Assert.That(!result.Contains("the"));
                Assert.That(result.Contains("to"));
            });
        }

        [Test]
        public void CheckContainsLetterFilter()
        {
            string[] sampleData = { "clean", "what", "rather", "the", "to" };
            ContainsLetterFilter filter = new ContainsLetterFilter('t');
            var result = filter.Filter(sampleData);
            Assert.Multiple(() =>
            {
                Assert.That(!result.Contains("clean"));
                Assert.That(result.Contains("what"));
                Assert.That(result.Contains("rather"));
                Assert.That(result.Contains("the"));
                Assert.That(result.Contains("to"));
            });
        }
    }
}
