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
    public partial class дополнение_сотрудника : Form
    {
        public дополнение_сотрудника()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Сотрудники main = this.Owner as Сотрудники;
            if (main != null)
            {
                DataRow nRow = main.database_lastDataSet.Tables[13].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox3.Text;
                nRow[4] = textBox4.Text;
                nRow[5] = textBox5.Text;

                main.database_lastDataSet.Tables[13].Rows.Add(nRow);
                main.сотрудникиTableAdapter1.Update(main.database_lastDataSet.Сотрудники);
                main.database_lastDataSet.Tables[13].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
