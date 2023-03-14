using LabD_02.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace LabD_02.Models.view;

    public record AddTicketVM
    {
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; init; }
        [Display(Name ="IsActive")]
        public bool Isclosed { get; init; }
        public string Description { get; init; }=string.Empty;
        public Severity severity { get; init; }

    }

