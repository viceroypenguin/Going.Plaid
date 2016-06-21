using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gigobyte.Plaid.Model
{
    public class Transaction
    {
        public string Id { get; set; }

        public string Account { get; set; }

        public string CategoryId { get; set; }

        public string Score { get; set; }

        public string Type { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public string Category { get; set; }

        public string Meta { get; set; }

        public bool Pending { get; set; }

        public string ReferenceNumber { get; set; }

        public string PendingTransaction { get; set; }
    }
}
