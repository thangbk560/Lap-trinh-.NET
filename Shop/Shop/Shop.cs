using System;
using System.Collections.Generic;
class SanPham
{
    private string tenSanPham { get; set; }
    private string moTa { get; set; }
    private float gia { get; set; }
    private int soLuong { get; set; }

    public SanPham(string tenSanPham, float gia, string moTa, int soLuong)
    {
        this.tenSanPham = tenSanPham;
        this.gia = gia;
        this.moTa = moTa;
        this.soLuong = soLuong;
    }
    public string getTenSanPham() { return tenSanPham; }
    public float getGia() { return gia; }
    public int getSoLuong() { return soLuong; }
    public virtual void hienThi()
    {
        Console.WriteLine("Tên sản phẩm: " + this.tenSanPham + ", Giá: " + this.gia + ", Mô tả: " + this.moTa + ", Số lượng: " + this.soLuong);
    }
}

class DienTu : SanPham
{
    private int baoHanh { get; set; }
    public DienTu(string tenSanPham, float gia, string moTa, int soLuong, int baoHanh) : base (tenSanPham, gia, moTa, soLuong)
    {
        this.baoHanh = baoHanh;
    }
    public override void hienThi()
    {
        base.hienThi();
        Console.WriteLine("Bảo hành: " + this.baoHanh + " tháng");
    }
}

class QuanAo : SanPham
{
    private string kichThuoc { get; set; }
    private string mauSac { get; set; }
    public QuanAo(string tenSanPham, float gia, string moTa, int soLuong, string kichThuoc, string mauSac) : base(tenSanPham, gia, moTa, soLuong)
    {
        this.kichThuoc = kichThuoc;
        this.mauSac = mauSac;
    }
    public override void hienThi()
    {
        base.hienThi();
        Console.WriteLine("Kích thước: " + this.kichThuoc + ", Màu sắc: " + this.mauSac);
    }
}

class ThucPham : SanPham
{
    private DateTime ngayHetHan { get; set; }
    public ThucPham(string tenSanPham, float gia, string moTa, int soLuong, DateTime ngayHetHan) : base(tenSanPham, gia, moTa, soLuong)
    {
        this.ngayHetHan = ngayHetHan;
    }
    public override void hienThi()
    {
        base.hienThi();
        Console.WriteLine("Ngày hết hạn: " + this.ngayHetHan.ToString("dd/MM/yyyy"));
    }
}

class GioHang
{
    private List<SanPham> danhSachSanPham;

    public GioHang()
    {
        danhSachSanPham = new List<SanPham>();
    }

    public void themSanPham(SanPham sp)
    {
        danhSachSanPham.Add(sp);
        Console.WriteLine($"{sp.getTenSanPham()} đã được thêm vào giỏ hàng.");
    }

    public void xoaSanPham(SanPham sp)
    {
        if (danhSachSanPham.Contains(sp))
        {
            danhSachSanPham.Remove(sp);
            Console.WriteLine($"{sp.getTenSanPham()} đã được xóa khỏi giỏ hàng.");
        }
        else
        {
            Console.WriteLine($"{sp.getTenSanPham()} không có trong giỏ hàng.");
        }
    }

    public void hienThiGioHang()
    {
        Console.WriteLine("Danh sách sản phẩm trong giỏ hàng:");
        foreach (var sp in danhSachSanPham)
        {
            sp.hienThi();
            Console.WriteLine("----------------------------");
        }
    }

    public float tinhTongGiaTri()
    {
        float tongGiaTri = 0;
        foreach (var sp in danhSachSanPham)
        {
            tongGiaTri += sp.getGia() * sp.getSoLuong();
        }
        return tongGiaTri;
    }
}

class Shop
{
    static void Main(string[] args)
    {
        DienTu laptop = new DienTu("Laptop", 15000000, "Laptop gaming", 1, 18);
        QuanAo aophong = new QuanAo("Áo phông", 200000, "Áo phông cotton", 3, "L", "Đen");
        ThucPham sua = new ThucPham("Sữa tươi", 30000, "Sữa tươi nguyên chất", 10, DateTime.Now.AddMonths(2));

        GioHang gioHang = new GioHang();

        gioHang.themSanPham(laptop);
        gioHang.themSanPham(aophong);
        gioHang.themSanPham(sua);

        gioHang.hienThiGioHang();

        float tongGiaTri = gioHang.tinhTongGiaTri();
        Console.WriteLine($"Tổng giá trị đơn hàng: {tongGiaTri} VND");
    }
}