using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }
            
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nobody\Documents\Siłownia.mdf;Integrated Security=True;Connect Timeout=30");


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(imie.Text == "" || telefon.Text == "" || wiek.Text == "" || oplata.Text =="")
            {
                MessageBox.Show("Brakuje infromacji");
            }
            else
            {
                try
                {
                    //z checkboxami danie nie zapisuja sie do tabelki
                    Con.Open();
                    string query = "insert into TabelaCzlonkow1 (imie,nazwisko,telefon,plec,wiek,oplata,czas) values('" + imie.Text + "','" + nazwisko.Text + "','" + telefon.Text + "','" + plec.Text + "'," + wiek.Text + "," + oplata.Text + ",'" + czas.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Członek został dodany do klubu");
                    Con.Close();
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show("XD");
                }
                    
     
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oplata.Clear();
            wiek.Clear();
            imie.Clear();
            czas.SelectedIndex = -1;
            plec.SelectedIndex = -1;    
            telefon.Clear();
            nazwisko.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void wiek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void oplata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
