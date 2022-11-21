
namespace StrategyPattern
{
    partial class Client
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
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.Pricelabel = new System.Windows.Forms.Label();
            this.Accountlabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Typelabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(327, 56);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 0;
            this.ConfirmButton.Text = "确定";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(327, 100);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "重置";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(110, 56);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(170, 21);
            this.PriceTextBox.TabIndex = 2;
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(110, 100);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(170, 21);
            this.CountTextBox.TabIndex = 3;
            // 
            // Pricelabel
            // 
            this.Pricelabel.AutoSize = true;
            this.Pricelabel.Location = new System.Drawing.Point(46, 65);
            this.Pricelabel.Name = "Pricelabel";
            this.Pricelabel.Size = new System.Drawing.Size(41, 12);
            this.Pricelabel.TabIndex = 4;
            this.Pricelabel.Text = "单价：";
            this.Pricelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Accountlabel
            // 
            this.Accountlabel.AutoSize = true;
            this.Accountlabel.Location = new System.Drawing.Point(46, 111);
            this.Accountlabel.Name = "Accountlabel";
            this.Accountlabel.Size = new System.Drawing.Size(41, 12);
            this.Accountlabel.TabIndex = 5;
            this.Accountlabel.Text = "数量：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 20);
            this.comboBox1.TabIndex = 6;
            // 
            // Typelabel
            // 
            this.Typelabel.AutoSize = true;
            this.Typelabel.Location = new System.Drawing.Point(22, 168);
            this.Typelabel.Name = "Typelabel";
            this.Typelabel.Size = new System.Drawing.Size(65, 12);
            this.Typelabel.TabIndex = 7;
            this.Typelabel.Text = "计算方式：";
            this.Typelabel.Click += new System.EventHandler(this.Typelabel_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(110, 236);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(303, 124);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(22, 406);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(41, 12);
            this.TotalLabel.TabIndex = 10;
            this.TotalLabel.Text = "合计：";
            // 
            // TotalNumberLabel
            // 
            this.TotalNumberLabel.AutoSize = true;
            this.TotalNumberLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TotalNumberLabel.Location = new System.Drawing.Point(110, 406);
            this.TotalNumberLabel.Name = "TotalNumberLabel";
            this.TotalNumberLabel.Size = new System.Drawing.Size(0, 12);
            this.TotalNumberLabel.TabIndex = 11;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 457);
            this.Controls.Add(this.TotalNumberLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Typelabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Accountlabel);
            this.Controls.Add(this.Pricelabel);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ConfirmButton);
            this.Name = "Client";
            this.Text = "W";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.Label Pricelabel;
        private System.Windows.Forms.Label Accountlabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Typelabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TotalNumberLabel;
    }
}