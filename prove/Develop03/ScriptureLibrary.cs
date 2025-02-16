using System;
using System.Collections.Generic;
//this whole class is for exceeding requirements
public class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _rand = new Random();

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Moses", 1, 39), "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man."),
            new Scripture(new Reference("Matthew", 5, 14, 16), "Ye are the light of the world. A city that is set on an hill cannot be hid. Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house. Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("Alma", 37, 6), "By small and simple things are great things brought to pass."),
            new Scripture(new Reference("Ether", 12, 27), "If men come unto me I will show unto them their weakness."),
            new Scripture(new Reference("Mosiah", 2, 17), "When ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture(new Reference("Romans", 8, 28), "All things work together for good to them that love God."),
            new Scripture(new Reference("D&C", 6, 36), "Look unto me in every thought; doubt not, fear not.")
        };
    }

    public Scripture GetRandomScripture()
    {
        int index = _rand.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
