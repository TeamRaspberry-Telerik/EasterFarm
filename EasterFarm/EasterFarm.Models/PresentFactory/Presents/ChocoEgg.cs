﻿namespace EasterFarm.Models.PresentFactory.Presents
{
    using EasterFarm.Models.Market;

    public class ChocoEgg : Present
    {
        private const int EggsAmmount = 2;
        private const int FlourAmmount = 1;
        private const int CocoaAmmount = 3;
        private const int MilkAmmount = 1;
        private const int BasketAmmount = 1;

        public ChocoEgg(FarmManager producer)
            : base(PresentType.ChocoEgg, (int)PresentType.ChocoEgg, MarketCurrency.Blueberries, producer)
        {
        }

        public override void SetIngredients()
        {
            this.NeededIngredients.Add(IngredientType.Egg, EggsAmmount);
            this.NeededIngredients.Add(IngredientType.Flour, FlourAmmount);
            this.NeededIngredients.Add(IngredientType.Cocoa, CocoaAmmount);
            this.NeededIngredients.Add(IngredientType.Milk, MilkAmmount);
            this.NeededIngredients.Add(IngredientType.Basket, BasketAmmount);
        }
    }
}
