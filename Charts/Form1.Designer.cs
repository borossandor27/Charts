namespace Charts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.data_Columns = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_Letrehozas_datum = new System.Windows.Forms.Label();
            this.label_Utolso_modositas_datum = new System.Windows.Forms.Label();
            this.button_Betolt = new System.Windows.Forms.Button();
            this.label_fajl = new System.Windows.Forms.Label();
            this.comboBox_Valaszthato_Fajlok = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Columns)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(0, 150);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(800, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // data_Columns
            // 
            this.data_Columns.AllowUserToAddRows = false;
            this.data_Columns.AllowUserToDeleteRows = false;
            this.data_Columns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Columns.Dock = System.Windows.Forms.DockStyle.Right;
            this.data_Columns.Location = new System.Drawing.Point(560, 0);
            this.data_Columns.Name = "data_Columns";
            this.data_Columns.ReadOnly = true;
            this.data_Columns.Size = new System.Drawing.Size(240, 150);
            this.data_Columns.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Forrásfájl";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label_Letrehozas_datum
            // 
            this.label_Letrehozas_datum.AutoSize = true;
            this.label_Letrehozas_datum.Location = new System.Drawing.Point(13, 95);
            this.label_Letrehozas_datum.Name = "label_Letrehozas_datum";
            this.label_Letrehozas_datum.Size = new System.Drawing.Size(55, 13);
            this.label_Letrehozas_datum.TabIndex = 4;
            this.label_Letrehozas_datum.Text = "letrehozas";
            // 
            // label_Utolso_modositas_datum
            // 
            this.label_Utolso_modositas_datum.AutoSize = true;
            this.label_Utolso_modositas_datum.Location = new System.Drawing.Point(13, 117);
            this.label_Utolso_modositas_datum.Name = "label_Utolso_modositas_datum";
            this.label_Utolso_modositas_datum.Size = new System.Drawing.Size(54, 13);
            this.label_Utolso_modositas_datum.TabIndex = 5;
            this.label_Utolso_modositas_datum.Text = "modositas";
            // 
            // button_Betolt
            // 
            this.button_Betolt.Location = new System.Drawing.Point(323, 13);
            this.button_Betolt.Name = "button_Betolt";
            this.button_Betolt.Size = new System.Drawing.Size(75, 23);
            this.button_Betolt.TabIndex = 6;
            this.button_Betolt.Text = "Betölt";
            this.button_Betolt.UseVisualStyleBackColor = true;
            this.button_Betolt.Click += new System.EventHandler(this.button_Betolt_Click);
            // 
            // label_fajl
            // 
            this.label_fajl.AutoSize = true;
            this.label_fajl.Location = new System.Drawing.Point(13, 73);
            this.label_fajl.Name = "label_fajl";
            this.label_fajl.Size = new System.Drawing.Size(20, 13);
            this.label_fajl.TabIndex = 7;
            this.label_fajl.Text = "fajl";
            // 
            // comboBox_Valaszthato_Fajlok
            // 
            this.comboBox_Valaszthato_Fajlok.FormattingEnabled = true;
            this.comboBox_Valaszthato_Fajlok.Location = new System.Drawing.Point(90, 43);
            this.comboBox_Valaszthato_Fajlok.Name = "comboBox_Valaszthato_Fajlok";
            this.comboBox_Valaszthato_Fajlok.Size = new System.Drawing.Size(214, 21);
            this.comboBox_Valaszthato_Fajlok.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_Valaszthato_Fajlok);
            this.Controls.Add(this.label_fajl);
            this.Controls.Add(this.button_Betolt);
            this.Controls.Add(this.label_Utolso_modositas_datum);
            this.Controls.Add(this.label_Letrehozas_datum);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_Columns);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Adatsorok ábrázolása";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Columns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView data_Columns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_Letrehozas_datum;
        private System.Windows.Forms.Label label_Utolso_modositas_datum;
        private System.Windows.Forms.Button button_Betolt;
        private System.Windows.Forms.Label label_fajl;
        private System.Windows.Forms.ComboBox comboBox_Valaszthato_Fajlok;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

