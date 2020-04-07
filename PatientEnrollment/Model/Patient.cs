using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PatientEnrollment.Model
{
    class Patient
    {
        public int Id { get; set; }

        [MaxLength(25)]
        [Required]
        public string Firstname { get; set; }

        [MaxLength(25)]
        [Required]
        public string Lastname { get; set; }


        public string Patronymic { get; set; }

        [Required] public string Sex { get; set; }

        [Required] public DateTime DAteOfBird { get; set; }

        [MaxLength(500)]
        public string Address { get; set; }

        [MaxLength(18)]
        public string Phone { get; set; }

        public IEnumerable<Treatment> Treatments { get; set; }

    }
}
