
namespace CoreRegSite
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Participant")]
    public class Participant
    {
        public int ParticipantId { get;set; }

        [Required]
        public string ParticipantEmail { get; set; }
        [Required]
        public string ParticipantFirstName { get; set; }
        [Required]
        public string ParticipantSecondName { get; set; }
        [Required]
        public string ParticipantPhone { get; set; }
        [Required]
        public string ParticipantActivity { get; set; }
    }
}