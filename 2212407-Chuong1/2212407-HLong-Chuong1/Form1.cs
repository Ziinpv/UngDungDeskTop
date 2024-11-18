using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212407_HLong_Chuong1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void frmTabControl_Load_TextChanged(object sender, EventArgs e)
        {
            this.tabControl1.TabPages.Clear();
            TabPage tabSV = new TabPage();
            TabPage tabGV = new TabPage(); 
            TabPage tabMH   = new TabPage();
            tabSV.Text = "Sinh Vien";
            tabGV.Text = "Giao Vien";
            tabMH.Text = "Mon Hoc";
            this.tabControl1.TabPages.Add(tabSV);
            this.tabControl1.TabPages.Add(tabGV);
            this.tabControl1.TabPages.Add(tabMH);
        }
    }
}
