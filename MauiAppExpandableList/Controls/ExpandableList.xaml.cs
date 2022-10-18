using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiAppExpandableList.Controls;

public partial class ExpandableList : ContentView
{

    public static readonly BindableProperty GroupNameProperty = BindableProperty.Create(nameof(GroupName),
           typeof(string),
           typeof(ExpandableList),
           defaultValue: "",
           defaultBindingMode: BindingMode.OneWay,
           propertyChanged: GroupNamePropertyChanged);
    public static readonly BindableProperty GroupValuesProperty = BindableProperty.Create(nameof(GroupValues),
          typeof(string[]),
          typeof(ExpandableList),
          defaultValue: new string[] { "" },
          defaultBindingMode: BindingMode.OneWay,
          propertyChanged: GroupValuesPropertyChanged);

    private static void GroupNamePropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (ExpandableList)bindable;
        control.GroupNameLabel.Text = newValue?.ToString();
    }

    public string GroupName
    {
        get
        {
            return base.GetValue(GroupNameProperty)?.ToString();
        }

        set
        {
            base.SetValue(GroupNameProperty, value);
        }
    }

    private static void GroupValuesPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (ExpandableList)bindable;
        control.CollectionView.ItemsSource = (string[])newValue;
    }

    public string[] GroupValues
    {
        get
        {
            return (string[])base.GetValue(GroupValuesProperty);
        }
        set
        {
            base.SetValue(GroupValuesProperty, value);
        }
    }

    public ExpandableList()
	{
		InitializeComponent();
      
    }

    private void GroupNameCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        throw new NotImplementedException();
    }

 

}