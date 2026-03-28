namespace azil_zivotinje
{
    partial class Unos_Zivotinje
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbKast = new System.Windows.Forms.CheckBox();
            this.cbCijep = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDolazak = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDob = new System.Windows.Forms.NumericUpDown();
            this.rbZ = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.txtPasmina = new System.Windows.Forms.TextBox();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDob)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 54);
            this.button2.TabIndex = 37;
            this.button2.Text = "Spremi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 24);
            this.button1.TabIndex = 36;
            this.button1.Text = "Odaberi sliku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(309, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(370, 110);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(100, 20);
            this.txtNapomena.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Napomena:";
            // 
            // cbKast
            // 
            this.cbKast.AutoSize = true;
            this.cbKast.Location = new System.Drawing.Point(403, 69);
            this.cbKast.Name = "cbKast";
            this.cbKast.Size = new System.Drawing.Size(67, 17);
            this.cbKast.TabIndex = 32;
            this.cbKast.Text = "Kastriran";
            this.cbKast.UseVisualStyleBackColor = true;
            // 
            // cbCijep
            // 
            this.cbCijep.AutoSize = true;
            this.cbCijep.Location = new System.Drawing.Point(299, 68);
            this.cbCijep.Name = "cbCijep";
            this.cbCijep.Size = new System.Drawing.Size(65, 17);
            this.cbCijep.TabIndex = 31;
            this.cbCijep.Text = "Cijepljen";
            this.cbCijep.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Datum dolaska:";
            // 
            // dtpDolazak
            // 
            this.dtpDolazak.Location = new System.Drawing.Point(54, 359);
            this.dtpDolazak.Name = "dtpDolazak";
            this.dtpDolazak.Size = new System.Drawing.Size(200, 20);
            this.dtpDolazak.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Dob:";
            // 
            // nudDob
            // 
            this.nudDob.Location = new System.Drawing.Point(87, 272);
            this.nudDob.Name = "nudDob";
            this.nudDob.Size = new System.Drawing.Size(120, 20);
            this.nudDob.TabIndex = 27;
            // 
            // rbZ
            // 
            this.rbZ.AutoSize = true;
            this.rbZ.Location = new System.Drawing.Point(134, 231);
            this.rbZ.Name = "rbZ";
            this.rbZ.Size = new System.Drawing.Size(61, 17);
            this.rbZ.TabIndex = 26;
            this.rbZ.TabStop = true;
            this.rbZ.Text = "Žensko";
            this.rbZ.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(54, 231);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(57, 17);
            this.rbM.TabIndex = 25;
            this.rbM.TabStop = true;
            this.rbM.Text = "Muško";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // txtPasmina
            // 
            this.txtPasmina.Location = new System.Drawing.Point(107, 165);
            this.txtPasmina.Name = "txtPasmina";
            this.txtPasmina.Size = new System.Drawing.Size(100, 20);
            this.txtPasmina.TabIndex = 24;
            // 
            // txtVrsta
            // 
            this.txtVrsta.Location = new System.Drawing.Point(91, 114);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(100, 20);
            this.txtVrsta.TabIndex = 23;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(85, 66);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Pasmina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Vrsta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ime:";
            // 
            // Unos_Zivotinje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbKast);
            this.Controls.Add(this.cbCijep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDolazak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudDob);
            this.Controls.Add(this.rbZ);
            this.Controls.Add(this.rbM);
            this.Controls.Add(this.txtPasmina);
            this.Controls.Add(this.txtVrsta);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Unos_Zivotinje";
            this.Text = "Unos_Zivotinje";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbKast;
        private System.Windows.Forms.CheckBox cbCijep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDolazak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudDob;
        private System.Windows.Forms.RadioButton rbZ;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.TextBox txtPasmina;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}