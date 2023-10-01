
namespace Drawing
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Rectangle = new System.Windows.Forms.ToolStripButton();
            this.Circle = new System.Windows.Forms.ToolStripButton();
            this.Triangle = new System.Windows.Forms.ToolStripButton();
            this.lineColor = new System.Windows.Forms.ToolStripButton();
            this.fillColor = new System.Windows.Forms.ToolStripButton();
            this.Select = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.Rectangle, this.Circle, this.Triangle, this.lineColor, this.fillColor, this.Select });
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(718, 47);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // Rectangle
            // 
            this.Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("Rectangle.Image")));
            this.Rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(44, 44);
            this.Rectangle.Text = "Квадрат";
            // 
            // Circle
            // 
            this.Circle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Circle.Image = ((System.Drawing.Image)(resources.GetObject("Circle.Image")));
            this.Circle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(44, 44);
            this.Circle.Text = "Круг";
            // 
            // Triangle
            // 
            this.Triangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Triangle.Image = ((System.Drawing.Image)(resources.GetObject("Triangle.Image")));
            this.Triangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(44, 44);
            this.Triangle.Text = "Треугольник";
            // 
            // lineColor
            // 
            this.lineColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineColor.Image = ((System.Drawing.Image)(resources.GetObject("lineColor.Image")));
            this.lineColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineColor.Name = "lineColor";
            this.lineColor.Size = new System.Drawing.Size(44, 44);
            this.lineColor.Text = "Цвет границы";
            // 
            // fillColor
            // 
            this.fillColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillColor.Image = ((System.Drawing.Image)(resources.GetObject("fillColor.Image")));
            this.fillColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillColor.Name = "fillColor";
            this.fillColor.Size = new System.Drawing.Size(44, 44);
            this.fillColor.Text = "Цвет заливки";
            // 
            // Select
            // 
            this.Select.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Select.Image = ((System.Drawing.Image)(resources.GetObject("Select.Image")));
            this.Select.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(44, 44);
            this.Select.Text = "Выбор фигуры";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Загрузить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(419, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "Очистка";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(317, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 476);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Rectangle;
        private System.Windows.Forms.ToolStripButton Circle;
        private System.Windows.Forms.ToolStripButton Triangle;
        private System.Windows.Forms.ToolStripButton lineColor;
        private System.Windows.Forms.ToolStripButton fillColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ToolStripButton Select;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

