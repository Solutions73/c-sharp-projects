using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace fsd_cs_OOP20
{
    class Program
    {
        static void Main(string[] args)
        {
            // copy the xml file in the bin folder of project to debug

            xmlTextReader reader = new XmlTextReade("exercise.xml");
            {
                while (reader.Read())
                {
                    if ( reader.IsStartElement())
                    {
                        switch ( reader.Name)
                        {
                            case "Name":
                                if (reader.read())
                                {
                                    Console.WriteLine("Name: {0}", reader.Value);
                                }
                                brerak;

                            case "Compant":
                                if (reader.read())
                                {
                                    Console.WriteLine("Compnay: {0}", reader.Value);
                                }
                                brerak;

                        }
                    }
                }
            }
            Console.WriteLine("Press any ket to exit.");
            Console.WriteLine();
        }
    }
}
