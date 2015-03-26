﻿namespace EasterFarm.Models.FarmObjects.Food
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Raspberry : FarmFood
    {
        private static char[,] image = new char[,] { { '♣' } };
        public Raspberry(MatrixCoords topLeft, bool isSpoiled) : base(topLeft, image, isSpoiled)
        {
        }
    }
}
