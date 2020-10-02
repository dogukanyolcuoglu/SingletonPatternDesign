namespace SingletonPattern
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtAd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSoyad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtId2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassWord = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassWord2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPosta = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 758);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(157, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 25);
            this.panel2.TabIndex = 1;
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGonder.FlatAppearance.BorderSize = 0;
            this.btnGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGonder.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGonder.ForeColor = System.Drawing.Color.White;
            this.btnGonder.Location = new System.Drawing.Point(352, 667);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(123, 41);
            this.btnGonder.TabIndex = 5;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtAd
            // 
            this.txtAd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAd.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAd.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.ForeColor = System.Drawing.Color.Black;
            this.txtAd.HintForeColor = System.Drawing.Color.Empty;
            this.txtAd.HintText = "";
            this.txtAd.isPassword = false;
            this.txtAd.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtAd.LineIdleColor = System.Drawing.Color.Teal;
            this.txtAd.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtAd.LineThickness = 3;
            this.txtAd.Location = new System.Drawing.Point(271, 210);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAd.MaxLength = 32767;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(215, 38);
            this.txtAd.TabIndex = 11;
            this.txtAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSoyad
            // 
            this.txtSoyad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSoyad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSoyad.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoyad.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F);
            this.txtSoyad.ForeColor = System.Drawing.Color.Black;
            this.txtSoyad.HintForeColor = System.Drawing.Color.Empty;
            this.txtSoyad.HintText = "";
            this.txtSoyad.isPassword = false;
            this.txtSoyad.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtSoyad.LineIdleColor = System.Drawing.Color.Teal;
            this.txtSoyad.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtSoyad.LineThickness = 3;
            this.txtSoyad.Location = new System.Drawing.Point(271, 290);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoyad.MaxLength = 32767;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(215, 38);
            this.txtSoyad.TabIndex = 11;
            this.txtSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtId2
            // 
            this.txtId2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtId2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtId2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtId2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId2.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F);
            this.txtId2.ForeColor = System.Drawing.Color.Black;
            this.txtId2.HintForeColor = System.Drawing.Color.Empty;
            this.txtId2.HintText = "";
            this.txtId2.isPassword = false;
            this.txtId2.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtId2.LineIdleColor = System.Drawing.Color.Teal;
            this.txtId2.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtId2.LineThickness = 3;
            this.txtId2.Location = new System.Drawing.Point(271, 372);
            this.txtId2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId2.MaxLength = 32767;
            this.txtId2.Name = "txtId2";
            this.txtId2.Size = new System.Drawing.Size(215, 38);
            this.txtId2.TabIndex = 11;
            this.txtId2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPassWord
            // 
            this.txtPassWord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassWord.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassWord.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassWord.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F);
            this.txtPassWord.ForeColor = System.Drawing.Color.Black;
            this.txtPassWord.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassWord.HintText = "";
            this.txtPassWord.isPassword = true;
            this.txtPassWord.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtPassWord.LineIdleColor = System.Drawing.Color.Teal;
            this.txtPassWord.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtPassWord.LineThickness = 3;
            this.txtPassWord.Location = new System.Drawing.Point(271, 448);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassWord.MaxLength = 32767;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(215, 38);
            this.txtPassWord.TabIndex = 11;
            this.txtPassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPassWord2
            // 
            this.txtPassWord2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassWord2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassWord2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassWord2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassWord2.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F);
            this.txtPassWord2.ForeColor = System.Drawing.Color.Black;
            this.txtPassWord2.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassWord2.HintText = "";
            this.txtPassWord2.isPassword = true;
            this.txtPassWord2.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtPassWord2.LineIdleColor = System.Drawing.Color.Teal;
            this.txtPassWord2.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtPassWord2.LineThickness = 3;
            this.txtPassWord2.Location = new System.Drawing.Point(271, 527);
            this.txtPassWord2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassWord2.MaxLength = 32767;
            this.txtPassWord2.Name = "txtPassWord2";
            this.txtPassWord2.Size = new System.Drawing.Size(215, 38);
            this.txtPassWord2.TabIndex = 11;
            this.txtPassWord2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPosta
            // 
            this.txtPosta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPosta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPosta.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPosta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPosta.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F);
            this.txtPosta.ForeColor = System.Drawing.Color.Black;
            this.txtPosta.HintForeColor = System.Drawing.Color.Empty;
            this.txtPosta.HintText = "";
            this.txtPosta.isPassword = false;
            this.txtPosta.LineFocusedColor = System.Drawing.Color.Crimson;
            this.txtPosta.LineIdleColor = System.Drawing.Color.Teal;
            this.txtPosta.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.txtPosta.LineThickness = 3;
            this.txtPosta.Location = new System.Drawing.Point(271, 608);
            this.txtPosta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPosta.MaxLength = 32767;
            this.txtPosta.Name = "txtPosta";
            this.txtPosta.Size = new System.Drawing.Size(314, 38);
            this.txtPosta.TabIndex = 11;
            this.txtPosta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "AD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "SOYAD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kullanıcı Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Parola :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Parola Tekrarı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(213, 581);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "E-Posta Adresi :";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::SingletonPattern.Properties.Resources.multimedia;
            this.pictureBox8.Location = new System.Drawing.Point(217, 608);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(37, 38);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::SingletonPattern.Properties.Resources.password__1_;
            this.pictureBox7.Location = new System.Drawing.Point(217, 527);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(37, 38);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SingletonPattern.Properties.Resources.password__1_;
            this.pictureBox6.Location = new System.Drawing.Point(217, 448);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(37, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SingletonPattern.Properties.Resources.name;
            this.pictureBox5.Location = new System.Drawing.Point(217, 372);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SingletonPattern.Properties.Resources.name;
            this.pictureBox4.Location = new System.Drawing.Point(217, 290);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SingletonPattern.Properties.Resources.name;
            this.pictureBox3.Location = new System.Drawing.Point(217, 210);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SingletonPattern.Properties.Resources.file__1_;
            this.pictureBox2.Location = new System.Drawing.Point(298, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::SingletonPattern.Properties.Resources.technology;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(424, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 25);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::SingletonPattern.Properties.Resources.account__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 53);
            this.button3.TabIndex = 1;
            this.button3.Text = " Kayıt Ol";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::SingletonPattern.Properties.Resources.login;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Giriş";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SingletonPattern.Properties.Resources.files_and_folders__1_;
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(614, 757);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtPosta);
            this.Controls.Add(this.txtPassWord2);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtId2);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGonder;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSoyad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtId2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassWord;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassWord2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPosta;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button button1;
    }
}