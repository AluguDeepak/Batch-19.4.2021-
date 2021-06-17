using HandsOnMVCConnectAPIUsingHttpClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HandsOnMVCConnectAPIUsingHttpClient.Services
{
    public class ProductService : IProductService
    {
        public void Add(Product product)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:15299/");
                var contentData = new StringContent(JsonConvert.SerializeObject(product),
                    System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("api/Product/Add", contentData).Result;
               // return response.Content.ReadAsStringAsync().Result;
            }
        }

        public void Delete(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:15299/");
                HttpResponseMessage response = client.DeleteAsync("api/Product/Delete/" + id).Result;
                //return response.Content.ReadAsStringAsync().Result;
            }
        }

        public Product GetProduct(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:15299/");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType); //add content type to the request header
                HttpResponseMessage response = client.GetAsync("/api/Product/GetById/"+id).Result;
                Product product = JsonConvert.DeserializeObject<Product>(response.Content.ReadAsStringAsync().Result);
                return product;
            }
        }

        public List<Product> GetProducts()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:15299/");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType); //add content type to the request header
                HttpResponseMessage response = client.GetAsync("api/Product/GetAll").Result;
                List<Product> list = JsonConvert.DeserializeObject<List<Product>>(response.Content.ReadAsStringAsync().Result);
                return list;
            }
        }

        public void Update(Product product)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:15299/");
                var contentData = new StringContent(JsonConvert.SerializeObject(product),
                    System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PutAsync("api/Product/Edit", contentData).Result;
                // return response.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
