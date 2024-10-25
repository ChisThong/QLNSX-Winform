using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class CNhaSanXuat
    {
        private string m_MaNSX;
        private string m_TenNSX;
        private string m_SoDT;
        private string m_DiaChi;

        public string MaNSX { get => m_MaNSX; set => m_MaNSX = value; }
        public string TenNSX { get => m_TenNSX; set => m_TenNSX = value; }
        public string SoDT { get => m_SoDT; set => m_SoDT = value; }
        public string DiaChi { get => m_DiaChi; set => m_DiaChi = value; }
        public CNhaSanXuat()
        {
            m_MaNSX = "";
            m_TenNSX = "";
            m_SoDT = "";
            m_DiaChi = "";
        }
        public CNhaSanXuat(string ma,string ten,string sodt,string dc)
        {
            m_MaNSX = ma;
            m_TenNSX = ten;
            m_SoDT = sodt;
            m_DiaChi = dc;
        }
        public CNhaSanXuat(CNhaSanXuat n)
        {
            m_MaNSX = n.MaNSX;
            m_TenNSX = n.TenNSX;
            m_SoDT = n.SoDT;
            m_DiaChi = n.DiaChi;
        }
    }
}
