using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sqlsifremiunuttumguncel.Models;

namespace sqlsifremiunuttumguncel
{
    public partial class SifreYenile : Form
    {
        public SifreYenile()
        {
            InitializeComponent();
        }
        MailGonderici mg = new MailGonderici();
        private void button1_Click(object sender, EventArgs e)
        {
            mg.Microsoft(textBox1.Text, textBox2.Text, textBox1.Text);
            MessageBox.Show("Doğrulama gerçekleşirse şifreniz yenilenecektir.", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
