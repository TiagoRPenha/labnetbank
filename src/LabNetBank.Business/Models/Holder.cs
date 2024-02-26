using LabNetBank.Business.Models.Enums;

namespace LabNetBank.Business.Models
{
    public class Holder : Entity
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthData { get; set; }
        public UserType UserType { get; set; }
    }
}
