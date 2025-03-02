# Tutorial

## Topic

parsing

## Author

Please write your name below. By adding your name as the author, you are certifying that you have researched and written all of the content on this page in your own words, and did not copy and paste it from another source.

Author name: Garrett Helms

## Overview

Parse(), specifically int.Parse(), converts an input from a string into an integer.

## Purpose

A problem I ran into is that console.ReadLine() always returns strings, so parsing is similar to putting the int declarer outside of a print statement in python ("3" becomes 3).

## Syntax

it's very simple syntax, int.Parse()

in my code, I set duration equal to the output of the console converted into an integer.

```
 duration = int.Parse(Console.ReadLine());
```

## Discussion

So from what I've read online, this has to do with the concept of type casting, where we convert one datatype into another. C# has very strong element-typing, so we need to make sure the variables we're working with are the right type.

## Other Interesting Notes

There's another method called TryParse() that returns boolean values, I might see if I can use it in my next project and make documentation on it. parcing decimals needs double.Parse() or float.Parse().
