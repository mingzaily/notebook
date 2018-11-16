namespace 记事本
{
    partial class FormReplace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReplace));
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.button_replace = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.button_replaceAll = new System.Windows.Forms.Button();
            this.textBox_replace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("宋体", 10F);
            this.checkBox.Location = new System.Drawing.Point(19, 164);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(96, 18);
            this.checkBox.TabIndex = 9;
            this.checkBox.Text = "匹配大小写";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // button_replace
            // 
            this.button_replace.Location = new System.Drawing.Point(303, 69);
            this.button_replace.Name = "button_replace";
            this.button_replace.Size = new System.Drawing.Size(90, 29);
            this.button_replace.TabIndex = 8;
            this.button_replace.Text = "替换";
            this.button_replace.UseVisualStyleBackColor = true;
            this.button_replace.Click += new System.EventHandler(this.button_replace_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(303, 27);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(90, 29);
            this.button_next.TabIndex = 7;
            this.button_next.Text = "查找下一个";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(94, 30);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(177, 21);
            this.textBox.TabIndex = 6;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "查找内容：";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(303, 153);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(90, 29);
            this.button_close.TabIndex = 11;
            this.button_close.Text = "取消";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_replaceAll
            // 
            this.button_replaceAll.Location = new System.Drawing.Point(303, 111);
            this.button_replaceAll.Name = "button_replaceAll";
            this.button_replaceAll.Size = new System.Drawing.Size(90, 29);
            this.button_replaceAll.TabIndex = 10;
            this.button_replaceAll.Text = "全部替换";
            this.button_replaceAll.UseVisualStyleBackColor = true;
            this.button_replaceAll.Click += new System.EventHandler(this.button_replaceAll_Click);
            // 
            // textBox_replace
            // 
            this.textBox_replace.Location = new System.Drawing.Point(94, 72);
            this.textBox_replace.Name = "textBox_replace";
            this.textBox_replace.Size = new System.Drawing.Size(177, 21);
            this.textBox_replace.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "替换为：";
            // 
            // FormReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 209);
            this.Controls.Add(this.textBox_replace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_replaceAll);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.button_replace);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReplace";
            this.ShowIcon = false;
            this.Text = "替换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button button_replace;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_replaceAll;
        private System.Windows.Forms.TextBox textBox_replace;
        private System.Windows.Forms.Label label2;
    }
}