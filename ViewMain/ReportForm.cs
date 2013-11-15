using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ViewMain
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            
            // TODO: 这行代码将数据加载到表“BookMSDataSet.BMS_Book”中。您可以根据需要移动或移除它。
            this.BMS_BookTableAdapter.Fill(this.BookMSDataSet.BMS_Book);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
