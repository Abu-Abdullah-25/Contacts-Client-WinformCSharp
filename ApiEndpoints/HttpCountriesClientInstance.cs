using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApiClient
{
    public static class HttpCountriesClientInstance
    {
        public static readonly HttpClient Client = new HttpClient()
        {
            BaseAddress = new Uri("http://localhost:5279/api/Countries/")
        };
    }
}
