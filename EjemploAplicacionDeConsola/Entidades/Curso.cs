using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EjemploAplicacionDeConsola.Entidades
{
    public class Curso
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public Curso()
        {
            CourseId = 0;
            CourseName = string.Empty;
        }

        public Curso(int courseId, string courseName)
        {
            CourseId = courseId;
            CourseName = courseName;
        }
    }
}
