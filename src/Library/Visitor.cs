using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    
   public class Visitor
    {
        public int Calcularedad=0;
        public int maxedad=0;
        public int maxlenght=0;
        public string nombremaslargo="";

        public bool flag=true;
        public bool flag1=true;
        public void Visit(Node node)
        {
            Calcularedad=Calcularedad+node.persona.Edad;
            foreach(var i in node.children)
            {
                i.Accept(this);
            }
        }

        public void Visitedad(Node node)
        {
            if (flag)
            {
                maxedad= node.persona.Edad;
                flag=false;
            }
            foreach(var i in node.children)
            {
                i.Acceptedad(this);
                if ( i.persona.Edad > maxedad )
                {
                    maxedad=i.persona.Edad;
                }
            }
            
        }
         public void VisitNombre(Node node)
        {
            if (flag1)
            {
                maxlenght=node.persona.Nombre.Length;
                nombremaslargo=node.persona.Nombre;
                flag1=false;
            }
            foreach(var i in node.children)
            {
                i.AcceptNombre(this);
                if ( i.persona.Nombre.Length > maxlenght )
                {
                    maxlenght=i.persona.Nombre.Length;
                    nombremaslargo=i.persona.Nombre;
                }
                
            }
        }
    }
}