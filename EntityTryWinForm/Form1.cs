using System;
using System.Windows.Forms;
using EntityTry.Service;

namespace EntityTryWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductService service = new ProductService();
            dataGridView1.DataSource = service.ListMake();
        }
    }
}
