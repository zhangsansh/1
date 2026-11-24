using _1.Pages;
using _1.SqlHepler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        private UserControl _currentPage;
        public Form1()
        {
            InitializeComponent();
            // 默认打开员工页面
            SwitchPage(new PageEmp());
        }

        /// <summary>
        /// 加载、切换页面
        /// </summary>
        private void SwitchPage(UserControl page)
        {
            if (_currentPage != null)
            {
                panel1.Controls.Remove(_currentPage);
                _currentPage.Dispose();
            }

            _currentPage = page;
            _currentPage.Dock = DockStyle.Fill;
            panel1.Controls.Add(_currentPage);
        }

        //private void SwitchPageCached(UserControl page)
        //{
        //    if (_currentPage != null)
        //        _currentPage.Visible = false;

        //    _currentPage = page;
        //    if (!panel1.Controls.Contains(page))
        //    {
        //        page.Dock = DockStyle.Fill;
        //        panel1.Controls.Add(page);
        //    }
        //    _currentPage.Visible = true;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            SwitchPage(new PageEmp());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SwitchPage(new Page2());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SwitchPage(new Page3());
        }
    }
}
