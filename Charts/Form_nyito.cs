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
    public partial class Form_nyito : Form
    {

        string adatforras = "";

        public Form_nyito()
        {
            InitializeComponent();
        }

        private void button_Betolt_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adatforras = openFileDialog1.FileName;
                label_fajl.Text = adatforras;
                label_Utolso_modositas_datum.Text = "Utolsó módosítás: " + File.GetCreationTime(adatforras).ToString("yyyy-MM-dd");
                label_Letrehozas_datum.Text = "Létrehozás: " + File.GetLastWriteTime(adatforras).ToString("yyyy-MM-dd");
                data_Columns.Rows.Clear();
                if (Beolvas(adatforras))
                {
                    foreach (Levels item in Program.levels)
                    {
                        int sor_index = data_Columns.Rows.Add();
                        data_Columns.Rows[sor_index].Cells["Level"].Value = Program.levels[sor_index].Level_value;
                        data_Columns.Rows[sor_index].Cells["Energy"].Value = Program.levels[sor_index].Energy;

                    }
                    //-- Megrajzolja a grafikont ----------------
                    Program.form_chart_level.Kirajzol();
                }
            }
        }

        bool Beolvas(string forras)
        {
            int page = 1;
            bool feldolgozni = false;
            try
            {
                using (StreamReader sr = new StreamReader(forras))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (String.IsNullOrEmpty(line))
                        {
                            continue;
                        } 
                        else if (line.Equals("\f"))
                        {
                            page++;
                            feldolgozni = false;
                            continue;
                        } 
                        else if (line.Substring(1, 5).Equals("-----"))
                        {
                            feldolgozni = true;
                            continue;
                        }

                        if (feldolgozni)
                        {
                            switch (page)
                            {
                                case 1:
                                    //--    List of levels ------------
                                    Program.levels.Add(new Levels(line));
                                    break;
                                case 2:
                                    //--    List of transitions --------
                                    break;
                                case 3:
                                    //--    Test of Gamma-ray and Level Energies
                                    break;
                                case 4:
                                    //--    Test of Gamma-ray Energy Sums
                                    break;
                                case 5:
                                    //--    Test of Gamma Ray Intensity Sums
                                    break;
                                default:
                                    break;
                            }
                        }
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

 

        private void Form1_Load(object sender, EventArgs e)
        {

            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory() + @"..\..";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Adatfájl kiválasztása";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Filter = "measurement data (*.dat)|*.dat|txt files (*.txt)|*.txt|All files (*.*)|*.*";

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
                column_x.Name = "Level";
                column_x.DataPropertyName = "Level";
                column_x.CellTemplate = new DataGridViewTextBoxCell();
            }
            data_Columns.Columns.Insert(0, column_x);
            
            DataGridViewColumn column_y = new DataGridViewColumn();
            {
                column_y.Name = "Energy";
                column_y.DataPropertyName = "Energy";
                column_y.CellTemplate = new DataGridViewTextBoxCell();
            }
            data_Columns.Columns.Insert(1, column_y);
        }

        private void button_Chart_Level_Click(object sender, EventArgs e)
        {
            Program.form_chart_level.Show();
        }
    }
}
