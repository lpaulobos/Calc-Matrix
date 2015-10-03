using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Dictionary<int, TextBox> matriz1 = new Dictionary<int, TextBox>();
        public Dictionary<int, TextBox> matriz2 = new Dictionary<int, TextBox>();
        public Dictionary<int, TextBox> matriz3 = new Dictionary<int, TextBox>();
        public Dictionary<string,float> multis = new Dictionary<string,float>();
        public Dictionary<string, TextBox> plano = new Dictionary<string, TextBox>();

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(matriz1.Count == 0)
            { 
                for (int j = 1; j <= Convert.ToInt32(comboBox2.Text); j++)
                {
                    for (int i = 1; i <= Convert.ToInt32(comboBox1.Text); i++)
                    {
                        TextBox textBox = new TextBox();
                        textBox.Location = new System.Drawing.Point(25 + 35 * j, 113 + 22 * i);
                        textBox.Size = new System.Drawing.Size(31, 20);
                        this.Controls.Add(textBox);
                        matriz1.Add(Convert.ToInt32(i.ToString()+j.ToString()),textBox);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (matriz2.Count == 0)
            {
                for (int j = 1; j <= Convert.ToInt32(comboBox3.Text); j++)
                {
                    for (int i = 1; i <= Convert.ToInt32(comboBox4.Text); i++)
                    {
                        TextBox textBox = new TextBox();
                        textBox.Location = new System.Drawing.Point(400 + 35 * j, 113 + 22 * i);
                        textBox.Size = new System.Drawing.Size(31, 20);
                        this.Controls.Add(textBox);
                        matriz2.Add(Convert.ToInt32(i.ToString() + j.ToString()), textBox);
                    }
                }
            }
           
           
        }

        private void clear(object sender, EventArgs e)
        {
            if (matriz1.Count > 0) { 
                for (int j = 1; j <= Convert.ToInt32(comboBox1.Text); j++)
                {
                    for (int i = 1; i <= Convert.ToInt32(comboBox2.Text); i++)
                    {
                        this.Controls.Remove(matriz1[Convert.ToInt32(j.ToString() + i.ToString())]);
                        matriz1.Remove(Convert.ToInt32(j.ToString() + i.ToString()));
                    }
                }
            } if (matriz2.Count > 0)
            {
                for (int j = 1; j <= Convert.ToInt32(comboBox3.Text); j++)
                {
                    for (int i = 1; i <= Convert.ToInt32(comboBox4.Text); i++)
                    {
                        this.Controls.Remove(matriz2[Convert.ToInt32(j.ToString() + i.ToString())]);
                        matriz2.Remove(Convert.ToInt32(j.ToString() + i.ToString()));
                    }
                }
            }
            if (matriz3.Count > 0)
            {
                for (int j = 1; j <= Convert.ToInt32(comboBox1.Text); j++)
                {
                    for (int i = 1; i <= Convert.ToInt32(comboBox2.Text); i++)
                    {
                        this.Controls.Remove(matriz3[Convert.ToInt32(j.ToString() + i.ToString())]);
                        matriz3.Remove(Convert.ToInt32(j.ToString() + i.ToString()));
                    }
                }
            }
        }

        private void soma(object sender, EventArgs e)
        {
                for (int j = 1; j <= Convert.ToInt32(comboBox1.Text); j++)
                {
                    for (int i = 1; i <= Convert.ToInt32(comboBox2.Text); i++)
                    {
                        TextBox textBoxC = new TextBox();
                        textBoxC.Location = new System.Drawing.Point(795 + 31 *i, 95 + 20 *j);
                        textBoxC.Size = new System.Drawing.Size(31, 20);
                        this.Controls.Add(textBoxC);
                        float a = float.Parse(matriz1[Convert.ToInt32(j.ToString() + i.ToString())].Text);
                        float b = float.Parse(matriz2[Convert.ToInt32(j.ToString() + i.ToString())].Text);
                        float c = a + b;
                        multis.Add(j.ToString() + i.ToString() , c);
                        matriz3.Add(Convert.ToInt32(i.ToString() + j.ToString()), textBoxC);
                    }
                
            }
                for (int j = 1; j <= Convert.ToInt32(comboBox1.Text); j++)
                {
                    for (int i = 1; i <= Convert.ToInt32(comboBox2.Text); i++)
                    {
                        matriz3[Convert.ToInt32(i.ToString() + j.ToString())].Text = multis[j.ToString() + i.ToString()].ToString();
                    }
                }
        }
        private void subtracao(object sender, EventArgs e)
        {
                for (int j = 1; j <= Convert.ToInt32(comboBox1.Text); j++)
                {
                    for (int i = 1; i <= Convert.ToInt32(comboBox2.Text); i++)
                    {
                        TextBox textBox = new TextBox();
                        textBox.Location = new System.Drawing.Point(800 + 35 * j, 113 + 22 * i);
                        textBox.Size = new System.Drawing.Size(31, 20);
                        this.Controls.Add(textBox);
                        float a = float.Parse(matriz1[Convert.ToInt32(j.ToString() + i.ToString())].Text);
                        float b = float.Parse(matriz2[Convert.ToInt32(j.ToString() + i.ToString())].Text);
                        float c = a - b;
                        textBox.Text = c.ToString();
                        matriz3.Add(Convert.ToInt32(i.ToString() + j.ToString()), textBox);
                    }
                }
            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            myCanvas1.Desenho1 = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void multiplicacao(object sender, EventArgs e)
        {

            for (int j = 1; j <= Convert.ToInt32(comboBox1.Text); j++)
            {
                for (int i = 1; i <= Convert.ToInt32(comboBox4.Text); i++)
                {
                    TextBox textBoxC = new TextBox();
                    textBoxC.Location = new System.Drawing.Point(795 + 31 * i, 95 + 20 * j);
                    textBoxC.Size = new System.Drawing.Size(31, 20);
                    this.Controls.Add(textBoxC);
                    for (int p = 0; p < Convert.ToInt32(comboBox2.Text); p++)
                    {
                        float a = float.Parse(matriz1[Convert.ToInt32(j.ToString() + i.ToString())].Text); //float.Parse(matriz1[Convert.ToInt32(j.ToString() + i.ToString())].Text);
                        float b = float.Parse(matriz2[Convert.ToInt32(i.ToString() + j.ToString())].Text); //float.Parse(matriz2[Convert.ToInt32(i.ToString() + j.ToString())].Text);
                        //float c = float.Parse(matriz1[Convert.ToInt32(j.ToString()+p.ToString()) ].Text) * float.Parse(matriz2[Convert.ToInt32(i.ToString()+p.ToString())].Text);
                        float c = a*b;
                        textBoxC.Text = c.ToString();
                        matriz3.Add(Convert.ToInt32(i.ToString() + j.ToString()), textBoxC);
                    }

                }
            } 
        }

        private void myCanvas1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            decimal x = coordinates.X/10;
            decimal y = coordinates.Y/10;
            if (coordinates.X > 99)
                Math.Round(x, 1);
            else Math.Round(x, 2);
            if (coordinates.Y > 99)
                Math.Round(y, 1);
            else Math.Round(y, 2);
            
            Console.WriteLine(coordinates);
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            myCanvas1.points.Clear();
            if (plano.Count > 0)
            {
                for (int j = 1; j <= plano.Count / 2; j++)
                {
                    Console.WriteLine(plano[j.ToString() + "1"]);
                    Console.WriteLine(plano[j.ToString() + "2"]);
                    myCanvas1.points.Add(new Point((Convert.ToInt32(plano[j.ToString() + "1"].Text)), (Convert.ToInt32(plano[j.ToString() + "2"].Text))));
                    myCanvas1.pts = myCanvas1.points.ToArray();
                }
                plano.Clear();
            }
            myCanvas1.Desenhar = true;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (plano.Count > 0) { 
                    for (int j = 1; j <= plano.Count/2; j++)
                    {
                        for (int i = 1; i < 3; i++){
                            this.Controls.Remove(plano[j.ToString()+i.ToString()]);
                    }
                }
                    plano.Clear();
            }
          

            for (int j = 1; j <= Convert.ToInt32(comboBox6.Text); j++)
            {
                for (int i = 1; i <3; i++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Location = new System.Drawing.Point(70 + 35 *i, 375 + 25*j);
                    textBox.Size = new System.Drawing.Size(31, 20);
                    this.Controls.Add(textBox);
                    plano.Add(j.ToString() + i.ToString(), textBox);
                }
            }
        }


    }
    
}