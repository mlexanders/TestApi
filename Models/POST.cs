using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApi
{
    public class POST
    {
        public POST()
        {
        //    this.id = "123";
            this.name = "morpheus";
            this.job = "leader";
            //this.createdAt = ;
        }
        public string name { get; set; }
        public string job { get; set; }
        public string id { get; set; }
        public string createdAt { get; set; }
    }
}
