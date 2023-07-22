using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAuthServer.Core.DTOs
{
    public class ClientLoginDTo
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
