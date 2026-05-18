namespace Trabalho
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
            panelmenu = new Panel();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            panelmenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelmenu
            // 
            panelmenu.BackColor = SystemColors.ActiveCaption;
            panelmenu.Controls.Add(label1);
            panelmenu.Controls.Add(button2);
            panelmenu.Controls.Add(button1);
            panelmenu.Location = new Point(0, -3);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(799, 458);
            panelmenu.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(325, 235);
            button1.Name = "button1";
            button1.Size = new Size(123, 52);
            button1.TabIndex = 0;
            button1.Text = "2_Jogadores";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(317, 340);
            button2.Name = "button2";
            button2.Size = new Size(131, 49);
            button2.TabIndex = 1;
            button2.Text = "4_Jogadores";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(317, 79);
            label1.Name = "label1";
            label1.Size = new Size(148, 45);
            label1.TabIndex = 2;
            label1.Text = "Blackjack";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelmenu);
            Name = "Form1";
            Text = "Form1";
            panelmenu.ResumeLayout(false);
            panelmenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelmenu;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}
