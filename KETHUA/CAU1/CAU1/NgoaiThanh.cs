using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAU1
{
    public class NgoaiThanh:ChuyenXe
    {
       
			private string noiDen;
			private int soNgayDiDuoc;

			public NgoaiThanh() : base()
			{
				this.noiDen = "";
				this.soNgayDiDuoc = 0;
			}

			public NgoaiThanh(string noiDen, int soNgayDiDuoc) : base()
			{
				this.noiDen = noiDen;
				this.soNgayDiDuoc = soNgayDiDuoc;
			}

			public virtual string NoiDen
			{
				get
				{
					return noiDen;
				}
				set
				{
					this.noiDen = value;
				}
			}


			public virtual int SoNgayDiDuoc
			{
				get
				{
					return soNgayDiDuoc;
				}
				set
				{
					this.soNgayDiDuoc = value;
				}
			}


			public virtual void nhapThongTinChuyenXe()
			{
				base.nhapThongTinChuyenXe();
				Console.Write("NHAP NOI DEN: ");
			    noiDen = Console.ReadLine();
				Console.Write("NHAP SO NGAY DI DUOC: ");
			   soNgayDiDuoc = Int16.Parse(Console.ReadLine());
			}
			public override string ToString()
			{
				return base.ToString() + ", NOI DEN: " + this.noiDen + ", SO NGAY DI DUOC: " + this.soNgayDiDuoc;
			}
		}

	}

