using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFWorksSpace
{
    /// <summary>
    /// ImageDisplayWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ImageDisplayWindow : UserControl
    {
        public ImageDisplayWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 表示画像の依存関係プロパティ
        /// </summary>
        public ImageSource DisplayImage
        {
            get { return (ImageSource)GetValue(DisplayImageProperty); }
            set { SetValue(DisplayImageProperty, value); }
        }
        public static readonly DependencyProperty DisplayImageProperty =
            DependencyProperty.Register(
                nameof(DisplayImage),           // プロパティ名
                typeof(ImageSource),            // プロパティの型
                typeof(ImageDisplayWindow),     // プロパティを所有する型＝このクラスの名前
                new PropertyMetadata(null));    // 初期値

        /// <summary>
        /// 文字列の依存関係プロパティ
        /// </summary>
        public string MyText
        {
            get { return (string)GetValue(MyTextProperty); }
            set { SetValue(MyTextProperty, value); }
        }
        public static readonly DependencyProperty MyTextProperty =
            DependencyProperty.Register(
                nameof(MyText),                         // プロパティ名
                typeof(string),                         // プロパティの型
                typeof(ImageDisplayWindow),             // プロパティを所有する型＝このクラスの名前
                new PropertyMetadata(string.Empty));    // 初期値

        private void Image_MouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
        }
    }
}
