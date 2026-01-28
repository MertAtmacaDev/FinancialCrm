using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialCrm.DataAccess.Enums;

namespace FinancialCrm.DataAccess.Entities
{
    public class BankProcess
    {
        public int BankProcessId { get; set; }
        public string Description { get; set; }
        public DateTime ProcessTime { get; set; }
        public BankProcessType ProcessType { get; set; }//enum
        public decimal Amount { get; set; }

        public int BankId { get; set; }
        public Bank Bank { get; set; }
    }
}
