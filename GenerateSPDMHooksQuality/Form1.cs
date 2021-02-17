using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateSPDMHooksQuality
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool gay = false;
            string[] gang = { "int", "float", "bool", "double", "long"};
            foreach (string item in gang)
            {
                if (item == textBox5.Text)
                {
                    gay = true;
                }
            }
            if (!changed && !textBox3.Text.Contains(" ") && textBox4.Text.StartsWith("0x") && textBox6.Text != "Value..." && gay)
            {
                textBox1.Text = "";
                LoadDina(0);
            }
            else if (changed && !textBox3.Text.Contains(" ") && textBox4.Text.StartsWith("0x"))
            {
                textBox1.Text = "";
                LoadDina(1);
            }
            else
            {
                MessageBox.Show("Gay failed something like always.");
            }
        }
        public void LoadDina(int whatCase)
        {
            if (whatCase == 0)
            {

                string[] valuegayyouorwhat = new string[255];
                string secondgayvalue = "";
                string tempShit0 = "";
                string[] gay = new string[255];
                int counting = 0;
                string isItRequired = "";
                string gangsheet = "";
                string allTogether = "";
                if (!string.IsNullOrEmpty(textBox7.Text))
                {
                    secondgayvalue = ", ";
                    string[] gang = { "int", "float", "bool", "double", "long" };
                    string[] kidnoob = textBox7.Text.Split(',');
                    valuegayyouorwhat = kidnoob;

                }
                
                for (int i = 0; i < valuegayyouorwhat.Length; i++)
                {
                    
                        isItRequired = ", ";
                   
                        if (!changed2)
                        {
                        if (counting == 0)
                        {
                            gay[i] += " oldGang" + counting++ + secondgayvalue;
                            tempShit0 += isItRequired + valuegayyouorwhat[i].ToString() + gay[i];
                            allTogether += gay[i];
                        }
                        else
                        {
                            if (i != valuegayyouorwhat.Length-1)
                            {
                                gay[i] += " oldGang" + counting++ + secondgayvalue;
                                tempShit0 += valuegayyouorwhat[i].ToString() + gay[i];
                                allTogether += gay[i];
                            }
                            else
                            {
                                gay[i] += " oldGang" + counting++;
                                tempShit0 += valuegayyouorwhat[i].ToString() + gay[i];
                                allTogether += gay[i];
                            }
                        }
                        }
                        else
                        {
                        if (i != valuegayyouorwhat.Length-1 && counting != 0)
                        {
                            gay[i] += " oldGang" + counting++ + secondgayvalue;
                            tempShit0 += valuegayyouorwhat[i].ToString() + gay[i];
                            allTogether += gay[i];
                        }
                        else if (counting == 0 && i != valuegayyouorwhat.Length-1)
                        {
                            gay[i] += "oldGang" + counting++ + secondgayvalue;
                            tempShit0 += valuegayyouorwhat[i].ToString() + " " + gay[i];
                            allTogether += gay[i];
                        }
                        else
                        {
                            gay[i] += " oldGang" + counting++;
                            tempShit0 += valuegayyouorwhat[i].ToString() + gay[i];
                            allTogether += gay[i];
                        }
                        }
                        
                        
                }
                if (!changed2)
                {
                    textBox1.AppendText("bool boolean = false;" + Environment.NewLine + Environment.NewLine);
                    textBox1.AppendText(textBox5.Text + " (*old_" + textBox3.Text + ")(void* instance" + tempShit0 + ");" + Environment.NewLine
                        + textBox5.Text + " " + textBox3.Text + "(void* instance" + tempShit0 + ")"
                        + Environment.NewLine + "{" + Environment.NewLine +
                        "    if (instance != NULL)" + Environment.NewLine +
                        "    {" + Environment.NewLine +
                        "       if (boolean)" + Environment.NewLine +
                        "       {" + Environment.NewLine +
                        "       return " + textBox6.Text + ";" + Environment.NewLine +
                        "       }" + Environment.NewLine +
                        "    }" + Environment.NewLine +
                        "    return old_" + textBox3.Text + "(instance" + isItRequired + allTogether + ");" + Environment.NewLine +
                        "}" + Environment.NewLine + Environment.NewLine + "SPDMHook(libName, Obfuscator2Tiahh(OBFUSCATE(\u0022" + textBox4.Text + "\u0022)), (void*)" + textBox3.Text + ", (void**)&old_" + textBox3.Text + ");");

                }
                else
                {
                    textBox1.AppendText("bool boolean = false;" + Environment.NewLine + Environment.NewLine);
                    textBox1.AppendText(textBox5.Text + " (*old_" + textBox3.Text + ")(" + tempShit0.Replace(", " + valuegayyouorwhat[0].ToString(), "") + ");" + Environment.NewLine
                         + textBox5.Text + " " + textBox3.Text + "(" + tempShit0.Replace(", " + valuegayyouorwhat[0].ToString(), "") + ")"
                         + Environment.NewLine + "{" + Environment.NewLine +
                         "    if (boolean)" + Environment.NewLine +
                         "    {" + Environment.NewLine +
                         "       return " + textBox6.Text + ";" + Environment.NewLine +
                         "    }" + Environment.NewLine +
                         "    else" + Environment.NewLine +
                         "    {" + Environment.NewLine +
                         "    return old_" + textBox3.Text + "(" + allTogether + ");" + Environment.NewLine +
                         "    }" + Environment.NewLine +
                         "}" + Environment.NewLine + Environment.NewLine + "SPDMHook(libName, Obfuscator2Tiahh(OBFUSCATE(\u0022" + textBox4.Text + "\u0022)), (void*)" + textBox3.Text + ", (void**)&old_" + textBox3.Text + ");");
                }
            }
            else
            {
                string[] valuegayyouorwhat = new string[255];
                string secondgayvalue = "";
                string tempShit0 = "";
                string[] gay = new string[255];
                int counting = 0;
                string isItRequired = "";
                string gangsheet = "";
                string allTogether = "";
                if (!string.IsNullOrEmpty(textBox7.Text))
                {
                    secondgayvalue = ", ";
                    string[] gang = { "int", "float", "bool", "double", "long" };
                    foreach (string item in gang)
                    {

                        string[] kidnoob = textBox7.Text.Split(',');
                        valuegayyouorwhat = kidnoob;
                    }
                }
                for (int i = 0; i < valuegayyouorwhat.Length; i++)
                {

                    isItRequired = ", ";

                    if (!changed2)
                    {
                        if (counting == 0)
                        {
                            gay[i] += " oldGang" + counting++ + secondgayvalue;
                            tempShit0 += isItRequired + valuegayyouorwhat[i].ToString() + gay[i];
                            allTogether += gay[i];
                        }
                        else
                        {
                            if (i != valuegayyouorwhat.Length - 1)
                            {
                                gay[i] += " oldGang" + counting++ + secondgayvalue;
                                tempShit0 += valuegayyouorwhat[i].ToString() + gay[i];
                                allTogether += gay[i];
                            }
                            else
                            {
                                gay[i] += " oldGang" + counting++;
                                tempShit0 += valuegayyouorwhat[i].ToString() + gay[i];
                                allTogether += gay[i];
                            }
                        }
                    }
                    else
                    {
                        if (i != valuegayyouorwhat.Length - 1 && counting != 0)
                        {
                            gay[i] += " oldGang" + counting++ + secondgayvalue;
                            tempShit0 += valuegayyouorwhat[i].ToString() + gay[i];
                            allTogether += gay[i];
                        }
                        else if (counting == 0 && i != valuegayyouorwhat.Length - 1)
                        {
                            gay[i] += "oldGang" + counting++ + secondgayvalue;
                            tempShit0 += valuegayyouorwhat[i].ToString() + " " + gay[i];
                            allTogether += gay[i];
                        }
                        else
                        {
                            gay[i] += " oldGang" + counting++;
                            tempShit0 += valuegayyouorwhat[i].ToString() + gay[i];
                            allTogether += gay[i];
                        }
                    }


                }
                if (!changed2)
                {
                    textBox1.AppendText("bool boolean = false;" + Environment.NewLine + Environment.NewLine);
                    textBox1.AppendText("void " + " (*old_" + textBox3.Text + ")(void* instance" + tempShit0 + ");" + Environment.NewLine
                        + "void" + " " + textBox3.Text + "(void* instance" + tempShit0 + ")"
                        + Environment.NewLine + "{" + Environment.NewLine +
                        "    if (instance != NULL)" + Environment.NewLine +
                        "    {" + Environment.NewLine +
                        "        if (boolean)" + Environment.NewLine +
                        "        {" + Environment.NewLine +
                        "       " + "//Value..." + Environment.NewLine +
                        "        }" + Environment.NewLine +
                        "    }" + Environment.NewLine +
                        "    old_" + textBox3.Text + "(instance" + isItRequired + gay[0] + gay[1] + gay[2] + ");" + Environment.NewLine +
                        "}" + Environment.NewLine + Environment.NewLine + "SPDMHook(libName, Obfuscator2Tiahh(OBFUSCATE(\u0022" + textBox4.Text + "\u0022)), (void*)" + textBox3.Text + ", (void**)&old_" + textBox3.Text + ");");
                }
                else
                {
                    textBox1.AppendText("bool boolean = false;" + Environment.NewLine + Environment.NewLine);
                    textBox1.AppendText("void*" + " (*old_" + textBox3.Text + ")(" + valuegayyouorwhat[0].ToString() + tempShit0.Replace(", " + valuegayyouorwhat[0].ToString(), "") + ");" + Environment.NewLine
                         + "void*" + " " + textBox3.Text + "(" + tempShit0 + ")"
                         + Environment.NewLine + "{" + Environment.NewLine +
                         "    if (boolean)" + Environment.NewLine +
                         "    {" + Environment.NewLine +
                         "       " + "//Value..." + Environment.NewLine +
                         "    }" + Environment.NewLine +
                         "    else" + Environment.NewLine +
                         "    {" + Environment.NewLine +
                         "    old_" + textBox3.Text + "(" + gay[0].Replace(" ", "") + gay[1] + gay[2] + ");" + Environment.NewLine +
                         "    }" + Environment.NewLine +
                         "}" + Environment.NewLine + Environment.NewLine + "SPDMHook(libName, Obfuscator2Tiahh(OBFUSCATE(\u0022" + textBox4.Text + "\u0022)), (void*)" + textBox3.Text + ", (void**)&old_" + textBox3.Text + ");");
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "Class name..")
            {
                textBox3.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "Offset..")
            {
                textBox4.Text = "";
            }
        }
        public static bool changed = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            changed = !changed;
            if (changed)
            {
               // textBox2.Visible = true;
                textBox5.Visible = false;
                textBox6.Visible = false;
            }
            else
            {
                //textBox2.Visible = false;
                textBox5.Visible = true;
                textBox6.Visible = true;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            bool gay = false;
            string[] gang = { "int", "float", "bool", "double", "long" };
            foreach (string item in gang)
            {
                if (item == textBox5.Text)
                {
                    gay = true;
                }
            }
            if (gay)
            {
                textBox5.ForeColor = Color.Red;
            }
            else
            {
                textBox5.ForeColor = Color.White;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static bool changed2 = false;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            changed2 = !changed2;
           
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "Has value..")
            {
                textBox7.Text = "";
            }
            bool gay = false;
            string[] gang = { "int", "float", "bool", "double", "long" };
            foreach (string item in gang)
            {
                if (item == textBox5.Text)
                {
                    gay = true;
                }
            }
            if (gay)
            {
                textBox5.ForeColor = Color.Red;
            }
            else
            {
                textBox5.ForeColor = Color.White;
            }
        }
    }
}
