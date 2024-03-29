﻿using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiApp1.ViewModel;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        Items = new ObservableCollection<string>();
    }

    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    string text;

    void Add()
    {
        if(string.IsNullOrWhiteSpace(Text))
            return;
        Items.Add(Text);
        //add our item
        Text = string.Empty;
    }
}

//public class MainViewModel : INotifyPropertyChanged
//{
//    string text;
//    public string Text
//    {
//        get => text;
//        set
//        {
//            text = value;
//            OnPropertyChanged(nameof(Text));
//        }
//    }

//    public event PropertyChangedEventHandler PropertyChanged;

//    void OnPropertyChanged(string name) =>
//        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name)); 
//}