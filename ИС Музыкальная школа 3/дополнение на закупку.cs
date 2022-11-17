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
    public partial class дополнение_на_закупку : Form
    {
        public дополнение_на_закупку()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Закуп main = this.Owner as Закуп;
            if (main != null)
            {
                DataRow nRow = main.database5DataSet.Tables[4].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = textBox3.Text;
                
                main.database5DataSet.Tables[4].Rows.Add(nRow);
                main.закупTableAdapter1.Update(main.database5DataSet.Закуп);
                main.database5DataSet.Tables[4].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
