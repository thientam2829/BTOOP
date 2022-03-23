using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAU4
{
    public class GiaoDichDat:GiaoDich
    {
		private string loaiDat;

		public GiaoDichDat() : base()
		{
		}

		public GiaoDichDat(string maGiaoDich, string ngayGiaoDich, long donGia, float dienTich,string loaiDat) : base(maGiaoDich, ngayGiaoDich, donGia, dienTich)
		{
			this.loaiDat = loaiDat;
		}

		public virtual string LoaiDat
		{
			get
			{
				return loaiDat;
			}
			set
			{
				this.loaiDat = value;
			}
		}

		public override string ToString()
		{
			return base.ToString() + ", LOAI DAT : " + this.loaiDat;
		}
	}
}
