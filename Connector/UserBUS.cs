using Microsoft.VisualBasic.ApplicationServices;
using QLDLNB_PH1.PH2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace QLDLNB_PH1.Connector
{
    
    class UserBUS
    {
        
        private static UserBUS instance;
        public static UserBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserBUS();
                }
                return instance;
            }
        }
        private UserBUS() { }
        public void Xem(DataGridView data)
        {
            data.DataSource = UserDAO.Instance.Xem();

        }

        public bool FixPhone(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string MANV = row.Cells["MaNV"].Value.ToString();

            //string id = row.Cells["MaNV"].Value.ToString();
            string dt = row.Cells["DT"].Value.ToString();
            NVienDTO user = new NVienDTO() { DT = dt};

            return UserDAO.Instance.FixPhone(MANV, user);
        }

        public bool FixGrade(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string MASV = row.Cells["MASV"].Value.ToString();
            string MAGV = row.Cells["MAGV"].Value.ToString();
            string MAHP = row.Cells["MAHP"].Value.ToString();
            int HK = Convert.ToInt32(row.Cells["HK"].Value);
            int NAM = Convert.ToInt32(row.Cells["NAM"].Value);
            decimal? DIEMTH = Convert.ToDecimal(row.Cells["DIEMTH"].Value);
            decimal? DIEMQT = Convert.ToDecimal(row.Cells["DIEMQT"].Value);
            decimal? DIEMCK = Convert.ToDecimal(row.Cells["DIEMCK"].Value);
            decimal? DIEMTK = Convert.ToDecimal(row.Cells["DIEMTK"].Value);
            DKiDTO user = new DKiDTO() { DiemTH = DIEMTH , DiemQT = DIEMQT , DiemCK = DIEMCK , DiemTK = DIEMTK , 
                MaSV = MASV , MaGV = MAGV , MaHP = MAHP , HK = HK , NAM = NAM };

            return UserDAO.Instance.FixGrade(user);
        }

        public bool Fix_SVien(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string MASV = row.Cells["MASV"].Value.ToString();
            string HOTEN = row.Cells["HOTEN"].Value.ToString();
            string PHAI = row.Cells["PHAI"].Value.ToString();
            DateTime NGAYSINH = Convert.ToDateTime(row.Cells["NGSINH"].Value) ;
            string DIACHI = row.Cells["DCHI"].Value.ToString();
            string DIENTHOAI = row.Cells["DT"].Value.ToString();
            string MACT = row.Cells["MACT"].Value.ToString();
            string MANGANH = row.Cells["MANGANH"].Value.ToString();
            int SOTCTL = Convert.ToInt32(row.Cells["SOTCTL"].Value);
            decimal? DTBTL = Convert.ToDecimal(row.Cells["DTBTL"].Value);

            SVienDTO user = new SVienDTO() { HOTEN = HOTEN , PHAI = PHAI , NGAYSINH = NGAYSINH , DCHI = DIACHI , 
                DT = DIENTHOAI , MACT = MACT , MANGANH = MANGANH , SOTCTL = SOTCTL, DTBTL = DTBTL , MASV = MASV };

            return UserDAO.Instance.Fix_SVien(user);
        }

        public bool Add_SVien(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string MASV = row.Cells["MASV"].Value.ToString();
            string HOTEN = row.Cells["HOTEN"].Value.ToString();
            string PHAI = row.Cells["PHAI"].Value.ToString();
            DateTime NGAYSINH = Convert.ToDateTime(row.Cells["NGSINH"].Value);
            string DIACHI = row.Cells["DCHI"].Value.ToString();
            string DIENTHOAI = row.Cells["DT"].Value.ToString();
            string MACT = row.Cells["MACT"].Value.ToString();
            string MANGANH = row.Cells["MANGANH"].Value.ToString();
            int SOTCTL = Convert.ToInt32(row.Cells["SOTCTL"].Value);
            decimal? DTBTL = Convert.ToDecimal(row.Cells["DTBTL"].Value);

            SVienDTO user = new SVienDTO()
            {
                MASV = MASV,
                HOTEN = HOTEN,
                PHAI = PHAI,
                NGAYSINH = NGAYSINH,
                DCHI = DIACHI,
                DT = DIENTHOAI,
                MACT = MACT,
                MANGANH = MANGANH,
                SOTCTL = SOTCTL,
                DTBTL = DTBTL
                
            };

            return UserDAO.Instance.Add_SVien(user);
        }
        public bool Fix_DVi(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string TENDV = row.Cells["TENDV"].Value.ToString();
            string TRGDV = row.Cells["TRGDV"].Value.ToString();
            string MADV = row.Cells["MADV"].Value.ToString();

            DViDTO user = new DViDTO()
            {
                TENDV = TENDV,
                TRGDV = TRGDV,
                MADV = MADV
            };

            return UserDAO.Instance.Fix_DVi(user);
        }
        public bool Add_DVi(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string MADV = row.Cells["MADV"].Value.ToString();
            string TENDV = row.Cells["TENDV"].Value.ToString();
            string TRGDV = row.Cells["TRGDV"].Value.ToString();


            DViDTO user = new DViDTO()
            {
                MADV = MADV,
                TENDV = TENDV,
                TRGDV = TRGDV
            };

            return UserDAO.Instance.Add_DVi(user);
        }
        public bool Fix_HPhan(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string TENHP = row.Cells["TENHP"].Value.ToString();
            int SOTC = Convert.ToInt32(row.Cells["SOTC"].Value);
            int STLT = Convert.ToInt32(row.Cells["STLT"].Value);
            int STTH = Convert.ToInt32(row.Cells["STTH"].Value);
            int SOSVTD = Convert.ToInt32(row.Cells["SOSVTD"].Value);
            string MADV = row.Cells["MADV"].Value.ToString();
            string MAHP = row.Cells["MAHP"].Value.ToString();
            HPhanDTO user = new HPhanDTO()
            {
                TENHP = TENHP,
                SOTC = SOTC,
                STLT = STLT,
                STTH = STTH,
                SOSVTD = SOSVTD,
                MADV = MADV,
                MAHP = MAHP
            };

            return UserDAO.Instance.Fix_HPhan(user);
        }
        public bool Add_HPhan(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string TENHP = row.Cells["TENHP"].Value.ToString();
            int SOTC = Convert.ToInt32(row.Cells["SOTC"].Value);
            int STLT = Convert.ToInt32(row.Cells["STLT"].Value);
            int STTH = Convert.ToInt32(row.Cells["STTH"].Value);
            int SOSVTD = Convert.ToInt32(row.Cells["SOSVTD"].Value);
            string MADV = row.Cells["MADV"].Value.ToString();
            string MAHP = row.Cells["MAHP"].Value.ToString();
            HPhanDTO user = new HPhanDTO()
            {
                MAHP = MAHP,
                TENHP = TENHP,
                SOTC = SOTC,
                STLT = STLT,
                STTH = STTH,
                SOSVTD = SOSVTD,
                MADV = MADV
                
            };

            return UserDAO.Instance.Add_HPhan(user);
        }

        public bool Add_KHoc(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string MAHP = row.Cells["MAHP"].Value.ToString();
            string MACT = row.Cells["MACT"].Value.ToString();
            int HK = Convert.ToInt32(row.Cells["HK"].Value);
            int NAM = Convert.ToInt32(row.Cells["NAM"].Value);
           
            KhoaHocDTO user = new KhoaHocDTO()
            {
                MAHP = MAHP,
                MACT = MACT,
                HK = HK,
                NAM = NAM
            };

            return UserDAO.Instance.Add_KHoc(user);
        }
        public bool Add_NhanVien(DataGridView data)
        {
            // Lấy dữ liệu từ các TextBox
            string MANV = CS5_TRUONGKHOA.textMANV.Text;
            string HOTEN = CS5_TRUONGKHOA.textHOTEN.Text;
            string PHAI = CS5_TRUONGKHOA.textPHAI.Text;
            string DT = CS5_TRUONGKHOA.textDIENTHOAI.Text;
            string VAITRO = CS5_TRUONGKHOA.textVAITRO.Text;
            string MADV = CS5_TRUONGKHOA.textMADV.Text;
            // Tiếp tục lấy dữ liệu từ các TextBox khác

            // Tạo đối tượng NVienDTO và gán giá trị
            NVienDTO user = new NVienDTO();
            {
                user.MANV = MANV;
                user.HOTEN = HOTEN;
                user.PHAI = PHAI;
                user.DT = DT;
                user.VAITRO = VAITRO;
                user.MADV = MADV;
                
                user.NGAYSINH = Convert.ToDateTime(CS5_TRUONGKHOA.textNGSINH.Text);
                user.PHUCAP = Convert.ToDecimal(CS5_TRUONGKHOA.textPHUCAP.Text);
                
                // Tiếp tục gán các giá trị khác
            }

            // Gọi hàm Add_NhanVien từ UserDAO để thêm nhân viên
            return UserDAO.Instance.Add_NhanVien(user);
        }
        public bool fixPhoneOrAddress(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string MASV = row.Cells["MASV"].Value.ToString();

            string DIACHI = row.Cells["DCHI"].Value.ToString();
            string DIENTHOAI = row.Cells["DT"].Value.ToString();

            SVienDTO user = new SVienDTO()
            {
                MASV = MASV,
                DCHI= DIACHI,
                DT = DIENTHOAI
            };
            return UserDAO.Instance.UpdateStudentContactInfo(user);
        }



    }
}
