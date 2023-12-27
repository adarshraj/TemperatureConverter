namespace Temperature_Converter
{
    partial class TempConverter
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
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtFahren = new System.Windows.Forms.TextBox();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.txtRankin = new System.Windows.Forms.TextBox();
            this.txtReamur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(77, 15);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(188, 21);
            this.txtCelsius.TabIndex = 0;
            this.txtCelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCelsius.TextChanged += new System.EventHandler(this.txtCelsius_TextChanged);
            this.txtCelsius.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtCelsius_MouseDown);
            // 
            // txtFahren
            // 
            this.txtFahren.Location = new System.Drawing.Point(77, 41);
            this.txtFahren.Name = "txtFahren";
            this.txtFahren.Size = new System.Drawing.Size(188, 21);
            this.txtFahren.TabIndex = 1;
            this.txtFahren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFahren.TextChanged += new System.EventHandler(this.txtFahren_TextChanged);
            this.txtFahren.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtFahren_MouseDown);
            // 
            // txtKelvin
            // 
            this.txtKelvin.Location = new System.Drawing.Point(77, 67);
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(188, 21);
            this.txtKelvin.TabIndex = 2;
            this.txtKelvin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKelvin.TextChanged += new System.EventHandler(this.txtKelvin_TextChanged);
            this.txtKelvin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtKelvin_MouseDown);
            // 
            // txtRankin
            // 
            this.txtRankin.Location = new System.Drawing.Point(77, 93);
            this.txtRankin.Name = "txtRankin";
            this.txtRankin.Size = new System.Drawing.Size(188, 21);
            this.txtRankin.TabIndex = 3;
            this.txtRankin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRankin.TextChanged += new System.EventHandler(this.txtRankin_TextChanged);
            this.txtRankin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtRankin_MouseDown);
            // 
            // txtReamur
            // 
            this.txtReamur.Location = new System.Drawing.Point(77, 119);
            this.txtReamur.Name = "txtReamur";
            this.txtReamur.Size = new System.Drawing.Size(188, 21);
            this.txtReamur.TabIndex = 4;
            this.txtReamur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtReamur.TextChanged += new System.EventHandler(this.txtReamur_TextChanged);
            this.txtReamur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtReamur_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "°Celsius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "°Fahrenheit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kelvin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "°Rankine";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Reaumur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(245, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Wax";
            // 
            // TempConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 152);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReamur);
            this.Controls.Add(this.txtRankin);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.txtFahren);
            this.Controls.Add(this.txtCelsius);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TempConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Converter";
            this.Load += new System.EventHandler(this.TempConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtFahren;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.TextBox txtRankin;
        private System.Windows.Forms.TextBox txtReamur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

