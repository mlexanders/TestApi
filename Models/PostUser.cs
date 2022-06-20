using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApi.Models
{
    public class PostUser
    {

        public string name { get; set; }
        public string login { get; set; }
        public Password password { get; set; }
        public Role role { get; set; }

      

        public PostUser()
        {
            name = "mlexanders";
            login = "GoGo.com";
            password = new Password();
            role = Role.ADMIN;

        }
       
    }
}
