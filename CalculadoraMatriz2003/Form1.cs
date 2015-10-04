using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMatriz2003
{
    public partial class Form1 : Form
    {

        public Dictionary<int, TextBox> matriz1 = new Dictionary<int, TextBox>();
        public Dictionary<int, TextBox> matriz2 = new Dictionary<int, TextBox>();
        public Dictionary<int, TextBox> matriz3 = new Dictionary<int, TextBox>();
        public Dictionary<string, float> multis = new Dictionary<string, float>();
        public Dictionary<string, TextBox> plano = new Dictionary<string, TextBox>();
        public float value = 0;
        public int chioX = 0;
        float a;
        float b;
        float c;
        float d;
        float e;
        float f;
        float multiplicador;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int j = 1; j <= Convert.ToInt32(comboBox2.Text); j++)
            {
                for (int i = 1; i <= Convert.ToInt32(comboBox1.Text); i++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Location = new System.Drawing.Point((32 * j) - 8, 18 + 22 * i);
                    textBox.Size = new System.Drawing.Size(31, 20);
                    textBox.Text = "0";
                    this.tabPage1.Controls.Add(textBox);
                    matriz1.Add(Convert.ToInt32(i.ToString() + j.ToString()), textBox);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int j = 1; j <= Convert.ToInt32(comboBox3.Text); j++)
            {
                for (int i = 1; i <= Convert.ToInt32(comboBox4.Text); i++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Location = new System.Drawing.Point(430 + 32 * j, 18 + 22 * i);
                    textBox.Size = new System.Drawing.Size(31, 20);
                    textBox.Text = "0";
                    this.tabPage1.Controls.Add(textBox);
                    matriz2.Add(Convert.ToInt32(i.ToString() + j.ToString()), textBox);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {




           
                for (int j = 1; j <= Convert.ToInt32(comboBox1.Text); j++)
                {
                    for (int i = 1; i <= Convert.ToInt32(comboBox1.Text); i++)
                    {
                        this.Controls.Remove(matriz3[Convert.ToInt32(j.ToString() + i.ToString())]);
                        this.Controls.RemoveByKey("result");
                        matriz3.Remove(Convert.ToInt32(j.ToString() + i.ToString()));
                    }
                }






                for (int j = 1; j <= Convert.ToInt32(comboBox1.Text); j++)
                {
                    for (int i = 1; i <= Convert.ToInt32(comboBox2.Text); i++)
                    {
                        TextBox textBox = new TextBox();
                        textBox.Location = new System.Drawing.Point((32 * j) - 18, 280 + 22 * i);
                        textBox.Size = new System.Drawing.Size(31, 20);
                        this.tabPage1.Controls.Add(textBox);
                        textBox.Text = "0";
                        float a = float.Parse(matriz1[Convert.ToInt32(j.ToString() + i.ToString())].Text);
                        float b = float.Parse(matriz2[Convert.ToInt32(j.ToString() + i.ToString())].Text);
                        float c = a + b;
                        textBox.Text = c.ToString();
                        matriz3.Add(Convert.ToInt32(i.ToString() + j.ToString()), textBox);
                        Console.Write("Somou");

                    }
                }


            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1 == comboBox3 && comboBox2 == comboBox4)
            {
                for (int j = 1; j <= Convert.ToInt32(comboBox1.Text); j++)
                {
                    for (int i = 1; i <= Convert.ToInt32(comboBox2.Text); i++)
                    {
                        TextBox textBox = new TextBox();
                        textBox.Location = new System.Drawing.Point((32 * j) - 18, 200 + 22 * i);
                        textBox.Size = new System.Drawing.Size(31, 20);
                        this.tabPage1.Controls.Add(textBox);
                        float a = float.Parse(matriz1[Convert.ToInt32(j.ToString() + i.ToString())].Text);
                        float b = float.Parse(matriz2[Convert.ToInt32(j.ToString() + i.ToString())].Text);
                        float c = a - b;
                        textBox.Text = c.ToString();
                        matriz3.Add(Convert.ToInt32(i.ToString() + j.ToString()), textBox);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (comboBox1 != comboBox2)
            {
                MessageBox.Show("O número de colunas da primeira deve ser igual ao número de linhas da segunda");

            }
            else
            for (int j = 1; j <= Convert.ToInt32(comboBox1.Text); j++)
            {
                for (int i = 1; i <= Convert.ToInt32(comboBox3.Text); i++)
                {
                    for (int x = 1; x <= Convert.ToInt32(comboBox4.Text); x++)
                    {
                        float a = float.Parse(matriz1[Convert.ToInt32(j.ToString() + x.ToString())].Text);
                        float b = float.Parse(matriz2[Convert.ToInt32(x.ToString() + i.ToString())].Text);
                        value += a * b;
                    }
                    TextBox textBoxC = new TextBox();
                    textBoxC.Location = new System.Drawing.Point((32 * j) - 18, 200 + 22 * i);
                    textBoxC.Size = new System.Drawing.Size(31, 20);
                    textBoxC.Text = value.ToString();
                    this.tabPage1.Controls.Add(textBoxC);
                    matriz3.Add(Convert.ToInt32(i.ToString() + j.ToString()), textBoxC);
                    value = 0;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (matriz1.Count > 9) Chio();
            else determinante();
        }

        private void determinante()
        {
            if (chioX < 1)
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
            if (chioX > 1)
            {
                result *= multiplicador;
            }
            if (result == float.NaN || float.IsNaN(result))
            {
                result = 0;
            }
            TextBox textBoxC = new TextBox();
            textBoxC.Location = new System.Drawing.Point(795, 95);
            textBoxC.Size = new System.Drawing.Size(31, 20);
            textBoxC.Text = result.ToString();
            this.tabPage1.Controls.Add(textBoxC);
            matriz3.Add(11, textBoxC);

        }

        private void Chio()
        {
            Dictionary<string, float> atual = new Dictionary<string, float>();

            if (chioX < 1)
            {
                for (int j = 1; j <= Convert.ToInt32(comboBox1.Text); j++)
                {
                    for (int i = 1; i <= Convert.ToInt32(comboBox2.Text); i++)
                    {
                        atual.Add(j.ToString() + i.ToString(), float.Parse(matriz1[Convert.ToInt32(j.ToString() + i.ToString())].Text));
                    }
                }
            }
            else
            {
                for (int j = 1; j <= multis.Count / (Convert.ToInt32(comboBox1.Text) - chioX); j++)
                {
                    for (int i = 1; i <= multis.Count / (Convert.ToInt32(comboBox2.Text) - chioX); i++)
                    {
                        atual.Add(j.ToString() + i.ToString(), multis[j.ToString() + i.ToString()]);
                    }
                }

                multis.Clear();
            }

            multiplicador = 1 / atual["11"];

            for (int i = 1; i <= Convert.ToInt32(comboBox1.Text) - chioX; i++)
            {
                for (int j = 1; j <= Convert.ToInt32(comboBox2.Text) - chioX; j++)
                {

                    if (i == 1)
                    {
                        float b = atual[i.ToString() + j.ToString()] * multiplicador;
                    }
                    else if (j != 1)
                    {
                        multis.Add((i - 1).ToString() + (j - 1).ToString(), atual[i.ToString() + j.ToString()] - atual["1" + j.ToString()] * atual[i.ToString() + "1"]);
                    }
                }
            }

            chioX += 1;

            if (multis.Count > 9) Chio();
            else determinante();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (plano.Count > 0)
            {
                for (int j = 1; j < 3; j++)
                {
                    for (int i = 1; i <= plano.Count / 2 + 1; i++)
                    {
                        plano.Remove(j.ToString() + i.ToString());
                    }
                }
            }
            for (int j = 1; j < 3; j++)
            {
                for (int i = 1; i <= Convert.ToInt32(comboBox5.Text); i++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Location = new System.Drawing.Point(31 * i + 25, 34 + 25 * j);
                    textBox.Size = new System.Drawing.Size(28, 18);
                    this.tabPage2.Controls.Add(textBox);
                    plano.Add(j.ToString() + i.ToString(), textBox);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            myCanvas1.points.Clear();

            for (int j = 1; j <= plano.Count / 2; j++)
            {
                if (plano["1" + j.ToString()].Text != "" && plano["2" + j.ToString()].Text != "")
                {
                    myCanvas1.points.Add(new Point(Convert.ToInt32(float.Parse(plano["1" + j.ToString()].Text) * 100 + 400), Convert.ToInt32(float.Parse(plano["2" + j.ToString()].Text) * -100 + 200)));
                }
            }

            myCanvas1.Desenhar = true;
        }


        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < myCanvas1.points.Count; i++)
            {
                myCanvas1.points[i] = new Point(Convert.ToInt32(float.Parse(textBox3.Text) * 100 + myCanvas1.points[i].X),
                                                Convert.ToInt32(float.Parse(textBox4.Text) * -100 + myCanvas1.points[i].Y));
            }
            myCanvas1.Desenhar = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            float h = float.Parse(textBox1.Text) * 100;
            for (int i = 1; i <= Convert.ToInt32(comboBox5.Text); i++)
            {
                float g = (float.Parse(plano["1" + i.ToString()].Text) * -1 * -h);
                myCanvas1.points[i - 1] = new Point(Convert.ToInt32(myCanvas1.points[i - 1].X + g), Convert.ToInt32(myCanvas1.points[i - 1].Y + g));
            }
            myCanvas1.Desenhar = true;
        }


    }
}
