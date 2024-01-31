using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\" + "Code.py");
                sw.WriteLine(label5.Text + "\n\n" +
                label6.Text + label3.Text + "\\" + textBox1.Text + "\\" + textBox2.Text + "\\" + textBox3.Text + "\\" + textBox4.Text + "\\" + textBox5.Text + "\\" + textBox6.Text + label7.Text + "\n" +
                label8.Text + label4.Text + "\\" + textBox7.Text + "\\" + textBox8.Text + "\\" + textBox9.Text + "\\" + textBox10.Text + "\\" + textBox11.Text + "\\" + textBox12.Text + label9.Text + "\n" +
                label10.Text + "\n\n" + label11.Text + "\n" + label12.Text + "\n" + label13.Text + "\n" + label14.Text + "\n\n" +
                label15.Text + "\n" + label16.Text + "\n" + label17.Text + "\n\n" +
                label18.Text + "\n" + label19.Text + "\n" + label20.Text + "\n" + label21.Text + "\n\n" +
                label22.Text + "\n" + "for i in range(20):\n sendp(payload, iface=interface)");
                sw.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            try
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\" + "mac" + ".txt");
                sw.WriteLine(textBox1.Text);
                sw.WriteLine(textBox2.Text);
                sw.WriteLine(textBox3.Text);
                sw.WriteLine(textBox4.Text);
                sw.WriteLine(textBox5.Text);
                sw.WriteLine(textBox6.Text);
                sw.WriteLine(textBox7.Text);
                sw.WriteLine(textBox8.Text);
                sw.WriteLine(textBox9.Text);
                sw.WriteLine(textBox10.Text);
                sw.WriteLine(textBox11.Text);
                sw.WriteLine(textBox12.Text);
                sw.Close();
                MessageBox.Show("Save", "Saves");
                button2.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\" + "PoC.bat");
                sw.WriteLine(" python Code.py\npause");
                sw.Close();
                if (File.Exists("PoC.bat"))
                {
                    Thread thread = new Thread(new ThreadStart(ThreadProc));
                    new Process
                    {
                        StartInfo =
                            {
                                WindowStyle = ProcessWindowStyle.Hidden,
                                FileName = "PoC.bat"
                            }
                    }.Start();

                    MessageBox.Show(" successfully created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {

                    MessageBox.Show("PoC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
            MessageBox.Show("Thanks  @RobbedColek", "Code!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            try
            {
                System.Diagnostics.Process.Start(@"PoC.bat");
            }
            catch
            {

            }
        }

        private void ThreadProc()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\" + "mac" + ".txt");
            textBox1.Text = sr.ReadLine();
            textBox2.Text = sr.ReadLine();
            textBox3.Text = sr.ReadLine();
            textBox4.Text = sr.ReadLine();
            textBox5.Text = sr.ReadLine();
            textBox6.Text = sr.ReadLine();
            textBox7.Text = sr.ReadLine();
            textBox8.Text = sr.ReadLine();
            textBox9.Text = sr.ReadLine();
            textBox10.Text = sr.ReadLine();
            textBox11.Text = sr.ReadLine();
            textBox12.Text = sr.ReadLine();
            sr.Close();
        }

        private void label25_MouseEnter(object sender, EventArgs e)
        {
            label26.Visible = true;
        }
    }
}
