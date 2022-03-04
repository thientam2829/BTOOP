using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAU1
{
    public class NoiThanh:ChuyenXe
    {
			private string soTuyen;
			private double soKmDiDuoc;

			public NoiThanh() : base()
			{
			}

			public NoiThanh(string soTuyen, double soKmDiDuoc) : base()
			{
				this.soTuyen = soTuyen;
				this.soKmDiDuoc = soKmDiDuoc;
			}

			public virtual double SoKmDiDuoc
			{
				get
				{
					return soKmDiDuoc;
				}
				set
				{
					this.soKmDiDuoc = value;
				}
			}

			public virtual void nhapThongTinChuyenXe()
			{
				base.nhapThongTinChuyenXe(); 
				Console.Write("NHAP SO TUYEN: ");
			    soTuyen = Console.ReadLine();
				Console.Write("NHAP SO KM DA DI: ");
			    soKmDiDuoc = double.Parse(Console.ReadLine());
			}

			public override string ToString()
			{
				return base.ToString() + ", SO TUYEN : " + this.soTuyen + ", SO KM DA DI : " + this.soKmDiDuoc;
			}
		}
	}



