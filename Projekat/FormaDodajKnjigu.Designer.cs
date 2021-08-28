namespace Projekat
{
    partial class FormaDodajKnjigu
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
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label cenaLabel;
            System.Windows.Forms.Label popustLabel;
            System.Windows.Forms.Label id_kategorijaLabel;
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnUpisi = new System.Windows.Forms.Button();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.popustTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dsKnjizara = new Projekat.dsKnjizara();
            this.kategorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorijaTableAdapter = new Projekat.dsKnjizaraTableAdapters.KategorijaTableAdapter();
            nazivLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            popustLabel = new System.Windows.Forms.Label();
            id_kategorijaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsKnjizara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nazivLabel.Location = new System.Drawing.Point(258, 118);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(43, 13);
            nazivLabel.TabIndex = 15;
            nazivLabel.Text = "Naziv:";
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            autorLabel.Location = new System.Drawing.Point(258, 144);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(41, 13);
            autorLabel.TabIndex = 17;
            autorLabel.Text = "Autor:";
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cenaLabel.Location = new System.Drawing.Point(258, 170);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(40, 13);
            cenaLabel.TabIndex = 19;
            cenaLabel.Text = "Cena:";
            // 
            // popustLabel
            // 
            popustLabel.AutoSize = true;
            popustLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            popustLabel.Location = new System.Drawing.Point(258, 199);
            popustLabel.Name = "popustLabel";
            popustLabel.Size = new System.Drawing.Size(50, 13);
            popustLabel.TabIndex = 21;
            popustLabel.Text = "Popust:";
            // 
            // id_kategorijaLabel
            // 
            id_kategorijaLabel.AutoSize = true;
            id_kategorijaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_kategorijaLabel.Location = new System.Drawing.Point(258, 225);
            id_kategorijaLabel.Name = "id_kategorijaLabel";
            id_kategorijaLabel.Size = new System.Drawing.Size(64, 13);
            id_kategorijaLabel.TabIndex = 23;
            id_kategorijaLabel.Text = "Kategorija";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.kategorijaBindingSource;
            this.comboBox1.DisplayMember = "naziv";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(350, 225);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.ValueMember = "ID_kategorije";
            // 
            // btnUpisi
            // 
            this.btnUpisi.Location = new System.Drawing.Point(379, 269);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(92, 33);
            this.btnUpisi.TabIndex = 24;
            this.btnUpisi.Text = "Upisi";
            this.btnUpisi.UseVisualStyleBackColor = true;
            this.btnUpisi.Click += new System.EventHandler(this.btnUpisi_Click);
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(350, 118);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(152, 20);
            this.nazivTextBox.TabIndex = 16;
            // 
            // autorTextBox
            // 
            this.autorTextBox.Location = new System.Drawing.Point(350, 144);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(152, 20);
            this.autorTextBox.TabIndex = 18;
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.Location = new System.Drawing.Point(350, 170);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(152, 20);
            this.cenaTextBox.TabIndex = 20;
            // 
            // popustTextBox
            // 
            this.popustTextBox.Location = new System.Drawing.Point(350, 196);
            this.popustTextBox.Name = "popustTextBox";
            this.popustTextBox.Size = new System.Drawing.Size(152, 20);
            this.popustTextBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Dodaj novu knjigu";
            // 
            // dsKnjizara
            // 
            this.dsKnjizara.DataSetName = "dsKnjizara";
            this.dsKnjizara.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorijaBindingSource
            // 
            this.kategorijaBindingSource.DataMember = "Kategorija";
            this.kategorijaBindingSource.DataSource = this.dsKnjizara;
            // 
            // kategorijaTableAdapter
            // 
            this.kategorijaTableAdapter.ClearBeforeFill = true;
            // 
            // FormaDodajKnjigu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnUpisi);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(autorLabel);
            this.Controls.Add(this.autorTextBox);
            this.Controls.Add(cenaLabel);
            this.Controls.Add(this.cenaTextBox);
            this.Controls.Add(popustLabel);
            this.Controls.Add(this.popustTextBox);
            this.Controls.Add(id_kategorijaLabel);
            this.Name = "FormaDodajKnjigu";
            this.Text = "FormaDodajKnjigu";
            this.Load += new System.EventHandler(this.FormaDodajKnjigu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsKnjizara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnUpisi;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.TextBox popustTextBox;
        private System.Windows.Forms.Label label1;
        private dsKnjizara dsKnjizara;
        private System.Windows.Forms.BindingSource kategorijaBindingSource;
        private dsKnjizaraTableAdapters.KategorijaTableAdapter kategorijaTableAdapter;
    }
}