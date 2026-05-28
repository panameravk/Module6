using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module6.Server
{
    public class ServerRequest
    {
        public static async Task<string> GetRequest(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {                
                HttpResponseMessage responseMessage = await client.GetAsync(url);
                if(responseMessage.IsSuccessStatusCode)
                {
                    return await responseMessage.Content.ReadAsStringAsync();
                }  
                else
                {
                    return $"Ошибка: {responseMessage.StatusCode}";
                }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, 
                        "Ошибка сервера", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                    return null;
                }
            }
        }
    }
}
