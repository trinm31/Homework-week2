using System;

namespace PhanSo
{
    public class PhanSo
    {
        public int Tu { get; set; }
        
        private int _mau;

        public int Mau
        {
            get => _mau;
            set => _mau = value != 0 ? value : 1;
        }
        // dieu kien ? true : false
        public PhanSo() { }

        public PhanSo(int tu, int mau)
        {
            Tu = tu;
            Mau = mau;
        }

        public PhanSo Cong(PhanSo phanSo)
        {
            PhanSo result = new PhanSo();

            result.Tu = Tu * phanSo.Mau + Mau * phanSo.Tu;
            result.Mau = Mau * phanSo.Mau;

            return result;
        }

        public string Display()
        {
            return string.Format("{0}/{1}", Tu, Mau);
        }
    }
}