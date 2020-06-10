using FileConvertor.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileConvertor.Services
{
    // THis particular implementation of IDataImporter is not great. I suspect if I created some tests 
    // I could quite easily break it. But you are more interest OOP principles right and I was asked to spend 
    // 2 hours on the exercise.
    public class PersonDataImporter : IDataImporter<Person>
    {
        public List<Person> ImportData()
        {
            List<Person> persons = new List<Person>();

            string line;
            FileStream aFile = new FileStream("./PersonData.csv", FileMode.Open);
            StreamReader sr = new StreamReader(aFile);

            // read data in line by line
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Split(",")[0] != "name")
                {
                    persons.Add(ParsePerson(line));
                }
            }
            sr.Close();
            return persons;
        }

        public Person ParsePerson(string personData)
        {
            var splitLine = personData.Split(",");
            return new Person
            {
                Name = splitLine[0],
                Address = new Address
                {
                    Line1 = splitLine[1],
                    Line2 = splitLine[2]
                }
            };
        }
    }
}
