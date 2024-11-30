using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            string[] sides = { "Разностороний", "Равнобедренный", "Равностороний" };
            string[] sidesAngle = { "Остроугольный", "Тупоугольный", "Прямоугольный" }; 
            
            int index = 0;
            int indexAngle = 0; 
            bool check = true;
            //значение не должны быть ниже  0 или быть 0
            if (a <= 0 ||  b <= 0 || c <= 0) 
            {
                MessageBox.Show("Стороны не должны быть равны 0");
                check = false;
            }
            //проверка на существование треугольника (сумму двух сторон должна быть больше третей)
            if (a + b <= c || c + b <= a || a + c <= b) 
            {
                MessageBox.Show("Треугольник с такими сторонами не существует");
                check = false;
            }
            if (a == b || b == c || a == c) 
            {
                index = 1;
            }
            

            if(a == b && b == c)
                index = 2;
            
            //полупериметр для расчета площади
            double p = (a + b + c) / 2.0;
            //Площадь
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            //расчет углов по теореме косинусов
            double A, B, C;

            A = Math.Acos((b*b+c*c - a * a) / (2*b*c));

            B = Math.Acos(( c * c + a * a- b * b) / (2 * a * c));

            C = Math.Acos((a * a + b * b - c * c ) / (2 * a * b));

            //преобразование из радионов в радиусы
            A = Math.Round(A*(180.0/Math.PI),0);

            B = Math.Round(B * (180.0/ Math.PI), 0);

            C = Math.Round(C * (180.0/ Math.PI),0);    

            //проверка на вид треугольника

            if (A > 90 || B > 90 || C > 90)
                indexAngle = 1;
            if (A == 90 || B == 90 || C == 90)
                indexAngle = 2;

            //вывод если треугольник получилось создать
            if (check)
                MessageBox.Show($"Треугольник: {sides[index]}\nПлощадь S = {S}\n" +
                                $"Треугольник: {sidesAngle[indexAngle]}\nуглы: A= {A}, B= {B}, C= {C}");

            
        }
    }
}
