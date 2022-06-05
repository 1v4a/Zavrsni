
namespace BusniKolodvor
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.Label();
            this.Id_tb = new System.Windows.Forms.TextBox();
            this.Linija = new System.Windows.Forms.Label();
            this.Registracija = new System.Windows.Forms.Label();
            this.Kapacitet = new System.Windows.Forms.Label();
            this.Kompanija = new System.Windows.Forms.GroupBox();
            this.Skolski_cb = new System.Windows.Forms.CheckBox();
            this.Linija_tb = new System.Windows.Forms.TextBox();
            this.Registracija_tb = new System.Windows.Forms.TextBox();
            this.Kapacitet_tb = new System.Windows.Forms.TextBox();
            this.Cazmatrans = new System.Windows.Forms.RadioButton();
            this.Slavijatrans = new System.Windows.Forms.RadioButton();
            this.Vincek = new System.Windows.Forms.RadioButton();
            this.Umetni = new System.Windows.Forms.Button();
            this.Uredi = new System.Windows.Forms.Button();
            this.Ukloni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Kompanija.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAZMATRANS - busevi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(556, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 394);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(61, 113);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(27, 21);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID";
            // 
            // Id_tb
            // 
            this.Id_tb.Location = new System.Drawing.Point(310, 113);
            this.Id_tb.Name = "Id_tb";
            this.Id_tb.Size = new System.Drawing.Size(31, 20);
            this.Id_tb.TabIndex = 3;
            // 
            // Linija
            // 
            this.Linija.AutoSize = true;
            this.Linija.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Linija.Location = new System.Drawing.Point(48, 145);
            this.Linija.Name = "Linija";
            this.Linija.Size = new System.Drawing.Size(52, 21);
            this.Linija.TabIndex = 4;
            this.Linija.Text = "Linija";
            // 
            // Registracija
            // 
            this.Registracija.AutoSize = true;
            this.Registracija.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registracija.Location = new System.Drawing.Point(25, 179);
            this.Registracija.Name = "Registracija";
            this.Registracija.Size = new System.Drawing.Size(99, 21);
            this.Registracija.TabIndex = 5;
            this.Registracija.Text = "Registracija";
            // 
            // Kapacitet
            // 
            this.Kapacitet.AutoSize = true;
            this.Kapacitet.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kapacitet.Location = new System.Drawing.Point(34, 212);
            this.Kapacitet.Name = "Kapacitet";
            this.Kapacitet.Size = new System.Drawing.Size(82, 21);
            this.Kapacitet.TabIndex = 6;
            this.Kapacitet.Text = "Kapacitet";
            // 
            // Kompanija
            // 
            this.Kompanija.Controls.Add(this.Vincek);
            this.Kompanija.Controls.Add(this.Slavijatrans);
            this.Kompanija.Controls.Add(this.Cazmatrans);
            this.Kompanija.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.Kompanija.Location = new System.Drawing.Point(29, 276);
            this.Kompanija.Name = "Kompanija";
            this.Kompanija.Size = new System.Drawing.Size(328, 130);
            this.Kompanija.TabIndex = 7;
            this.Kompanija.TabStop = false;
            this.Kompanija.Text = "Kompanija";
            // 
            // Skolski_cb
            // 
            this.Skolski_cb.AutoSize = true;
            this.Skolski_cb.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.Skolski_cb.Location = new System.Drawing.Point(34, 245);
            this.Skolski_cb.Name = "Skolski_cb";
            this.Skolski_cb.Size = new System.Drawing.Size(83, 25);
            this.Skolski_cb.TabIndex = 8;
            this.Skolski_cb.Text = "Školski";
            this.Skolski_cb.UseVisualStyleBackColor = true;
            // 
            // Linija_tb
            // 
            this.Linija_tb.Location = new System.Drawing.Point(310, 148);
            this.Linija_tb.Name = "Linija_tb";
            this.Linija_tb.Size = new System.Drawing.Size(143, 20);
            this.Linija_tb.TabIndex = 9;
            // 
            // Registracija_tb
            // 
            this.Registracija_tb.Location = new System.Drawing.Point(310, 179);
            this.Registracija_tb.Name = "Registracija_tb";
            this.Registracija_tb.Size = new System.Drawing.Size(143, 20);
            this.Registracija_tb.TabIndex = 10;
            // 
            // Kapacitet_tb
            // 
            this.Kapacitet_tb.Location = new System.Drawing.Point(310, 213);
            this.Kapacitet_tb.Name = "Kapacitet_tb";
            this.Kapacitet_tb.Size = new System.Drawing.Size(143, 20);
            this.Kapacitet_tb.TabIndex = 11;
            // 
            // Cazmatrans
            // 
            this.Cazmatrans.AutoSize = true;
            this.Cazmatrans.Location = new System.Drawing.Point(9, 28);
            this.Cazmatrans.Name = "Cazmatrans";
            this.Cazmatrans.Size = new System.Drawing.Size(117, 25);
            this.Cazmatrans.TabIndex = 0;
            this.Cazmatrans.TabStop = true;
            this.Cazmatrans.Text = "Cazmatrans";
            this.Cazmatrans.UseVisualStyleBackColor = true;
            // 
            // Slavijatrans
            // 
            this.Slavijatrans.AutoSize = true;
            this.Slavijatrans.Location = new System.Drawing.Point(9, 59);
            this.Slavijatrans.Name = "Slavijatrans";
            this.Slavijatrans.Size = new System.Drawing.Size(117, 25);
            this.Slavijatrans.TabIndex = 1;
            this.Slavijatrans.TabStop = true;
            this.Slavijatrans.Text = "Slavijatrans";
            this.Slavijatrans.UseVisualStyleBackColor = true;
            // 
            // Vincek
            // 
            this.Vincek.AutoSize = true;
            this.Vincek.Location = new System.Drawing.Point(9, 90);
            this.Vincek.Name = "Vincek";
            this.Vincek.Size = new System.Drawing.Size(80, 25);
            this.Vincek.TabIndex = 2;
            this.Vincek.TabStop = true;
            this.Vincek.Text = "Vincek";
            this.Vincek.UseVisualStyleBackColor = true;
            // 
            // Umetni
            // 
            this.Umetni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Umetni.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Umetni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Umetni.Location = new System.Drawing.Point(34, 443);
            this.Umetni.Name = "Umetni";
            this.Umetni.Size = new System.Drawing.Size(102, 45);
            this.Umetni.TabIndex = 12;
            this.Umetni.Text = "UMETNI";
            this.Umetni.UseVisualStyleBackColor = false;
            this.Umetni.Click += new System.EventHandler(this.Umetni_Click);
            // 
            // Uredi
            // 
            this.Uredi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Uredi.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uredi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Uredi.Location = new System.Drawing.Point(189, 443);
            this.Uredi.Name = "Uredi";
            this.Uredi.Size = new System.Drawing.Size(102, 45);
            this.Uredi.TabIndex = 13;
            this.Uredi.Text = "UREDI";
            this.Uredi.UseVisualStyleBackColor = false;
            this.Uredi.Click += new System.EventHandler(this.Uredi_Click);
            // 
            // Ukloni
            // 
            this.Ukloni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Ukloni.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ukloni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ukloni.Location = new System.Drawing.Point(346, 443);
            this.Ukloni.Name = "Ukloni";
            this.Ukloni.Size = new System.Drawing.Size(102, 45);
            this.Ukloni.TabIndex = 14;
            this.Ukloni.Text = "UKLONI";
            this.Ukloni.UseVisualStyleBackColor = false;
            this.Ukloni.Click += new System.EventHandler(this.Ukloni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1149, 573);
            this.Controls.Add(this.Ukloni);
            this.Controls.Add(this.Uredi);
            this.Controls.Add(this.Umetni);
            this.Controls.Add(this.Kapacitet_tb);
            this.Controls.Add(this.Registracija_tb);
            this.Controls.Add(this.Linija_tb);
            this.Controls.Add(this.Skolski_cb);
            this.Controls.Add(this.Kompanija);
            this.Controls.Add(this.Kapacitet);
            this.Controls.Add(this.Registracija);
            this.Controls.Add(this.Linija);
            this.Controls.Add(this.Id_tb);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CAZMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Kompanija.ResumeLayout(false);
            this.Kompanija.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox Id_tb;
        private System.Windows.Forms.Label Linija;
        private System.Windows.Forms.Label Registracija;
        private System.Windows.Forms.Label Kapacitet;
        private System.Windows.Forms.GroupBox Kompanija;
        private System.Windows.Forms.CheckBox Skolski_cb;
        private System.Windows.Forms.TextBox Linija_tb;
        private System.Windows.Forms.TextBox Registracija_tb;
        private System.Windows.Forms.TextBox Kapacitet_tb;
        private System.Windows.Forms.RadioButton Vincek;
        private System.Windows.Forms.RadioButton Slavijatrans;
        private System.Windows.Forms.RadioButton Cazmatrans;
        private System.Windows.Forms.Button Umetni;
        private System.Windows.Forms.Button Uredi;
        private System.Windows.Forms.Button Ukloni;
    }
}

