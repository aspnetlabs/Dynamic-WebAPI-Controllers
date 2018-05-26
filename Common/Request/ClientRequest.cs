using System;
using System.Collections.Generic;
using System.Text; 

namespace Common.Request
{ 
    public class ClientRequest<T>  where T :class, new()
    {
        public string SourceSystem { get; set; }
        public string EntityVersion { get; set; }
        public T Entity { get; set; }
    } 
}
