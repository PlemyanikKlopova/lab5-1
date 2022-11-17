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
    public partial class Итоговый_экзамен : Form
    {
        public Итоговый_экзамен()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database_lastDataSet.Материалы_для_подготовки". При необходимости она может быть перемещена или удалена.
            this.материалы_для_подготовкиTableAdapter1.Fill(this.database_lastDataSet.Материалы_для_подготовки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database_lastDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter1.Fill(this.database_lastDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database_lastDataSet.Оборудование". При необходимости она может быть перемещена или удалена.
            this.оборудованиеTableAdapter1.Fill(this.database_lastDataSet.Оборудование);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database_lastDataSet.Музыкальные_инструменты". При необходимости она может быть перемещена или удалена.
            this.музыкальные_инструментыTableAdapter1.Fill(this.database_lastDataSet.Музыкальные_инструменты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database_lastDataSet.Итоговый_экзамен". При необходимости она может быть перемещена или удалена.
            this.итоговый_экзаменTableAdapter2.Fill(this.database_lastDataSet.Итоговый_экзамен);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database_lastDataSet.Материалы_для_подготовки". При необходимости она может быть перемещена или удалена.
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Дополнение_на_итог af = new Дополнение_на_итог();

            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            итоговыйЭкзаменBindingSource5.EndEdit();
            итоговый_экзаменTableAdapter2.Update(database_lastDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            поиск_итога af = new поиск_итога();

            af.Owner = this;
            af.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
