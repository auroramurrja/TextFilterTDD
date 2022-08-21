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
            Assert.That(result.Contains("clean"));
            Assert.That(result.Contains("what"));
            Assert.That(!result.Contains("rather"));
            Assert.That(!result.Contains("the"));
            Assert.That(result.Contains("to"));
        }

        [Test]
        public void CheckLengthLessThan3Filter()
        {
            string[] sampleData = { "clean", "what", "rather", "the", "to" };
            LengthLessThan3Filter filter = new LengthLessThan3Filter();
            var result = filter.Filter(sampleData);
            Assert.That(!result.Contains("clean"));
            Assert.That(!result.Contains("what"));
            Assert.That(!result.Contains("rather"));
            Assert.That(!result.Contains("the"));
            Assert.That(result.Contains("to"));
        }

        [Test]
        public void CheckContainsLetterTfilter()
        {
            string[] sampleData = { "clean", "what", "rather", "the", "to" };
            ContainsLetterTfilter filter = new ContainsLetterTfilter();
            var result = filter.Filter(sampleData);
            Assert.That(!result.Contains("clean"));
            Assert.That(result.Contains("what"));
            Assert.That(result.Contains("rather"));
            Assert.That(result.Contains("the"));
            Assert.That(result.Contains("to"));
        }
    }
}
