using System;
using System.Collections.Generic;
using System.Text;

namespace FileConvertor.Services
{
    public interface IDataImporter<T>
    {
        public List<T> ImportData();
    }
}
