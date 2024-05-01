using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab3
{
    partial class Form1_Load
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Добавляем новые текстовые поля для вывода результатов
        private System.Windows.Forms.TextBox txtEllipseArea;
        private System.Windows.Forms.TextBox txtHyperbolaArea;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();

            // Добавляем новые текстовые поля для вывода результатов
            txtEllipseArea = new System.Windows.Forms.TextBox();
            txtHyperbolaArea = new System.Windows.Forms.TextBox();

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 471);
            Name = "Form1";
            Text = "Geometry Calculator";

            // Добавляем текстовые поля на форму
            Controls.Add(txtEllipseArea);
            Controls.Add(txtHyperbolaArea);

            // Назначаем положение и размеры текстовых полей
            txtEllipseArea.Location = new System.Drawing.Point(50, 50);
            txtEllipseArea.Size = new System.Drawing.Size(200, 30);

            txtHyperbolaArea.Location = new System.Drawing.Point(50, 100);
            txtHyperbolaArea.Size = new System.Drawing.Size(200, 30);

            // Добавляем обработчик события загрузки формы
            Load += Form_Load;

            ResumeLayout(false);
        }

        #endregion
    }
}
