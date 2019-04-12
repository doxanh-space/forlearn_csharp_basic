﻿using System;
using System.Windows.Forms;

namespace baitap002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeYear();
            InitializeMonth();
            InitializeDay();
        }

        private void InitializeYear()
        {
            var yearStart = int.Parse(DateTime.Now.ToString("yyyy")) - 100;
            for (int y = yearStart; y <= yearStart + 200; y++)
            {
                cbbYear.Items.Add(y);
            }
        }

        private void InitializeMonth()
        {
            for (int m = 1; m <= 12; m++)
            {
                cbbMonth.Items.Add(m);
            }
        }

        private void InitializeDay()
        {
            for (int d = 1; d <= 31; d++)
            {
                cbboxDay.Items.Add(d);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát hay không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            var hoTen = textHoTen.Text;
            var soThich = textSoThich.Text;
            var day = cbboxDay.Text;
            var month = cbbMonth.Text;
            var year = cbbYear.Text;

            if (string.IsNullOrEmpty(hoTen)
                || string.IsNullOrEmpty(soThich)
                || string.IsNullOrEmpty(day)
                || string.IsNullOrEmpty(month)
                || string.IsNullOrEmpty(year))
            {
                MessageBox.Show("Bạn phải điền đủ thông tin");
            }
            else
            {
                var result = hoTen + "\n" + day + "/" + month + "/" + year + "\n" + soThich;
                textResult.Text = result;
            }
        }
    }
}
