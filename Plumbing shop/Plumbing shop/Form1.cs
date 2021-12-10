using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plumbing_shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void manufacturer_Plumbing_productssBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.manufacturer_Plumbing_productssBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Manufacturer_Plumbing_productss". При необходимости она может быть перемещена или удалена.
            this.manufacturer_Plumbing_productssTableAdapter.Fill(this.dataSet1.Manufacturer_Plumbing_productss);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            manufacturer_Plumbing_productssBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manufacturer_Plumbing_productssBindingSource.EndEdit();
            manufacturer_Plumbing_productssTableAdapter.Update(dataSet1);
        }
    }
}
