﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Form1 : Form
    {

        private string _moveType;
        
        private Color _lineColor = Color.Black;
        private Color _fillColor = Color.White;
        
        
        private ShapeFactory shapeFactory;

        private Shape newShape;

        private Decorator.Decorator decorator;
        private bool moving;
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            _moveType = e.ClickedItem.ToString();
            switch (_moveType)
            {
                case "Круг":
                    shapeFactory = CircleFactory.getCircleFactory();
                    moving = false;
                    Refresh();
                    break;
                case "Квадрат":
                    shapeFactory = RectangleFactory.getRectangleFactory();
                    moving = false;
                    Refresh();
                    break;
                case "Треугольник":
                    shapeFactory = TriangleFactory.getTriangleFactory();
                    moving = false;
                    Refresh();
                    break;
                case "Цвет границы":
                    if (moving)
                    {
                        colorDialog1.ShowDialog();
                        foreach (var item in Collect.getCollection().GetTouched())
                        {
                            item.line = colorDialog1.Color;
                        }
                        Refresh();
                        moving = false;
                    }
                    else
                    {
                        colorDialog1.ShowDialog();
                        _lineColor = colorDialog1.Color;
                    }
                    break;
                case "Цвет заливки":
                    if (moving)
                    {
                        colorDialog2.ShowDialog();
                        foreach (var item in Collect.getCollection().GetTouched())
                        {
                            item.fill = colorDialog2.Color;
                        }
                        Refresh();
                        moving = false;
                    }
                    else
                    {
                        colorDialog2.ShowDialog();
                        _fillColor = colorDialog2.Color;
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
            saveFileDialog1.ShowDialog();
            Collect.getCollection().Save(saveFileDialog1.FileName);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Refresh();
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "openFileDialog1.FileName")
            {
                Collect.getCollection().Load(openFileDialog1.FileName);
                Collect.getCollection().Clear();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Collect.getCollection().Clear();
            Refresh();           
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (moving)
            {
                foreach (var item in Collect.getCollection().GetTouched())
                {
                    Collect.getCollection().Remove(item);
                }
                Collect.getCollection().Remove(decorator);
                Refresh();
                moving = false;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            if (shapeFactory != null && _moveType != null && _moveType != "Выбор фигуры")
            {
                Shape shape = shapeFactory.GetShape(newShape.X, newShape.Y, newShape.Width, newShape.Height, _lineColor, _fillColor);
                Collect.getCollection().Remove(newShape);
                newShape = null;
                Collect.getCollection().Add(shape);
            }
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Collect.getCollection().Draw(e.Graphics);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_moveType == "Выбор фигуры")
            {
                foreach (var iShape in Collect.getCollection().GetTouched())
                {
                    iShape.Touched = false;
                }
                Collect.getCollection().Remove(decorator);
                decorator = null;
                if (Collect.getCollection().Touch(e.X, e.Y) != null && !(Collect.getCollection().Touch(e.X, e.Y) is Decorator.Decorator))
                {
                    Console.WriteLine("START");
                    moving = true;
                    Shape shape = Collect.getCollection().Touch(e.X, e.Y);
                    decorator = new Decorator.Decorator(shape.X, shape.Y,shape.Width, shape.Height, Color.Black, Color.Black);
                    decorator.Assign(shape, e);
                    Collect.getCollection().Add(decorator);
                }
                Refresh();
            }

            if (_moveType != null && _moveType != "Выбор фигуры")
            {
                newShape = shapeFactory.GetShape(e.X, e.Y, 0, 0, _lineColor, _fillColor);
                Collect.getCollection().Add(newShape);
            }
            Refresh();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && e.Button == MouseButtons.Left)
            {
                decorator.Drag(e.X, e.Y);
            }

            if (newShape != null && _moveType != "Выбор фигуры")
            {
                newShape.Width = e.X - newShape.X;
                newShape.Height = e.Y - newShape.Y;
            }
            Refresh();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {

            }
        }
    }
}