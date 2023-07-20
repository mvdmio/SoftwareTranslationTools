using Xunit;

namespace STT.Tests;

public class ResxTranslationSourceTests
{
   [Fact]
   public async Task ShouldRetrieveResxFilesFromDirectory()
   {
      var resxTranslationSource = new ResxTranslationSource("Resources");
      var results = await resxTranslationSource.Retrieve();

      Assert.Equal(6, results.Count);
      Assert.Contains(new Translation("Strings.resx", "en", "Test 1", "Translated Test 1"), results);
      Assert.Contains(new Translation("Strings.resx", "en", "Test 2", "Translated Test 2"), results);
      Assert.Contains(new Translation("Strings.nl.resx", "nl", "Test 1", "Vertaald Test 1"), results);
      Assert.Contains(new Translation("Strings.nl.resx", "nl", "Test 2", "Vertaald Test 2"), results);
      Assert.Contains(new Translation("Strings.de.resx", "de", "Test 1", "übersetzt Test 1"), results);
      Assert.Contains(new Translation("Strings.de.resx", "de", "Test 2", "übersetzt Test 2"), results);
   }
}