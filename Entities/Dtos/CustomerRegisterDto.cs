using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class CustomerRegisterDto
    {       
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }    
    }
}
