using STT.Tests.Stubs;
using Xunit;

namespace STT.Tests;

public class TranslationRetrieverTests
{
   [Fact]
   public async Task ShouldRetrieveTranslationsFromSources()
   {
      var stubTranslationSource = new StubTranslationSource();
      stubTranslationSource.Add(new Translation());

      var translationRetriever = new TranslationRetriever();
      translationRetriever.AddSource(stubTranslationSource);

      var translations = await translationRetriever.Retrieve();

      Assert.Equal(1, translations.Count);
   }
}