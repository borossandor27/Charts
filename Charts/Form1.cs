using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Charts
{
    public partial class Form1 : Form
    {
        string adatforras = "";
        List<Adat> adatok = new List<Adat>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Betolt_Click(object sender, EventArgs e)
        {
            //foreach (DriveInfo Drive in DriveInfo.GetDrives())
            //{
            //    foreach (string filePath in Directory.GetDirectories(Drive.Name))
            //    {
            //        try
            //        {
            //            if (!string.IsNullOrWhiteSpace(filePath) && !filePath.ToLower().Contains("program files") && !filePath.ToLower().Contains("$"))
            //            {
            //                foreach (string f in Directory.GetFiles(filePath, "*.txt", SearchOption.AllDirectories))
            //                {
            //                    comboBox_Valaszthato_Fajlok.Items.Add(f);
            //                }
            //            }
            //        }
            //        catch (IOException ex)
            //        {
            //            Console.WriteLine(ex.Message);
            //            Console.ReadKey();
            //        }
            //    }
            //}
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adatforras = openFileDialog1.FileName;
                label_fajl.Text = adatforras;
                label_Utolso_modositas_datum.Text = "Utolsó módosítás: " + File.GetCreationTime(adatforras).ToString("yyyy-MM-dd");
                label_Letrehozas_datum.Text = "Létrehozás: " + File.GetLastWriteTime(adatforras).ToString("yyyy-MM-dd");
                if (Beolvas(adatforras))
                {
                    //-- Megrajzolja a grafikont ----------------
                    Kirajzol();
                }
            }
        }

        bool Beolvas(string forras)
        {
            try
            {
                using (StreamReader sr = new StreamReader(forras))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        string[] sor = sr.ReadLine().Split(';');
                        adatok.Add(new Adat(float.Parse(sor[0]), float.Parse(sor[1])));
                    }
                }
                return true;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        void Kirajzol()
        {
            chart1.Series.Clear();
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Series1",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line
            };

            this.chart1.Series.Add(series1);

            for (int i = 0; i < adatok.Count; i++)
            {
                series1.Points.AddXY(adatok[i].X, adatok[i].Y);
            }
            chart1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Adatfájl kiválasztása";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            data_Columns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Columns.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data_Columns.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            data_Columns.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            data_Columns.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
            data_Columns.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            data_Columns.MultiSelect = false;
            data_Columns.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //-- Az id oszlop --------------------------------------------------
            DataGridViewColumn column_x = new DataGridViewColumn();
            {
                column_x.Name = "x";
                column_x.DataPropertyName = "X";
                column_x.CellTemplate = new DataGridViewTextBoxCell();
            }
            data_Columns.Columns.Insert(0, column_x);
            
            DataGridViewColumn column_y = new DataGridViewColumn();
            {
                column_y.Name = "y";
                column_y.DataPropertyName = "Y";
                column_y.CellTemplate = new DataGridViewTextBoxCell();
            }
            data_Columns.Columns.Insert(0, column_y);
        }
    }
}
