using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace uretim_ve_imalat
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Width = 850;
            this.Height = 600;
            this.CenterToScreen();

            // TODO: This line of code loads data into the 'vtDataSet.urunstok' table. You can move, or remove it, as needed.
            this.urunstokTableAdapter.Fill(this.vtDataSet.urunstok);
            // TODO: This line of code loads data into the 'vtDataSet.hammadde' table. You can move, or remove it, as needed.
            this.hammaddeTableAdapter.Fill(this.vtDataSet.hammadde);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
