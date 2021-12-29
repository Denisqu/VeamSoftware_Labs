using System;
namespace VeamSoftware_Labs.Veam_module_1.lb1
{
    struct TrickyStruct
    {
        Ancestor ancestor;
        public Func<int> func;

        public TrickyStruct(Ancestor ancestor)
        {
            this.ancestor = ancestor;
            func = null;
			
            if(this.GetType().GetMethod("Method") != null)
            {
                func = Method;
            }
            else
            {
                func = ancestor.AncestorMethod;
            }
        }

        public int Method()
        {
            return 0;
        }

    }
}