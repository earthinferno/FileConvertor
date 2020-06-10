using FileConvertor.Models;
using FileConvertor.Services;
using System;

namespace FileConvertor.Factories
{
    public class PersonDataServicesFactory : IFactory<Person>
    {
        public (IDataImporter<Person> dataImporter, IDataExporter<Person> dataExporter) DiFactoryMethod(string resolver)
        {
            switch (resolver)
            {
                case "CSVtoJSON":
                    return (dataImporter: new PersonDataImporter(), dataExporter: new JsonDataExporter());
                default:
                    throw new Exception("Data Services not found");
            }
        }
    }
}
