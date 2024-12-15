﻿using DesignPatters1.Decorator.WithDecorator;

namespace DesignPatters1.Decorator.WithoutDecorator;

public class FoodWithSpicesN : IFoodN
{
    private readonly IFoodN _food;

    public FoodWithSpicesN(IFoodN food)
    {
        _food = food;
    }

    public double GetCost()
    {
        return _food.GetCost() + 3.0;
    }

    public string GetDescription()
    {
        return _food.GetDescription() + " + Spices";
    }
}