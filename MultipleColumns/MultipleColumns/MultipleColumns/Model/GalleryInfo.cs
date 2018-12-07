using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewGridLayout
{
    public class ListViewGalleryInfo : INotifyPropertyChanged
    {
        #region Fields

        private ImageSource image;
        private string imageTitle;
        private string createdData;

        #endregion

        #region Constructor

        public ListViewGalleryInfo()
        {

        }

        #endregion

        #region Properties

        public ImageSource Image
        {
            get { return image; }
            set
            {
                image = value;
                OnPropertyChanged("Image");
            }
        }

        public string ImageTitle
        {
            get { return imageTitle; }
            set
            {
                imageTitle = value;
                OnPropertyChanged("ImageTitle");
            }
        }

        public string CreatedDate
        {
            get { return createdData; }
            set
            {
                createdData = value;
                OnPropertyChanged("CreatedDate");
            }
        }

        #endregion

        #region Interface Member

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
