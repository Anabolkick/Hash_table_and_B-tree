
using System.Drawing;

namespace lab_2_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.create_date_btn = new System.Windows.Forms.Button();
            this.find_date_btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.create_check_btn = new System.Windows.Forms.Button();
            this.temperature = new System.Windows.Forms.RadioButton();
            this.humidity = new System.Windows.Forms.RadioButton();
            this.pressure = new System.Windows.Forms.RadioButton();
            this.precipitation = new System.Windows.Forms.RadioButton();
            this.find_check_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.prec_lvl_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // create_date_btn
            // 
            this.create_date_btn.Location = new System.Drawing.Point(349, 28);
            this.create_date_btn.Name = "create_date_btn";
            this.create_date_btn.Size = new System.Drawing.Size(139, 23);
            this.create_date_btn.TabIndex = 0;
            this.create_date_btn.Text = "Create from dates";
            this.create_date_btn.UseVisualStyleBackColor = true;
            this.create_date_btn.Click += new System.EventHandler(this.create_date_btn_Click);
            // 
            // find_date_btn
            // 
            this.find_date_btn.Location = new System.Drawing.Point(367, 122);
            this.find_date_btn.Name = "find_date_btn";
            this.find_date_btn.Size = new System.Drawing.Size(109, 32);
            this.find_date_btn.TabIndex = 2;
            this.find_date_btn.Text = "Вивести за датою";
            this.find_date_btn.UseVisualStyleBackColor = true;
            this.find_date_btn.Click += new System.EventHandler(this.find_date_btn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(320, 91);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2021, 11, 3, 0, 0, 0, 0);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "0";
            // 
            // create_check_btn
            // 
            this.create_check_btn.Location = new System.Drawing.Point(55, 28);
            this.create_check_btn.Name = "create_check_btn";
            this.create_check_btn.Size = new System.Drawing.Size(139, 23);
            this.create_check_btn.TabIndex = 6;
            this.create_check_btn.Text = "Create from checkbox ";
            this.create_check_btn.UseVisualStyleBackColor = true;
            this.create_check_btn.Click += new System.EventHandler(this.create_check_btn_Click);
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Checked = true;
            this.temperature.Location = new System.Drawing.Point(76, 75);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(85, 17);
            this.temperature.TabIndex = 7;
            this.temperature.TabStop = true;
            this.temperature.Text = "Temperature";
            this.temperature.UseVisualStyleBackColor = true;
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.Location = new System.Drawing.Point(76, 99);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(65, 17);
            this.humidity.TabIndex = 8;
            this.humidity.TabStop = true;
            this.humidity.Text = "Humidity";
            this.humidity.UseVisualStyleBackColor = true;
            // 
            // pressure
            // 
            this.pressure.AutoSize = true;
            this.pressure.Location = new System.Drawing.Point(76, 122);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(66, 17);
            this.pressure.TabIndex = 9;
            this.pressure.TabStop = true;
            this.pressure.Text = "Pressure";
            this.pressure.UseVisualStyleBackColor = true;
            // 
            // precipitation
            // 
            this.precipitation.AutoSize = true;
            this.precipitation.Location = new System.Drawing.Point(77, 145);
            this.precipitation.Name = "precipitation";
            this.precipitation.Size = new System.Drawing.Size(108, 17);
            this.precipitation.TabIndex = 10;
            this.precipitation.TabStop = true;
            this.precipitation.Text = "Precipitation level";
            this.precipitation.UseVisualStyleBackColor = true;
            // 
            // find_check_btn
            // 
            this.find_check_btn.Location = new System.Drawing.Point(76, 246);
            this.find_check_btn.Name = "find_check_btn";
            this.find_check_btn.Size = new System.Drawing.Size(75, 23);
            this.find_check_btn.TabIndex = 11;
            this.find_check_btn.Text = "Вивести";
            this.find_check_btn.UseVisualStyleBackColor = true;
            this.find_check_btn.Click += new System.EventHandler(this.find_check_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 12;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Створити дерево з дат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Створити дерево з обраної властивості";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Вивести погоду за зазначеним днем";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Вивести погоду за значенням обраної властивості";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(561, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 276);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вивід структури";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(701, 257);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // prec_lvl_btn
            // 
            this.prec_lvl_btn.Location = new System.Drawing.Point(320, 217);
            this.prec_lvl_btn.Name = "prec_lvl_btn";
            this.prec_lvl_btn.Size = new System.Drawing.Size(207, 23);
            this.prec_lvl_btn.TabIndex = 20;
            this.prec_lvl_btn.Text = "Знайти найвищий рівень опадів ";
            this.prec_lvl_btn.UseVisualStyleBackColor = true;
            this.prec_lvl_btn.Click += new System.EventHandler(this.prec_lvl_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 339);
            this.Controls.Add(this.prec_lvl_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.find_check_btn);
            this.Controls.Add(this.precipitation);
            this.Controls.Add(this.pressure);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.create_check_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.find_date_btn);
            this.Controls.Add(this.create_date_btn);
            this.Name = "Form1";
            this.Text = "Galysh_2_2";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_date_btn;
        private System.Windows.Forms.Button find_date_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button create_check_btn;
        private System.Windows.Forms.RadioButton temperature;
        private System.Windows.Forms.RadioButton humidity;
        private System.Windows.Forms.RadioButton pressure;
        private System.Windows.Forms.RadioButton precipitation;
        private System.Windows.Forms.Button find_check_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button prec_lvl_btn;
    }
}

