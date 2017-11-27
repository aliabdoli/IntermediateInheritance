using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeCSharp.Section5
{
    public class ParentVirtual
    {
        public virtual void DoVirtual()
        {
            
        }

        public void DoNoVirtual()
        {
            
        }
    }

    public class ChildVirtual : ParentVirtual
    {
        public override void DoVirtual()
        {
            base.DoVirtual();
        }

        //public new void DoNoVirtual()
        public void DoNoVirtual()
        {

        }
    }

    public static class Client
    {
        public static void Run()
        {
            ParentVirtual parentVirtual = new ParentVirtual();
            parentVirtual.DoVirtual();
            parentVirtual.DoNoVirtual();

            ParentVirtual childParentVirtual = new ChildVirtual();
            childParentVirtual.DoVirtual();
            childParentVirtual.DoNoVirtual();

            ChildVirtual childChildVirtual = new ChildVirtual();
            childChildVirtual.DoVirtual();
            childChildVirtual.DoNoVirtual();

            ChildVirtual childVirtual2 = new ChildVirtual();
            ParentVirtual parentVirtualUp = childVirtual2;
            parentVirtualUp.DoVirtual();
            parentVirtualUp.DoNoVirtual();

            ChildVirtual childVirtualDown = (ChildVirtual) parentVirtualUp;
            childVirtualDown.DoVirtual();
            childVirtualDown.DoNoVirtual();

        }
    }
}
