// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace CAU1
{

	public class Program
	{

		public static void Main(string[]args)
		{
			List<NoiThanh> arrNoiThanh = new List<NoiThanh>();
			List<NgoaiThanh> arrNgoaiThanh = new List<NgoaiThanh>();
			int soChuyenNoiThanh, soChuyenNgoaiThanh;
			double doanhThuXeNoiThanh = 0, doanhThuXeNgoaiThanh = 0;

			Console.Write("NHAP SO CHUYEN XE NOI THANH : ");
			soChuyenNoiThanh = Int16.Parse( Console.ReadLine());
			Console.Write("NHAP SO CHUYEN XE NGOAI THANH : ");
			soChuyenNgoaiThanh = Int16.Parse(Console.ReadLine());

			Console.WriteLine("===========================================================================");

			Console.WriteLine("NHAP THONG TIN CHUYEN XE NOI THANH :");
			for (int i = 0; i < soChuyenNoiThanh; i++)
			{
				Console.WriteLine("NHAP THONG TIN CHUYEN XE THU " + (i + 1) + ":");
				NoiThanh chuyenXeNoiThanh = new NoiThanh();
				chuyenXeNoiThanh.nhapThongTinChuyenXe();
               
				doanhThuXeNoiThanh = chuyenXeNoiThanh.DoanhThu;
				arrNoiThanh.Add(chuyenXeNoiThanh);
			}

			Console.WriteLine("==============================================================================");

			Console.WriteLine("NHAP THONG TIN CHUYEN XE NGOAI THANH:");
			for (int i = 0; i < soChuyenNgoaiThanh; i++)
			{
				Console.WriteLine("NHAP THONG TIN CHUYEN XE THU " + (i + 1) + ":");
				NgoaiThanh chuyenXeNgoaiThanh = new NgoaiThanh();
				chuyenXeNgoaiThanh.nhapThongTinChuyenXe();
				doanhThuXeNgoaiThanh += chuyenXeNgoaiThanh.DoanhThu;
				arrNgoaiThanh.Add(chuyenXeNgoaiThanh);
			}
			Console.WriteLine("==============================================================================");

			Console.WriteLine("-----THONG TIN XE NOI THANH-----");
			for (int i = 0; i < arrNoiThanh.Count; i++)
			{
				Console.WriteLine(arrNoiThanh[i].ToString());
			}

			Console.WriteLine("-----THONG TIN XE NGOAI THANH-----");
			for (int i = 0; i < arrNgoaiThanh.Count; i++)
			{
				Console.WriteLine(arrNgoaiThanh[i].ToString());

			}
			Console.WriteLine("==============================================================================");

			Console.WriteLine("DOANH THU TUNG CHUYEN XE : ");
			Console.WriteLine("DOANH THU TUYEN NOI THANH : " + doanhThuXeNoiThanh);
			Console.WriteLine("DOANH THU CHUYEN NGOAI THANH: " + doanhThuXeNgoaiThanh);
		}

	}
}

