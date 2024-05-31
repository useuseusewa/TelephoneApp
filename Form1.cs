using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{Application.StartupPath}/data.dat"))
                database.ReadXml($"{Application.StartupPath}/data.dat");
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                phoneBooksBindingSource.Filter = $"FullName like '*{txtSearch.Text}*' or Mobile* '{txtSearch.Text}'";
        }

        private void phoneBooksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            phoneBooksBindingSource.EndEdit();
            database.WriteXml($"{Application.StartupPath}/data.dat");
            MessageBox.Show("Ваши данные были успешно сохранены", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void postalCodeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
