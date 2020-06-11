using System;
using EjemploAplicacionDeConsola.DAL;
using EjemploAplicacionDeConsola.Entidades;

namespace EjemploAplicacionDeConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Contexto())
            {

                var std = new Estudiante()
                {
                    Name = "Bill"
                };

                context.Estudiantes.Add(std);
                context.SaveChanges();
            }
        }
    }
}
