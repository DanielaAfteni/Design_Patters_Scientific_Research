﻿namespace DesignPatters1.CreationalPatterns.Singleton.WithSingleton;

public sealed class Singleton
{
    private Singleton() { }

    private static Singleton _instance;

    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }

    public void someBusinessLogic()
    {
        // ...
    }
}