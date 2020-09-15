using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartSkills
{
    public partial class main : Form1
    {
        public main()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Создаем новый экземпляр для окна main и отображаем его
            new signin().Show();
            //Скрываем текущее окно (форму)
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
    }
    }
    }

