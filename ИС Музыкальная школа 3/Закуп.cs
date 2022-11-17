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
    public partial class Закуп : Form
    {
        public Закуп()
        {
            InitializeComponent();
        }

        private void Закуп_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database5DataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter1.Fill(this.database5DataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database5DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter1.Fill(this.database5DataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database5DataSet.Музыкальные_инструменты". При необходимости она может быть перемещена или удалена.
            this.музыкальные_инструментыTableAdapter1.Fill(this.database5DataSet.Музыкальные_инструменты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database5DataSet.Оборудование". При необходимости она может быть перемещена или удалена.
            this.оборудованиеTableAdapter1.Fill(this.database5DataSet.Оборудование);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database5DataSet.Закуп". При необходимости она может быть перемещена или удалена.
            this.закупTableAdapter1.Fill(this.database5DataSet.Закуп);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            закупTableAdapter1.Update(database5DataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            дополнение_на_закупку af = new дополнение_на_закупку();
         
                af.Owner = this;
                af.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            закупTableAdapter1.Update(database5DataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           поиск_закупа af = new поиск_закупа();

            af.Owner = this;
            af.Show();
        }
    }
}
