using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UpdateDelete upd = new UpdateDelete();
            upd.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddMember memb = new AddMember();
            memb.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ViewMembers view = new ViewMembers();
            view.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
