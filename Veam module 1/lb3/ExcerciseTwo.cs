using System.Collections.Generic;
namespace VeamSoftware_Labs.Veam_module_1.lb3
{
    public static class ExcerciseTwo
    {
        public static string GetResult()
        {
            Element[] a =
            {
                new Element("A"),
                new Element("B"),
                new Element("C"),
                new Element("May"),
                new Element("Pen")
            };

            string returnedString = "";
            
            foreach (var element in Finder.FindAll(a))
            {
                returnedString += element.Name;
            }

            return returnedString;
        }
    }

    public static class Finder
    {
        public static IEnumerable<T> FindAll<T>(IEnumerable<T> col) where T : INamed
        {
            List<T> returnedCollection = new List<T>();

            int i = 0;
            foreach (var item in col)
            {
                if (item.Name.Length < i)
                {
                    returnedCollection.Add(item);
                }

                i++;
            }

            return returnedCollection;
        }
    }
    
    
    
}