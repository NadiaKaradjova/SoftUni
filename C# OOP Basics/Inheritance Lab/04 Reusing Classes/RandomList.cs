﻿using System;
using System.Collections;

public class RandomList : ArrayList
{
    private Random rnd;

    public RandomList()
    {
        this.rnd = new Random();
    }

    public string RandomString()
    {
        int element = rnd.Next(0, this.Count - 1);
        return (string)this[element];
    }
}