using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniMate
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rTKDataSet.Tok". При необходимости она может быть перемещена или удалена.
            this.tokTableAdapter.Fill(this.rTKDataSet.Tok);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rTKDataSet.ProgRTK". При необходимости она может быть перемещена или удалена.
            this.progRTKTableAdapter.Fill(this.rTKDataSet.ProgRTK);

        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
