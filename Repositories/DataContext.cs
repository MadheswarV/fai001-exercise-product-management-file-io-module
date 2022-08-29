using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Repositories
{
    // this class provides functionalities to read and write product collection data with file

    public class DataContext
    { 
        public string FileName { get; set; }
        public string FilePath { get; set; }
        // declare field for filename with path
        // declare field for list of products
        


        // the constructor should accept filename and path strings
        public DataContext(string filename,string filepath)
        {
            this.FileName = filename;
            this.FilePath = filepath;
            //Checking if the File is exit or not
            if (!File.Exists($@"{filepath}\{filename}"))
            {
                File.Create($@"{filepath}\{filename}");
            }
            // the constructor code should open file if it exists else create new

            // the code should read data from file if it contains any data

            StreamReader filereader = new StreamReader($@"{filepath}\{filename}");
            string line;

            while ((line = filereader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            filereader.Close();

            // the data read should populate the list of products field

            // if no data is present an empty list should be created 

        }

        // this method should return the list of products read from file
        public string ReadProducts(string filepath,string filename)
        {
            // return data of the product list
            StreamReader filereader = new StreamReader($@"{filepath}\{filename}");
            string line;

            while ((line = filereader.ReadLine()) != null)
            {
                return line;
            }
            return line;
            filereader.Close();

        }

        // this method should add the product data passed as parameter to the list of products
        public void AddProduct(Dictionary<int,string> ProductDictionary2, string productname, int productid)
        {
            ProductDictionary2.Add(productid, productname);
        }

        // this method should write the data from list of products to file and make data persistent
        public void SaveChanges(Dictionary<int,string> ProductDictionary2, string filepath, string filename)
        {
            StreamWriter writer = new StreamWriter($@"{filepath}\{filename}");
            foreach(var a in ProductDictionary2)
            {
                writer.WriteLine($"Product Id:{a.Key}, Product Name:{a.Value}");
            }
            // implement serialization
        }

        // this method should delete the file if exists
        public void CleanUp(string filename, string filepath)
        {
            if (File.Exists($@"{filepath}\{filename}"))
            {
                File.Delete($@"{filepath}\{filename}");
                Console.WriteLine("File is successfully Deleted");
            }
            else
            {
                Console.WriteLine("File is not found");
            }
        }
    }
}
