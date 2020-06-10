using System;
using System.Collections.Generic;
using System.Text;

namespace FileConvertor.Services
{
    public interface IDataExporter<T>
    {
        public void ExportData(List<T> data, Action<string> output);
    }
}
