using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 记事本
{
    public partial class FormFind : Form
    {
        FormFather formFather;
        bool isMatchCase = false;

        public FormFind(FormFather formFather)
        {
            InitializeComponent();
            button_next.Enabled = false;
            this.formFather = formFather;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if(textBox.Text!="")
            {
                button_next.Enabled = true;
            }
            else
            {
                button_next.Enabled = false;
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length != 0)
            {
                formFather.FindRichTextBoxString(textBox.Text, isMatchCase);
            }
            else
            {
                MessageBox.Show("查找字符串不能为空", "提示", MessageBoxButtons.OK);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            isMatchCase = !isMatchCase;
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button_next.Focus();
                button_next_Click(sender, e);
            }
        }
    }
}
