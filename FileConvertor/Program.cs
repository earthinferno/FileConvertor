using FileConvertor.Factories;
using FileConvertor.Models;
using FileConvertor.Services;
using System;

namespace FileConvertor
{
    class Program 
    {
        public static (IDataImporter<Person> dataImporter, IDataExporter<Person> dataExporter) MockDIContainer()
        {
            var abstractfactory = new ConvertorFactory<Person>();
            var factory = abstractfactory.GetConvertorFactory();
            return factory.DiFactoryMethod("CSVtoJSON");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Begin conversion!");
            Console.WriteLine();

            // This is perhaps unescessary for the exercise I just got a bit carried away
            var dependencies = MockDIContainer();

            // GenericDataConvertor is the thing of interest for this assessment. Lets assume the console app is particular client in the context of Person data
            var PersonDataConvertor = new GenericDataConvertor<Person>(dependencies.dataImporter, dependencies.dataExporter, (x) => { Console.WriteLine(x); });

            PersonDataConvertor.ExportData();

            Console.WriteLine();
            Console.WriteLine("Press a key to exit.");
            Console.ReadLine();
        }
    }
}
