using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr11
{
    public partial class Form1 : Form
    { //Объявляем переменные доступные в каждом обработчике события
        private Point PreviousPoint, point; //Точка до перемещения курсора мыши и текущая точка
        private Bitmap bmp;
        private Pen blackPen;
        private Graphics g;

        private Rectangle randomRectangle;
        private Random random = new Random();
        private Brush color = new SolidBrush(Color.FromArgb(255, 255, 255));
        public int sizeX;
        public int sizeY;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            blackPen = new Pen(Color.Black, 4); //подготавливаем перо для рисования
        }
        private void button1_Click(object sender, EventArgs e)
        { //открытие файла
            OpenFileDialog dialog = new OpenFileDialog(); //описываем и порождаем объект dialog класса OpenFileDialog
                                                          //задаем расширения файлов
            dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF," +
           "*.WMF)| *.bmp; *.jpg; *.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (dialog.ShowDialog() == DialogResult.OK)//вызываем диалоговое окно и проверяем выбран ли файл
            {
                Image image = Image.FromFile(dialog.FileName); //Загружаем в image изображение из выбранного файла
                int width = image.Width;
                int height = image.Height;
                pictureBox1.Width = width;
                pictureBox1.Height = height;
                bmp = new Bitmap(image, width, height); //создаем и загружаем из image изображение в форматье bmp
                pictureBox1.Image = bmp; //записываем изображение в формате bmp в pictureBox1
                g = Graphics.FromImage(pictureBox1.Image); //подготавливаме объект Graphics для рисования в pictureBox1
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        { // обработчик события нажатия кнопки на мыши
          // записываем в предыдущую точку (PreviousPoint) текущие координаты
            PreviousPoint.X = e.X;
            PreviousPoint.Y = e.Y;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {//Обработчик события перемещения мыши по pictuteBox1
            if (e.Button == MouseButtons.Left) //Проверяем нажата ли левая кнопка мыши
            { //запоминаем в point текущее положение курсора мыши
                point.X = e.X;
                point.Y = e.Y;
                //соеденяем линией предыдущую точку с текущей
                g.DrawLine(blackPen, PreviousPoint, point);
                //текущее положение курсора мыши сохраняем в PreviousPoint
                PreviousPoint.X = point.X;
                PreviousPoint.Y = point.Y;
                pictureBox1.Invalidate();//Принудительно вызываем переррисовку pictureBox1
            }
        }
        //код для создания 1000 точек в рандомном месте и цвета
        private void button3_Click(object sender, EventArgs e)
        {
            //получаем размер картины
            sizeX = pictureBox1.Width;
            sizeY = pictureBox1.Height;
            for (int i = 0; i < 1000; i++) 
            {
                //создаем квадрат с рандомной позицией от 0 до размеров картины
                randomRectangle = new Rectangle(random.Next(0,sizeX),random.Next(0,sizeY),5,5);
                //задаем рандомный цвет
                color = new SolidBrush(Color.FromArgb(
                    random.Next(0, 255),
                    random.Next(0, 255),
                    random.Next(0, 255)));
                //создаем зарисованный квадрат
                g.FillRectangle(color,randomRectangle);
                //отображение
                pictureBox1.Invalidate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { //сохранение файла
            SaveFileDialog savedialog = new SaveFileDialog();//описываем и порождаем объект savedialog
                                                             //задаем свойства для savedialog
            savedialog.Title = "Сохранить картинку как ...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter =
            "Bitmap File(*.bmp)|*.bmp|" +
            "GIF File(*.gif)|*.gif|" +
            "JPEG File(*.jpg)|*.jpg|" +
            "TIF File(*.tif)|*.tif|" +
            "PNG File(*.png)|*.png";
            savedialog.ShowHelp = true;
            // If selected, save
            if (savedialog.ShowDialog() == DialogResult.OK)//вызываем диалоговое окно и проверяем задано ли имя файла
            {
                // в строку fileName записываем указанный в savedialog полный путь к файлу
                string fileName = savedialog.FileName;
                // Убираем из имени три последних символа (расширение файла)
                string strFilExtn =
                fileName.Remove(0, fileName.Length - 3);
                // Сохраняем файл в нужном формате и с нужным расширением
                switch (strFilExtn)
                {
                    case "bmp":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "tif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
