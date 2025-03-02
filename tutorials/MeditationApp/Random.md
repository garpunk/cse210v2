# Tutorial

## Topic

Random()

## Author

Please write your name below. By adding your name as the author, you are certifying that you have researched and written all of the content on this page in your own words, and did not copy and paste it from another source.

Author name: Garrett Helms

## Overview

I know we've talked about the random class before, but I saw this as a chance to help me understand it better.

## Purpose

So the random class is a simple, built-in C# class that generates numbers that are "random". I put quotations around "random" because although it does generate different numbers, it isn't truly random.

## Syntax

random as a class actually has a few of it's own useful built-in methods. the one we used in the project is the .Next() method.

```
private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
```

In this code, we're picking a random index from 0 - \_prompts.Count - 1, and rand.Next() generates generates a random number between that range. very similar to pythons .randint() function

## Discussion

The useful thing about using random and specifically random.Next() is that if true randomness isn't that important it will shuffle and pick choices fairly decently. for our simple program it suffices, but if this was code tied to something like a competitive game that uses some sort of coin flip mechanic to choose a starting player, it would be much more important to create robust randomization.

## Other Interesting Notes

Though I haven't made documentation for it yet, there is actually an algorithm you can use that generates true randomness called the fisher-yates shuffle.
