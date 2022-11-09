using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1= new Persona("Jorgerererereeee",150);
            Persona p2= new Persona("Isabel",100);
            Persona p3= new Persona("Felipe",60);
            Persona p4= new Persona("Carlos",45);
            Persona p5= new Persona("Diana",37);
            Persona p6= new Persona("Guillermo",19);
            Persona p7= new Persona("Harry",16);
            Persona p8= new Persona("Ger",10);
            Node n1 = new Node(p1);
            Node n2 = new Node(p2);
            Node n3 = new Node(p3);
            Node n4 = new Node(p4);
            Node n5 = new Node(p5);
            Node n6 = new Node(p6);
            Node n7 = new Node(p7);
            Node n8 = new Node(p8);

            n1.AddChildren(n2);

            n2.AddChildren(n3);
            n3.AddChildren(n4);
            n4.AddChildren(n5);

            n5.AddChildren(n6);
            n5.AddChildren(n7);
            n5.AddChildren(n8);


            Visitor visit = new Visitor();
            visit.Visit(n1);
            Console.WriteLine(visit.Calcularedad);
            visit.Visitedad(n1);
            Console.WriteLine(visit.maxedad);
            visit.VisitNombre(n1);
            Console.WriteLine(visit.nombremaslargo);
        
        }
    }
}
