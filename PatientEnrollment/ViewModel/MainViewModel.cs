namespace PatientEnrollment.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(IPatientDetailViewModel patientDetailViewModel, ITreatmentDetailViewModel treatmentDetailViewModel)
        {
            PatientDetailViewModel = patientDetailViewModel;
            TreatmentDetailViewModel = treatmentDetailViewModel;
        }

        public IPatientDetailViewModel PatientDetailViewModel { get; }

        public ITreatmentDetailViewModel TreatmentDetailViewModel { get; }
    }
}
