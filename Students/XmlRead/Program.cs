using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlRead
{
    class Program
    {
        static void Main(string[] args)
        {
            //XmlDocument xdoc = new XmlDocument();
            string file = "C:\\Users\\Y\\Desktop\\Students\\students.xml";
            //xdoc.Load(file);
            //xdoc.Save(Console.Out);          
            XmlReader reader = XmlReader.Create(file);
            while (reader.Read())
            {
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "s1"))
                {
                    if (reader.HasAttributes)
                    {
                        Console.WriteLine("ai aq" + reader.GetAttribute("Firstname"));

                    }
                }
            }
            Console.ReadLine();
        }
    }
}
