using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Students
{
    class Program
    {
        public static void Main(string[] args)
        {
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Vqmni XML DOkuments"),
                new XElement("Students",
                    new XElement("s1",
                        new XElement("Firstname", "Nika"),
                        new XElement("Lastname", "Darchiashvili"),
                        new XElement("ID", "098402198201")),
                    new XElement("s2",
                        new XElement("Firstname", "Vaso"),
                        new XElement("Lastname", "Nasyidashvili"),
                        new XElement("ID", "03583959939")),
                    new XElement("s3",
                        new XElement("Firstname", "Elene"),
                        new XElement("Lastname", "Burjanadze"),
                        new XElement("ID", "49503090935"))
                        ));
            xmlDocument.Save("C:\\Users\\Y\\Desktop\\Students\\students.xml");
            Console.WriteLine("Saved");
            Console.ReadKey();
        }
    }
}
