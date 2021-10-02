using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moderate.Problem02;

namespace ModerateTests.Problem02
{
    [TestClass]
    public class WordFrequenciesTests
    {
        private WordFrequencies _wordFrequencies = new WordFrequencies();

        [TestMethod]
        public void CountWordSuccessfully()
        {
            string book = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum";

            _wordFrequencies.InitializeBook(book);

            _wordFrequencies.Count("Lorem").Should().Be(4);
            _wordFrequencies.Count("xxxx").Should().Be(0);
        }
    }
}
