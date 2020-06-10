using FileConvertor.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FileConvertor.Services
{
    public class JsonDataExporter : IDataExporter<Person>
    {
        public void ExportData(List<Person> data, Action<string> output)
        {
            output(JsonConvert.SerializeObject(data));
        }
    }
}
