using Microsoft.VisualBasic.ApplicationServices;
using Oracle.ManagedDataAccess.Client;
using QLDLNB_PH1.Connector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace QLDLNB_PH1.Connector
{
    class UserDAO
    {
        private static UserDAO instance;
        public static UserDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserDAO();
                }
                return instance;
            }
        }
        private UserDAO() { }

        public DataTable Xem()
        {
            string query = "";

            return DataProvider.Instance.ExecuteQuerry(query);
        }
        
       public bool FixPhone(string id, NVienDTO user)
        {
            bool kt = false;
            StaffConn staffConn = new StaffConn();
            string query = "UPDATE SEC_ADM.NHANSU SET DT = :DT WHERE MANV = :MANV  ";
            using (OracleConnection connection = new OracleConnection(StaffConn._connStr))
            {
                connection.Open();
                using (OracleCommand command = connection.CreateCommand())
                {

                    command.CommandText = query;
                    command.Parameters.Add(":DT", OracleDbType.Varchar2).Value = user.DT;
                    command.Parameters.Add(":MANV", OracleDbType.Varchar2).Value = id;
                    if (command.ExecuteNonQuery() > 0)
                    {
                        kt = true;
                    }
                }

                connection.Close();
            }
            return kt;
        }
        /*
        public bool FixGrade1(HPhanDTO user)
        {
            bool kt = false;
            StaffConn staffConn = new StaffConn();
            string query = "UPDATE SEC_ADM.DANGKY SET DIEMTH = :DIEMTH , DIEMQT = :DIEMQT , DIEMCK = :DIEMCK , DIEMTK = :DIEMTK WHERE MASV = :MASV AND MAGV = :MAGV AND MAHP = :MAHP AND HK = :HK AND NAM = :NAM ";
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter(":DIEMTH", OracleDbType.Decimal, user.DiemTH, ParameterDirection.Input),
                new OracleParameter(":DIEMQT", OracleDbType.Decimal, user.DiemQT, ParameterDirection.Input),
                new OracleParameter(":DIEMCK", OracleDbType.Decimal, user.DiemCK, ParameterDirection.Input),
                new OracleParameter(":DIEMTK", OracleDbType.Decimal, user.DiemTK, ParameterDirection.Input),
                new OracleParameter(":MASV", OracleDbType.Varchar2,  user.MaSV, ParameterDirection.Input),
                new OracleParameter(":MAGV", OracleDbType.Varchar2,  user.MaGV, ParameterDirection.Input),
                new OracleParameter(":MAHP", OracleDbType.Varchar2,  user.MaHP, ParameterDirection.Input),
                new OracleParameter(":HK", OracleDbType.Decimal,  user.HK, ParameterDirection.Input),
                new OracleParameter(":NAM", OracleDbType.Varchar2,  user.NAM, ParameterDirection.Input),
            };
            using (OracleConnection connection = new OracleConnection(StaffConn._connStr))
            {
                connection.Open();
                using (OracleCommand command = connection.CreateCommand())
                {

                    command.CommandText = query;
                    command.Parameters.Add(":DIEMTH", OracleDbType.Decimal).Value = user.DiemTH;
                    command.Parameters.Add(":DIEMQT", OracleDbType.Decimal).Value = user.DiemQT;
                    command.Parameters.Add(":DIEMCK", OracleDbType.Decimal).Value = user.DiemCK;
                    command.Parameters.Add(":DIEMTK", OracleDbType.Decimal).Value = user.DiemTK;
                    command.Parameters.Add(":MASV", OracleDbType.Varchar2).Value = user.MaSV;
                    command.Parameters.Add(":MAGV", OracleDbType.Varchar2).Value = user.MaGV;
                    command.Parameters.Add(":MAHP", OracleDbType.Varchar2).Value = user.MaHP;
                    command.Parameters.Add(":HK", OracleDbType.Decimal).Value = user.HK;
                    command.Parameters.Add(":NAM", OracleDbType.Decimal).Value = user.NAM;
                    if (command.ExecuteNonQuery() > 0)
                    {
                        kt = true;
                    }
                }

                connection.Close();
            }
            return kt;
        }
        */
        public bool FixGrade(DKiDTO user)
        {
            bool kt = false;
            string query = "UPDATE SEC_ADM.UV_GIANGVIEN_DANGKY  SET DIEMTH = :DIEMTH , DIEMQT = :DIEMQT , DIEMCK = :DIEMCK , DIEMTK = :DIEMTK" +
                " WHERE MASV = :MASV AND MAGV = :MAGV AND MAHP = :MAHP AND HK = :HK AND NAM = :NAM ";
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter(":DIEMTH", OracleDbType.Decimal, user.DiemTH, ParameterDirection.Input),
                new OracleParameter(":DIEMQT", OracleDbType.Decimal, user.DiemQT, ParameterDirection.Input),
                new OracleParameter(":DIEMCK", OracleDbType.Decimal, user.DiemCK, ParameterDirection.Input),
                new OracleParameter(":DIEMTK", OracleDbType.Decimal, user.DiemTK, ParameterDirection.Input),
                new OracleParameter(":MASV", OracleDbType.Varchar2,  user.MaSV, ParameterDirection.Input),
                new OracleParameter(":MAGV", OracleDbType.Varchar2,  user.MaGV, ParameterDirection.Input),
                new OracleParameter(":MAHP", OracleDbType.Varchar2,  user.MaHP, ParameterDirection.Input),
                new OracleParameter(":HK", OracleDbType.Decimal,  user.HK, ParameterDirection.Input),
                new OracleParameter(":NAM", OracleDbType.Decimal,  user.NAM, ParameterDirection.Input)
            };

            if (DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0)
            {
                kt = true;
            }
            return kt;
        }

        public bool Fix_SVien(SVienDTO user)
        {

            bool kt = false;
            string query = "UPDATE SEC_ADM.SINHVIEN SET HOTEN = :HOTEN , PHAI = :PHAI , NGSINH = :NGSINH , DCHI = :DCHI ," +
                " DT = :DT , MACT = :MACT , MANGANH = :MANGANH , SOTCTL = :SOTCTL , DTBTL = :DTBTL WHERE MASV = :MASV  ";
            
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter(":HOTEN", OracleDbType.Varchar2, user.HOTEN, ParameterDirection.Input),
                new OracleParameter(":PHAI", OracleDbType.Varchar2, user.PHAI, ParameterDirection.Input),
                new OracleParameter(":NGSINH", OracleDbType.Date, user.NGAYSINH, ParameterDirection.Input),
                new OracleParameter(":DCHI", OracleDbType.Varchar2, user.DCHI, ParameterDirection.Input),
                new OracleParameter(":DT", OracleDbType.Varchar2,  user.DT, ParameterDirection.Input),
                new OracleParameter(":MACT", OracleDbType.Varchar2,  user.MACT, ParameterDirection.Input),
                new OracleParameter(":MANGANH", OracleDbType.Varchar2,  user.MANGANH, ParameterDirection.Input),
                new OracleParameter(":SOTCTL", OracleDbType.Int32,  user.SOTCTL, ParameterDirection.Input),
                new OracleParameter(":DTBTL", OracleDbType.Decimal,  user.DTBTL, ParameterDirection.Input),
                new OracleParameter(":MASV", OracleDbType.Varchar2, user.MASV, ParameterDirection.Input)
            };
            if (DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0)
            {
                kt = true;
            }
            return kt;
            
            /*
            StaffConn staffConn = new StaffConn();

            using (OracleConnection connection = new OracleConnection(StaffConn._connStr))
            {
                connection.Open();
                using (OracleCommand command = connection.CreateCommand())
                {

                    command.CommandText = query;
                    command.Parameters.Add(":HOTEN", OracleDbType.Varchar2).Value = user.HOTEN;
                    command.Parameters.Add(":PHAI", OracleDbType.Varchar2).Value = user.PHAI;
                    command.Parameters.Add(":NGSINH", OracleDbType.Date).Value = user.NGAYSINH;
                    command.Parameters.Add(":DCHI", OracleDbType.Varchar2).Value = user.DCHI;
                    command.Parameters.Add(":DT", OracleDbType.Varchar2).Value = user.DT;
                    command.Parameters.Add(":MACT", OracleDbType.Varchar2).Value = user.MACT;
                    command.Parameters.Add(":MANGANH", OracleDbType.Varchar2).Value = user.MANGANH;
                    command.Parameters.Add(":SOTCTL", OracleDbType.Decimal).Value = user.SOTCTL;
                    command.Parameters.Add(":DTBTL", OracleDbType.Decimal).Value = user.DTBTL;
                    command.Parameters.Add(":MASV", OracleDbType.Varchar2).Value = user.MASV;
                    if (command.ExecuteNonQuery() > 0)
                    {
                        kt = true;
                    }
                }

                connection.Close();
            }
            return kt;
            */

        }
        public bool Add_SVien(SVienDTO user)
        {

            bool kt = false;
            string query = "INSERT INTO SEC_ADM.SINHVIEN ( MASV , HOTEN  , PHAI , NGSINH  , DCHI ,DT  , MACT , MANGANH  , SOTCTL  , DTBTL  ) VALUES ( :MASV , :HOTEN , :PHAI , :NGSINH , :DCHI , :DT , :MACT , :MANGANH , :SOTCTL , :DTBTL )  ";

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter(":MASV", OracleDbType.Varchar2, user.MASV, ParameterDirection.Input),
                new OracleParameter(":HOTEN", OracleDbType.Varchar2, user.HOTEN, ParameterDirection.Input),
                new OracleParameter(":PHAI", OracleDbType.Varchar2, user.PHAI, ParameterDirection.Input),
                new OracleParameter(":NGSINH", OracleDbType.Date, user.NGAYSINH, ParameterDirection.Input),
                new OracleParameter(":DCHI", OracleDbType.Varchar2, user.DCHI, ParameterDirection.Input),
                new OracleParameter(":DT", OracleDbType.Varchar2,  user.DT, ParameterDirection.Input),
                new OracleParameter(":MACT", OracleDbType.Varchar2,  user.MACT, ParameterDirection.Input),
                new OracleParameter(":MANGANH", OracleDbType.Varchar2,  user.MANGANH, ParameterDirection.Input),
                new OracleParameter(":SOTCTL", OracleDbType.Int32,  user.SOTCTL, ParameterDirection.Input),
                new OracleParameter(":DTBTL", OracleDbType.Decimal,  user.DTBTL, ParameterDirection.Input)
                
            };
            if (DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0)
            {
                kt = true;
            }
            return kt;

            /*
            StaffConn staffConn = new StaffConn();

            using (OracleConnection connection = new OracleConnection(StaffConn._connStr))
            {
                connection.Open();
                using (OracleCommand command = connection.CreateCommand())
                {

                    command.CommandText = query;
                    command.Parameters.Add(":HOTEN", OracleDbType.Varchar2).Value = user.HOTEN;
                    command.Parameters.Add(":PHAI", OracleDbType.Varchar2).Value = user.PHAI;
                    command.Parameters.Add(":NGSINH", OracleDbType.Date).Value = user.NGAYSINH;
                    command.Parameters.Add(":DCHI", OracleDbType.Varchar2).Value = user.DCHI;
                    command.Parameters.Add(":DT", OracleDbType.Varchar2).Value = user.DT;
                    command.Parameters.Add(":MACT", OracleDbType.Varchar2).Value = user.MACT;
                    command.Parameters.Add(":MANGANH", OracleDbType.Varchar2).Value = user.MANGANH;
                    command.Parameters.Add(":SOTCTL", OracleDbType.Decimal).Value = user.SOTCTL;
                    command.Parameters.Add(":DTBTL", OracleDbType.Decimal).Value = user.DTBTL;
                    command.Parameters.Add(":MASV", OracleDbType.Varchar2).Value = user.MASV;
                    if (command.ExecuteNonQuery() > 0)
                    {
                        kt = true;
                    }
                }

                connection.Close();
            }
            return kt;
            */

        }

        public bool Fix_DVi(DViDTO user)
        {

            bool kt = false;
            string query = "UPDATE SEC_ADM.DONVI SET  TENDV = :TENDV , TRGDV = :TRGDV " +
                " WHERE MADV = :MADV  ";

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter(":TENDV", OracleDbType.Varchar2, user.TENDV, ParameterDirection.Input),
                new OracleParameter(":TRGDV", OracleDbType.Varchar2, user.TRGDV, ParameterDirection.Input),
                new OracleParameter(":MADV", OracleDbType.Varchar2, user.MADV, ParameterDirection.Input),
            };
            if (DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0)
            {
                kt = true;
            }
            return kt;


        }
        public bool Add_DVi(DViDTO user)
        {

            bool kt = false;
            string query = "INSERT INTO SEC_ADM.DONVI(MADV, TENDV, TRGDV) " +
                " VALUES (:MADV, :TENDV,  :TRGDV)  ";

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter(":MADV", OracleDbType.Varchar2, user.MADV, ParameterDirection.Input),
                new OracleParameter(":TENDV", OracleDbType.Varchar2, user.TENDV, ParameterDirection.Input),
                new OracleParameter(":TRGDV", OracleDbType.Varchar2, user.TRGDV, ParameterDirection.Input)
                
            };
            if (DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0)
            {
                kt = true;
            }
            return kt;


        }
        public bool Fix_HPhan(HPhanDTO user)
        {
            bool kt = false;
            string query = "UPDATE SEC_ADM.HOCPHAN SET  TENHP = :TENHP , SOTC = :SOTC , STLT = :STLT , STTH = :STTH , SOSVTD = :SOSVTD , MADV = :MADV " +
                " WHERE MAHP = :MAHP  ";

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter(":TENHP", OracleDbType.Varchar2, user.TENHP, ParameterDirection.Input),
                new OracleParameter(":SOTC", OracleDbType.Int32,  user.SOTC, ParameterDirection.Input),
                new OracleParameter(":STLT", OracleDbType.Int32,  user.STLT, ParameterDirection.Input),
                new OracleParameter(":STTH", OracleDbType.Int32,  user.STTH, ParameterDirection.Input),
                new OracleParameter(":SOSVTD", OracleDbType.Int32,  user.SOSVTD, ParameterDirection.Input),
                new OracleParameter(":MADV", OracleDbType.Varchar2,  user.MADV, ParameterDirection.Input),
                new OracleParameter(":MAHP", OracleDbType.Varchar2,  user.MAHP, ParameterDirection.Input)

            };
            if (DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool Add_HPhan(HPhanDTO user)
        {
            bool kt = false;
            string query = "INSERT INTO SEC_ADM.HOCPHAN(MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES (:MAHP,:TENHP,:SOTC,:STLT,:STTH,:SOSVTD,:MADV) " ;

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter(":MAHP", OracleDbType.Varchar2,  user.MAHP, ParameterDirection.Input),
                new OracleParameter(":TENHP", OracleDbType.Varchar2, user.TENHP, ParameterDirection.Input),
                new OracleParameter(":SOTC", OracleDbType.Int32,  user.SOTC, ParameterDirection.Input),
                new OracleParameter(":STLT", OracleDbType.Int32,  user.STLT, ParameterDirection.Input),
                new OracleParameter(":STTH", OracleDbType.Int32,  user.STTH, ParameterDirection.Input),
                new OracleParameter(":SOSVTD", OracleDbType.Int32,  user.SOSVTD, ParameterDirection.Input),
                new OracleParameter(":MADV", OracleDbType.Varchar2,  user.MADV, ParameterDirection.Input),
                

            };
            if (DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0)
            {
                kt = true;
            }
            return kt;
        }
        public bool Add_KHoc(KhoaHocDTO user)
        {
            MessageBox.Show(user.MAHP + " " + user.MACT + " " + user.HK);
            bool kt = false;
            string query = "INSERT INTO SEC_ADM.KHMO (MAHP, MACT, HK, NAM) VALUES (:MAHP, :MACT, :HK, :NAM); ";

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter(":MAHP", OracleDbType.Varchar2,  user.MAHP, ParameterDirection.Input),
                new OracleParameter(":MACT", OracleDbType.Varchar2, user.MACT, ParameterDirection.Input),
                new OracleParameter(":HK", OracleDbType.Int32,  user.HK, ParameterDirection.Input),
                new OracleParameter(":NAM", OracleDbType.Int32,  user.NAM, ParameterDirection.Input)

            };
            if (DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0)
            {
                kt = true;
            }
            return kt;
        }

        public bool Fix_PhanCong(PhanCongDTO OldUser, PhanCongDTO User)
        {
            /*
            bool kt = false;
            MessageBox.Show(" "+OldUser.MAHP+" | "+OldUser.HK+" | "+User.MAHP+" | "+User.HK );
            string query = "UPDATE SEC_ADM.PHANCONG SET  MAHP = :NEWMAHP , MAGV = :NEWMAGV , HK = :NEWHK , NAM = :NEWNAM, MACT = :NEWMACT" +
                " WHERE MAHP = :OLDMAHP ,  MAGV = :OLDMAGV , HK = :OLDHK , NAM = :OLDNAM , MACT = :OLDMACT "; 

            OracleParameter[] parameters = new OracleParameter[]
            {
                
                new OracleParameter(":NEWMAHP", OracleDbType.Varchar2, User.MAHP,  ParameterDirection.Input),
                
                new OracleParameter(":NEWMAGV", OracleDbType.Varchar2, User.MAGV,  ParameterDirection.Input),
                
                new OracleParameter(":NEWHK", OracleDbType.Int32, User.HK,  ParameterDirection.Input),
                
                new OracleParameter(":NEWNAM", OracleDbType.Int32, User.NAM,  ParameterDirection.Input),
                
                new OracleParameter(":NEWMACT", OracleDbType.Varchar2, User.MACT,  ParameterDirection.Input),

                new OracleParameter(":OLDMAHP", OracleDbType.Varchar2,  OldUser.MAHP, ParameterDirection.Input),
                new OracleParameter(":OLDMAGV", OracleDbType.Varchar2,  OldUser.MAGV, ParameterDirection.Input),
                new OracleParameter(":OLDHK", OracleDbType.Int32,  OldUser.HK, ParameterDirection.Input),
                new OracleParameter(":OLDNAM", OracleDbType.Int32,  OldUser.NAM, ParameterDirection.Input),
                new OracleParameter(":OLDMACT", OracleDbType.Varchar2,  OldUser.MACT, ParameterDirection.Input)

            };
            if (DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0)
            {
                kt = true;
            }
            return kt;
            */
            try
            {
                bool kt = false;
                StaffConn staffConn = new StaffConn();
                //string query = "UPDATE SEC_ADM.PHANCONG SET MAGV = 'NS030' WHERE MAHP = 'HP003' AND HK = 3 AND NAM = 2023 AND MACT = 'CTTT';";
                string query = "UPDATE SEC_ADM.PHANCONG SET MAHP = :NEWMAHP , MAGV = :NEWMAGV , HK = :NEWHK , NAM = :NEWNAM , MACT = :NEWMACT WHERE MAHP = :OLDMAHP AND MAGV = :OLDMAGV AND HK = :OLDHK AND NAM = :OLDNAM AND MACT = :OLDMACT ";
                using (OracleConnection connection = new OracleConnection(StaffConn._connStr))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {

                        //command.CommandText = query;
                        
                        command.Parameters.Add(":NEWMAHP", OracleDbType.Varchar2).Value = User.MAHP;
                        command.Parameters.Add(":NEWMAGV", OracleDbType.Varchar2).Value = User.MAGV;
                        command.Parameters.Add(":NEWHK", OracleDbType.Int32).Value = User.HK;
                        command.Parameters.Add(":NEWNAM", OracleDbType.Int32).Value = User.NAM;
                        command.Parameters.Add(":NEWMACT", OracleDbType.Varchar2).Value = User.MACT;
                        command.Parameters.Add(":OLDMAHP", OracleDbType.Varchar2).Value = OldUser.MAHP;
                        command.Parameters.Add(":OLDMAGV", OracleDbType.Varchar2).Value = OldUser.MAGV;
                        command.Parameters.Add(":OLDHK", OracleDbType.Int32).Value = OldUser.HK;
                        command.Parameters.Add(":OLDNAM", OracleDbType.Int32).Value = OldUser.NAM;
                        command.Parameters.Add(":OLDMACT", OracleDbType.Varchar2).Value = OldUser.MACT;
                        
                        if (command.ExecuteNonQuery() > 0)
                        {
                            kt = true;
                        }
                    }

                    connection.Close();
                }
                return kt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
                // You can handle or log the exception as per your requirement
                return false;
            }
            
        }
        public bool Add_DKi(DKiDTO User)
        {
            
            try
            {
                bool kt = false;
                StaffConn staffConn = new StaffConn();
                //MessageBox.Show(User.MaSV + "|" + User.MaGV + "|" + User.MaHP + "|" + User.HK + "|" + User.NAM + "|" + User.MaCT);
                string query = "INSERT INTO SEC_ADM.UV_GIAOVU_DANGKY( MASV , MAGV , MAHP, NAM , HK , MACT ) VALUES ( :MASV , :MAGV , :MAHP , :NAM , :HK , :MACT)";
                using (OracleConnection connection = new OracleConnection(StaffConn._connStr))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":MASV", OracleDbType.Varchar2).Value = User.MaSV;
                        command.Parameters.Add(":MAGV", OracleDbType.Varchar2).Value = User.MaGV;
                        command.Parameters.Add(":MAHP", OracleDbType.Varchar2).Value = User.MaHP;
                        
                        command.Parameters.Add(":NAM", OracleDbType.Int32).Value = User.NAM;
                        command.Parameters.Add(":HK", OracleDbType.Int32).Value = User.HK;
                        command.Parameters.Add(":MACT", OracleDbType.Varchar2).Value = User.MaCT;


                        if (command.ExecuteNonQuery() > 0)
                        {
                            kt = true;
                        }
                    }

                    connection.Close();
                }
                return kt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
                // You can handle or log the exception as per your requirement
                return false;
            }

        }
        public bool DeleteDKy(DKiDTO User)
        {

            try
            {
                bool kt = false;
                StaffConn staffConn = new StaffConn();
                //MessageBox.Show(User.MaSV+"|"+ User.MaGV+"|"+ User.MaHP +"|"+ User.MaCT+"|"+ User.NAM+"|"+ User.HK);
                string query = "DELETE FROM SEC_ADM.UV_GIAOVU_DANGKY WHERE MASV = :MASV AND MAGV = :MAGV AND MAHP = :MAHP AND NAM = :NAM AND HK = :HK AND MACT = :MACT ";
                using (OracleConnection connection = new OracleConnection(StaffConn._connStr))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":MASV", OracleDbType.Varchar2).Value = User.MaSV;
                        command.Parameters.Add(":MAGV", OracleDbType.Varchar2).Value = User.MaGV;
                        command.Parameters.Add(":MAHP", OracleDbType.Varchar2).Value = User.MaHP;
                        command.Parameters.Add(":NAM", OracleDbType.Int32).Value = User.NAM;
                        command.Parameters.Add(":HK", OracleDbType.Int32).Value = User.HK;
                        command.Parameters.Add(":MACT", OracleDbType.Varchar2).Value = User.MaCT;
                        //MessageBox.Show(command.CommandText);
                        if (command.ExecuteNonQuery() > 0)
                        {
                            kt = true;
                        }
                    }

                    connection.Close();
                }
                return kt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
                // You can handle or log the exception as per your requirement
                return false;
            }

        }




    }
}


