using System;
using System.Globalization;
using Avalonia.Data.Converters;
using AvaloniaMatrixInvertIssue.ViewModels;

namespace AvaloniaMatrixInvertIssue.Converters;

public class VideoToLowestQualityThumbnailUrlConverter : IValueConverter
{
    public static VideoToLowestQualityThumbnailUrlConverter Instance { get; } = new();

    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        //return "https://img.youtube.com/vi/YQHsXMglC9A/default.jpg";
        if (value is VideoViewModel video)
        {
            string? url = video.Url;
            return url;
        }
        return null;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) =>
        throw new NotSupportedException();
}