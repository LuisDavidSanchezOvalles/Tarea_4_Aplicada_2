using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SavingData.Entidades
{
    public class Estudiante
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Estudiante()
        {
            StudentId = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
        }

        public Estudiante(int studentId, string name, string lastName)
        {
            StudentId = studentId;
            FirstName = name;
            LastName = lastName;
        }
    }
}
