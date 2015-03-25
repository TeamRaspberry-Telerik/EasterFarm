﻿namespace EasterFarm.Models.Contracts
{
    using EasterFarm.Models.Market;

    public interface IBuyable : IProduct
    {
        int Price { get; }
    }
}
