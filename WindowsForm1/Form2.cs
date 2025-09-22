using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Ví dụ hiện 1 label "Đăng nhập thành công"
            this.Text = "Thông báo";
            Label lbl = new Label();
            lbl.Text = "Đăng nhập thành công!";
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            lbl.Location = new System.Drawing.Point(50, 50);
            this.Controls.Add(lbl);
        }
    }
}
