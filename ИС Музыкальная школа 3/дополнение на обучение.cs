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
    public partial class дополнение_на_обучение : Form
    {
        public дополнение_на_обучение()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Обучение main = this.Owner as Обучение;
            if (main != null)
            {
                DataRow nRow = main.database_lastDataSet.Tables[10].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;

                main.database_lastDataSet.Tables[10].Rows.Add(nRow);
                main.обучениеTableAdapter2.Update(main.database_lastDataSet.Обучение);
                main.database_lastDataSet.Tables[10].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";

            }
        }
    }
}
