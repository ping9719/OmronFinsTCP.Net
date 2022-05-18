
namespace FinsDebuger
{
    partial class Form2
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.txtUseTime = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.radioButton88 = new System.Windows.Forms.RadioButton();
            this.radioButton77 = new System.Windows.Forms.RadioButton();
            this.radioButton66 = new System.Windows.Forms.RadioButton();
            this.radioButton55 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlcport = new System.Windows.Forms.TextBox();
            this.btnCon = new System.Windows.Forms.Button();
            this.txtPlcip = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "int16";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(104, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "int32";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(205, 8);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "bool";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(306, 9);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(53, 16);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "float";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // txtUseTime
            // 
            this.txtUseTime.Location = new System.Drawing.Point(3, 57);
            this.txtUseTime.Name = "txtUseTime";
            this.txtUseTime.ReadOnly = true;
            this.txtUseTime.Size = new System.Drawing.Size(515, 21);
            this.txtUseTime.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(3, 30);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(265, 21);
            this.txtAddress.TabIndex = 11;
            this.txtAddress.Text = "W100.1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "读";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 21);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(271, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 21);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "true";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "写";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(515, 21);
            this.textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 25);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(262, 21);
            this.textBox4.TabIndex = 19;
            this.textBox4.Text = "W100.1";
            // 
            // radioButton88
            // 
            this.radioButton88.AutoSize = true;
            this.radioButton88.Location = new System.Drawing.Point(306, 4);
            this.radioButton88.Name = "radioButton88";
            this.radioButton88.Size = new System.Drawing.Size(53, 16);
            this.radioButton88.TabIndex = 18;
            this.radioButton88.Text = "float";
            this.radioButton88.UseVisualStyleBackColor = true;
            // 
            // radioButton77
            // 
            this.radioButton77.AutoSize = true;
            this.radioButton77.Location = new System.Drawing.Point(205, 3);
            this.radioButton77.Name = "radioButton77";
            this.radioButton77.Size = new System.Drawing.Size(47, 16);
            this.radioButton77.TabIndex = 17;
            this.radioButton77.Text = "bool";
            this.radioButton77.UseVisualStyleBackColor = true;
            // 
            // radioButton66
            // 
            this.radioButton66.AutoSize = true;
            this.radioButton66.Location = new System.Drawing.Point(104, 3);
            this.radioButton66.Name = "radioButton66";
            this.radioButton66.Size = new System.Drawing.Size(53, 16);
            this.radioButton66.TabIndex = 16;
            this.radioButton66.Text = "int32";
            this.radioButton66.UseVisualStyleBackColor = true;
            // 
            // radioButton55
            // 
            this.radioButton55.AutoSize = true;
            this.radioButton55.Checked = true;
            this.radioButton55.Location = new System.Drawing.Point(3, 3);
            this.radioButton55.Name = "radioButton55";
            this.radioButton55.Size = new System.Drawing.Size(53, 16);
            this.radioButton55.TabIndex = 15;
            this.radioButton55.TabStop = true;
            this.radioButton55.Text = "int16";
            this.radioButton55.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtUseTime);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(25, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 107);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton55);
            this.panel2.Controls.Add(this.radioButton66);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.radioButton77);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.radioButton88);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Location = new System.Drawing.Point(25, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 112);
            this.panel2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "PORT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 28;
            this.label1.Text = "IP:";
            // 
            // txtPlcport
            // 
            this.txtPlcport.Location = new System.Drawing.Point(304, 12);
            this.txtPlcport.Name = "txtPlcport";
            this.txtPlcport.Size = new System.Drawing.Size(120, 21);
            this.txtPlcport.TabIndex = 27;
            this.txtPlcport.Text = "9600";
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(444, 12);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(75, 23);
            this.btnCon.TabIndex = 26;
            this.btnCon.Text = "连接";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // txtPlcip
            // 
            this.txtPlcip.Location = new System.Drawing.Point(95, 12);
            this.txtPlcip.Name = "txtPlcip";
            this.txtPlcip.Size = new System.Drawing.Size(120, 21);
            this.txtPlcip.TabIndex = 25;
            this.txtPlcip.Text = "10.10.56.14";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 320);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlcport);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.txtPlcip);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox txtUseTime;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton radioButton88;
        private System.Windows.Forms.RadioButton radioButton77;
        private System.Windows.Forms.RadioButton radioButton66;
        private System.Windows.Forms.RadioButton radioButton55;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlcport;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.TextBox txtPlcip;
    }
}