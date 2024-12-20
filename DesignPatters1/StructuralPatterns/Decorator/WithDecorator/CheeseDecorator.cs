﻿namespace DesignPatters1.StructuralPatterns.Decorator.WithDecorator;

public class CheeseDecorator : FoodDecorator
{
    public CheeseDecorator(IFood food) : base(food) { }

    public override double GetCost()
    {
        return base.GetCost() + 2.0;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + " + Cheese";
    }
}