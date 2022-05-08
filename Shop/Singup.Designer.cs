
using System.Drawing;
using System.Windows.Forms;

namespace Shop
{
    partial class Singup
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
        
        //регистрация

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 300);
            this.Text = "Singup";

            label.Text = "SING UP";
            Controls.Add(label);

            email.Location = new Point(50, 50);
            Controls.Add(email);

            pas1.Location = new Point(50, 100);
            pas1.PasswordChar = '*';
            Controls.Add(pas1);

            pas2.Location = new Point(50, 150);
            pas2.PasswordChar = '*';
            Controls.Add(pas2);

            start.Location = new Point(50, 200);
            start.Text = "Accept";
            Controls.Add(start);

        }

        Label label = new Label();

        TextBox email = new TextBox();
        TextBox pas1 = new TextBox();
        TextBox pas2 = new TextBox();


        Button start = new Button();
        #endregion
    }
}