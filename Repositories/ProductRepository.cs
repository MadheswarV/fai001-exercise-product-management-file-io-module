using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class ProductRepository
    {
        // declare field of type DataContext

        public Dictionary<int, string> ProductDictionary = new Dictionary<int, string>();
        public string Productname;
        public int Productid;



        public ProductRepository(int productid, string productname, Dictionary<int, string> productDictionary)
        {
            //  initialize the DataContext field with parameter passed



            this.Productid = productid;
            this.Productname = productname;
            this.ProductDictionary = productDictionary;
        }

        /*
         * this method should accept product data and add it to the product collection
         * 
         */
        public void AddProduct(string productname, int productid)

        {
            ProductDictionary.Add(productid, productname);
            Console.WriteLine("Product added successfully");
        }


        /*
         * this method should search for the product by the provided product id 
         * and if found should remove it from the collection
         * 
         * the method should return true for success and false for invalid id 
         */
        public bool RemoveProduct(int productid)
        {
            // code to remove product by the id provided from file as parameter    
            if (ProductDictionary.ContainsKey(productid))
            {
                ProductDictionary.Remove(productid);
                return true;
            }
            else
            {
                return false;

            }


        }

        /*
         * this method should search and return product by product name from the file 
         * 
         * the search value should be passed as parameter
         * 
         * the method should return null for non-matching product name
         */
        public bool GetProduct(string productname)
        {
            if (ProductDictionary.ContainsValue(productname))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
         * this method should search and return product by product id from the collection 
         * 
         * the search value should be passed as parameter
         * 
         * the method should return null for non-matching product id
         */
        public bool GetProduct(int productid)
        {
            if (ProductDictionary.ContainsKey(productid))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /*
         * this method should return all items from the product collection
         */
        public Dictionary<int, string> GetAllProducts()
        {
            return ProductDictionary;

        }
    }
}