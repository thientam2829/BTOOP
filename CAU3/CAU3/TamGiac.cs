using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAU3
{
    public class TamGiac
    {
        private int ma;
        private int mb;
        private int mc;
        private string loaitamgiac;

        public TamGiac()
        {

        }
        public TamGiac(int ma, int mb, int mc)
        {

            if ((ma < mb + mc) && (mb < ma + mc) && (mc < mb + ma))
            {
                setma(ma);
                setmb(mb);
                setmc(mc);
            }
            else ma = mb = mc = 0;
        }

        public int getma()
        {
            return ma;
        }
        public void setma(int ma)
        {
            if (this.ma < 0)
            {
                ma = 0;
            }
            else this.ma = ma;
        }
        public int getmb()
        {
            return mb;
        }
        public void setmb(int mb)
        {
            if (this.mb < 0)
            {
                mb = 0;
            }
            else this.mb = mb;
        }
        public int getmc()
        {
            return mc;
        }
        public void setmc(int mc)
        {
            if (this.mc < 0)
            {
                mc = 0;
            }
            else this.mc = mc;
        }
        
        public string getloaitamgiac()
        {
            return loaitamgiac;
        }
        public void setloaitamgiac()
        {

            if (ma < mb + mc && mb < ma + mc && mc < ma + mb)
            {
                if (ma * ma == mb * mb + mc * mc || mb * mb == ma * ma + mc * mc || mc * mc == ma * ma + mb * mb)
                {
                    loaitamgiac = "DAY LA TAM GIAC VUONG";
                }
                else if (ma == mb && mb == mc)
                {
                    loaitamgiac = "DAY LA TAM GIAC DEU";
                }
                else if (ma == mb || ma == mc || mb == mc)
                {
                    loaitamgiac = "DAY LA TAM GIAC CAN";
                }
                else if (ma * ma > mb * mb + mc * mc || mb * mb > ma * ma + mc * mc || mc * mc > ma * ma + mb * mb)
                {
                    loaitamgiac = "DAY LA TAM GIAC TU ";
                }
                else
                {
                    loaitamgiac = "DAY LA TAM GIAC NHON";
                }
            }
            else
            {
                loaitamgiac = "DAY KHONG PHAI LA MOT TAM GIAC ";
            }
        }
        public int getChuVi()
        {
            return ma + mb + mc;
        }
        public int getDienTich()
        {
            int a = (ma + mb + mc) / 2;
            return (int)Math.Sqrt(a * (a - ma) * (a - mb) * (a - mc));
        }
        public override string ToString()
        {
            return string.Format("{0,-8} {1,-8} {2,-8} {3,-40} {4,-25} {5}", ma, mb, mc, loaitamgiac, getChuVi(), getDienTich());
        }
    }
}
