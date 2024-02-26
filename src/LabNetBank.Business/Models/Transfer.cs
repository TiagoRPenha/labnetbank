using LabNetBank.Business.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetBank.Business.Models
{
    public class Transfer : Entity
    {
        public string AccountNumberOrigin { get; private set; }
        public string AccountNumberTarger { get; private set; }
        public int Office { get; private set; }
        public decimal ValueTransfer { get; private set; }
        public DateTime TransferDate { get; private set; }
        public Status Status { get; set; }
    }
}
