using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAU2
{
	public class SachGiaoKhoa : Sach
	{
		private string tinhTrang;
		private int number;
		private double thanhTien;

		public SachGiaoKhoa() : base()
		{
		}

		public SachGiaoKhoa(string maSach, string ngayNhap, string nhaXuatBan, double donGia, int soLuong,string tinhTrang) : base(maSach, ngayNhap, nhaXuatBan, donGia, soLuong)
        {
			this.tinhTrang = tinhTrang;
        }



		public virtual string TinhTrang
		{
			get
			{
				return tinhTrang;
			}
			set
			{
				this.tinhTrang = value;
			}
		}




		public virtual int Number
		{
			get
			{
				return number;
			}
			set
			{
				this.number = value;
			}
		}
		public String tinhTrangSach(int x)
		{
			switch (Number)
			{
				case 0:
					TinhTrang = "cu";
					break;
				case 1:
					TinhTrang = "moi";
					break;
				default:
					break;
			}
			return TinhTrang;
		}
		public override string ToString()
		{
			return base.ToString() + ", tinh trang sach: " + this.TinhTrang;
		}

	}





	
}

