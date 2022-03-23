// See https://aka.ms/new-console-template for more information
using System;
namespace CAU2
{
    class Program
    {
        public static void Main()
        {
			
				List<SachGiaoKhoa> arrSachGiaoKhoa = new List<SachGiaoKhoa>();
				List<SachThamKhao> arrSachThamKhao = new List<SachThamKhao>();
				int soSachGiaoKhoa, soSachThamKhao;
				double tongTienSachGiaoKhoa = 0, tongTienSachThamKhao = 0, tongDonGiaSachThamKhao = 0, trungBinhCongDonGia = 0;

			     SachGiaoKhoa sgk1 = new SachGiaoKhoa("S01", "20/12/2021", "NXB K", 25000, 25, "moi");
			     SachGiaoKhoa sgk2 = new SachGiaoKhoa("S02", "20/12/2021", "NXB X", 15000, 25, "moi");
			     SachGiaoKhoa sgk3 = new SachGiaoKhoa("S03", "20/12/2021", "NXB K", 55000, 15, "cu");
			     arrSachGiaoKhoa.Add(sgk1);
			     arrSachGiaoKhoa.Add(sgk2);
			     arrSachGiaoKhoa.Add(sgk3);

			    SachThamKhao stk1 = new SachThamKhao("A01", "30/4/2021", "NXB K", 15500, 20, 2500);
			    SachThamKhao stk2 = new SachThamKhao("A02", "30/4/2021", "NXB K", 25000, 15, 1800);
			    SachThamKhao stk3 = new SachThamKhao("A03", "30/4/2021", "NXB x", 18000, 50, 3000);
			    arrSachThamKhao.Add(stk1);
			    arrSachThamKhao.Add(stk2);
			    arrSachThamKhao.Add(stk3);




			for (int i = 0; i < arrSachGiaoKhoa.Count; i++)
				{
					if (arrSachGiaoKhoa[i].Number == 0)
					{
						tongTienSachGiaoKhoa += arrSachGiaoKhoa[i].SoLuong * arrSachGiaoKhoa[i].DonGia * 50 / 100;
					}
					else if (arrSachGiaoKhoa[i].Number == 1)
					{
						tongTienSachGiaoKhoa += arrSachGiaoKhoa[i].SoLuong * arrSachGiaoKhoa[i].DonGia;
					}
				}
				Console.WriteLine("Tong Tien Sach Giao Khoa = " + tongTienSachGiaoKhoa);

				for (int i = 0; i < arrSachThamKhao.Count; i++)
				{
					tongTienSachThamKhao += arrSachThamKhao[i].SoLuong * arrSachThamKhao[i].DonGia + arrSachThamKhao[i].Thue;
				}
				Console.WriteLine("Tong Tien Sach Tham Khao = " + tongTienSachThamKhao);

				Console.WriteLine("-----Thong Tin Sach Giao Khoa-----");
				for (int i = 0; i < arrSachGiaoKhoa.Count; i++)
				{
					Console.WriteLine(arrSachGiaoKhoa[i].ToString());
				}

				Console.WriteLine("-----Thong Tin Sach Tham Khao-----");
				for (int i = 0; i < arrSachThamKhao.Count; i++)
				{
					Console.WriteLine(arrSachThamKhao[i].ToString());
				}

				Console.WriteLine("---Trung Binh Cong Sach Tham Khao---");
				for (int i = 0; i < arrSachThamKhao.Count; i++)
				{
					tongDonGiaSachThamKhao += arrSachThamKhao[i].DonGia;
					trungBinhCongDonGia = tongDonGiaSachThamKhao / arrSachThamKhao.Count;
				}
				Console.WriteLine("Trung Binh Cong Cac Sach Tham Khao = " + trungBinhCongDonGia);

			}
		}

	}
