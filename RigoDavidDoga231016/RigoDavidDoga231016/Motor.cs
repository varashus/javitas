﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RigoDavidDoga231016
{
    class Motor
    {
        public Motor(string r)
        {
            var v = r.Split(';');
            this.gyarto = v[0];
            this.modell = v[1];
            this.maxseb = int.Parse(v[2]);
            this.fogyasztas = double.Parse(v[3]);
            this.urtartalom = double.Parse(v[4]);
            this.felfugg = v[5];
            this.gallon = fogyasztas / 0.264172; //*

        }

        public string gyarto { get; set; } //(NEM INDOKOLT A PROTECTED, NINCS GYEREKOSZTÁLY)
        public string modell { get;  set; }
        public int maxseb { get;  set; }
        public double fogyasztas { get;  set; }
        public Double urtartalom { get;  set; }
        public string felfugg { get;  set; }
        public double gallon  { get; set; }
        public override string ToString()
        {
            
                return $" gyarto: {gyarto} modell:{modell} maxsebesség:{maxseb} fogyasztás:{fogyasztas} űrtartalom: {urtartalom} felfüggesztés tipusa:{felfugg}";
     
            
        }
    }

    






}
