using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using coding.data;

namespace coding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"C:\Users\sqwish\source\repos\coding\assets\font\Comfortaa-Regular.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
            }

            textBox1.AutoSize = false;
            textBox1.Size = new System.Drawing.Size(200, 35);
            textBox2.AutoSize = false;
            textBox2.Size = new System.Drawing.Size(200, 35);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            using (DataContext db = new DataContext())
            {
                var b = db.Users.Any(u => u.Login == login && u.Password == password);
                var c = b ? MessageBox.Show("Вы успешно вошли!") : MessageBox.Show("Некорректные данные!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
