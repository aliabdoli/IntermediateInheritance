using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeCSharp
{
    public class Parent
    {
        public Parent(string input)
        {
            
        }

        public void ParentMethod(){}
    }

    public class Child : Parent
    {
        public Child() : base("xx")
        {
            
        }

        public void ChildMethod(){}
    }

    public class ChildB : Parent
    {
        public ChildB() : base("BB")
        {
        }

    }

    public class Anyone
    {
        
    }

    public static class Client
    {
        public static void Run()
        {
            //upcasting
            Child child = new Child();
            Parent parent = child;

            //downcasting
           
            //NoNo Anyone anyone = (Anyone) parent;

            //Throw exception
            //ChildB childb = (ChildB) parent;


            Parent parent2 = new Parent("xx");
            //throw exception
            //Child child1 = (Child)parent2 ;

            if (child is Child)
            {
                var temp1 = "I am Child";
            }

            if (child is Parent)
            {
                var temp1 = "I am Parent";
            }


            if (child is ChildB)
            {
                var temp1 = "I am ChildB";
            }


            if (parent is Child)
            {
                var temp1 = "I am parent but child !!!";
            }

            if (parent2 is Child)
            {
                var temp1 = "I am parent newed but child !!!";
            }

        }
    }
}
