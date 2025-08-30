using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.comportamiento.Iterator.NewFolder
{
    public class Libreria : Icollection<Libro>
    {
        private List<Libro> _libroList;
        public Libreria() {
            _libroList = new List<Libro>() {
            
              new Libro("Estructuras de Datos y Algoritmos en C#", "Michael McMillan"),
              new Libro("Introducción a la Ingeniería de Software", "Roger S. Pressman"),
              new Libro("Ingeniería de Software Moderna", "Ian Sommerville"),
              new Libro("Programación en C# 10 y .NET 6", "Andrew Troelsen"),
              new Libro("Patrones de Diseño en C#", "Steven John Metsker"),
              new Libro("Algoritmos: Teoría y Práctica", "Thomas H. Cormen"),
                new Libro("Bases de Datos: Diseño y Administración", "Abraham Silberschatz"),
                new Libro("Redes de Computadoras", "Andrew S. Tanenbaum"),
                new Libro("Sistemas Operativos", "Abraham Silberschatz"),
                new Libro("Inteligencia Artificial: Un Enfoque Moderno", "Stuart Russell"),
                new Libro("Programación Orientada a Objetos en C#", "B. J. Millstein"),
                new Libro("Arquitectura de Computadoras", "David A. Patterson"),
                new Libro("Seguridad Informática", "William Stallings"),
                new Libro("Aprendizaje Automático", "Tom M. Mitchell"),
                new Libro("Ingeniería de Requisitos", "Karl Wiegers"),
                new Libro("Desarrollo de Aplicaciones Web con ASP.NET", "Adam Freeman"),
                new Libro("Ingeniería de Software Ágil", "Alistair Cockburn"),
                new Libro("Compiladores: Principios, Técnicas y Herramientas", "Alfred V. Aho"),
                new Libro("Sistemas Distribuidos", "George Coulouris"),
                new Libro("Programación Funcional en C#", "Enrico Buonanno"),
                new Libro("Métodos Numéricos en Ingeniería", "Steven C. Chapra"),
                new Libro("Matemáticas Discretas", "Kenneth H. Rosen"),
                new Libro("Estructuras de Datos Avanzadas", "Mark Allen Weiss"),
                new Libro("Análisis y Diseño Orientado a Objetos", "Grady Booch"),
                new Libro("Desarrollo de Videojuegos con Unity", "Mike Geig"),
                new Libro("Ingeniería de Software con UML", "Craig Larman"),
                new Libro("Computación Paralela y Distribuida", "Quinn"),
                new Libro("Programación Concurrente en C#", "Joe Duffy"),
                new Libro("Big Data y Ciencia de Datos", "Viktor Mayer-Schönberger"),
                new Libro("Ingeniería de Software Basada en Componentes", "Ivica Crnkovic")
            };
            
        }
        public IIterator<Libro> CrearIterador()
        {
            return new LibroIterados(_libroList);
        }
    }
}
