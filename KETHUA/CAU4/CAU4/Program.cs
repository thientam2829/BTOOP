using System;
using System.Collections.Generic;

namespace CAU4
{

	public class Program
	{

		public static void Main()
		{
			List<GiaoDichNha> arrGiaoDichNha = new List<GiaoDichNha>();
			List<GiaoDichDat> arrGiaoDichDat = new List<GiaoDichDat>();
			int soGiaoDichDat = 0, soGiaoDichNha = 0;
			double tongTienGiaoDichDat = 0, trungBinhThanhTien = 0;

			GiaoDichNha N1 = new GiaoDichNha("001","20/9/2013",4500000000000,25,"CAO CAP","LONG AN");
			GiaoDichNha N2 = new GiaoDichNha("002", "07/9/2013", 1500000000000, 22, "THUONG", "DA LAT");
			GiaoDichNha N3 = new GiaoDichNha("003", "20/10/2013", 6500000000000, 40, "CAO CAP", "TPHCM");
			arrGiaoDichNha.Add(N1);
			arrGiaoDichNha.Add(N2);
			arrGiaoDichNha.Add(N3);

			GiaoDichDat D1 = new GiaoDichDat("D001", "22/12/2013", 4000000000, 500, "A");
			GiaoDichDat D2 = new GiaoDichDat("D002", "15/9/2013", 25500000000, 219, "B");
			GiaoDichDat D3 = new GiaoDichDat("D003", "22/9/2013", 40000000, 50, "C");
			arrGiaoDichDat.Add(D1);
			arrGiaoDichDat.Add(D2);
			arrGiaoDichDat.Add(D3);


			Console.WriteLine("---THONG TIN CAC GIAO DICH DAT---");
			for (int i = 0; i < arrGiaoDichNha.Count; i++)
			{
				Console.WriteLine(arrGiaoDichDat[i].ToString());
			}
			for (int i = 0; i < arrGiaoDichDat.Count; i++)
			{
				if (arrGiaoDichDat[i].LoaiDat.Equals("A"))
				{
					tongTienGiaoDichDat += arrGiaoDichDat[i].DienTich * arrGiaoDichDat[i].DonGia * 1.5;
				}
				else if (arrGiaoDichDat[i].LoaiDat.Equals("B") || arrGiaoDichDat[i].LoaiDat.Equals("C"))
				{
					tongTienGiaoDichDat += arrGiaoDichDat[i].DienTich * arrGiaoDichDat[i].DonGia;
				}
			}
			trungBinhThanhTien = tongTienGiaoDichDat / (arrGiaoDichDat.Count);
			Console.WriteLine("TRUNG BINH THANH TIEN GIAO DICH DAT  = " + trungBinhThanhTien);

			Console.WriteLine("---THONG TIN CAC GIAO DICH NHA---");
			for (int i = 0; i < arrGiaoDichNha.Count; i++)
			{
				Console.WriteLine(arrGiaoDichNha[i].ToString());
			}

			

			// xuất ra các giao dịch của tháng 9 năm 2013
			Console.WriteLine("CAC GIAO DICH DAT THANG 9 NAM 2013 : ");
			for (int i = 0; i < arrGiaoDichDat.Count; i++)
			{
				string[] dateGiaoDichDat = arrGiaoDichDat[i].NgayGiaoDich.Split("/");
				if (dateGiaoDichDat[1].Equals("9") && dateGiaoDichDat[2].Equals("2013"))
				{
					Console.WriteLine(arrGiaoDichDat[i].ToString());
				}
			}

			Console.WriteLine("CAC GIAO DICH NHA THANG 9 NAM 2013: ");
			for (int i = 0; i < arrGiaoDichNha.Count; i++)
			{
				string[] dateGiaoDichNha = arrGiaoDichNha[i].NgayGiaoDich.Split("/");
				if (dateGiaoDichNha[1].Equals("9") && dateGiaoDichNha[2].Equals("2013"))
				{
					Console.WriteLine(arrGiaoDichNha[i].ToString());
				}
			}
		}

	}
}

