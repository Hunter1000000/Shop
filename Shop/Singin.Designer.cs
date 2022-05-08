
using System.Drawing;
using System.Windows.Forms;

namespace Shop
{
    partial class Singin
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
        
        //войти

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Text = "Singin";

            label.Text = "SING IN";
            Controls.Add(label);

            email.Location = new Point(50, 50);
            Controls.Add(email);

            pas1.Location = new Point(50, 100);
            pas1.PasswordChar = '*';
            Controls.Add(pas1);

            start.Location = new Point(50, 150);
            start.Text = "Accept";
            Controls.Add(start);

            register.Location = new Point(150, 150);
            register.Text = "Register";
            Controls.Add(register);
            register.Click += Register_Click;

        }

        private void Register_Click(object sender, System.EventArgs e)
        {
            Form f = new Singup();
            f.Show();
        }

        Label label = new Label();

        TextBox email = new TextBox();
        TextBox pas1 = new TextBox();

        Button register = new Button();
        Button start = new Button();
        #endregion
    }
}