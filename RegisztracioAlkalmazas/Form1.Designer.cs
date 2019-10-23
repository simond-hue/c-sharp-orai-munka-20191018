namespace RegisztracioAlkalmazas
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
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.labelNev = new System.Windows.Forms.Label();
            this.textBoxSzulDatum = new System.Windows.Forms.TextBox();
            this.labelSzulDatum = new System.Windows.Forms.Label();
            this.labelNem = new System.Windows.Forms.Label();
            this.labelKedvencHobbi = new System.Windows.Forms.Label();
            this.buttonMentes = new System.Windows.Forms.Button();
            this.buttonBetoltes = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxHobbi = new System.Windows.Forms.TextBox();
            this.buttonUjHobbi = new System.Windows.Forms.Button();
            this.labelUjHobbi = new System.Windows.Forms.Label();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonFerfi = new System.Windows.Forms.RadioButton();
            this.groupBoxNem = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxKedvencHobbi = new System.Windows.Forms.ListBox();
            this.listBoxFile = new System.Windows.Forms.ListBox();
            this.groupBoxNem.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(80, 6);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(100, 20);
            this.textBoxNev.TabIndex = 0;
            // 
            // labelNev
            // 
            this.labelNev.AutoSize = true;
            this.labelNev.Location = new System.Drawing.Point(12, 9);
            this.labelNev.Name = "labelNev";
            this.labelNev.Size = new System.Drawing.Size(27, 13);
            this.labelNev.TabIndex = 1;
            this.labelNev.Text = "Név";
            // 
            // textBoxSzulDatum
            // 
            this.textBoxSzulDatum.Location = new System.Drawing.Point(80, 31);
            this.textBoxSzulDatum.Name = "textBoxSzulDatum";
            this.textBoxSzulDatum.Size = new System.Drawing.Size(100, 20);
            this.textBoxSzulDatum.TabIndex = 2;
            // 
            // labelSzulDatum
            // 
            this.labelSzulDatum.AutoSize = true;
            this.labelSzulDatum.Location = new System.Drawing.Point(12, 34);
            this.labelSzulDatum.Name = "labelSzulDatum";
            this.labelSzulDatum.Size = new System.Drawing.Size(62, 13);
            this.labelSzulDatum.TabIndex = 3;
            this.labelSzulDatum.Text = "Szül. dátum";
            // 
            // labelNem
            // 
            this.labelNem.AutoSize = true;
            this.labelNem.Location = new System.Drawing.Point(12, 59);
            this.labelNem.Name = "labelNem";
            this.labelNem.Size = new System.Drawing.Size(29, 13);
            this.labelNem.TabIndex = 4;
            this.labelNem.Text = "Nem";
            // 
            // labelKedvencHobbi
            // 
            this.labelKedvencHobbi.AutoSize = true;
            this.labelKedvencHobbi.Location = new System.Drawing.Point(12, 149);
            this.labelKedvencHobbi.Name = "labelKedvencHobbi";
            this.labelKedvencHobbi.Size = new System.Drawing.Size(79, 13);
            this.labelKedvencHobbi.TabIndex = 6;
            this.labelKedvencHobbi.Text = "Kedvenc hobbi";
            // 
            // buttonMentes
            // 
            this.buttonMentes.Location = new System.Drawing.Point(12, 276);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(79, 23);
            this.buttonMentes.TabIndex = 8;
            this.buttonMentes.Text = "Mentés";
            this.buttonMentes.UseVisualStyleBackColor = true;
            this.buttonMentes.Click += new System.EventHandler(this.buttonMentes_Click);
            // 
            // buttonBetoltes
            // 
            this.buttonBetoltes.Location = new System.Drawing.Point(118, 276);
            this.buttonBetoltes.Name = "buttonBetoltes";
            this.buttonBetoltes.Size = new System.Drawing.Size(79, 23);
            this.buttonBetoltes.TabIndex = 9;
            this.buttonBetoltes.Text = "Betöltés";
            this.buttonBetoltes.UseVisualStyleBackColor = true;
            this.buttonBetoltes.Click += new System.EventHandler(this.buttonBetoltes_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "\"Text\"|*.txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Text\"|*.txt";
            // 
            // textBoxHobbi
            // 
            this.textBoxHobbi.Location = new System.Drawing.Point(12, 126);
            this.textBoxHobbi.Name = "textBoxHobbi";
            this.textBoxHobbi.Size = new System.Drawing.Size(100, 20);
            this.textBoxHobbi.TabIndex = 10;
            // 
            // buttonUjHobbi
            // 
            this.buttonUjHobbi.Location = new System.Drawing.Point(118, 123);
            this.buttonUjHobbi.Name = "buttonUjHobbi";
            this.buttonUjHobbi.Size = new System.Drawing.Size(79, 23);
            this.buttonUjHobbi.TabIndex = 11;
            this.buttonUjHobbi.Text = "Hozzáadás";
            this.buttonUjHobbi.UseVisualStyleBackColor = true;
            this.buttonUjHobbi.Click += new System.EventHandler(this.buttonUjHobbi_Click);
            // 
            // labelUjHobbi
            // 
            this.labelUjHobbi.AutoSize = true;
            this.labelUjHobbi.Location = new System.Drawing.Point(9, 110);
            this.labelUjHobbi.Name = "labelUjHobbi";
            this.labelUjHobbi.Size = new System.Drawing.Size(106, 13);
            this.labelUjHobbi.TabIndex = 12;
            this.labelUjHobbi.Text = "Új hobbi hozzáadása";
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(67, 2);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(33, 17);
            this.radioButtonNo.TabIndex = 6;
            this.radioButtonNo.Text = "N";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonFerfi
            // 
            this.radioButtonFerfi.AutoSize = true;
            this.radioButtonFerfi.Location = new System.Drawing.Point(6, 2);
            this.radioButtonFerfi.Name = "radioButtonFerfi";
            this.radioButtonFerfi.Size = new System.Drawing.Size(31, 17);
            this.radioButtonFerfi.TabIndex = 7;
            this.radioButtonFerfi.Text = "F";
            this.radioButtonFerfi.UseVisualStyleBackColor = true;
            // 
            // groupBoxNem
            // 
            this.groupBoxNem.Controls.Add(this.radioButtonFerfi);
            this.groupBoxNem.Controls.Add(this.radioButtonNo);
            this.groupBoxNem.Location = new System.Drawing.Point(80, 57);
            this.groupBoxNem.Name = "groupBoxNem";
            this.groupBoxNem.Size = new System.Drawing.Size(100, 33);
            this.groupBoxNem.TabIndex = 5;
            this.groupBoxNem.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Betöltött fájl tartalma";
            // 
            // listBoxKedvencHobbi
            // 
            this.listBoxKedvencHobbi.FormattingEnabled = true;
            this.listBoxKedvencHobbi.Location = new System.Drawing.Point(12, 165);
            this.listBoxKedvencHobbi.Name = "listBoxKedvencHobbi";
            this.listBoxKedvencHobbi.Size = new System.Drawing.Size(185, 108);
            this.listBoxKedvencHobbi.TabIndex = 14;
            // 
            // listBoxFile
            // 
            this.listBoxFile.FormattingEnabled = true;
            this.listBoxFile.Location = new System.Drawing.Point(203, 28);
            this.listBoxFile.Name = "listBoxFile";
            this.listBoxFile.Size = new System.Drawing.Size(291, 264);
            this.listBoxFile.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 311);
            this.Controls.Add(this.listBoxFile);
            this.Controls.Add(this.listBoxKedvencHobbi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUjHobbi);
            this.Controls.Add(this.buttonUjHobbi);
            this.Controls.Add(this.textBoxHobbi);
            this.Controls.Add(this.buttonBetoltes);
            this.Controls.Add(this.buttonMentes);
            this.Controls.Add(this.labelKedvencHobbi);
            this.Controls.Add(this.groupBoxNem);
            this.Controls.Add(this.labelNem);
            this.Controls.Add(this.labelSzulDatum);
            this.Controls.Add(this.textBoxSzulDatum);
            this.Controls.Add(this.labelNev);
            this.Controls.Add(this.textBoxNev);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxNem.ResumeLayout(false);
            this.groupBoxNem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.Label labelNev;
        private System.Windows.Forms.TextBox textBoxSzulDatum;
        private System.Windows.Forms.Label labelSzulDatum;
        private System.Windows.Forms.Label labelNem;
        private System.Windows.Forms.Label labelKedvencHobbi;
        private System.Windows.Forms.Button buttonMentes;
        private System.Windows.Forms.Button buttonBetoltes;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxHobbi;
        private System.Windows.Forms.Button buttonUjHobbi;
        private System.Windows.Forms.Label labelUjHobbi;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonFerfi;
        private System.Windows.Forms.GroupBox groupBoxNem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxKedvencHobbi;
        private System.Windows.Forms.ListBox listBoxFile;
    }
}

