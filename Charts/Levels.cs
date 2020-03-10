using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charts
{
    class Levels
    {
        string level_label;
        int level_value;
        double energy;
        int jpi_value;
        int jpi_spin;
        double k;

        public Levels(string line)
        {
            this.Level_label = line.Substring(0, 12).Trim();
            if (level_label.Length>3)
            {
                int.TryParse(line.Substring(0, 12).Split(new char[] { '_', '-' })[1].Trim(), out this.level_value);
            }
            else
            {
                this.level_value = 0;
            }
            double.TryParse(line.Substring(13, 17).Trim().Split('(')[0], out this.energy);

        }

        public double Energy { get => energy; set => energy = value; }
        public int Jpi_value { get => jpi_value; set => jpi_value = value; }
        public int Jpi_spin { get => jpi_spin; set => jpi_spin = value; }
        public double K { get => k; set => k = value; }
        public string Level_label { get => level_label; set => level_label = value; }
        public int Level_value { get => level_value; set => level_value = value; }
    }
}
