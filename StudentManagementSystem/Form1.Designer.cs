namespace StudentManagementSystem
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
            textBoxId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            button1 = new Button();
            label4 = new Label();
            labelAddedInformation = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 52);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(129, 44);
            textBoxId.Margin = new Padding(2, 2, 2, 2);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(195, 23);
            textBoxId.TabIndex = 10;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 14);
            label2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 116);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(129, 79);
            textBoxName.Margin = new Padding(2, 2, 2, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(195, 23);
            textBoxName.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(129, 108);
            textBoxEmail.Margin = new Padding(2, 2, 2, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(195, 23);
            textBoxEmail.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(165, 181);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(109, 27);
            button1.TabIndex = 6;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 84);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 11;
            label4.Text = "Name:";
            // 
            // labelAddedInformation
            // 
            labelAddedInformation.AutoSize = true;
            labelAddedInformation.Location = new Point(165, 143);
            labelAddedInformation.Margin = new Padding(2, 0, 2, 0);
            labelAddedInformation.Name = "labelAddedInformation";
            labelAddedInformation.Size = new Size(108, 15);
            labelAddedInformation.TabIndex = 12;
            labelAddedInformation.Text = "Added Information";
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 257);
            Controls.Add(labelAddedInformation);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxId);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxId;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private Button button1;
        private Label label4;
        private Label labelAddedInformation;
    }
}
