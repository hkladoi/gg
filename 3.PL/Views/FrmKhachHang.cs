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
    public partial class FrmKhachHang : Form
    {
        private IQLKhachHang _iQLKhachHang;
        private ViewKhachHang _kh;
        private List<ViewKhachHang> _khList;
        public FrmKhachHang()
        {
            InitializeComponent();
            _iQLKhachHang = new QLKhachHang();
            _khList = new List<ViewKhachHang>();
        }
        public void LoadData()
        {
            dtg_Show.Rows.Clear();
            dtg_Show.ColumnCount = 5;
            dtg_Show.Columns[0].Name = "ID";
            dtg_Show.Columns[0].Visible = false;
            dtg_Show.Columns[1].Name = "Mã khách hàng";
            dtg_Show.Columns[2].Name = "Họ tên";
            dtg_Show.Columns[3].Name = "Địa chỉ";
            dtg_Show.Columns[4].Name = "Ngày sinh";
            var lstkhachhang = _iQLKhachHang.GetAll();
            foreach (var item in lstkhachhang)
            {
                dtg_Show.Rows.Add(
                    item.Id,
                    item.Ma,
                    item.TenDayDu,
                    item.DiaChi,
                    item.NgaySinh
                    );
            }
            if (tb_timKiem != null)
            {
                //_khList.ToList() = _iQLKhachHang.GetAll().Where(c => c.DiaChi.Contains(tb_timKiem.Text)).ToString();
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        public ViewKhachHang GetData()
        {
            ViewKhachHang vkh = new ViewKhachHang()
            {
                Id = new Guid(),
                Ma = tb_ma.Text,
                Ten = tb_Ten.Text,
                TenDem = tb_TenDem.Text,
                Ho = tb_ho.Text,
                DiaChi = tb_diachi.Text,
                NgaySinh = dtg_ngaysinh.Value
            };
            return vkh;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("bạn có muốn thêm không!", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _iQLKhachHang.Add(GetData());
                MessageBox.Show("thêm thành công");
            }
            LoadData();
        }

        private void dtg_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            _kh = _iQLKhachHang.GetAll().FirstOrDefault(c => c.Id == Guid.Parse(dtg_Show.CurrentRow.Cells[0].Value.ToString()));
            tb_ma.Text = dtg_Show.CurrentRow.Cells[1].Value.ToString();
            tb_Ten.Text = _kh.Ten;
            tb_ho.Text = _kh.Ho;
            tb_TenDem.Text = _kh.TenDem;
            tb_diachi.Text = dtg_Show.CurrentRow.Cells[3].Value.ToString();
            dtg_ngaysinh.Value = _kh.NgaySinh.Value;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("bạn có muốn xóa không!", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_kh == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng");
                }
                _iQLKhachHang.Delete(_kh);
                MessageBox.Show("xóa thành công");
            }
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Id = Guid.Parse(dtg_Show.CurrentRow.Cells[0].Value.ToString());
            temp.Ma = tb_ma.Text;
            temp.Ten = tb_Ten.Text;
            temp.TenDem = tb_TenDem.Text;
            temp.Ho = tb_ho.Text;
            temp.DiaChi = tb_diachi.Text;
            temp.NgaySinh = dtg_ngaysinh.Value;
            _iQLKhachHang.Update(temp);
        }
    }
}
