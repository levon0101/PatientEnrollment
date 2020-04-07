using System;
using System.ComponentModel.DataAnnotations;

namespace PatientEnrollment.Model
{
    class Treatment
    {
        public int Id { get; set; }
        [Required] public Patient Patient { get; set; }

        public int PatientId { get; set; }

        public DateTime TreatmentDate { get; set; }

        [Required] public string Type { get; set; }

        [Required] public string Diseases { get; set; }

    }
}
