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
    public class PersonViewModel : ViewModelBase
    {
        private ServiceAgent _serviceAgent;

        /// <summary>
        /// Initializes a new instance of the PersonViewModel class.
        /// </summary>
        public PersonViewModel()
        {
            _serviceAgent = new ServiceAgent();
            GetPerson();
        }
        
        private void GetPerson()
        {
            _serviceAgent.GetPerson(p => SelPerson = p);
        }

        #region Properties
        private Person _selPerson;
        public Person SelPerson
        {
            get { return _selPerson; }
            set
            {
                _selPerson = value;
                RaisePropertyChanged("SelPerson");
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