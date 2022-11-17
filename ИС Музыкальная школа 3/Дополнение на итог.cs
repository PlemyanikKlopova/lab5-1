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
    public partial class Дополнение_на_итог : Form
    {
        public Дополнение_на_итог()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Итоговый_экзамен main = this.Owner as Итоговый_экзамен;
            if (main != null)
            {
                DataRow nRow = main.database_lastDataSet.Tables[5].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;

                main.database_lastDataSet.Tables[5].Rows.Add(nRow);
                main.итоговый_экзаменTableAdapter2.Update(main.database_lastDataSet.Итоговый_экзамен);
                main.database_lastDataSet.Tables[5].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
