using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAU5
{
    public  class ThucPham
    {
			private string maHang;
			private string tenHang;
			private double donGia;
			private DateTime nSX, hSD;
		    private string kiemtra;
			
			public ThucPham(string maHang, string tenHang, double donGia, DateTime nSX, DateTime hSD)
			{
				this.maHang = maHang;
				this.tenHang = tenHang;
				this.donGia = donGia;
				this.nSX = nSX;
				this.hSD = hSD;
			}

			
			public ThucPham()
			{
			}
		public override string ToString()
		{
			return string.Format("{0,-18} {1,-21} {2,-23} {3,-20} {4,-35} {5,-25}", maHang,TenHang,DonGia,nSX,hSD,getghichu());
		}

		public virtual string TenHang
			{
				get
				{
					return tenHang;
				}
				set
				{
					this.tenHang = value;
				}
			}


			public virtual double DonGia
			{
				get
				{
					return donGia;
				}
				set
				{
					this.donGia = value;
				}
			}
		public string getmaHang()
        {
			return maHang;
        }
		public void setmaHang()
        {
			if (!maHang.Trim().Equals(" "))
            {
				this.maHang = maHang;
			}
			else _ = new Exception("ERROR!");
		}


			public virtual DateTime getnSX()
			{
				return nSX;
			}

		public virtual void setnSX(DateTime nSX)
		{
			if (DateTime.Compare(nSX, DateTime.Now) < 0) 
				this.nSX = nSX;
			else this.nSX = DateTime.Now;
		}
		

			public virtual DateTime gethSD()
			{
				return hSD;
			}

			public virtual void sethSD(DateTime hSD)
			{
			if (DateTime.Compare(hSD, nSX) > 0) 
				 this.hSD = hSD;
			else hSD = nSX;
		}
		public void KiemTra(DateTime nSX, DateTime hSD)
		{
			int result = DateTime.Compare(nSX, hSD);
			if (result < 0)
            {
				kiemtra = "SAN PHAM CON HAN";
			}
				
			else kiemtra = "SAN PHAM HET HAN	 ";
		}
		public string getghichu()
        {
			return kiemtra;
        }

	}
}
