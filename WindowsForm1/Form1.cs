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
    public partial class d : Form
    {
        public d()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Form2 successForm = new Form2();
            successForm.Show();

            // Ẩn form hiện tại (nếu muốn)
            this.Hide();
        }
    }
}
