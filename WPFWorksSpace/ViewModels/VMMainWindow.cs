using System;
using System.IO;
using System.Net;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WPFWorksSpace
{
    class VMMainWindow : ViewModelBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public VMMainWindow()
        {
            DisplayImage = new BitmapImage(new Uri("Images/ソフィーのアトリエ.jpg", UriKind.Relative));
            MyText = "コンストラクタ";
        }

        /// <summary>
        /// 表示画像
        /// </summary>
        private ImageSource displayImage = null;
        public ImageSource DisplayImage
        {
            get => displayImage;
            set
            {
                displayImage = value;
                OnPropertyChanged(nameof(DisplayImage));
            }
        }

        /// <summary>
        /// 表示文字列
        /// </summary>
        private string myText = string.Empty;
        public string MyText
        {
            get => myText;
            set
            {
                myText = value;
                OnPropertyChanged(nameof(MyText));
            }
        }
    }
}
