using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET.Models
{
     // private ASPNET.Models.EmployeeContext context;
    public class EmployeeItem
    {
        private ASPNET.Models.EmployeeContext context;

        public int id { get; set; }
        public string nama { get; set; }
        public string jenisKelamin { get; set; }
        public string alamat { get; set; }
    }
}
