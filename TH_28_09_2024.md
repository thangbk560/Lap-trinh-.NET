using System;
using System.Collections.Generic;

class SinhVien
{
    private string HoTen { get; set; }
    private string MSSV { get; set; }
    private double DiemTrungBinh { get; set; }

    public SinhVien()
    {
        this.HoTen = "";
        this.MSSV = "";
        this.DiemTrungBinh = 0.0;
    }

    public void NhapThongTin()
    {
        Console.Write("Nhập họ tên sinh viên: ");
        this.HoTen = Console.ReadLine();
        Console.Write("Nhập mã số sinh viên: ");
        this.MSSV = Console.ReadLine();
        Console.Write("Nhập điểm trung bình: ");
        this.DiemTrungBinh = double.Parse(Console.ReadLine());
    }

    public void HienThiThongTin()
    {
        Console.WriteLine("Họ tên: " + this.HoTen + "\tMSSV: " + this.MSSV + "\tĐiểm trung bình: " + this.DiemTrungBinh);
    }

    public double getDiemTrungBinh()
    {
        return this.DiemTrungBinh;
    }

    public string getMSSV()
    {
        return this.MSSV;
    }
}

class DanhSachSinhVien
{
    private List<SinhVien> dssv;

    public DanhSachSinhVien()
    {
        dssv = new List<SinhVien>();
    }
    public void ThemSinhVien(SinhVien sv)
    {
        dssv.Add(sv);
        Console.WriteLine("Đã thêm sinh viên với MSSV: " + sv.getMSSV());
    }
    public void HienThiDanhSach()
    {
        Console.WriteLine("Danh sách sinh viên:");
        foreach (var sv in dssv)
        {
            sv.HienThiThongTin();
        }
    }
    public void TimSinhVienTheoMSSV(string mssv)
    {
        SinhVien sinhVien = dssv.Find(sv => sv.getMSSV() == mssv);
        if (sinhVien != null)
        {
            Console.WriteLine("Thông tin sinh viên tìm thấy:");
            sinhVien.HienThiThongTin();
        }
        else
        {
            Console.WriteLine("Không tìm thấy sinh viên với MSSV: " + mssv);
        }
    }
    public SinhVien TinhDiemTrungBinhCaoNhat()
    {
        if (dssv.Count == 0) return null;

        SinhVien svCaoNhat = dssv[0];
        foreach (SinhVien sv in dssv)
        {
            if (sv.getDiemTrungBinh() > svCaoNhat.getDiemTrungBinh())
            {
                svCaoNhat = sv;
            }
        }
        return svCaoNhat;
    }
}

class TH_28_09_2024
{
    static void Main(string[] args)
    {
        DanhSachSinhVien danhSach = new DanhSachSinhVien();
        for (int i = 0; i < 3; i++)
        {
            SinhVien sv = new SinhVien();
            sv.NhapThongTin();
            danhSach.ThemSinhVien(sv);
        }
        danhSach.HienThiDanhSach();
        SinhVien svCaoNhat = danhSach.TinhDiemTrungBinhCaoNhat();
        if (svCaoNhat != null)
        {
            Console.WriteLine("\nSinh viên có điểm trung bình cao nhất:");
            svCaoNhat.HienThiThongTin();
        }
        Console.Write("\nNhập MSSV để tìm kiếm sinh viên: ");
        string mssv = Console.ReadLine();
        danhSach.TimSinhVienTheoMSSV(mssv);
    }
}
