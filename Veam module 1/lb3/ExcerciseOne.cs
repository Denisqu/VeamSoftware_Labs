using System.Collections.Generic;
using System.Text;
namespace VeamSoftware_Labs.Veam_module_1.lb3
{
    public static class ExcerciseOne
    {
        public static string GetResult()
        {
            List <Element> elements = new List<Element>();
            
            // initialize list
            for (int i = 0; i < 10; i++)
            {
                elements.Add(new Element("Name#" + i));
            }
            
            // return concatenated string
            return Concatenator.Concatenate(elements, '|', 3);
        }
    }

    public static class Concatenator
    {
        public static string Concatenate<T>(IEnumerable<T> collection, char delimeter, int skipCount) where T : INamed
        {
            StringBuilder concatenatedStringBuilder = new StringBuilder(50);
            int alreadySkipped = 0;
            foreach (var item in collection)
            {
                if (alreadySkipped < skipCount)
                {
                    alreadySkipped++;
                    continue;
                }

                concatenatedStringBuilder.Append(item.Name);
                concatenatedStringBuilder.Append(delimeter);

            }

            return concatenatedStringBuilder.ToString();
        }
    }
    
    public class Element : INamed
    {
        private string _name;
        
        public Element(string name)
        {
            _name = name;
        }

        public string Name { get => _name; }
        
        public override string ToString()
        {
            return _name;
        }
    }

    public interface INamed
    {
        public string Name { get; }
    }


}