using Common.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    [Serializable]
    [GeneratedController("api/client")]
    public class Client : IManagedEntity
    {
        public Client()
        {

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
