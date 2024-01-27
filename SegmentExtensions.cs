using System.Collections.Generic;
using Avalonia.Media;
using Geometry;
using Segment = Geometry.Segment;

namespace GeometryPainting;

public static class SegmentExtensions
{
    private static readonly Dictionary<Segment, Color> Colors = new();

    public static void SetColor(this Segment segment, Color color) 
        => Colors[segment] = color;

    public static Color GetColor(this Segment segment) 
        => Colors.ContainsKey(segment) 
            ? Colors[segment] 
            : Avalonia.Media.Colors.Black;
}