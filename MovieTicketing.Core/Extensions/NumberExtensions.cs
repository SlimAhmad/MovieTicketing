﻿namespace MovieTicketing.Core;

public static class NumberExtensions
{
    public static string FormattedNumber(this double number) =>
        number switch
        {
            >= 1000000 => (number / 1000000D).ToString("0.#M"),
            >= 10000 => (number / 1000D).ToString("0.#K"),
            _ => number.ToString("#,0")
        };
}