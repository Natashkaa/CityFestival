using System.ComponentModel.DataAnnotations.Schema;

namespace CoreRegSite.Models
{
    public class SimpleUserModel
    {
        public string ParticipantFirstName { get; set; }
        public string ParticipantSecondName { get; set; }
        public string ParticipantActivity { get; set; }
    }
}