using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Calculator
{
    public class Calculator
    {

        public HttpClient Client = new HttpClient();
        public string URLBase = "https://localhost:44356/api/";
        public string UserID;
        public ResultText ResultText;

        public async Task SendUserID()
        {
            // Initialization
            HttpResponseMessage res = await Client.PostAsync(URLBase + "Register?id=" + UserID, null);
            string resString = await res.Content.ReadAsStringAsync();
        }

        public Calculator()
        {
            
            UserID = Guid.NewGuid().ToString();
            SendUserID();
            this.ResultText = new ResultText();
        }
    }
}
