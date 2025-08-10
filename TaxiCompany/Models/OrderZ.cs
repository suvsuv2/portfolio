using Microsoft.Identity.Client;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiCompany.Models
{
    public class OrderZ
    {
        public int Id { get; set; }
        public string FIO { get; set; }

        public string PhoneNUmber { get; set; }

        public string Status { get; set; }
       
        public string TypeofService { get; set; }
        
        public string adressClienta { get; set; }

        public string adressKudaClienty { get; set; }

        public int codeTransporta { get; set; }

        public int SummaZakaZa { get; set; }
    }
}
