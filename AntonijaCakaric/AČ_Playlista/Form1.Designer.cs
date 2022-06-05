
namespace AČ_Playlista
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
            this.GridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.ImeTB = new System.Windows.Forms.TextBox();
            this.AutorTB = new System.Windows.Forms.TextBox();
            this.DuljinaTB = new System.Windows.Forms.TextBox();
            this.EksplicitnaCB = new System.Windows.Forms.CheckBox();
            this.GrammyCB = new System.Windows.Forms.CheckBox();
            this.SingleRB = new System.Windows.Forms.RadioButton();
            this.EPRB = new System.Windows.Forms.RadioButton();
            this.AlbumRB = new System.Windows.Forms.RadioButton();
            this.Dodaj = new System.Windows.Forms.Button();
            this.Uredi = new System.Windows.Forms.Button();
            this.Ukloni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(67)))), ((int)(((byte)(131)))));
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(41, 31);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(400, 379);
            this.GridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(466, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Playlista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(565, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(552, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(540, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(528, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "duljina";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(495, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "distribucija";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(84)))));
            this.groupBox1.Controls.Add(this.AlbumRB);
            this.groupBox1.Controls.Add(this.EPRB);
            this.groupBox1.Controls.Add(this.SingleRB);
            this.groupBox1.Location = new System.Drawing.Point(598, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 120);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // IdTB
            // 
            this.IdTB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTB.Location = new System.Drawing.Point(598, 85);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(115, 22);
            this.IdTB.TabIndex = 8;
            // 
            // ImeTB
            // 
            this.ImeTB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeTB.Location = new System.Drawing.Point(598, 117);
            this.ImeTB.Name = "ImeTB";
            this.ImeTB.Size = new System.Drawing.Size(115, 22);
            this.ImeTB.TabIndex = 9;
            // 
            // AutorTB
            // 
            this.AutorTB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutorTB.Location = new System.Drawing.Point(598, 148);
            this.AutorTB.Name = "AutorTB";
            this.AutorTB.Size = new System.Drawing.Size(115, 22);
            this.AutorTB.TabIndex = 10;
            // 
            // DuljinaTB
            // 
            this.DuljinaTB.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DuljinaTB.Location = new System.Drawing.Point(598, 179);
            this.DuljinaTB.Name = "DuljinaTB";
            this.DuljinaTB.Size = new System.Drawing.Size(115, 22);
            this.DuljinaTB.TabIndex = 11;
            // 
            // EksplicitnaCB
            // 
            this.EksplicitnaCB.AutoSize = true;
            this.EksplicitnaCB.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.EksplicitnaCB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EksplicitnaCB.Location = new System.Drawing.Point(499, 337);
            this.EksplicitnaCB.Name = "EksplicitnaCB";
            this.EksplicitnaCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EksplicitnaCB.Size = new System.Drawing.Size(110, 24);
            this.EksplicitnaCB.TabIndex = 12;
            this.EksplicitnaCB.Text = "eksplicitna";
            this.EksplicitnaCB.UseVisualStyleBackColor = true;
            // 
            // GrammyCB
            // 
            this.GrammyCB.AutoSize = true;
            this.GrammyCB.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.GrammyCB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GrammyCB.Location = new System.Drawing.Point(514, 367);
            this.GrammyCB.Name = "GrammyCB";
            this.GrammyCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrammyCB.Size = new System.Drawing.Size(95, 24);
            this.GrammyCB.TabIndex = 13;
            this.GrammyCB.Text = "GRAMMY";
            this.GrammyCB.UseVisualStyleBackColor = true;
            // 
            // SingleRB
            // 
            this.SingleRB.AutoSize = true;
            this.SingleRB.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.SingleRB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SingleRB.Location = new System.Drawing.Point(15, 19);
            this.SingleRB.Name = "SingleRB";
            this.SingleRB.Size = new System.Drawing.Size(74, 24);
            this.SingleRB.TabIndex = 0;
            this.SingleRB.TabStop = true;
            this.SingleRB.Text = "Single";
            this.SingleRB.UseVisualStyleBackColor = true;
            // 
            // EPRB
            // 
            this.EPRB.AutoSize = true;
            this.EPRB.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.EPRB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EPRB.Location = new System.Drawing.Point(15, 49);
            this.EPRB.Name = "EPRB";
            this.EPRB.Size = new System.Drawing.Size(46, 24);
            this.EPRB.TabIndex = 1;
            this.EPRB.TabStop = true;
            this.EPRB.Text = "EP";
            this.EPRB.UseVisualStyleBackColor = true;
            // 
            // AlbumRB
            // 
            this.AlbumRB.AutoSize = true;
            this.AlbumRB.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.AlbumRB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AlbumRB.Location = new System.Drawing.Point(15, 79);
            this.AlbumRB.Name = "AlbumRB";
            this.AlbumRB.Size = new System.Drawing.Size(73, 24);
            this.AlbumRB.TabIndex = 2;
            this.AlbumRB.TabStop = true;
            this.AlbumRB.Text = "Album";
            this.AlbumRB.UseVisualStyleBackColor = true;
            // 
            // Dodaj
            // 
            this.Dodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.Dodaj.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.Dodaj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Dodaj.Location = new System.Drawing.Point(864, 337);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(148, 31);
            this.Dodaj.TabIndex = 14;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = false;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // Uredi
            // 
            this.Uredi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.Uredi.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.Uredi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Uredi.Location = new System.Drawing.Point(864, 374);
            this.Uredi.Name = "Uredi";
            this.Uredi.Size = new System.Drawing.Size(148, 31);
            this.Uredi.TabIndex = 15;
            this.Uredi.Text = "Uredi";
            this.Uredi.UseVisualStyleBackColor = false;
            this.Uredi.Click += new System.EventHandler(this.Uredi_Click);
            // 
            // Ukloni
            // 
            this.Ukloni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.Ukloni.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.Ukloni.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Ukloni.Location = new System.Drawing.Point(864, 411);
            this.Ukloni.Name = "Ukloni";
            this.Ukloni.Size = new System.Drawing.Size(148, 31);
            this.Ukloni.TabIndex = 16;
            this.Ukloni.Text = "Ukloni";
            this.Ukloni.UseVisualStyleBackColor = false;
            this.Ukloni.Click += new System.EventHandler(this.Ukloni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.Ukloni);
            this.Controls.Add(this.Uredi);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.GrammyCB);
            this.Controls.Add(this.EksplicitnaCB);
            this.Controls.Add(this.DuljinaTB);
            this.Controls.Add(this.AutorTB);
            this.Controls.Add(this.ImeTB);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton AlbumRB;
        private System.Windows.Forms.RadioButton EPRB;
        private System.Windows.Forms.RadioButton SingleRB;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox ImeTB;
        private System.Windows.Forms.TextBox AutorTB;
        private System.Windows.Forms.TextBox DuljinaTB;
        private System.Windows.Forms.CheckBox EksplicitnaCB;
        private System.Windows.Forms.CheckBox GrammyCB;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button Uredi;
        private System.Windows.Forms.Button Ukloni;
    }
}

