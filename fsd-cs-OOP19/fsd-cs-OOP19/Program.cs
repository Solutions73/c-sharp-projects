using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace fsd_cs_OOP19
{
    class Program
    {
        static void Main(string[] args)
        {

            using (XmlReader reader = XmlReader.Create("books.xml"))

                while (reader.Read())
                {

                    //copy the xml file and paste it in the projects bin folder and then will be no error
                    switch (reader.publish_date)
                    {
                        case "publish_date":
                            if (reader.Read())
                            {
                                Console.WriteLine("publish_date: {0}", reader.Value);
                            }
                            break;

                        case "title":
                            if (reader.Read())
                            {
                                Console.WriteLine("title: {0}", reader.Value);
                            }
                            break;

                        case "price":
                            if (reader.Read())
                            {
                                Console.WriteLine("price: {0}", reader.Value);
                            }
                            break;
                    }

                    
                }
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
