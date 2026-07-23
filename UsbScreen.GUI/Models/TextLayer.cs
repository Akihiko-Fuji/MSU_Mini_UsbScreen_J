using CommunityToolkit.Mvvm.ComponentModel;
using System;

namespace UsbScreen.GUI.Models;

public partial class TextLayer : ObservableObject
{
    public string Id { get; } = Guid.NewGuid().ToString();

    [ObservableProperty] private double _x;
    [ObservableProperty] private double _y;
    [ObservableProperty] private string _text = "Text";
    [ObservableProperty] private string _color = "White";
    [ObservableProperty] private int _fontSize = 12;
    [ObservableProperty] private string _fontFamily = FontConfiguration.AvaloniaFontFamily;

    [ObservableProperty] private string _displayText = "Text";

    partial void OnTextChanged(string value) => DisplayText = value;
    
    // For selection/UI state
    [ObservableProperty] private bool _isSelected;
}
