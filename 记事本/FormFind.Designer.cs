namespace 记事本
{
    partial class FormFind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFind));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button_next = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "查找内容：";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(90, 28);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(177, 21);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(299, 25);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(90, 29);
            this.button_next.TabIndex = 2;
            this.button_next.Text = "查找下一个";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(299, 67);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(90, 29);
            this.button_close.TabIndex = 3;
            this.button_close.Text = "取消";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("宋体", 10F);
            this.checkBox.Location = new System.Drawing.Point(15, 109);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(96, 18);
            this.checkBox.TabIndex = 4;
            this.checkBox.Text = "匹配大小写";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // FormFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 156);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFind";
            this.ShowIcon = false;
            this.Text = "查找";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.CheckBox checkBox;
    }
}