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
    public partial class FormReplace : Form
    {
        FormFather formFather;
        bool isMatchCase = false;

        public FormReplace(FormFather formFather)
        {
            InitializeComponent();
            button_next.Enabled = false;
            button_replace.Enabled = false;
            button_replaceAll.Enabled = false;
            this.formFather = formFather;
        }

        //查找的一些事件
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                button_next.Enabled = true;
                button_replace.Enabled = true;
                button_replaceAll.Enabled = true;
            }
            else
            {
                button_next.Enabled = false;
                button_replace.Enabled = false;
                button_replaceAll.Enabled = false;
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

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_next.Focus();
                button_next_Click(sender, e);
            }
        }

        //替换的一些事件
        private void button_replace_Click(object sender, EventArgs e)
        {
            if (textBox_replace.Text.Length != 0)
            {
                formFather.ReplaceRichTextBoxString(textBox.Text,textBox_replace.Text,isMatchCase);
            }
            else
            {
                MessageBox.Show("替换字符串不能为空", "提示", MessageBoxButtons.OK);
            }
                
        }

        //全部替换
        private void button_replaceAll_Click(object sender, EventArgs e)
        {
            if (textBox_replace.Text.Length != 0)
            {
                formFather.ReplaceAllRichTextBoxString(textBox.Text,textBox_replace.Text,isMatchCase);
            }
            else
            {
                MessageBox.Show("替换字符串不能为空", "提示", MessageBoxButtons.OK);
            }
        }

        //判断是否需要匹配大小写
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            isMatchCase = !isMatchCase;
        }

        //取消按钮
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
