/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:SLApp"
                                   x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using GalaSoft.MvvmLight;

namespace SLApp.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        private static MainViewModel _main;
        private static PersonViewModel _person;
        private static CarViewModel _car;
        private static HouseViewModel _house;
        private static ContentViewModel _content;

        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time services and viewmodels
            ////}
            ////else
            ////{
            ////    // Create run time services and view models
            ////}
            
            _main = new MainViewModel();
            _person = new PersonViewModel();
            _car = new CarViewModel();
            _house = new HouseViewModel();
            _content = new ContentViewModel();
        }

        /// <summary>
        /// Gets the Main property which defines the main viewmodel.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public MainViewModel Main
        {
            get
            {
                return _main;
            }
        }

        /// <summary>
        /// Gets the Main property which defines the main viewmodel.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public PersonViewModel PViewModel
        {
            get
            {
                return _person;
            }
        }

        /// <summary>
        /// Gets the Main property which defines the main viewmodel.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public CarViewModel CViewModel
        {
            get
            {
                return _car;
            }
        }

        /// <summary>
        /// Gets the Main property which defines the main viewmodel.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public HouseViewModel HViewModel
        {
            get
            {
                return _house;
            }
        }

        /// <summary>
        /// Gets the Main property which defines the main viewmodel.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public ContentViewModel CoViewModel
        {
            get
            {
                return _content;
            }
        }
    }
}