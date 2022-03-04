using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAU1
{
    class ToaDo
    {
        private int x;
        private int y;
        private string tentoado;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                this.x = value;
            }
        }
        
     public int Y
        {
            get
            {
                return y;
            }
            set
            {
                this.y = value;
            }
        }
        public string Ten
        {
            get
            {
                return tentoado;
            }
            set
            {
                this.tentoado = value;
            }
        }
        public ToaDo()
        {

        }
        public ToaDo(int a, int b , string c)
        {
            X = a;
            Y = b;
            Ten = c;
        }

        public override string ToString()
        {
            return $"{Ten}({X},{Y})";
        }
           
    }
}
