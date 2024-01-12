﻿
using System.Collections;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;

var niceColors = new [] { "Blue", "Purple", "Pink" };

var yellow = "Yellow";
List<string> otherColors = ["Green", "Orange", "Red", yellow];
var moreColors = new[] { "Grey", "Black" };

string[] allColors = [ .. niceColors, .. otherColors, "Brown", 
    ..moreColors];
Console.WriteLine(string.Join(", ", allColors));

Span<int> numbers = [ 1, 2, 3 ];

int Sum(IEnumerable<int> numbers) => numbers.Sum(x => x);

Sum([4, 8, 9, ..numbers]);

LineBuffer buffer = ['x', 'y', 'z'];
public class CollectionTest
{
    public static readonly ImmutableArray<int> numbers = [ 1, 2, 3 ];

    public IEnumerable<int> Ints => [ 1, 2, 3 ];
}

[CollectionBuilder(typeof(LineBufferBuilder), "Create")]
public class LineBuffer(ReadOnlySpan<char> chars): IEnumerable<char>
{
    private readonly char[] charBuffer = new char[80];

    public IEnumerator<char> GetEnumerator() =>
        charBuffer.AsEnumerable().GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => 
        charBuffer.GetEnumerator();
}
internal static class LineBufferBuilder
{
    internal static LineBuffer Create(ReadOnlySpan<char> values) => 
        new LineBuffer(values);
}




