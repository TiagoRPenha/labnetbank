using LabNetBank.Business.Models.Enums;
namespace LabNetBank.Business.Models
{
    public class Account : Entity
    {
        public int AccountNumber { get; set; }
        public int Office {  get; set; }
        public decimal Balance { get; set; }
        public AccountType AccountType { get; set; }
        public Guid HolderId { get; set; }
        public Holder Holder { get; set; }
    }
}
