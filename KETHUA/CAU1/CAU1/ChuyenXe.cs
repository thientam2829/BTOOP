using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAU1
{
    public class ChuyenXe
    {
        
			protected internal string maSoChuyen, hoTenTaiXe, soXe;
			protected internal double doanhThu;

			public ChuyenXe() : base()
			{
				this.maSoChuyen = "";
				this.hoTenTaiXe = "";
				this.soXe = "";
				this.doanhThu = 0;
			}

			public ChuyenXe(string maSoChuyen, string hoTenTaiXe, string soXe, double doanhThu) : base()
			{
				this.maSoChuyen = maSoChuyen;
				this.hoTenTaiXe = hoTenTaiXe;
				this.soXe = soXe;
				this.doanhThu = doanhThu;
			}

			public virtual string MaSoChuyen
			{
				get
				{
					return maSoChuyen;
				}
				set
				{
					this.maSoChuyen = value;
				}
			}


			public virtual string HoTenTaiXe
			{
				get
				{
					return hoTenTaiXe;
				}
				set
				{
					this.hoTenTaiXe = value;
				}
			}


			public virtual string SoXe
			{
				get
				{
					return soXe;
				}
				set
				{
					this.soXe = value;
				}
			}


			public virtual double DoanhThu
			{
				get
				{
					return doanhThu;
				}
				set
				{
					this.doanhThu = value;
				}
			}


			public virtual void nhapThongTinChuyenXe()
			{
				Console.Write("NHAP MA SO CHUYEN : ");
			    maSoChuyen = Console.ReadLine();
				Console.Write("NHAP HO TEN TAI XE : ");
			    hoTenTaiXe = Console.ReadLine();
				Console.Write("NHAP SO XE : ");
			    soXe = Console.ReadLine();
				Console.Write("NHAP DOANH THU: ");
			    doanhThu = double.Parse(Console.ReadLine());
			}

			public override string ToString()
			{
				return "MA SO CHUYEN : " + this.maSoChuyen + ", HO TEN TAI XE: " + this.hoTenTaiXe + ", SO XE : " + this.soXe + ", DOANH  THU: " + this.doanhThu;
			}
		}
	}




