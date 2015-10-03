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
        public float value = 0;
        public bool chio = false;
        float a;
        float b;
        float c;
        float d;
        float e;
        float f;
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
                for (int j = 1; j <= Convert.ToInt32(comboBox4.Text); j++)
                {
                    for (int i = 1; i <= Convert.ToInt32(comboBox3.Text); i++)
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
                    for (int i = 1; i <= Convert.ToInt32(comboBox1.Text); i++)
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
                        textBoxC.Text = c.ToString();
                        matriz3.Add(Convert.ToInt32(i.ToString() + j.ToString()), textBoxC);
                    }
                
            }
        }
        private void subtracao(object sender, EventArgs e)
        {
            if(comboBox1 == comboBox3 && comboBox2 == comboBox4)
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
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (matriz1.Count > 9) Chio();
            else
            {
                chio = false;
                determinante();
            }
           
        }
        private void multiplicacao(object sender, EventArgs e)
        {
            for (int j = 1; j <= Convert.ToInt32(comboBox1.Text); j++)
            {
                for (int i = 1; i <= Convert.ToInt32(comboBox3.Text); i++)
                {
                    for (int x = 1; x <= Convert.ToInt32(comboBox4.Text); x++)
                    {
                         float a = float.Parse(matriz1[Convert.ToInt32(j.ToString() + x.ToString())].Text);
                         Console.Write("A: " + j.ToString() + x.ToString());
                         float b = float.Parse(matriz2[Convert.ToInt32(x.ToString() + i.ToString())].Text);
                         Console.WriteLine(" * b: " + x.ToString() + i.ToString());
                         value += a * b;
                    }
                    TextBox textBoxC = new TextBox();
                    textBoxC.Location = new System.Drawing.Point(795 + 31 * j, 95 + 20 * i);
                    textBoxC.Size = new System.Drawing.Size(31, 20);
                    textBoxC.Text = value.ToString();
                    this.Controls.Add(textBoxC);
                    matriz3.Add(Convert.ToInt32(i.ToString() + j.ToString()), textBoxC);
                    value = 0;
                }

            }
        }
        private void myCanvas1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
           
        }
        private void button8_Click(object sender, EventArgs e)
        {
            myCanvas1.points.Clear();

            for (int j = 1; j <= plano.Count / 2; j++)
            {
                if (plano["1" + j.ToString()].Text !="" && plano["2" + j.ToString()].Text !="")
                {
                    myCanvas1.points.Add(new Point(Convert.ToInt32(float.Parse(plano["1" + j.ToString()].Text) * 100 + 400), Convert.ToInt32(float.Parse(plano["2" + j.ToString()].Text) * -100 + 200)));
                }
                else Console.WriteLine("Tá vazio");
            }
            
            myCanvas1.Desenhar = true;
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (plano.Count > 0)
            {
                for (int j = 1; j < 3; j++)
                {
                    for (int i = 1; i <= plano.Count/2 +1; i++)
                    {
                        TextBox textBox = new TextBox();
                        textBox.Location = new System.Drawing.Point(31 * i - 5, 350 + 21 * j);
                        textBox.Size = new System.Drawing.Size(28, 18);
                        this.Controls.Remove(textBox);
                        plano.Remove(j.ToString() + i.ToString());
                    }
                }
            }
            else if (plano.Count == 0)
            {
                for (int j = 1; j < 3; j++)
                {
                    for (int i = 1; i <= Convert.ToInt32(comboBox6.Text); i++)
                    {
                        TextBox textBox = new TextBox();
                        textBox.Location = new System.Drawing.Point(31 * i - 5, 350 + 21 * j);
                        textBox.Size = new System.Drawing.Size(28, 18);
                        this.Controls.Add(textBox);
                        plano.Add(j.ToString() + i.ToString(), textBox);
                    }
                }
            }
            
        }
        private void button9_Click(object sender, EventArgs e)
        {
            myCanvas1.Desenhar = false;
            plano.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            myCanvas1.Desenho1 = true;
        }
        private void determinante()
        {
            if (!chio)
            {
                 a = float.Parse(matriz1[11].Text) * float.Parse(matriz1[22].Text) * float.Parse(matriz1[33].Text);
                 b = float.Parse(matriz1[12].Text) * float.Parse(matriz1[23].Text) * float.Parse(matriz1[31].Text);
                 c = float.Parse(matriz1[13].Text) * float.Parse(matriz1[21].Text) * float.Parse(matriz1[32].Text);
                 d = float.Parse(matriz1[13].Text) * float.Parse(matriz1[22].Text) * float.Parse(matriz1[31].Text);
                 e = float.Parse(matriz1[11].Text) * float.Parse(matriz1[23].Text) * float.Parse(matriz1[32].Text);
                 f = float.Parse(matriz1[12].Text) * float.Parse(matriz1[21].Text) * float.Parse(matriz1[33].Text);
               
            }
            else
            {
                 a = multis["11"] * multis["22"] * multis["33"];
                 b = multis["12"] * multis["23"] * multis["31"];
                 c = multis["13"] * multis["21"] * multis["32"];
                 d = multis["13"] * multis["22"] * multis["31"];
                 e = multis["11"] * multis["23"] * multis["32"];
                 f = multis["12"] * multis["21"] * multis["33"];
            }
                float result = (a + b + c) - (d + e + f);
                Console.WriteLine(result);

                TextBox textBoxC = new TextBox();
                textBoxC.Location = new System.Drawing.Point(795, 95);
                textBoxC.Size = new System.Drawing.Size(31, 20);
                textBoxC.Text = result.ToString();
                this.Controls.Add(textBoxC);
                matriz3.Add(11, textBoxC);
           
        }
        private void Chio()
        {
            float a = 1 / float.Parse(matriz1[11].Text);
            for (int i = 1; i <= Convert.ToInt32(comboBox1.Text); i++){   
		        for (int j = 1; j <= Convert.ToInt32(comboBox2.Text); j++)
		        {
			        if(i == 1)
			        {
				        float b = float.Parse(matriz1[Convert.ToInt32(i.ToString()+j.ToString())].Text) * a;
                        Console.WriteLine("Multiplicador: "  + a.ToString() +" = "+ b.ToString());
			        }
			        else if(j != 1 )
			        {
				        multis.Add((i-1).ToString()+(j-1).ToString(),float.Parse(matriz1 [Convert.ToInt32(i.ToString()+j.ToString())].Text) -((float.Parse(matriz1[Convert.ToInt32("1"+ j.ToString())].Text)* (float.Parse(matriz1[Convert.ToInt32(i.ToString() + "1")].Text)))));
                        Console.WriteLine("Adicionou ao elemento: " + (i - 1).ToString() + (j - 1).ToString());
                        Console.WriteLine(float.Parse(matriz1[Convert.ToInt32(i.ToString() + j.ToString())].Text) - ((float.Parse(matriz1[Convert.ToInt32("1" + j.ToString())].Text) * (float.Parse(matriz1[Convert.ToInt32(i.ToString() + "1")].Text)))));
                    }
		        }
	        }
            chio = true;
           
            determinante();
        }
    }
    
}


