﻿using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Vehicle[] vehicles = { new Car(), new Train() };

        
    }
}

abstract class Vehicle
{
    protected float Speed;

    public abstract void Move();    

    public float GetCurrentSpeed()
    {
        return Speed;
    }
}

class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Машина едет по асфальту.")
    }
}

class Train : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Поезд едет по рельсам.")
    }
}
