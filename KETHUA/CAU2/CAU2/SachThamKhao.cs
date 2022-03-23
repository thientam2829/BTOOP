using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAU2
{
    public class SachThamKhao:Sach
    {
        
			private double thue, thanhTien;

			public SachThamKhao() : base()
			{
			}

			public SachThamKhao(string maSach, string ngayNhap, string nhaXuatBan, double donGia, int soLuong,double thue) : base(maSach, ngayNhap, nhaXuatBan, donGia, soLuong)
			{
				this.thue = thue;
			}

			public virtual double Thue
			{
				get
				{
					return thue;
				}
				set
				{
					this.thue = value;
				}
			}


			public virtual void nhapthue()
			{
				
				Console.Write("Nhap Thue : ");
			    thue = Double.Parse(Console.ReadLine());
			}

			public override string ToString()
			{
				return base.ToString() + ", thue: " + this.thue;
			}

		}
	}