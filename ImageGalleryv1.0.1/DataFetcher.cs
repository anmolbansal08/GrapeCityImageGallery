
// a class to fetch the data from server, parse it and provide the data back to the application
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;// used to parse the JSON data which gets returned by the server
using System.IO;
using System.Windows.Forms;
using System.Net.Http;

namespace ImageGalleryv1._0._1
{
    class DataFetcher//a class to fetch the data from server,
                     //parse it and provide the data back to the application
    {

        //GetDatafromService uses the HttpClient class to fetch the JSON data from the server
        async Task<string> GetDatafromService(string searchstring, int customsearch)
        {

            string readText = null;
            try
            {
                var azure = @"https://imagefetcher20200529182038.azurewebsites.net";

                //Prefer stringBuilder  over more concatenations

                //StringBuilder url1 = new StringBuilder();
                //url1.Append(azure);
                //url1.Append(@"/api/fetch_images?query=");
                //url1.Append(searchstring) ;
                //url1.Append($"&max_count={customsearch}");
                // string url2 = url1.ToString().Substring(0, url1.Length);

                //adding string interpolation for custom search
                string url = azure + @"/api/fetch_images?query=" + searchstring + $"&max_count={customsearch}";

                // http request
                using (HttpClient c = new HttpClient())
                {
                    readText = await c.GetStringAsync(url);
                }
            }
            catch
            {
                MessageBox.Show("OOPS!!Currently We are down,We will be Back Soon");
                readText = File.ReadAllText(@"Data/sampleData.json");
            }
            return readText;

        }
        public async Task<List<ImageItem>> GetImageData(string search, int val)
        {

            string data = await GetDatafromService(search, val);
            return JsonConvert.DeserializeObject<List<ImageItem>>(data);// method of Newtonsoft.Json
            //to parse the json data // into an instance of ImageItem
        }
    }
}
