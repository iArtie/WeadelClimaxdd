namespace WeadelClimaxd
{
    partial class FrmClima
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
            this.txtClima = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.labelCd = new System.Windows.Forms.Label();
            this.laberDt = new System.Windows.Forms.Label();
            this.labelSn = new System.Windows.Forms.Label();
            this.labelSun = new System.Windows.Forms.Label();
            this.labelWn = new System.Windows.Forms.Label();
            this.labelPress = new System.Windows.Forms.Label();
            this.picWeather = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClima
            // 
            this.txtClima.Location = new System.Drawing.Point(200, 64);
            this.txtClima.Multiline = true;
            this.txtClima.Name = "txtClima";
            this.txtClima.Size = new System.Drawing.Size(215, 24);
            this.txtClima.TabIndex = 0;
            this.txtClima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClima_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ciudad";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(449, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // labelCd
            // 
            this.labelCd.AutoSize = true;
            this.labelCd.BackColor = System.Drawing.Color.Transparent;
            this.labelCd.Location = new System.Drawing.Point(145, 139);
            this.labelCd.Name = "labelCd";
            this.labelCd.Size = new System.Drawing.Size(0, 13);
            this.labelCd.TabIndex = 3;
            // 
            // laberDt
            // 
            this.laberDt.AutoSize = true;
            this.laberDt.BackColor = System.Drawing.Color.Transparent;
            this.laberDt.Location = new System.Drawing.Point(145, 171);
            this.laberDt.Name = "laberDt";
            this.laberDt.Size = new System.Drawing.Size(0, 13);
            this.laberDt.TabIndex = 4;
            // 
            // labelSn
            // 
            this.labelSn.AutoSize = true;
            this.labelSn.BackColor = System.Drawing.Color.Transparent;
            this.labelSn.Location = new System.Drawing.Point(143, 208);
            this.labelSn.Name = "labelSn";
            this.labelSn.Size = new System.Drawing.Size(27, 13);
            this.labelSn.TabIndex = 5;
            this.labelSn.Text = "N/A";
            // 
            // labelSun
            // 
            this.labelSun.AutoSize = true;
            this.labelSun.BackColor = System.Drawing.Color.Transparent;
            this.labelSun.Location = new System.Drawing.Point(143, 240);
            this.labelSun.Name = "labelSun";
            this.labelSun.Size = new System.Drawing.Size(27, 13);
            this.labelSun.TabIndex = 6;
            this.labelSun.Text = "N/A";
            // 
            // labelWn
            // 
            this.labelWn.AutoSize = true;
            this.labelWn.BackColor = System.Drawing.Color.Transparent;
            this.labelWn.Location = new System.Drawing.Point(391, 139);
            this.labelWn.Name = "labelWn";
            this.labelWn.Size = new System.Drawing.Size(27, 13);
            this.labelWn.TabIndex = 9;
            this.labelWn.Text = "N/A";
            // 
            // labelPress
            // 
            this.labelPress.AutoSize = true;
            this.labelPress.BackColor = System.Drawing.Color.Transparent;
            this.labelPress.Location = new System.Drawing.Point(388, 171);
            this.labelPress.Name = "labelPress";
            this.labelPress.Size = new System.Drawing.Size(27, 13);
            this.labelPress.TabIndex = 11;
            this.labelPress.Text = "N/A";
            // 
            // picWeather
            // 
            this.picWeather.BackColor = System.Drawing.Color.Transparent;
            this.picWeather.Location = new System.Drawing.Point(22, 67);
            this.picWeather.Name = "picWeather";
            this.picWeather.Size = new System.Drawing.Size(100, 50);
            this.picWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWeather.TabIndex = 13;
            this.picWeather.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(71, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sunset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(71, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sunrise";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(71, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(71, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Condition";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(302, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Wind Speed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(311, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Pressure";
            // 
            // FrmClima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 362);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picWeather);
            this.Controls.Add(this.labelPress);
            this.Controls.Add(this.labelWn);
            this.Controls.Add(this.labelSun);
            this.Controls.Add(this.labelSn);
            this.Controls.Add(this.laberDt);
            this.Controls.Add(this.labelCd);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClima);
            this.Name = "FrmClima";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmClima_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label labelCd;
        private System.Windows.Forms.Label laberDt;
        private System.Windows.Forms.Label labelSn;
        private System.Windows.Forms.Label labelSun;
        private System.Windows.Forms.Label labelWn;
        private System.Windows.Forms.Label labelPress;
        private System.Windows.Forms.PictureBox picWeather;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

