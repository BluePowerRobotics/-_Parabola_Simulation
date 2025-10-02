using System.Windows.Forms;
using System;
using System.Drawing;
namespace 抛物线模拟
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
            panel2 = new Panel();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            axisDisplayer2 = new AxisDisplayer();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 42);
            panel2.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(610, 9);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(52, 23);
            textBox5.TabIndex = 9;
            textBox5.Text = "0.3";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(548, 12);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 8;
            label5.Text = "篮子宽度";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(471, 6);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(52, 23);
            textBox4.TabIndex = 7;
            textBox4.Text = "2";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 9);
            label4.Name = "label4";
            label4.Size = new Size(38, 17);
            label4.TabIndex = 6;
            label4.Text = "篮子y";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(339, 6);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(52, 23);
            textBox3.TabIndex = 5;
            textBox3.Text = "4";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 9);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 4;
            label3.Text = "篮子中心x";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(52, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "45";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 9);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 2;
            label2.Text = "仰角";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(52, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "1";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 0;
            label1.Text = "初速度";
            label1.Click += label1_Click;
            // 
            // axisDisplayer2
            // 
            axisDisplayer2.Dock = DockStyle.Fill;
            axisDisplayer2.Font = new Font("Consolas", 15F);
            axisDisplayer2.Location = new Point(0, 42);
            axisDisplayer2.Name = "axisDisplayer2";
            axisDisplayer2.Size = new Size(800, 408);
            axisDisplayer2.TabIndex = 2;
            axisDisplayer2.UnitLength = 20D;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(axisDisplayer2);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private AxisDisplayer axisDisplayer2;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox5;
        private Label label5;
    }
}
