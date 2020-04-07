using Prism.Events;
using Autofac;
using PatientEnrollment.ViewModel;


namespace PatientEnrollment.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();


            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();


            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();

            builder.RegisterType<PatientDetailViewModel>().As<IPatientDetailViewModel>();
            builder.RegisterType<TreatmentDetailViewModel>().As<ITreatmentDetailViewModel>();


            return builder.Build();
        }
    }
}
