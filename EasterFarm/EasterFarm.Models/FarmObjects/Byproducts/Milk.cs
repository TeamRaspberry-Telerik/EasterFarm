﻿namespace EasterFarm.Models.FarmObjects.Byproducts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using EasterFarm.Models.Contracts;

    public class Milk : Byproduct
    {
        public Milk(MatrixCoords topLeft, char[,] image) : base(topLeft, image)
        {
        }
    }
}
