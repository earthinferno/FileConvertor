using FileConvertor.Services;

namespace FileConvertor.Factories
{
    public interface IFactory<T>
    {
        public (IDataImporter<T> dataImporter, IDataExporter<T> dataExporter) DiFactoryMethod(string resolver);
    }
}
