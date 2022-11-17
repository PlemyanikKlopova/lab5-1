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
    public partial class Сотрудники : Form
    {
        public Сотрудники()
        {
            InitializeComponent();
        }

        private void Сотрудники_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database_lastDataSet.Пол". При необходимости она может быть перемещена или удалена.
            this.полTableAdapter.Fill(this.database_lastDataSet.Пол);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database_lastDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.database_lastDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database_lastDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter1.Fill(this.database_lastDataSet.Сотрудники);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            сотрудникиTableAdapter1.Update(database_lastDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            поиск_сотрудника af = new поиск_сотрудника();

            af.Owner = this;
            af.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            дополнение_сотрудника af = new дополнение_сотрудника();

            af.Owner = this;
            af.Show();
        }
    }
}
