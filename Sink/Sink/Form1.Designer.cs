
namespace Sink
{
    partial class SinkForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SinkParameters = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.WidthSink = new System.Windows.Forms.Label();
            this.Dsink = new System.Windows.Forms.Label();
            this.Hsink = new System.Windows.Forms.Label();
            this.Rsink = new System.Windows.Forms.Label();
            this.R1sink = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SinkParameters)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SinkParameters);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.R1sink);
            this.splitContainer1.Panel2.Controls.Add(this.Rsink);
            this.splitContainer1.Panel2.Controls.Add(this.Hsink);
            this.splitContainer1.Panel2.Controls.Add(this.Dsink);
            this.splitContainer1.Panel2.Controls.Add(this.WidthSink);
            this.splitContainer1.Panel2.Controls.Add(this.textBox5);
            this.splitContainer1.Panel2.Controls.Add(this.textBox4);
            this.splitContainer1.Panel2.Controls.Add(this.textBox3);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 404;
            this.splitContainer1.TabIndex = 0;
            // 
            // SinkParameters
            // 
            this.SinkParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SinkParameters.BackgroundImage = global::Sink.Properties.Resources.чертеж;
            this.SinkParameters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SinkParameters.Location = new System.Drawing.Point(3, 3);
            this.SinkParameters.Name = "SinkParameters";
            this.SinkParameters.Size = new System.Drawing.Size(398, 444);
            this.SinkParameters.TabIndex = 0;
            this.SinkParameters.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(25, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(25, 146);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(25, 108);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            // 
            // WidthSink
            // 
            this.WidthSink.AutoSize = true;
            this.WidthSink.Location = new System.Drawing.Point(162, 36);
            this.WidthSink.Name = "WidthSink";
            this.WidthSink.Size = new System.Drawing.Size(113, 13);
            this.WidthSink.TabIndex = 5;
            this.WidthSink.Text = "Ширина раковины W";
            // 
            // Dsink
            // 
            this.Dsink.AutoSize = true;
            this.Dsink.Location = new System.Drawing.Point(162, 74);
            this.Dsink.Name = "Dsink";
            this.Dsink.Size = new System.Drawing.Size(104, 13);
            this.Dsink.TabIndex = 6;
            this.Dsink.Text = "Длина раковины D";
            // 
            // Hsink
            // 
            this.Hsink.AutoSize = true;
            this.Hsink.Location = new System.Drawing.Point(162, 111);
            this.Hsink.Name = "Hsink";
            this.Hsink.Size = new System.Drawing.Size(112, 13);
            this.Hsink.TabIndex = 7;
            this.Hsink.Text = "Глубина раковины Н";
            // 
            // Rsink
            // 
            this.Rsink.AutoSize = true;
            this.Rsink.Location = new System.Drawing.Point(162, 149);
            this.Rsink.Name = "Rsink";
            this.Rsink.Size = new System.Drawing.Size(169, 13);
            this.Rsink.TabIndex = 8;
            this.Rsink.Text = "Диаметр сливного отверстия R";
            // 
            // R1sink
            // 
            this.R1sink.AutoSize = true;
            this.R1sink.Location = new System.Drawing.Point(162, 190);
            this.R1sink.Name = "R1sink";
            this.R1sink.Size = new System.Drawing.Size(173, 13);
            this.R1sink.TabIndex = 9;
            this.R1sink.Text = "Диаметр отверстия под кран R1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 62);
            this.button1.TabIndex = 10;
            this.button1.Text = "Построить ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Примечание: все значения вводятся в мм!";
            // 
            // SinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SinkForm";
            this.Text = "SinkForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SinkParameters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox SinkParameters;
        private System.Windows.Forms.Label R1sink;
        private System.Windows.Forms.Label Rsink;
        private System.Windows.Forms.Label Hsink;
        private System.Windows.Forms.Label Dsink;
        private System.Windows.Forms.Label WidthSink;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

