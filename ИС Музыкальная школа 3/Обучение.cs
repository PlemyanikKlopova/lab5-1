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
    public partial class Обучение : Form
    {
        public Обучение()
        {
            InitializeComponent();
        }

        private void Обучение_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database_lastDataSet.Оборудование". При необходимости она может быть перемещена или удалена.
            this.оборудованиеTableAdapter1.Fill(this.database_lastDataSet.Оборудование);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database_lastDataSet.Время_урока". При необходимости она может быть перемещена или удалена.
            this.время_урокаTableAdapter1.Fill(this.database_lastDataSet.Время_урока);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database_lastDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter1.Fill(this.database_lastDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database_lastDataSet.Музыкальные_инструменты". При необходимости она может быть перемещена или удалена.
            this.музыкальные_инструментыTableAdapter1.Fill(this.database_lastDataSet.Музыкальные_инструменты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database_lastDataSet.Обучение". При необходимости она может быть перемещена или удалена.
            this.обучениеTableAdapter2.Fill(this.database_lastDataSet.Обучение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database5DataSet.Музыкальные_инструменты". При необходимости она может быть перемещена или удалена.
            this.музыкальные_инструментыTableAdapter.Fill(this.database5DataSet.Музыкальные_инструменты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database5DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.database5DataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database5DataSet.Оборудование". При необходимости она может быть перемещена или удалена.
            this.оборудованиеTableAdapter.Fill(this.database5DataSet.Оборудование);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database5DataSet.Время_урока". При необходимости она может быть перемещена или удалена.
            this.время_урокаTableAdapter.Fill(this.database5DataSet.Время_урока);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database5DataSet.Обучение". При необходимости она может быть перемещена или удалена.
            this.обучениеTableAdapter1.Fill(this.database5DataSet.Обучение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database4rDataSet.Обучение". При необходимости она может быть перемещена или удалена.
            this.обучениеTableAdapter.Fill(this.database4rDataSet.Обучение);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Главная af = new Главная();
            af.Owner = this;
            af.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            поиск_обучения af = new поиск_обучения();

            af.Owner = this;
            af.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            обучениеTableAdapter2.Update(database_lastDataSet);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            дополнение_на_обучение af = new дополнение_на_обучение();

            af.Owner = this;
            af.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
