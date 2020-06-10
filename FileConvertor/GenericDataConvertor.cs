using FileConvertor.Models;
using FileConvertor.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileConvertor
{
    // I've tried to make my file convertor as absract as possible. Control is inverted to it's dependancies such
    // that this class could be used in any context where data conversion is required.
    public class GenericDataConvertor<T>
    {
        // GenericDataConvertor is agnostic of the data it is converting. 
        // Your could inject any data importer and exporter so long as they conform to the type T in common.
        private readonly IDataImporter<T> _dataImporter;
        private readonly IDataExporter<T> _dataExporter;

        // A bit of functional (pure) programing style. Pass a delegate in to handle the means of outputting the data. in this way the exporter is tied to any
        // particular UI/output. It ensures the dataexporter implementation is closed to modification but open to extension as far as output is concerned.
        private readonly Action<string> _outputHandle;

        public GenericDataConvertor(IDataImporter<T> dataImporter, IDataExporter<T> dataExporter, Action<string> outputHandle)
        {
            _dataImporter = dataImporter;
            _dataExporter = dataExporter;
            _outputHandle = outputHandle;
        }

        public void ExportData()
        {
            var personData = _dataImporter.ImportData();
            _dataExporter.ExportData(personData, _outputHandle);
        }
    }
}
