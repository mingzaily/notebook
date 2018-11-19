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
    public partial class FormFather : Form
    {

        string s_file_name = "";
        bool isSave = true;
        int FindPostion = 0;//记录下一次查找的开始位置

        public FormFather()
        {
            InitializeComponent();
            foreach (FontFamily name in FontFamily.Families)
            {
                toolStripComboBox.Items.Add(name.Name);
            }
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = richTextBox.GetFirstCharIndexOfCurrentLine();
            int row = richTextBox.GetLineFromCharIndex(index) + 1;
            int column = richTextBox.SelectionStart - index + 1;
            toolStripStatusLabel.Text = row + "行" + column + "列";
            isSave = false;
        }

        //文件功能区
        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PromptSave(sender, e))
            {
                return;
            }
            richTextBox.Clear();
            isSave = true;
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PromptSave(sender, e))
            {
                return;
            }
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                richTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                s_file_name = openFileDialog.FileName;
                isSave = true;
            }
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                s_file_name = saveFileDialog.FileName;
                isSave = true;
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(s_file_name.Length!=0)
            {
                richTextBox.SaveFile(s_file_name, RichTextBoxStreamType.RichText);
                isSave = true;
            }
            else
            {
                另存为ToolStripMenuItem_Click(sender, e);
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFather_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!PromptSave(sender, e))
            {
                e.Cancel = true ;
            }
                
        }

        private bool PromptSave(object sender, EventArgs e)
        {
            bool ReturnValue = true;

            if (!isSave)
            {
                System.Windows.Forms.DialogResult dr = MessageBox.Show("文本尚未保存，是否保存更改？", "提示",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                switch(dr)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        保存ToolStripMenuItem_Click(sender, e);
                        ReturnValue = true;
                        break;
                    case System.Windows.Forms.DialogResult.No:
                        ReturnValue = true;
                        break;
                    case System.Windows.Forms.DialogResult.Cancel:
                        ReturnValue = false;
                        break;
                }
            }

            return ReturnValue;
        }

        //查看功能区
        private void 工具栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = !toolStrip.Visible;
            工具栏ToolStripMenuItem.Checked = !工具栏ToolStripMenuItem.Checked;
        }

        private void 状态栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = !statusStrip.Visible;
            状态栏ToolStripMenuItem.Checked = !状态栏ToolStripMenuItem.Checked;
        }

        //编辑功能区
        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }


        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectedText = "";
        }

        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindPostion = 0;
            FormFind formFind = new FormFind(this);
            formFind.Show();
        }

        private void 替换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindPostion = 0;
            FormReplace formReplace = new FormReplace(this);
            formReplace.Show();
        }

        //查找方法
        public void FindRichTextBoxString(string FindString,bool isMatchCase)
        {
            if (FindPostion >= richTextBox.Text.Length)
            {
                MessageBox.Show("已到文本底部", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                FindPostion = 0;    //下次查找的开始位置
                return;
            }

            if(isMatchCase)
            {
                FindPostion = richTextBox.Find(FindString, FindPostion, RichTextBoxFinds.MatchCase);
            }
            else
            {
                FindPostion = richTextBox.Find(FindString, FindPostion, RichTextBoxFinds.None);
            }

            if (FindPostion == -1)//-1表示未找到匹配字符串，提示用户
            {
                MessageBox.Show("找不到"+FindString, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); 
                FindPostion = 0;       //下次查找的开始位置
            }
            else                //找到匹配字符串
            {
                richTextBox.Focus();  //主窗体成为注视窗口
                FindPostion += FindString.Length;
            }
        }

        //部分替换函数
        public void ReplaceRichTextBoxString(string FindString, string ReplaceString,bool isMatchCase)
        {
            FindRichTextBoxString(FindString, isMatchCase);
            if (richTextBox.SelectedText.Length != 0)
            {
                richTextBox.SelectedText = ReplaceString;
            }
        }

        //全部替换
        public void ReplaceAllRichTextBoxString(string FindString,string ReplaceString,bool isMatchCase)
        {
            FindPostion = 0;//全部替换从头开始

            while (FindPostion <= richTextBox.Text.Length)
            {

                if (isMatchCase)
                {
                    FindPostion = richTextBox.Find(FindString, FindPostion, RichTextBoxFinds.MatchCase);
                }
                else
                {
                    FindPostion = richTextBox.Find(FindString, FindPostion, RichTextBoxFinds.None);
                }

                if (FindPostion == -1)//-1表示未找到匹配字符串，提示用户
                {
                    FindPostion = 0;
                    break;  //推出循环
                }
                else                //找到匹配字符串
                {
                    if (richTextBox.SelectedText.Length != 0)
                    {
                        richTextBox.SelectedText = ReplaceString;
                    }
                    FindPostion += FindString.Length;
                }
            }

            MessageBox.Show("替换完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }

        private void 时间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Text = richTextBox.Text + DateTime.Now.ToString();
        }

        //帮助功能区
        private void 查看帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://jingyan.baidu.com/article/77b8dc7fb27c366174eab626.html");
        }

        private void 关于记事本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        //格式功能区
        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.WordWrap = !richTextBox.WordWrap;
            自动换行ToolStripMenuItem.Checked = !自动换行ToolStripMenuItem.Checked;
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog.ShowDialog()==DialogResult.OK)
            {
                richTextBox.SelectionFont = fontDialog.Font;
            }
            
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionColor = colorDialog.Color;
            }
        }

        //工具栏功能区
        private void toolStripComboBox_TextChanged(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(toolStripComboBox.Text, richTextBox.Font.Size);
            richTextBox.Focus();
        }

        //右键功能区
        private void 左对齐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment= HorizontalAlignment.Left;
        }

        private void 居中对齐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void 右对齐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }


    }
}
