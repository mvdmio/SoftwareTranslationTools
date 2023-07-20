namespace STT;

public interface ITranslationSource
{
   Task<ICollection<Translation>> Retrieve();
}