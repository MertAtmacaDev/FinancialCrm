using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.DataAccess.Entities
{
    public class Bank
    {
        public int BankId { get; set; }
        public string BankTitle { get; set; }
        public string BankAccountNumber { get; set; }
        public decimal BankBalance { get; set; }
        public List<BankProcess> BankProcesses { get; set; }
    }
}
