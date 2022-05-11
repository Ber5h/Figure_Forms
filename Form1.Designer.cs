
namespace Четырехугольники
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Rectangle = new System.Windows.Forms.RadioButton();
            this.Romb = new System.Windows.Forms.RadioButton();
            this.Create_Figure = new System.Windows.Forms.GroupBox();
            this.redact = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.sm_or_grad = new System.Windows.Forms.Label();
            this.sm = new System.Windows.Forms.Label();
            this.height_text = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.Label();
            this.width_text = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.Label();
            this.Figure_charact = new System.Windows.Forms.GroupBox();
            this.exception = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.Label();
            this.area_output = new System.Windows.Forms.Label();
            this.sm_area = new System.Windows.Forms.Label();
            this.perimetr = new System.Windows.Forms.Label();
            this.sm_perimetr = new System.Windows.Forms.Label();
            this.perimetr_output = new System.Windows.Forms.Label();
            this.diagonal = new System.Windows.Forms.Label();
            this.diagonal_output = new System.Windows.Forms.Label();
            this.sm_diagonal = new System.Windows.Forms.Label();
            this.isQuare = new System.Windows.Forms.Label();
            this.isQuare_output = new System.Windows.Forms.Label();
            this.Create_Figure.SuspendLayout();
            this.Figure_charact.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Какую фигуру создать?";
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.Location = new System.Drawing.Point(12, 48);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(114, 17);
            this.Rectangle.TabIndex = 1;
            this.Rectangle.TabStop = true;
            this.Rectangle.Text = "Параллелограмм";
            this.Rectangle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Romb
            // 
            this.Romb.AutoSize = true;
            this.Romb.Location = new System.Drawing.Point(161, 48);
            this.Romb.Name = "Romb";
            this.Romb.Size = new System.Drawing.Size(52, 17);
            this.Romb.TabIndex = 2;
            this.Romb.TabStop = true;
            this.Romb.Text = "Ромб";
            this.Romb.UseVisualStyleBackColor = true;
            this.Romb.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Create_Figure
            // 
            this.Create_Figure.Controls.Add(this.redact);
            this.Create_Figure.Controls.Add(this.create);
            this.Create_Figure.Controls.Add(this.sm_or_grad);
            this.Create_Figure.Controls.Add(this.sm);
            this.Create_Figure.Controls.Add(this.height_text);
            this.Create_Figure.Controls.Add(this.height);
            this.Create_Figure.Controls.Add(this.width_text);
            this.Create_Figure.Controls.Add(this.width);
            this.Create_Figure.Location = new System.Drawing.Point(15, 83);
            this.Create_Figure.Name = "Create_Figure";
            this.Create_Figure.Size = new System.Drawing.Size(424, 384);
            this.Create_Figure.TabIndex = 3;
            this.Create_Figure.TabStop = false;
            this.Create_Figure.Text = " ";
            // 
            // redact
            // 
            this.redact.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redact.Location = new System.Drawing.Point(68, 267);
            this.redact.Name = "redact";
            this.redact.Size = new System.Drawing.Size(276, 100);
            this.redact.TabIndex = 7;
            this.redact.Text = "Редактировать фигуру";
            this.redact.UseVisualStyleBackColor = true;
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create.Location = new System.Drawing.Point(68, 158);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(276, 103);
            this.create.TabIndex = 6;
            this.create.Text = "Создать фигуру";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // sm_or_grad
            // 
            this.sm_or_grad.AutoSize = true;
            this.sm_or_grad.Location = new System.Drawing.Point(350, 115);
            this.sm_or_grad.Name = "sm_or_grad";
            this.sm_or_grad.Size = new System.Drawing.Size(21, 13);
            this.sm_or_grad.TabIndex = 5;
            this.sm_or_grad.Text = "см";
            // 
            // sm
            // 
            this.sm.AutoSize = true;
            this.sm.Location = new System.Drawing.Point(350, 44);
            this.sm.Name = "sm";
            this.sm.Size = new System.Drawing.Size(21, 13);
            this.sm.TabIndex = 4;
            this.sm.Text = "см";
            // 
            // height_text
            // 
            this.height_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.height_text.Location = new System.Drawing.Point(189, 84);
            this.height_text.Name = "height_text";
            this.height_text.Size = new System.Drawing.Size(155, 44);
            this.height_text.TabIndex = 3;
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.height.Location = new System.Drawing.Point(13, 91);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(142, 37);
            this.height.TabIndex = 2;
            this.height.Text = "Высота: ";
            // 
            // width_text
            // 
            this.width_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.width_text.Location = new System.Drawing.Point(189, 13);
            this.width_text.Name = "width_text";
            this.width_text.Size = new System.Drawing.Size(155, 44);
            this.width_text.TabIndex = 1;
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.width.Location = new System.Drawing.Point(6, 16);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(159, 37);
            this.width.TabIndex = 0;
            this.width.Text = "Сторона: ";
            // 
            // Figure_charact
            // 
            this.Figure_charact.Controls.Add(this.isQuare_output);
            this.Figure_charact.Controls.Add(this.isQuare);
            this.Figure_charact.Controls.Add(this.sm_diagonal);
            this.Figure_charact.Controls.Add(this.diagonal_output);
            this.Figure_charact.Controls.Add(this.diagonal);
            this.Figure_charact.Controls.Add(this.perimetr_output);
            this.Figure_charact.Controls.Add(this.sm_perimetr);
            this.Figure_charact.Controls.Add(this.perimetr);
            this.Figure_charact.Controls.Add(this.sm_area);
            this.Figure_charact.Controls.Add(this.area_output);
            this.Figure_charact.Controls.Add(this.area);
            this.Figure_charact.Location = new System.Drawing.Point(476, 83);
            this.Figure_charact.Name = "Figure_charact";
            this.Figure_charact.Size = new System.Drawing.Size(450, 384);
            this.Figure_charact.TabIndex = 4;
            this.Figure_charact.TabStop = false;
            this.Figure_charact.Text = " ";
            // 
            // exception
            // 
            this.exception.AutoSize = true;
            this.exception.Location = new System.Drawing.Point(381, 20);
            this.exception.Name = "exception";
            this.exception.Size = new System.Drawing.Size(10, 13);
            this.exception.TabIndex = 5;
            this.exception.Text = " ";
            // 
            // area
            // 
            this.area.AutoSize = true;
            this.area.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.area.Location = new System.Drawing.Point(6, 16);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(161, 37);
            this.area.TabIndex = 0;
            this.area.Text = "Площадь: ";
            // 
            // area_output
            // 
            this.area_output.AutoSize = true;
            this.area_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.area_output.Location = new System.Drawing.Point(173, 16);
            this.area_output.Name = "area_output";
            this.area_output.Size = new System.Drawing.Size(102, 37);
            this.area_output.TabIndex = 1;
            this.area_output.Text = "label2";
            // 
            // sm_area
            // 
            this.sm_area.AutoSize = true;
            this.sm_area.Location = new System.Drawing.Point(281, 34);
            this.sm_area.Name = "sm_area";
            this.sm_area.Size = new System.Drawing.Size(33, 13);
            this.sm_area.TabIndex = 2;
            this.sm_area.Text = "см^2";
            // 
            // perimetr
            // 
            this.perimetr.AutoSize = true;
            this.perimetr.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perimetr.Location = new System.Drawing.Point(6, 91);
            this.perimetr.Name = "perimetr";
            this.perimetr.Size = new System.Drawing.Size(179, 37);
            this.perimetr.TabIndex = 3;
            this.perimetr.Text = "Периметр: ";
            // 
            // sm_perimetr
            // 
            this.sm_perimetr.AutoSize = true;
            this.sm_perimetr.Location = new System.Drawing.Point(281, 109);
            this.sm_perimetr.Name = "sm_perimetr";
            this.sm_perimetr.Size = new System.Drawing.Size(21, 13);
            this.sm_perimetr.TabIndex = 4;
            this.sm_perimetr.Text = "см";
            // 
            // perimetr_output
            // 
            this.perimetr_output.AutoSize = true;
            this.perimetr_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perimetr_output.Location = new System.Drawing.Point(173, 91);
            this.perimetr_output.Name = "perimetr_output";
            this.perimetr_output.Size = new System.Drawing.Size(102, 37);
            this.perimetr_output.TabIndex = 5;
            this.perimetr_output.Text = "label3";
            // 
            // diagonal
            // 
            this.diagonal.AutoSize = true;
            this.diagonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diagonal.Location = new System.Drawing.Point(6, 158);
            this.diagonal.Name = "diagonal";
            this.diagonal.Size = new System.Drawing.Size(184, 37);
            this.diagonal.TabIndex = 6;
            this.diagonal.Text = "Диагональ: ";
            // 
            // diagonal_output
            // 
            this.diagonal_output.AutoSize = true;
            this.diagonal_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diagonal_output.Location = new System.Drawing.Point(173, 158);
            this.diagonal_output.Name = "diagonal_output";
            this.diagonal_output.Size = new System.Drawing.Size(102, 37);
            this.diagonal_output.TabIndex = 7;
            this.diagonal_output.Text = "label2";
            // 
            // sm_diagonal
            // 
            this.sm_diagonal.AutoSize = true;
            this.sm_diagonal.Location = new System.Drawing.Point(281, 176);
            this.sm_diagonal.Name = "sm_diagonal";
            this.sm_diagonal.Size = new System.Drawing.Size(21, 13);
            this.sm_diagonal.TabIndex = 8;
            this.sm_diagonal.Text = "см";
            // 
            // isQuare
            // 
            this.isQuare.AutoSize = true;
            this.isQuare.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isQuare.Location = new System.Drawing.Point(13, 247);
            this.isQuare.Name = "isQuare";
            this.isQuare.Size = new System.Drawing.Size(102, 37);
            this.isQuare.TabIndex = 9;
            this.isQuare.Text = "label2";
            // 
            // isQuare_output
            // 
            this.isQuare_output.AutoSize = true;
            this.isQuare_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isQuare_output.Location = new System.Drawing.Point(132, 247);
            this.isQuare_output.Name = "isQuare_output";
            this.isQuare_output.Size = new System.Drawing.Size(312, 37);
            this.isQuare_output.TabIndex = 10;
            this.isQuare_output.Text = "Является квадратом";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 530);
            this.Controls.Add(this.exception);
            this.Controls.Add(this.Figure_charact);
            this.Controls.Add(this.Create_Figure);
            this.Controls.Add(this.Romb);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Четырехугольники";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Create_Figure.ResumeLayout(false);
            this.Create_Figure.PerformLayout();
            this.Figure_charact.ResumeLayout(false);
            this.Figure_charact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Rectangle;
        private System.Windows.Forms.RadioButton Romb;
        private System.Windows.Forms.GroupBox Create_Figure;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.TextBox width_text;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.Label sm_or_grad;
        private System.Windows.Forms.Label sm;
        private System.Windows.Forms.TextBox height_text;
        private System.Windows.Forms.Button redact;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.GroupBox Figure_charact;
        private System.Windows.Forms.Label sm_area;
        private System.Windows.Forms.Label area_output;
        private System.Windows.Forms.Label area;
        private System.Windows.Forms.Label exception;
        private System.Windows.Forms.Label perimetr_output;
        private System.Windows.Forms.Label sm_perimetr;
        private System.Windows.Forms.Label perimetr;
        private System.Windows.Forms.Label sm_diagonal;
        private System.Windows.Forms.Label diagonal_output;
        private System.Windows.Forms.Label diagonal;
        private System.Windows.Forms.Label isQuare_output;
        private System.Windows.Forms.Label isQuare;
    }
}

