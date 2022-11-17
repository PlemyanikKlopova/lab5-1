using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИС_Музыкальная_школа_3
{
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Обучение af = new Обучение();
            af.Owner = this;
            af.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Итоговый_экзамен af = new Итоговый_экзамен();
            af.Owner = this;
            af.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Закуп af = new Закуп();
            af.Owner = this;
            af.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Сотрудники af = new Сотрудники();
            af.Owner = this;
            af.Show();
        }

        private void Главная_Load(object sender, EventArgs e)
        {

        }
    }
}
