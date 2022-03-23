using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAU2
{
    public class Sach
    {
			protected string maSach, nhaXuatBan,ngayNhap;
			protected double donGia;
			protected int soLuong;

			public Sach() : base()
			{
			}

			public Sach(string maSach,string ngayNhap,string nhaXuatBan, double donGia, int soLuong) : base()
			{
				this.maSach = maSach;
				this.nhaXuatBan = nhaXuatBan;
				this.donGia = donGia;
				this.soLuong = soLuong;
			    this.ngayNhap = ngayNhap;
			}

			public virtual string MaSach
			{
				get
				{
					return maSach;
				}
				set
				{
					this.maSach = value;
				}
			}


			public virtual string NhaXuatBan
			{
				get
				{
					return nhaXuatBan;
				}
				set
				{
					this.nhaXuatBan = value;
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


			public virtual int SoLuong
			{
				get
				{
					return soLuong;
				}
				set
				{
					this.soLuong = value;
				}
			}
		   public virtual string NgayNhap
           {
            get
            {
				return ngayNhap;
            }
			set
            {
				this.ngayNhap = value;
            }
            }
		

			public override string ToString()
			{
				return "Ma Sach: " + this.maSach + ", Nha Xuat Ban : " + this.nhaXuatBan + ", Don Gia: " + this.donGia + ", So Luong: " + this.soLuong;
			}
		}
	}

