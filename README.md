# How to display items with multiple columns in the xamarin.forms listview?
This example demonstrates how to display items with multiple columns in the xamarin.forms listview by using the gridlayout.

## Sample

```xaml
 <Grid Margin="0,10,0,0">
    <Grid.RowDefinitions>
        <RowDefinition Height="40"/>
        <RowDefinition Height="*"/>
    </Grid.RowDefinitions>
    <Grid x:Name="headerGrid" BackgroundColor="#FFEEEEF2" HeightRequest="45">
        <Label Text="Photos" HorizontalOptions="CenterAndExpand" VerticalOptions="CenterAndExpand"
            FontAttributes="Bold" FontSize="16"/>
    </Grid>
    <syncfusion:SfListView x:Name="listView" Grid.Row="1"
                            ItemsSource="{Binding Gallerynfo}"
                            SelectionMode="None"
                            ItemSize="150"
                            ItemSpacing="3">

        <syncfusion:SfListView.LayoutManager>
            <syncfusion:GridLayout SpanCount=2>
            </syncfusion:GridLayout>
        </syncfusion:SfListView.LayoutManager>
        
        <syncfusion:SfListView.DataSource>
            <data:DataSource>
                <data:DataSource.GroupDescriptors>
                    <data:GroupDescriptor PropertyName="CreatedDate"/>
                </data:DataSource.GroupDescriptors>
            </data:DataSource>
        </syncfusion:SfListView.DataSource>
        <syncfusion:SfListView.GroupHeaderTemplate>
            <DataTemplate>
                <ViewCell>
                    <ViewCell.View>
                        <code>
                        . . .
                        . . .
                        <code>
                    </ViewCell.View>
                </ViewCell>
            </DataTemplate>
        </syncfusion:SfListView.GroupHeaderTemplate>
        <syncfusion:SfListView.ItemTemplate>
            <DataTemplate>
                <code>
                . . .
                . . .
                <code>
            </DataTemplate>
        </syncfusion:SfListView.ItemTemplate>
    </syncfusion:SfListView>
</Grid>
```

See [How to display items with multiple columns in the xamarin.forms listview](https://www.syncfusion.com/kb/9980/how-to-display-items-with-multiple-columns-in-the-xamarin-forms-listview) for more details.
## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.