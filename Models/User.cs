using System.Net.Sockets;
using System.Xml.Linq;

namespace HTS.Models
{
    public class User
    {
        public string Id { get; set; }  
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string Role { get; set; }

       
    }
}
