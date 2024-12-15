﻿using DesignPatters1.Decorator.WithDecorator;

namespace DesignPatters1.Decorator.WithoutDecorator;

public class FoodWithCheeseN : IFoodN
{
    private readonly IFoodN _food;

    public FoodWithCheeseN(IFoodN food)
    {
        _food = food;
    }

    public double GetCost()
    {
        return _food.GetCost() + 2.0;
    }

    public string GetDescription()
    {
        return _food.GetDescription() + " + Cheese";
    }
}