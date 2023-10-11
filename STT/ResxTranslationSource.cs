using System.Xml;

namespace STT;

public class ResxTranslationSource : ITranslationSource
{
   private readonly string _path;

   public ResxTranslationSource(string path)
   {
      _path = path;
   }

   public async Task<ICollection<Translation>> Retrieve()
   {
      var directory = new DirectoryInfo(_path);
      var resourceFiles = directory.GetFiles("*.resx", SearchOption.AllDirectories);

      var result = new List<Translation>();
      foreach (var resourceFile in resourceFiles)
      {
         string culture;
         if (resourceFile.Name.Count(x => x == '.') > 1)
         {
            culture = resourceFile.Name.Split('.')[1];
         }
         else
         {
            culture = "en"; // TODO: Get default value from config.
         }

         var fileContents = await File.ReadAllTextAsync(resourceFile.FullName);
         var xmlDocument = new XmlDocument();
         xmlDocument.LoadXml(fileContents);

         var nodes = xmlDocument.SelectNodes("//root/data");

         if(nodes is null)
            continue;

         foreach (XmlNode node in nodes)
         {
            var key = node.Attributes?.GetNamedItem("name")?.Value;
            var value = node.SelectSingleNode("value")?.InnerText ?? "";

            if (key is null)
               continue;

            result.Add(new Translation(resourceFile.Name, Culture: culture, key, value));
         }
      }

      return result;
   }
}