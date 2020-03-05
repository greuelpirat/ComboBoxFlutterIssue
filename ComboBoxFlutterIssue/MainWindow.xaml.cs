using System;

namespace ComboBoxFlutterIssue
{
    public enum SortBy
    {
        Opened,
        Modified,
        Name
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public SortBy SortBy { get; set; } = SortBy.Name;

        public static Tuple<SortBy, string>[] SortByOptions { get; } =
        {
            new Tuple<SortBy, string>(SortBy.Opened, "Kürzlich geöffnet"),
            new Tuple<SortBy, string>(SortBy.Modified, "Kürzlich geändert"),
            new Tuple<SortBy, string>(SortBy.Name, "Name")
        };
    }
}