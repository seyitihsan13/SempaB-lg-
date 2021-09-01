
namespace BilgiMİllyoner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnBasla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblpuan = new System.Windows.Forms.Label();
            this.lbldogru = new System.Windows.Forms.Label();
            this.lblsoru = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblzaman = new System.Windows.Forms.Label();
            this.lblsure = new System.Windows.Forms.Label();
            this.BtnSkorTablosu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblYarismaAdiii = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mİlyonerolmakisterDataSet1 = new BilgiMİllyoner.MİlyonerolmakisterDataSet();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mİlyonerolmakisterDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 103);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 164);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "A)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "B)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "C)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(229, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "D)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnBasla
            // 
            this.BtnBasla.Location = new System.Drawing.Point(541, 103);
            this.BtnBasla.Name = "BtnBasla";
            this.BtnBasla.Size = new System.Drawing.Size(162, 36);
            this.BtnBasla.TabIndex = 5;
            this.BtnBasla.Text = "Başla";
            this.BtnBasla.UseVisualStyleBackColor = true;
            this.BtnBasla.Click += new System.EventHandler(this.BtnBasla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(537, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kazanılan Para:";
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.BackColor = System.Drawing.Color.IndianRed;
            this.lblpuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpuan.ForeColor = System.Drawing.Color.White;
            this.lblpuan.Location = new System.Drawing.Point(699, 247);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(19, 20);
            this.lblpuan.TabIndex = 7;
            this.lblpuan.Text = "0";
            // 
            // lbldogru
            // 
            this.lbldogru.AutoSize = true;
            this.lbldogru.BackColor = System.Drawing.Color.IndianRed;
            this.lbldogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldogru.ForeColor = System.Drawing.Color.White;
            this.lbldogru.Location = new System.Drawing.Point(672, 433);
            this.lbldogru.Name = "lbldogru";
            this.lbldogru.Size = new System.Drawing.Size(60, 20);
            this.lbldogru.TabIndex = 8;
            this.lbldogru.Text = "dogru:";
            this.lbldogru.Visible = false;
            // 
            // lblsoru
            // 
            this.lblsoru.AutoSize = true;
            this.lblsoru.BackColor = System.Drawing.Color.IndianRed;
            this.lblsoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoru.ForeColor = System.Drawing.Color.White;
            this.lblsoru.Location = new System.Drawing.Point(620, 202);
            this.lblsoru.Name = "lblsoru";
            this.lblsoru.Size = new System.Drawing.Size(19, 20);
            this.lblsoru.TabIndex = 10;
            this.lblsoru.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(537, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Soru:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblzaman
            // 
            this.lblzaman.AutoSize = true;
            this.lblzaman.BackColor = System.Drawing.Color.IndianRed;
            this.lblzaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblzaman.ForeColor = System.Drawing.Color.White;
            this.lblzaman.Location = new System.Drawing.Point(620, 152);
            this.lblzaman.Name = "lblzaman";
            this.lblzaman.Size = new System.Drawing.Size(19, 20);
            this.lblzaman.TabIndex = 12;
            this.lblzaman.Text = "0";
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.BackColor = System.Drawing.Color.IndianRed;
            this.lblsure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsure.ForeColor = System.Drawing.Color.White;
            this.lblsure.Location = new System.Drawing.Point(537, 152);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(52, 20);
            this.lblsure.TabIndex = 11;
            this.lblsure.Text = "Süre:";
            // 
            // BtnSkorTablosu
            // 
            this.BtnSkorTablosu.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnSkorTablosu.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSkorTablosu.Location = new System.Drawing.Point(541, 294);
            this.BtnSkorTablosu.Name = "BtnSkorTablosu";
            this.BtnSkorTablosu.Size = new System.Drawing.Size(148, 36);
            this.BtnSkorTablosu.TabIndex = 15;
            this.BtnSkorTablosu.Text = "Skor Tablosu";
            this.BtnSkorTablosu.UseVisualStyleBackColor = false;
            this.BtnSkorTablosu.Visible = false;
            this.BtnSkorTablosu.Click += new System.EventHandler(this.BtnSkorTablosu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Yarışma Adı:";
            // 
            // lblYarismaAdiii
            // 
            this.lblYarismaAdiii.AutoSize = true;
            this.lblYarismaAdiii.Location = new System.Drawing.Point(98, 42);
            this.lblYarismaAdiii.Name = "lblYarismaAdiii";
            this.lblYarismaAdiii.Size = new System.Drawing.Size(13, 13);
            this.lblYarismaAdiii.TabIndex = 18;
            this.lblYarismaAdiii.Text = "0";
            this.lblYarismaAdiii.Click += new System.EventHandler(this.lblYarismaAdiii_Click);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.BackColor = System.Drawing.Color.LightSalmon;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategori.Location = new System.Drawing.Point(117, 68);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(13, 13);
            this.lblKategori.TabIndex = 19;
            this.lblKategori.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Soru Kategorisi:";
            // 
            // mİlyonerolmakisterDataSet1
            // 
            this.mİlyonerolmakisterDataSet1.DataSetName = "MİlyonerolmakisterDataSet";
            this.mİlyonerolmakisterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(12, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 36);
            this.button5.TabIndex = 21;
            this.button5.Text = "Çıkış";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 486);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblYarismaAdiii);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSkorTablosu);
            this.Controls.Add(this.lblzaman);
            this.Controls.Add(this.lblsure);
            this.Controls.Add(this.lblsoru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbldogru);
            this.Controls.Add(this.lblpuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBasla);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sempa Teknoloji Bilgi Yarışması";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mİlyonerolmakisterDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnBasla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpuan;
        private System.Windows.Forms.Label lbldogru;
        private System.Windows.Forms.Label lblsoru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblzaman;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.Button BtnSkorTablosu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblYarismaAdiii;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label label5;
        private MİlyonerolmakisterDataSet mİlyonerolmakisterDataSet1;
        private System.Windows.Forms.Button button5;
    }
}