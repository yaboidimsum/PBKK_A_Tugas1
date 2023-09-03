namespace Tugas_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbFirstName = new TextBox();
            label2 = new Label();
            tbLastName = new TextBox();
            lbWelcome = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnClear = new Button();
            btnOK = new Button();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("DM Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 69);
            label1.Name = "label1";
            label1.Size = new Size(77, 16);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // tbFirstName
            // 
            tbFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbFirstName.Location = new Point(23, 88);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(338, 23);
            tbFirstName.TabIndex = 1;
            tbFirstName.TextChanged += tbFirstName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("DM Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 132);
            label2.Name = "label2";
            label2.Size = new Size(70, 16);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            label2.Click += label2_Click;
            // 
            // tbLastName
            // 
            tbLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbLastName.Location = new Point(23, 151);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(338, 23);
            tbLastName.TabIndex = 3;
            // 
            // lbWelcome
            // 
            lbWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbWelcome.AutoSize = true;
            lbWelcome.Font = new Font("DM Mono", 14.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            lbWelcome.Location = new Point(23, 194);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(78, 25);
            lbWelcome.TabIndex = 4;
            lbWelcome.Text = "label3";
            lbWelcome.Click += label3_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnClear, 1, 0);
            tableLayoutPanel1.Controls.Add(btnOK, 0, 0);
            tableLayoutPanel1.Location = new Point(22, 270);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(338, 39);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClear.Font = new Font("DM Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(172, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(163, 33);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button2_Click;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnOK.Font = new Font("DM Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOK.ForeColor = Color.Black;
            btnOK.Location = new Point(3, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(163, 33);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("DM Mono Medium", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(22, 24);
            label3.Name = "label3";
            label3.Size = new Size(250, 28);
            label3.TabIndex = 6;
            label3.Text = "Welcome to PBKK A";
            label3.Click += label3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(372, 321);
            Controls.Add(label3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lbWelcome);
            Controls.Add(tbLastName);
            Controls.Add(label2);
            Controls.Add(tbFirstName);
            Controls.Add(label1);
            ForeColor = Color.Transparent;
            MinimumSize = new Size(388, 360);
            Name = "Form1";
            Text = "Welcome Folks!";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbFirstName;
        private Label label2;
        private TextBox tbLastName;
        private Label lbWelcome;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnClear;
        private Button btnOK;
        private Label label3;
    }
}