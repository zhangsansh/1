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

namespace _1.Pages
{
    public partial class PageEmp : UserControl
    {
        public PageEmp()
        {
            InitializeComponent();
            dataGridView1.DataSource = SqlSugarHelper.Db.Queryable<VEmpFull>().ToList();
        }
    }
}
