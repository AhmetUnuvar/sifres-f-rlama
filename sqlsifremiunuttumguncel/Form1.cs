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
    public partial class Form1 : Form
    {
        WindowsFormOturumAcmaIslemleriSifreMailHatirlatmaEntitiesConnectionDB db = new WindowsFormOturumAcmaIslemleriSifreMailHatirlatmaEntitiesConnectionDB();
        public Form1()
        {
            InitializeComponent();
        }
        public static int Id;

        private void button1_Click(object sender, EventArgs e)
        {
         var Durum = db.PersonelGirisTablosu.FirstOrDefault(x => x.MailAdress == textBox1.Text && x.Password == textBox2.Text);
            if(Durum != null)
            {
                Id = Durum.Id;
                GirisBasarili gb = new GirisBasarili();
                gb.ShowDialog();
            }
            else
            {
                MessageBox.Show("Girilen Bilgi Yanlış", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SifreYenile st = new SifreYenile();
            st.ShowDialog();
        }
    }
}
