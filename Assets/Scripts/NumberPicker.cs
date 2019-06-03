﻿using UnityEngine;
using System.Collections;

public class NumberPicker
{
    private int _min;
    private int _max;

    public NumberPicker (int min, int max)
    {
        if (max <= min)
        {
            throw new System.Exception("Are you kidding me?");
        }

        _min = min;
        _max = max;
    }

    public NumberPicker ()
    {
        _min = (int) Random.Range(0, 100000);
        _max = (int) Random.Range(_min, _min + 100000);
    }
    
    public int suggest ()
    {
        return (_min + _max) / 2;
    }

    public void lower ()
    {
        int suggestion = this.suggest();
        _max = suggestion;
    }

    public void highter()
    {
        int suggestion = this.suggest();
        _min = suggestion;
    }

    public int getMin()
    {
        return _min;
    }
    public int getMax()
    {
        return _max;
    }
}