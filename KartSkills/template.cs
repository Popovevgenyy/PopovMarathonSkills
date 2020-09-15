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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer_event_Tick(object sender, EventArgs e)
        {
            //Создаем новый экземпляр типа DateTime для хранения время начала события
            DateTime finishdate = new DateTime(2020, 10, 1, 9, 0, 0);
            //Вычисляем текущее время и время начала события
            TimeSpan result = finishdate - DateTime.Now;
            /*
            //Проверяем условие если finishdate (время начало события) меньше или равно текущей дате и времени (берется с компьютера),
            то выводится сообщение что "Событие уже началось", если нет то отображается счетчик
                */
            if (finishdate <= System.DateTime.Now)
            {
                // В элемент Label (с идентификатором l_timer) в свойство Text добавляем сообщение Событие уже началось
                l_timer.Text = "Событие уже началось";
            }
            else
            {
                // В элемент label (с идентификатором l_timer) в свойство Text добавляем сообщение которое так же принимается переменную Resuklt для отображения даты и времени
                l_timer.Text = "До события осталось: " + result.Days + " дней " + result.Hours + " часов " + result.Minutes + " минут " + result.Seconds + " секунд";
            }
        }
                   
    }
}
