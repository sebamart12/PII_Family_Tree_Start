using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {

        public  List<Node> children = new List<Node>();

        public Persona persona{get;set;}


        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Persona persona)
        {
            this.persona= persona;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }  
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public void Acceptedad(Visitor visitor)
        {
            visitor.Visitedad(this);
        }

        public void AcceptNombre(Visitor visitor)
        {
            visitor.VisitNombre(this);
        }
    }
            
}
