using GalaSoft.MvvmLight;
using SLApp.Model;

namespace SLApp.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm/getstarted
    /// </para>
    /// </summary>
    public class HouseViewModel : ViewModelBase
    {
        private ServiceAgent _serviceAgent;

        /// <summary>
        /// Initializes a new instance of the HouseViewModel class.
        /// </summary>
        public HouseViewModel()
        {
            _serviceAgent = new ServiceAgent();
            GetHouse();
        }

        private void GetHouse()
        {
            _serviceAgent.GetHouse(h => SelHouse = h);
        }

        #region Properties
        private House _selHouse;
        public House SelHouse
        {
            get { return _selHouse; }
            set
            {
                _selHouse = value;
                RaisePropertyChanged("SelHouse");
            }
        }
        #endregion
        

        ////public override void Cleanup()
        ////{
        ////    // Clean own resources if needed

        ////    base.Cleanup();
        ////}
    }
}