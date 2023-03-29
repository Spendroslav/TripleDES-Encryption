namespace _3Des_encryption
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSeach1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.path1TXT = new System.Windows.Forms.TextBox();
            this.pass1TXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.path2TXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pass2TXT = new System.Windows.Forms.TextBox();
            this.btnSeach2 = new System.Windows.Forms.Button();
            this.CheckKoncovky = new System.Windows.Forms.CheckBox();
            this.CheckSubDirectory = new System.Windows.Forms.CheckBox();
            this.Generate1 = new System.Windows.Forms.Button();
            this.Generate2 = new System.Windows.Forms.Button();
            this.PasswordStreng = new System.Windows.Forms.LinkLabel();
            this.PasswordStreng2 = new System.Windows.Forms.LinkLabel();
            this.btnENC1 = new System.Windows.Forms.Button();
            this.btnENC2 = new System.Windows.Forms.Button();
            this.KoncovkaTxt = new System.Windows.Forms.TextBox();
            this.KoncovkaLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.path1DTXT = new System.Windows.Forms.TextBox();
            this.pass1DTXT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSeach1D = new System.Windows.Forms.Button();
            this.btnDEC1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.path2DTXT = new System.Windows.Forms.TextBox();
            this.pass2DTXT = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSeach2D = new System.Windows.Forms.Button();
            this.btnDEC2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSeach1
            // 
            this.btnSeach1.Location = new System.Drawing.Point(255, 79);
            this.btnSeach1.Name = "btnSeach1";
            this.btnSeach1.Size = new System.Drawing.Size(88, 23);
            this.btnSeach1.TabIndex = 0;
            this.btnSeach1.Text = "Hledat";
            this.btnSeach1.UseVisualStyleBackColor = true;
            this.btnSeach1.Click += new System.EventHandler(this.btnSeach1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nastavení";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Šifrovat jeden soubor";
            // 
            // path1TXT
            // 
            this.path1TXT.Location = new System.Drawing.Point(49, 84);
            this.path1TXT.Name = "path1TXT";
            this.path1TXT.Size = new System.Drawing.Size(183, 20);
            this.path1TXT.TabIndex = 3;
            // 
            // pass1TXT
            // 
            this.pass1TXT.Location = new System.Drawing.Point(49, 124);
            this.pass1TXT.Name = "pass1TXT";
            this.pass1TXT.Size = new System.Drawing.Size(183, 20);
            this.pass1TXT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Heslo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(836, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Šifrovat složku";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(792, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Path";
            // 
            // path2TXT
            // 
            this.path2TXT.Location = new System.Drawing.Point(840, 82);
            this.path2TXT.Name = "path2TXT";
            this.path2TXT.Size = new System.Drawing.Size(183, 20);
            this.path2TXT.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(792, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Heslo";
            // 
            // pass2TXT
            // 
            this.pass2TXT.Location = new System.Drawing.Point(840, 124);
            this.pass2TXT.Name = "pass2TXT";
            this.pass2TXT.Size = new System.Drawing.Size(183, 20);
            this.pass2TXT.TabIndex = 11;
            // 
            // btnSeach2
            // 
            this.btnSeach2.Location = new System.Drawing.Point(1055, 79);
            this.btnSeach2.Name = "btnSeach2";
            this.btnSeach2.Size = new System.Drawing.Size(88, 23);
            this.btnSeach2.TabIndex = 12;
            this.btnSeach2.Text = "Hledat";
            this.btnSeach2.UseVisualStyleBackColor = true;
            this.btnSeach2.Click += new System.EventHandler(this.btnSeach2_Click);
            // 
            // CheckKoncovky
            // 
            this.CheckKoncovky.AutoSize = true;
            this.CheckKoncovky.ForeColor = System.Drawing.Color.White;
            this.CheckKoncovky.Location = new System.Drawing.Point(30, 505);
            this.CheckKoncovky.Name = "CheckKoncovky";
            this.CheckKoncovky.Size = new System.Drawing.Size(222, 17);
            this.CheckKoncovky.TabIndex = 14;
            this.CheckKoncovky.Text = "Přidávat koncovku za zašifrovaný soubor";
            this.CheckKoncovky.UseVisualStyleBackColor = true;
            this.CheckKoncovky.CheckedChanged += new System.EventHandler(this.koncovky_CheckedChanged);
            // 
            // CheckSubDirectory
            // 
            this.CheckSubDirectory.AutoSize = true;
            this.CheckSubDirectory.ForeColor = System.Drawing.Color.White;
            this.CheckSubDirectory.Location = new System.Drawing.Point(30, 528);
            this.CheckSubDirectory.Name = "CheckSubDirectory";
            this.CheckSubDirectory.Size = new System.Drawing.Size(279, 30);
            this.CheckSubDirectory.TabIndex = 15;
            this.CheckSubDirectory.Text = "Při šifrování složek, bude program šifrovat i podsložky\r\n (zaškrtněte i při dešif" +
    "rování podsložek)";
            this.CheckSubDirectory.UseVisualStyleBackColor = true;
            // 
            // Generate1
            // 
            this.Generate1.Location = new System.Drawing.Point(49, 153);
            this.Generate1.Name = "Generate1";
            this.Generate1.Size = new System.Drawing.Size(183, 23);
            this.Generate1.TabIndex = 16;
            this.Generate1.Text = "Generovat heslo";
            this.Generate1.UseVisualStyleBackColor = true;
            this.Generate1.Click += new System.EventHandler(this.Generate1_Click);
            // 
            // Generate2
            // 
            this.Generate2.Location = new System.Drawing.Point(840, 153);
            this.Generate2.Name = "Generate2";
            this.Generate2.Size = new System.Drawing.Size(183, 23);
            this.Generate2.TabIndex = 17;
            this.Generate2.Text = "Generovat heslo";
            this.Generate2.UseVisualStyleBackColor = true;
            this.Generate2.Click += new System.EventHandler(this.Generate2_Click);
            // 
            // PasswordStreng
            // 
            this.PasswordStreng.AutoSize = true;
            this.PasswordStreng.LinkColor = System.Drawing.Color.White;
            this.PasswordStreng.Location = new System.Drawing.Point(61, 188);
            this.PasswordStreng.Name = "PasswordStreng";
            this.PasswordStreng.Size = new System.Drawing.Size(166, 13);
            this.PasswordStreng.TabIndex = 18;
            this.PasswordStreng.TabStop = true;
            this.PasswordStreng.Text = "Silnost hesla můžeš otestovat zde";
            this.PasswordStreng.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PasswordStreng_LinkClicked);
            // 
            // PasswordStreng2
            // 
            this.PasswordStreng2.AutoSize = true;
            this.PasswordStreng2.LinkColor = System.Drawing.Color.White;
            this.PasswordStreng2.Location = new System.Drawing.Point(857, 188);
            this.PasswordStreng2.Name = "PasswordStreng2";
            this.PasswordStreng2.Size = new System.Drawing.Size(166, 13);
            this.PasswordStreng2.TabIndex = 19;
            this.PasswordStreng2.TabStop = true;
            this.PasswordStreng2.Text = "Silnost hesla můžeš otestovat zde";
            this.PasswordStreng2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PasswordStreng2_LinkClicked);
            // 
            // btnENC1
            // 
            this.btnENC1.Location = new System.Drawing.Point(255, 150);
            this.btnENC1.Name = "btnENC1";
            this.btnENC1.Size = new System.Drawing.Size(88, 28);
            this.btnENC1.TabIndex = 20;
            this.btnENC1.Text = "ZAŠIFROVAT";
            this.btnENC1.UseVisualStyleBackColor = true;
            this.btnENC1.Click += new System.EventHandler(this.btnENC1_Click);
            // 
            // btnENC2
            // 
            this.btnENC2.Location = new System.Drawing.Point(1055, 148);
            this.btnENC2.Name = "btnENC2";
            this.btnENC2.Size = new System.Drawing.Size(88, 28);
            this.btnENC2.TabIndex = 21;
            this.btnENC2.Text = "ZAŠIFROVAT";
            this.btnENC2.UseVisualStyleBackColor = true;
            this.btnENC2.Click += new System.EventHandler(this.btnENC2_Click);
            // 
            // KoncovkaTxt
            // 
            this.KoncovkaTxt.Location = new System.Drawing.Point(100, 585);
            this.KoncovkaTxt.Name = "KoncovkaTxt";
            this.KoncovkaTxt.Size = new System.Drawing.Size(61, 20);
            this.KoncovkaTxt.TabIndex = 22;
            // 
            // KoncovkaLabel
            // 
            this.KoncovkaLabel.AutoSize = true;
            this.KoncovkaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KoncovkaLabel.ForeColor = System.Drawing.Color.White;
            this.KoncovkaLabel.Location = new System.Drawing.Point(27, 585);
            this.KoncovkaLabel.Name = "KoncovkaLabel";
            this.KoncovkaLabel.Size = new System.Drawing.Size(67, 16);
            this.KoncovkaLabel.TabIndex = 23;
            this.KoncovkaLabel.Text = "Koncovka";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(483, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "Obecné";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(40, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 24);
            this.label10.TabIndex = 25;
            this.label10.Text = "Dešifrovat jeden soubor";
            // 
            // path1DTXT
            // 
            this.path1DTXT.Location = new System.Drawing.Point(49, 280);
            this.path1DTXT.Name = "path1DTXT";
            this.path1DTXT.Size = new System.Drawing.Size(183, 20);
            this.path1DTXT.TabIndex = 26;
            // 
            // pass1DTXT
            // 
            this.pass1DTXT.Location = new System.Drawing.Point(49, 324);
            this.pass1DTXT.Name = "pass1DTXT";
            this.pass1DTXT.Size = new System.Drawing.Size(183, 20);
            this.pass1DTXT.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(9, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Path";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(9, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Heslo";
            // 
            // btnSeach1D
            // 
            this.btnSeach1D.Location = new System.Drawing.Point(255, 277);
            this.btnSeach1D.Name = "btnSeach1D";
            this.btnSeach1D.Size = new System.Drawing.Size(88, 23);
            this.btnSeach1D.TabIndex = 30;
            this.btnSeach1D.Text = "Hledat";
            this.btnSeach1D.UseVisualStyleBackColor = true;
            this.btnSeach1D.Click += new System.EventHandler(this.btnSeach1D_Click);
            // 
            // btnDEC1
            // 
            this.btnDEC1.Location = new System.Drawing.Point(255, 319);
            this.btnDEC1.Name = "btnDEC1";
            this.btnDEC1.Size = new System.Drawing.Size(88, 28);
            this.btnDEC1.TabIndex = 31;
            this.btnDEC1.Text = "DEŠIFROVAT";
            this.btnDEC1.UseVisualStyleBackColor = true;
            this.btnDEC1.Click += new System.EventHandler(this.btnDEC1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(836, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 24);
            this.label13.TabIndex = 32;
            this.label13.Text = "Dešifrovat složku";
            // 
            // path2DTXT
            // 
            this.path2DTXT.Location = new System.Drawing.Point(840, 280);
            this.path2DTXT.Name = "path2DTXT";
            this.path2DTXT.Size = new System.Drawing.Size(183, 20);
            this.path2DTXT.TabIndex = 33;
            // 
            // pass2DTXT
            // 
            this.pass2DTXT.Location = new System.Drawing.Point(840, 324);
            this.pass2DTXT.Name = "pass2DTXT";
            this.pass2DTXT.Size = new System.Drawing.Size(183, 20);
            this.pass2DTXT.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(792, 287);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Path";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(792, 327);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Heslo";
            // 
            // btnSeach2D
            // 
            this.btnSeach2D.Location = new System.Drawing.Point(1055, 278);
            this.btnSeach2D.Name = "btnSeach2D";
            this.btnSeach2D.Size = new System.Drawing.Size(88, 23);
            this.btnSeach2D.TabIndex = 37;
            this.btnSeach2D.Text = "Hledat";
            this.btnSeach2D.UseVisualStyleBackColor = true;
            this.btnSeach2D.Click += new System.EventHandler(this.btnSeach2D_Click);
            // 
            // btnDEC2
            // 
            this.btnDEC2.Location = new System.Drawing.Point(1055, 319);
            this.btnDEC2.Name = "btnDEC2";
            this.btnDEC2.Size = new System.Drawing.Size(88, 28);
            this.btnDEC2.TabIndex = 38;
            this.btnDEC2.Text = "DEŠIFROVAT";
            this.btnDEC2.UseVisualStyleBackColor = true;
            this.btnDEC2.Click += new System.EventHandler(this.btnDEC2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Lime;
            this.label16.Location = new System.Drawing.Point(1128, 689);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Vytvořil: Ondřej Diviš";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(484, 495);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(320, 65);
            this.label17.TabIndex = 41;
            this.label17.Text = "Program šifruje pomocí algoritmu TripleDes (3DES).\r\n\r\nAlgoritmus šifruje pod 112-" +
    "168 bitovým klíčem a pod režimem ECB.\r\n\r\nVelikost klíče v programu musí být přes" +
    "ně 16 znaků.\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1246, 711);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnDEC2);
            this.Controls.Add(this.btnSeach2D);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pass2DTXT);
            this.Controls.Add(this.path2DTXT);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnDEC1);
            this.Controls.Add(this.btnSeach1D);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pass1DTXT);
            this.Controls.Add(this.path1DTXT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.KoncovkaLabel);
            this.Controls.Add(this.KoncovkaTxt);
            this.Controls.Add(this.btnENC2);
            this.Controls.Add(this.btnENC1);
            this.Controls.Add(this.PasswordStreng2);
            this.Controls.Add(this.PasswordStreng);
            this.Controls.Add(this.Generate2);
            this.Controls.Add(this.Generate1);
            this.Controls.Add(this.CheckSubDirectory);
            this.Controls.Add(this.CheckKoncovky);
            this.Controls.Add(this.btnSeach2);
            this.Controls.Add(this.pass2TXT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.path2TXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pass1TXT);
            this.Controls.Add(this.path1TXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeach1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3DES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeach1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox path1TXT;
        private System.Windows.Forms.TextBox pass1TXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox path2TXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pass2TXT;
        private System.Windows.Forms.Button btnSeach2;
        private System.Windows.Forms.CheckBox CheckKoncovky;
        private System.Windows.Forms.CheckBox CheckSubDirectory;
        private System.Windows.Forms.Button Generate1;
        private System.Windows.Forms.Button Generate2;
        private System.Windows.Forms.LinkLabel PasswordStreng;
        private System.Windows.Forms.LinkLabel PasswordStreng2;
        private System.Windows.Forms.Button btnENC1;
        private System.Windows.Forms.Button btnENC2;
        private System.Windows.Forms.TextBox KoncovkaTxt;
        private System.Windows.Forms.Label KoncovkaLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox path1DTXT;
        private System.Windows.Forms.TextBox pass1DTXT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSeach1D;
        private System.Windows.Forms.Button btnDEC1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox path2DTXT;
        private System.Windows.Forms.TextBox pass2DTXT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSeach2D;
        private System.Windows.Forms.Button btnDEC2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

