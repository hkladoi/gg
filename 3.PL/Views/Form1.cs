using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class Form1 : Form
    {
        private IQLChiTietSP _ichi;
        private IQLSanPhamServices _isp;
        private ViewChiTietSP _ct;
        public Form1()
        {
            _ichi = new QLChiTietSP();
            _isp = new QLSanPhamServices();
            InitializeComponent();
        }

        public ViewChiTietSP GetData()
        {
            ViewChiTietSP vct = new ViewChiTietSP()
            {
                IdSP = _isp.GetAll()
            };
        }
    }
}
