using FileConvertor.Models;
using System;

namespace FileConvertor.Factories
{
    public class ConvertorFactory<T>
    {
        public IFactory<T> GetConvertorFactory()
        {
            Type type = typeof(T);
            switch (type.Name)
            {
                case "Person":
                    return new PersonDataServicesFactory() as IFactory<T>;
                default:
                    return null;
            }
        }
    }
}
