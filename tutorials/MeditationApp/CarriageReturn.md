# Tutorial

## Topic

Carriage Return

## Author

Please write your name below. By adding your name as the author, you are certifying that you have researched and written all of the content on this page in your own words, and did not copy and paste it from another source.

Author name: Garrett Helms

## Overview

Carriage Return "\r" moves the cursor back to the beginning of a line and allows what you've already written to be rewritten

## Purpose

The main purpose of carriage return is when you start dealing with counting with numbers that are larger than 1 interger, you can more easily replace them than through the \b return.

## Syntax

Carriage Return is similar to the \b return, except it moves the cursor back to the beginning of the line rather than a single space back, so it's more scaleable for terminal manipulations in general.

```
for (int i = seconds; i > 0; i--)
    {
        Console.Write($"\r{i}   ");
        Thread.Sleep(1000);
    }

```

You return the cursor to the beginning of the same line that prints {i} which is whatever the current countdown number is (plus a few extra spaces to erase some possibly larger numbers).

## Discussion

The Carriage return is quite useful for printing and replacing much larger numbers, as you don't have to count out how many \b lines you need, given that the numbers printed are within a reasonable range. if we needed it to infinitely scale you'd probably have to do something more involved.

## Other Interesting Notes

I had to make this because of my StretchingSession, which needs larger integers to display the stretching countdowns. I really like this tool and will probably use it more in the future!
