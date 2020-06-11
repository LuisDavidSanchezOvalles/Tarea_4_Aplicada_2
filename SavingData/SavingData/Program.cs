using SavingData.DAL;
using SavingData.Entidades;
using System;
using System.Linq;

namespace SavingData
{
    class Program
    {
        static void Main(string[] args)
        {
            //para agregar un dato
            using (var context = new Contexto())
            {
                var std = new Estudiante()
                {
                    FirstName = "Bill",
                    LastName = "Gates"
                };
                context.Estudiantes.Add(std);

                // or
                // context.Add<Student>(std);

                context.SaveChanges();
            }

            //para modificarlo
            using (var context = new Contexto())
            {
                var std = context.Estudiantes.First<Estudiante>();
                std.FirstName = "Steve";
                context.SaveChanges();
            }

            //para eliminarlo
            using (var context = new Contexto())
            {
                var std = context.Estudiantes.First<Estudiante>();
                context.Estudiantes.Remove(std);

                // or
                // context.Remove<Student>(std);

                context.SaveChanges();
            }
        }
    }
}
