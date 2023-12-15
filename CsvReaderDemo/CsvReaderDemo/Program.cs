using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.Json.Serialization;

namespace CsvReaderDemo
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public Person(string name, int age, string country)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
        }
    }
    public class Program
    {
        static void writeToJson(string jsonPath)
        {
            List<Person> people = new List<Person>()
                    {
                        new Person ( "Suresh", 24, "USA" ),
                        new Person ( "Srikanth", 23, "India" ),
                        new Person ( "Manohar",22,"UK" )
                    };
            var jsonstring = JsonConvert.SerializeObject(people);
            File.WriteAllText(jsonPath, jsonstring);
        }
        static void ReadToJson(string jsonPath)
        {
            string json = File.ReadAllText(jsonPath);
            var value = JsonConvert.DeserializeObject(json);
            Console.WriteLine(value);
        }
        static void WriteToCsv(string filePath)
        {

            try
            {
                if (File.Exists(filePath))
                {
                    List<Person> people = new List<Person>()
                    {
                        new Person ( "Suresh", 24, "USA" ),
                        new Person ( "Srikanth", 23, "India" ),
                        new Person ( "Manohar",22,"UK" )
                    };
                    var configPersons = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        HasHeaderRecord = true
                    };
                    using (StreamWriter streamWriter = new StreamWriter(filePath))
                    using (CsvWriter csvWriter = new CsvWriter(streamWriter, configPersons))
                    {
                        csvWriter.WriteRecords(people);
                    };
                }
            }
            catch (Exception e) { }

        }
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Person 1\source\repos\CsvReaderDemo\csvFile.csv";
            Program.WriteToCsv(filePath);
            string jsonPath = @"C:\Users\Person 1\source\repos\CsvReaderDemo\jsonFile.json";
            Program.writeToJson(jsonPath);
            Program.ReadToJson(jsonPath);

        }

        
    }
}
