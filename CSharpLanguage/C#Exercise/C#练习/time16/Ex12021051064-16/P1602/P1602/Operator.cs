using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace P1602
{
    class Operator
    {
        private float x1 = 0.0F,x2=0.0F;
        public float A
        {
            get { return x1; }
            set { x1 = value; }
        }
        public float B
        {
            get { return x2; }
            set { x2 = value; }
        }
        public virtual float Compute()
        {
            float result = 0.0F;
            return result ;
        }
    }
    class ADD : Operator
    {
        public override float Compute()
        {
            float result = A + B;
            return result;
        }
        
    }
    class SUB : Operator 
    {
        public override float Compute()
        {
            float result = A - B;
            return result;
        }
    }
    class MUL:Operator
    {
        public override float Compute()
        {
            float result = A * B;
            return result;
        }
    }
    class DIV:Operator
    {
        public override float Compute()
        {
            float result = 0.0F;
            if(B!=0)
                result= A / B;
            return result;
        }
    }
}
