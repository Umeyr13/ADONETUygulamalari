namespace Adonet_Ornek_2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxurunad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownfiyat = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownstok = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonekle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonguncelle = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text_sp_ile_ekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownfiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownstok)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 98);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1311, 528);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı";
            // 
            // textBoxurunad
            // 
            this.textBoxurunad.Location = new System.Drawing.Point(104, 12);
            this.textBoxurunad.Name = "textBoxurunad";
            this.textBoxurunad.Size = new System.Drawing.Size(292, 26);
            this.textBoxurunad.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat";
            // 
            // numericUpDownfiyat
            // 
            this.numericUpDownfiyat.Location = new System.Drawing.Point(479, 12);
            this.numericUpDownfiyat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownfiyat.Name = "numericUpDownfiyat";
            this.numericUpDownfiyat.Size = new System.Drawing.Size(164, 26);
            this.numericUpDownfiyat.TabIndex = 1;
            // 
            // numericUpDownstok
            // 
            this.numericUpDownstok.Location = new System.Drawing.Point(714, 12);
            this.numericUpDownstok.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownstok.Name = "numericUpDownstok";
            this.numericUpDownstok.Size = new System.Drawing.Size(179, 26);
            this.numericUpDownstok.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(665, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stok";
            // 
            // buttonekle
            // 
            this.buttonekle.Location = new System.Drawing.Point(921, 12);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(115, 38);
            this.buttonekle.TabIndex = 3;
            this.buttonekle.Text = "Ekle";
            this.buttonekle.UseVisualStyleBackColor = true;
            this.buttonekle.Click += new System.EventHandler(this.buttonekle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1042, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kategoriler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonguncelle
            // 
            this.buttonguncelle.Location = new System.Drawing.Point(1163, 12);
            this.buttonguncelle.Name = "buttonguncelle";
            this.buttonguncelle.Size = new System.Drawing.Size(115, 38);
            this.buttonguncelle.TabIndex = 3;
            this.buttonguncelle.Text = "Güncelle";
            this.buttonguncelle.UseVisualStyleBackColor = true;
            this.buttonguncelle.Click += new System.EventHandler(this.buttonguncelle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 28);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // text_sp_ile_ekle
            // 
            this.text_sp_ile_ekle.Location = new System.Drawing.Point(921, 56);
            this.text_sp_ile_ekle.Name = "text_sp_ile_ekle";
            this.text_sp_ile_ekle.Size = new System.Drawing.Size(236, 38);
            this.text_sp_ile_ekle.TabIndex = 3;
            this.text_sp_ile_ekle.Text = "Stored Procedure ile ekle";
            this.text_sp_ile_ekle.UseVisualStyleBackColor = true;
            this.text_sp_ile_ekle.Click += new System.EventHandler(this.text_sp_ile_ekle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 626);
            this.Controls.Add(this.buttonguncelle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_sp_ile_ekle);
            this.Controls.Add(this.buttonekle);
            this.Controls.Add(this.numericUpDownstok);
            this.Controls.Add(this.numericUpDownfiyat);
            this.Controls.Add(this.textBoxurunad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownfiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownstok)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxurunad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownfiyat;
        private System.Windows.Forms.NumericUpDown numericUpDownstok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonekle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonguncelle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button text_sp_ile_ekle;
    }
}

