using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November14Practice
{
    internal static class Helper
    {

        public static async Task<string> GetDataFromWeb(string url)
        {
            HttpClient client = new HttpClient();
            return await client.GetStringAsync(url);
        }

        public static string SerializeObject<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T DeserializeObject<T>(string strObj)
        {
            return JsonConvert.DeserializeObject<T>(strObj);
        }

        public static bool WriteToFile(string filePath,string value)
        {
            if(!File.Exists(filePath))
                return false;
            using StreamWriter writer = new StreamWriter(filePath,false); // tezden silir yazir
            writer.Write(value);
            return true;
        }

        public static bool AppendToFile(string filePath, string value)
        {
            if (!File.Exists(filePath))
                return false;
            using StreamWriter writer = new StreamWriter(filePath, true);// bu ardina yapisdirir
            writer.Write(value);
            return true;
        }




    }
}
