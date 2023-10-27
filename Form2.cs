using coding.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using coding.data;

namespace coding
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
            textBox3.AutoSize = false;
            textBox3.Size = new System.Drawing.Size(200, 35);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User u = new User();

            if (textBox1.Text.Length > 3 && textBox1.Text.Length < 12)
            {
                if (textBox2.Text.Length > 6 && textBox2.Text.Length < 18)
                {
                    if (textBox3.Text.Contains('@') && textBox3.Text.Contains('.'))
                    {
                        u.Login = textBox1.Text;
                        u.Password = textBox2.Text;
                        u.Email = textBox3.Text;
                        u.Admin = 0;

                        using (DataContext db = new DataContext())
                        {
                            db.Users.Add(u);
                            db.SaveChanges();
                            MessageBox.Show("Вы успешно зарегистрировались!");
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Некорректная почта!");
                    }
                }
                else
                {
                    MessageBox.Show("Пароль должен быть более 6 или менее 18 символов!");
                }
            }
            else
            {
                MessageBox.Show("Логин должен быть более 3 или менее 12 символов!");
            }
        }
    }
}
