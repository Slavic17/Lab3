using System;
using System.Windows.Forms;

namespace GeometryCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
            Label lblA = new Label();
            TextBox txtA = new TextBox();
            Button btnCalculate = new Button();

            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            tableLayoutPanel1.Controls.Add(lblA, 0, 0);
            tableLayoutPanel1.Controls.Add(txtA, 1, 0);
            tableLayoutPanel1.Controls.Add(btnCalculate, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            lblA.Anchor = AnchorStyles.None;
            lblA.AutoSize = true;
            lblA.Text = "a:";
            lblA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            txtA.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtA.Dock = DockStyle.Fill;

            btnCalculate.Anchor = AnchorStyles.None;
            btnCalculate.AutoSize = true;
            btnCalculate.Text = "Calculate";
            btnCalculate.Click += new System.EventHandler(btnCalculate_Click);

            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(300, 200);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Geometry Calculator";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
        
        }
    }
}
