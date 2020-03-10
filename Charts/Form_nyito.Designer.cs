namespace Charts
{
    partial class Form_nyito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_nyito));
            this.data_Columns = new System.Windows.Forms.DataGridView();
            this.label_Letrehozas_datum = new System.Windows.Forms.Label();
            this.label_Utolso_modositas_datum = new System.Windows.Forms.Label();
            this.button_Betolt = new System.Windows.Forms.Button();
            this.label_fajl = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_Chart_Level = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_Columns)).BeginInit();
            this.SuspendLayout();
            // 
            // data_Columns
            // 
            this.data_Columns.AllowUserToAddRows = false;
            this.data_Columns.AllowUserToDeleteRows = false;
            this.data_Columns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Columns.Dock = System.Windows.Forms.DockStyle.Right;
            this.data_Columns.Location = new System.Drawing.Point(402, 0);
            this.data_Columns.Name = "data_Columns";
            this.data_Columns.ReadOnly = true;
            this.data_Columns.Size = new System.Drawing.Size(398, 450);
            this.data_Columns.TabIndex = 1;
            // 
            // label_Letrehozas_datum
            // 
            this.label_Letrehozas_datum.AutoSize = true;
            this.label_Letrehozas_datum.Location = new System.Drawing.Point(26, 58);
            this.label_Letrehozas_datum.Name = "label_Letrehozas_datum";
            this.label_Letrehozas_datum.Size = new System.Drawing.Size(55, 13);
            this.label_Letrehozas_datum.TabIndex = 4;
            this.label_Letrehozas_datum.Text = "letrehozas";
            // 
            // label_Utolso_modositas_datum
            // 
            this.label_Utolso_modositas_datum.AutoSize = true;
            this.label_Utolso_modositas_datum.Location = new System.Drawing.Point(26, 80);
            this.label_Utolso_modositas_datum.Name = "label_Utolso_modositas_datum";
            this.label_Utolso_modositas_datum.Size = new System.Drawing.Size(54, 13);
            this.label_Utolso_modositas_datum.TabIndex = 5;
            this.label_Utolso_modositas_datum.Text = "modositas";
            // 
            // button_Betolt
            // 
            this.button_Betolt.Location = new System.Drawing.Point(12, 10);
            this.button_Betolt.Name = "button_Betolt";
            this.button_Betolt.Size = new System.Drawing.Size(75, 23);
            this.button_Betolt.TabIndex = 6;
            this.button_Betolt.Text = "Kiválaszt";
            this.button_Betolt.UseVisualStyleBackColor = true;
            this.button_Betolt.Click += new System.EventHandler(this.button_Betolt_Click);
            // 
            // label_fajl
            // 
            this.label_fajl.AutoSize = true;
            this.label_fajl.Location = new System.Drawing.Point(26, 36);
            this.label_fajl.Name = "label_fajl";
            this.label_fajl.Size = new System.Drawing.Size(52, 13);
            this.label_fajl.TabIndex = 7;
            this.label_fajl.Text = "forrásfájl: ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_Chart_Level
            // 
            this.button_Chart_Level.Location = new System.Drawing.Point(100, 140);
            this.button_Chart_Level.Name = "button_Chart_Level";
            this.button_Chart_Level.Size = new System.Drawing.Size(75, 23);
            this.button_Chart_Level.TabIndex = 8;
            this.button_Chart_Level.Text = "Ábrázol";
            this.button_Chart_Level.UseVisualStyleBackColor = true;
            this.button_Chart_Level.Click += new System.EventHandler(this.button_Chart_Level_Click);
            // 
            // Form_nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Chart_Level);
            this.Controls.Add(this.label_fajl);
            this.Controls.Add(this.button_Betolt);
            this.Controls.Add(this.label_Utolso_modositas_datum);
            this.Controls.Add(this.label_Letrehozas_datum);
            this.Controls.Add(this.data_Columns);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_nyito";
            this.Text = "Adatsorok ábrázolása";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Columns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView data_Columns;
        private System.Windows.Forms.Label label_Letrehozas_datum;
        private System.Windows.Forms.Label label_Utolso_modositas_datum;
        private System.Windows.Forms.Button button_Betolt;
        private System.Windows.Forms.Label label_fajl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_Chart_Level;
    }
}

