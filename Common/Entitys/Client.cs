using Common.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Common
{
    
    [GeneratedController("api/client","test")]
    public class Client 
    {
        public Client()
        {

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
 
}
