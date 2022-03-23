using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAU4
{
	public class GiaoDichNha : GiaoDich
	{
		private string loaiNha, diaChi;
		private int choose;

		public GiaoDichNha() : base()
		{
		}

		public GiaoDichNha(string maGiaoDich, string ngayGiaoDich, long donGia, float dienTich,string loaiNha, string diaChi) : base(maGiaoDich,ngayGiaoDich,donGia,dienTich)
		{
			this.loaiNha = loaiNha;
			this.diaChi = diaChi;
		}

		public virtual string LoaiNha
		{
			get
			{
				return loaiNha;
			}
			set
			{
				this.loaiNha = value;
			}
		}


		public virtual string DiaChi
		{
			get
			{
				return diaChi;
			}
			set
			{
				this.diaChi = value;
			}
		}


		public override string ToString()
		{
			return base.ToString() + ", LOAI NHA : " + this.loaiNha + ", DIA CHI : " + this.diaChi;
		}
	}
}


