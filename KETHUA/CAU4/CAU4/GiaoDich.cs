using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAU4
{
    public class GiaoDich
    {
    
			private string maGiaoDich, ngayGiaoDich;
			private long donGia;
			private float dienTich;

			public GiaoDich() : base()
			{
			}

			public GiaoDich(string maGiaoDich, string ngayGiaoDich, long donGia, float dienTich) : base()
			{
				this.maGiaoDich = maGiaoDich;
				this.ngayGiaoDich = ngayGiaoDich;
				this.donGia = donGia;
				this.dienTich = dienTich;
			}

			public virtual string MaGiaoDich
			{
				get
				{
					return maGiaoDich;
				}
				set
				{
					this.maGiaoDich = value;
				}
			}


			public virtual string NgayGiaoDich
			{
				get
				{
					return ngayGiaoDich;
				}
				set
				{
					this.ngayGiaoDich = value;
				}
			}


			public virtual long DonGia
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


			public virtual float DienTich
			{
				get
				{
					return dienTich;
				}
				set
				{
					this.dienTich = value;
				}
			}

			public override string ToString()
			{
				return "MA GIAO DICH: " + this.maGiaoDich + ", NGAY GIAO DICH: " + this.ngayGiaoDich + ", DON GIA : " + this.donGia + ", DIEN TICH: " + this.dienTich;
			}
		}
	}


