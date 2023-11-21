namespace STT;

public class TranslationRetriever
{
   private readonly List<ITranslationSource> _sources;

   public TranslationRetriever()
   {
      _sources = new List<ITranslationSource>();
   }

   public void AddSource(ITranslationSource translationSource)
   {
      ArgumentNullException.ThrowIfNull(translationSource, nameof(translationSource));

      _sources.Add(translationSource);
   }

   public async Task<ICollection<Translation>> Retrieve()
   {
      var result = new List<Translation>();

      foreach (var source in _sources)
      {
         result.AddRange(await source.Retrieve());
      }

      return result;
   }
}