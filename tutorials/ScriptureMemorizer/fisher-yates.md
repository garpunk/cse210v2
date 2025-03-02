# Tutorial

## Topic

The fisher-yates shuffle

## Author

Please write your name below. By adding your name as the author, you are certifying that you have researched and written all of the content on this page in your own words, and did not copy and paste it from another source.

Author name: Garrett Helms

## Overview

The Fisher-yates shuffle is an algorithm that randomly shuffles an array or list. unlike the random class in C#, the fisher-yates shuffle produces true randomness.

## Purpose

The main purpose of this algorithm is when something requires true randomness, like competitive game that has to randomly choose which player goes first, or some sort of online card game that needs to shuffle a deck of cards into a random sequence.

## Syntax

So the way this algorithm works is it swaps elements in an array from the end to the beginning.

step 1. start with an array of elements

step 2. loop BACKWARDS from the LAST element down to the SECOND element.

step 3. For each element at index i:
a. pick a random index (j) between 0 an 1
b. swap the elements at i and j

step 4. repeat this process until the entire array is shuffled.

Here's an example of this code from the Scripture memorizer program:

```
 for (int i = words.Count - 1; i > 0; i--)
    {
        int j = rand.Next(i + 1);
        (words[i], words[j]) = (words[j], words[i]);
    }

```

we generate a random index (j) with the remaining part of the array (0 to i)

```
rand.Next(0, i + 1):
```

swap element i with j to ensure randomness:

```
(array[i], array[j]) = (array[j], array[i])
```

then the loop runs from n-1 to 1, ensuring every element is shuffled.

## Discussion

As you can see, this algorithm embeds the random class into it, but extrapolates its logic out in such a way that true randomness occurs. It's unbiased, so there is equal probability for any number to be returned.

## Other Interesting Notes

It is apparently very efficient for O(n) time complexity. this isn't something I've studied yet, though I know I'll need to understand this for technical interviews. and as far as I can tell, it is the best algorithm for true randomness because of it's efficiency in O(n) time complexity.
