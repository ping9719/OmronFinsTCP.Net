using OmronFinsTCP.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinsDebuger
{
    public partial class Form2 : Form
    {
        EtherNetPLC ENT;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            string s = btnCon.Text.Trim();
            if (s == "连接")
            {
                string plcip = txtPlcip.Text.Trim();
                string plcport = txtPlcport.Text.Trim();
                ENT = new EtherNetPLC();
                short re = ENT.Link(plcip, int.Parse(plcport), 500);
                if (re == 0)
                {
                    btnCon.Text = "断开";
                }
                else
                {
                    MessageBox.Show("连接出错！");
                }
            }
            else
            {
                short re = ENT.Close();
                if (re == 0)
                {
                    btnCon.Text = "连接";
                }
                else
                {
                    MessageBox.Show("断开出错！");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var data = ENT.GetDatas<Int16>(txtAddress.Text, int.Parse(textBox1.Text));
                txtUseTime.Text = string.Join(",", data);
            }
            else if (radioButton2.Checked)
            {
                var data = ENT.GetDatas<int>(txtAddress.Text, int.Parse(textBox1.Text));
                txtUseTime.Text = string.Join(",", data);
            }
            else if (radioButton3.Checked)
            {
                var data = ENT.GetDatas<bool>(txtAddress.Text, int.Parse(textBox1.Text));
                txtUseTime.Text = string.Join(",", data);
            }
            else if (radioButton4.Checked)
            {
                var data = ENT.GetDatas<float>(txtAddress.Text, int.Parse(textBox1.Text));
                txtUseTime.Text = string.Join(",", data);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton55.Checked)
                {
                    ENT.SetData(textBox4.Text, Int16.Parse(textBox2.Text));
                }
                else if (radioButton66.Checked)
                {
                    ENT.SetData(textBox4.Text, int.Parse(textBox2.Text));
                }
                else if (radioButton77.Checked)
                {
                    ENT.SetData(textBox4.Text, radioButton5.Checked);
                }
                else if (radioButton88.Checked)
                {
                    ENT.SetData(textBox4.Text, float.Parse(textBox2.Text));
                }

                textBox3.Text = "成功" + DateTime.Now.ToString();
            }
            catch (Exception ex)
            {
                textBox3.Text = "失败" + DateTime.Now.ToString();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            ENT?.Close();
        }

        private void radioButton77_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Visible = radioButton77.Checked;
        }
    }
}
