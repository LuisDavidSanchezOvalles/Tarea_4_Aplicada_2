using EjemploQueryFuncion.DAL;
using System;
using System.Linq;

namespace EjemploQueryFuncion
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Contexto();
            var studentsWithSameName = context.Estudiantes
                                              .Where(s => s.FirstName == GetName())
                                              .ToList();
        }

        public static string GetName()
        {
            return "Bill";
        }
    }
}
