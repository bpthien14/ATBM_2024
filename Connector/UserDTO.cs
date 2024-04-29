using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDLNB_PH1.Connector
{
    class SVienDTO
    {
        private string maSV;
        public string MASV
        {
            get { return maSV; }
            set { maSV = value; }
        }
        private string hoten;
        public string HOTEN
        {
            get { return hoten; }
            set { hoten = value; }
        }
        private string phai;
        public string PHAI
        {
            get { return phai; }
            set { phai = value; }
        }
        private DateTime ngaysinh;
        public DateTime NGAYSINH  
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        private string dchi;
        public string DCHI
        {
            get { return dchi; }
            set { dchi = value; }
        }
        private string dt;
        public string DT
        {
            get { return dt; }
            set { dt = value; }
        }
        private string mact;
        public string MACT
        {
            get { return mact; }
            set { mact = value; }
        }
        private string manganh;
        public string MANGANH
        {
            get { return manganh; }
            set { manganh = value; }
        }
        private int sotctl;
        public int SOTCTL
        {
            get { return sotctl; }
            set { sotctl = value; }
        }
        private decimal? dtbtl;
        public decimal? DTBTL
        {
            get { return dtbtl; }
            set { dtbtl = value; }
        }

    }
    class DViDTO
    {
        private string madv;
        public string MADV
        {
            get { return madv; }
            set { madv = value; }
        }
        private string tendv;
        public string TENDV
        {
            get { return tendv; }
            set { tendv = value; }
        }
        private string trgdv;
        public string TRGDV
        {
            get { return trgdv; }
            set { trgdv = value; }
        }
    }

    class DKiDTO
    {
        private string maSV;
        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
        private string maGV;
        public string MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }
        private string maHP;
        public string MaHP
        {
            get { return maHP; }
            set { maHP = value; }
        }
        private string maCT;
        public string MaCT
        {
            get { return maCT; }
            set { maCT = value; }
        }
        private int nam;
        public int NAM
        {
            get { return nam; }
            set { nam = value; }
        }
        private int hk;
        public int HK
        {
            get { return hk; }
            set { hk = value; }
        }
        private decimal? diemTH;
        public decimal? DiemTH
        {
            get { return diemTH; }
            set { diemTH = value; }
        }
        private decimal? diemQT;
        public decimal? DiemQT
        {
            get { return diemQT; }
            set { diemQT = value; }
        }
        private decimal? diemCK;
        public decimal? DiemCK
        {
            get { return diemCK; }
            set { diemCK = value; }
        }
        private decimal? diemTK;
        public decimal? DiemTK
        {
            get { return diemTK; }
            set { diemTK = value; }
        }

    }
    class HPhanDTO
    {
        private string mahp;
        public string MAHP
        {
            get { return mahp; }
            set { mahp = value; }
        }
        private string tenhp;
        public string TENHP
        {
            get { return tenhp; }
            set { tenhp = value; }
        }
        private int sotc;
        public int SOTC
        {
            get { return sotc; }
            set { sotc = value; }
        }
        private int stlt;
        public int STLT
        {
            get { return stlt; }
            set { stlt = value; }
        }
        private int stth;
        public int STTH
        {
            get { return stth; }
            set { stth = value; }
        }
        private int sosvtd;
        public int SOSVTD
        {
            get { return sosvtd; }
            set { sosvtd = value; }
        }
        private string madv;
        public string MADV
        {
            get { return madv; }
            set { madv = value; }
        }
    }
    class KhoaHocDTO
    {
        private string mahp;
        public string MAHP
        {
            get { return mahp; }
            set { mahp = value; }
        }
        private string mact;
        public string MACT
        {
            get { return mact; }
            set { mact = value; }
        }
        private int hk;
        public int HK
        {
            get { return hk; }
            set { hk = value; }
        }
        private int nam;
        public int NAM
        {
            get { return nam; }
            set { nam = value; }
        }
    }
    class PhanCongDTO
    {
        private string mahp;
        public string MAHP
        {
            get { return mahp; }
            set { mahp = value; }
        }
        private string magv;
        public string MAGV
        {
            get { return magv; }
            set { magv = value; }
        }
        private int hk;
        public int HK
        {
            get { return hk; }
            set { hk = value; }
        }
        private int nam;
        public int NAM
        {
            get { return nam; }
            set { nam = value; }
        }
        private string mact;
        public string MACT
        {
            get { return mact; }
            set { mact = value; }
        }
    }
    class NVienDTO
    {
        private string manv;
        public string MANV
        {
            get { return manv; }
            set { manv = value; }
        }

        private string hoten;
        public string HOTEN
        {
            get { return hoten; }
            set { hoten = value; }
        }

        private string phai;
        public string PHAI
        {
            get { return phai; }
            set { phai = value; }
        }

        private DateTime ngaysinh;
        public DateTime NGAYSINH
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        private decimal phucap;
        public decimal PHUCAP
        {
            get { return phucap; }
            set { phucap = value; }
        }

        private string dt;
        public string DT
        {
            get { return dt; }
            set { dt = value; }
        }

        private string vaitro;
        public string VAITRO
        {
            get { return vaitro; }
            set { vaitro = value; }
        }

        private string madv;
        public string MADV
        {
            get { return madv; }
            set { madv = value; }
        }
    }

}
