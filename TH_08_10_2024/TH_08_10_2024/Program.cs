using System;
using System.Collections.Generic;

public abstract class PhuongTien
{
    private string _TenPhuongTien;
    private string _LoaiNhienLieu;

    public PhuongTien(string tenphuongtien, string loainhienlieu)
    {
        this._TenPhuongTien = tenphuongtien;
        this._LoaiNhienLieu = loainhienlieu;
    }
    public string TenPhuongTien
    {
        get { return _TenPhuongTien; }
        private set { _TenPhuongTien = value; }
    }
    public string LoaiNhienLieu
    {
        get { return _LoaiNhienLieu; }
        private set { _LoaiNhienLieu = value; }
    }
    public abstract void DiChuyen();
}

public interface IThongTinThem
{
    void TocDoToiDa();
    void MucTieuThuNhienLieu();
}

public class XeHoi : PhuongTien, IThongTinThem
{
    public XeHoi(string tenphuongtien, string loainhienlieu) : base(tenphuongtien, loainhienlieu)
    {
    }

    public override void DiChuyen()
    {
        Console.WriteLine($"{TenPhuongTien} di chuyển bằng động cơ.");
    }

    public void TocDoToiDa()
    {
        Console.WriteLine($"{TenPhuongTien} có tốc độ tối đa là 200 km/h.");
    }

    public void MucTieuThuNhienLieu()
    {
        Console.WriteLine($"{TenPhuongTien} tiêu thụ 8 lít nhiên liệu trên 100km.");
    }
}

public class XeDap : PhuongTien, IThongTinThem
{
    public XeDap(string tenphuongtien) : base(tenphuongtien, "Không sử dụng nhiên liệu")
    {
    }

    public override void DiChuyen()
    {
        Console.WriteLine($"{TenPhuongTien} di chuyển bằng sức người.");
    }

    public void TocDoToiDa()
    {
        Console.WriteLine($"{TenPhuongTien} có tốc độ tối đa là 25 km/h.");
    }

    public void MucTieuThuNhienLieu()
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<PhuongTien> danhSachPhuongTien = new List<PhuongTien>();

        XeHoi xeHoi = new XeHoi("Ô tô", "Xăng");
        XeDap xeDap = new XeDap("Xe đạp");

        danhSachPhuongTien.Add(xeHoi);
        danhSachPhuongTien.Add(xeDap);

        foreach (PhuongTien phuongTien in danhSachPhuongTien)
        {
            phuongTien.DiChuyen();

            if (phuongTien is IThongTinThem)
            {
                IThongTinThem thongTinThem = (IThongTinThem)phuongTien;
                thongTinThem.TocDoToiDa();
                thongTinThem.MucTieuThuNhienLieu();
            }

            Console.WriteLine();
        }
    }
}
