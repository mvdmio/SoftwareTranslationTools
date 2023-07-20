namespace STT.Tests.Stubs;

internal sealed class StubTranslationSource : ITranslationSource
{
   private readonly List<Translation> _translations;

    public StubTranslationSource()
    {
        _translations = new List<Translation>();
    }

    public void Add(Translation translation)
    {
       _translations.Add(translation);
    }

    public Task<ICollection<Translation>> Retrieve()
    {
       return Task.FromResult((ICollection<Translation>)_translations);
    }
}