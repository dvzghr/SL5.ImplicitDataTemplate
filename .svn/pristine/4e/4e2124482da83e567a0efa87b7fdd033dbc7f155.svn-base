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
    public class CarViewModel : ViewModelBase
    {
        private ServiceAgent _serviceAgent;

        /// <summary>
        /// Initializes a new instance of the CarViewModel class.
        /// </summary>
        public CarViewModel()
        {
            _serviceAgent = new ServiceAgent();
            GetCar();
        }

        private void GetCar()
        {
            _serviceAgent.GetCar(c => SelCar = c);
        }

        #region Properties
        private Car _selCar;
        public Car SelCar
        {
            get { return _selCar; }
            set
            {
                _selCar = value;
                RaisePropertyChanged("SelCar");
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