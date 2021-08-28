namespace Projekat
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRacun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kategorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsKnjizaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsKnjizara = new Projekat.dsKnjizara();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.btnIzbaci = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPrikazi2 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.kategorijaTableAdapter = new Projekat.dsKnjizaraTableAdapters.KategorijaTableAdapter();
            this.btnNovaKnjiga = new System.Windows.Forms.Button();
            this.racunTableAdapter = new Projekat.dsKnjizaraTableAdapters.RacunTableAdapter();
            this.tableAdapterManager = new Projekat.dsKnjizaraTableAdapters.TableAdapterManager();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKnjizaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKnjizara)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 403);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.txtPretraga);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnRacun);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.btnPrikazi);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtKolicina);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtUkupno);
            this.tabPage1.Controls.Add(this.btnIzbaci);
            this.tabPage1.Controls.Add(this.btnDodaj);
            this.tabPage1.Controls.Add(this.listBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(192, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 61);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izaberi kriterijum";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(146, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Naslov";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Autor";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(235, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "Filtriraj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(12, 292);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(116, 20);
            this.txtPretraga.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Autor/Naslov";
            // 
            // btnRacun
            // 
            this.btnRacun.Location = new System.Drawing.Point(576, 340);
            this.btnRacun.Name = "btnRacun";
            this.btnRacun.Size = new System.Drawing.Size(115, 23);
            this.btnRacun.TabIndex = 29;
            this.btnRacun.Text = "Racun";
            this.btnRacun.UseVisualStyleBackColor = true;
            this.btnRacun.Click += new System.EventHandler(this.btnRacun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Izaberi kategoriju";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(149, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 199);
            this.listBox1.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.kategorijaBindingSource;
            this.comboBox1.DisplayMember = "naziv";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.ValueMember = "ID_kategorije";
            // 
            // kategorijaBindingSource
            // 
            this.kategorijaBindingSource.DataMember = "Kategorija";
            this.kategorijaBindingSource.DataSource = this.dsKnjizaraBindingSource;
            // 
            // dsKnjizaraBindingSource
            // 
            this.dsKnjizaraBindingSource.DataSource = this.dsKnjizara;
            this.dsKnjizaraBindingSource.Position = 0;
            // 
            // dsKnjizara
            // 
            this.dsKnjizara.DataSetName = "dsKnjizara";
            this.dsKnjizara.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(7, 114);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(121, 23);
            this.btnPrikazi.TabIndex = 21;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ukupno:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(338, 74);
            this.txtKolicina.Multiline = true;
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(77, 45);
            this.txtKolicina.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Izaberi kolicinu:";
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(576, 280);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(115, 20);
            this.txtUkupno.TabIndex = 26;
            // 
            // btnIzbaci
            // 
            this.btnIzbaci.Location = new System.Drawing.Point(715, 70);
            this.btnIzbaci.Name = "btnIzbaci";
            this.btnIzbaci.Size = new System.Drawing.Size(63, 49);
            this.btnIzbaci.TabIndex = 27;
            this.btnIzbaci.Text = "Izbaci sa racuna";
            this.btnIzbaci.UseVisualStyleBackColor = true;
            this.btnIzbaci.Click += new System.EventHandler(this.btnIzbaci_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(451, 74);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(77, 49);
            this.btnDodaj.TabIndex = 23;
            this.btnDodaj.Text = "Dodaj na racun";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(543, 34);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(174, 186);
            this.listBox2.TabIndex = 24;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPrikazi2);
            this.tabPage2.Controls.Add(this.listBox3);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPrikazi2
            // 
            this.btnPrikazi2.Location = new System.Drawing.Point(154, 182);
            this.btnPrikazi2.Name = "btnPrikazi2";
            this.btnPrikazi2.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi2.TabIndex = 11;
            this.btnPrikazi2.Text = "Prikazi";
            this.btnPrikazi2.UseVisualStyleBackColor = true;
            this.btnPrikazi2.Click += new System.EventHandler(this.btnPrikazi2_Click);
            // 
            // listBox3
            // 
            this.listBox3.DataSource = this.racunBindingSource;
            this.listBox3.DisplayMember = "vreme";
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(355, 15);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(369, 251);
            this.listBox3.TabIndex = 10;
            this.listBox3.ValueMember = "ID_racun";
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "Racun";
            this.racunBindingSource.DataSource = this.dsKnjizara;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(103, 123);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Do:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Od:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // kategorijaTableAdapter
            // 
            this.kategorijaTableAdapter.ClearBeforeFill = true;
            // 
            // btnNovaKnjiga
            // 
            this.btnNovaKnjiga.Location = new System.Drawing.Point(404, 421);
            this.btnNovaKnjiga.Name = "btnNovaKnjiga";
            this.btnNovaKnjiga.Size = new System.Drawing.Size(86, 51);
            this.btnNovaKnjiga.TabIndex = 19;
            this.btnNovaKnjiga.Text = "Dodaj novu knjigu";
            this.btnNovaKnjiga.UseVisualStyleBackColor = true;
            this.btnNovaKnjiga.Click += new System.EventHandler(this.btnNovaKnjiga_Click);
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KategorijaTableAdapter = this.kategorijaTableAdapter;
            this.tableAdapterManager.KnjigaTableAdapter = null;
            this.tableAdapterManager.RacunTableAdapter = this.racunTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projekat.dsKnjizaraTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 465);
            this.Controls.Add(this.btnNovaKnjiga);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKnjizaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKnjizara)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRacun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource dsKnjizaraBindingSource;
        private dsKnjizara dsKnjizara;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.Button btnIzbaci;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.BindingSource kategorijaBindingSource;
        private dsKnjizaraTableAdapters.KategorijaTableAdapter kategorijaTableAdapter;
        private System.Windows.Forms.Button btnPrikazi2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnNovaKnjiga;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private dsKnjizaraTableAdapters.RacunTableAdapter racunTableAdapter;
        private dsKnjizaraTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

