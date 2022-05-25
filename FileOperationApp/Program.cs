using Business.Abstract;
using Business.Concrete;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using System;
namespace FileOperationApp
{
    class Program
    {
        private IPersonService _personService;
        private IPoliceService _policeService;
        private ITheTahHataService _theTahHataService;
        private IVkfeService _vkfeService;
        private IGenericPdfService _genericPdfService;
        public Program(IPersonService personService, IPoliceService policeService, ITheTahHataService theTahHataService,
            IVkfeService vkfeService, IGenericPdfService genericPdfService)
        {
            _personService = personService;
            _policeService = policeService;
            _theTahHataService = theTahHataService;
            _vkfeService = vkfeService;
            _genericPdfService = genericPdfService;
        }
        static void Main(string[] args)
        {
            IServiceProvider serviceProvider = RegisterServices();
            Program program = serviceProvider.GetService<Program>();
            program.Run();
            DisposeServices(serviceProvider);

        }
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("İşlem Listesi:\n");
                Console.WriteLine("1 - Zeyl tip sayısı ve açıklamaları");
                Console.WriteLine("2 - 30 yaş üstü müşteri sayısı");
                Console.WriteLine("3 - Kaç farklı tarife numarasına ait poliçe oluşturulmuştur, tarife numaralarının açıklamaları");
                Console.WriteLine("4 - Ferdi Kaza,Hayat,Emeklilik tipindeki poliçelerden yapılan üretim sayısı");
                Console.WriteLine("5 - The Tah Hata Loglama");
                Console.WriteLine("6 - Vkfe Hata Loglama");
                Console.WriteLine("7 - Pdf Oluşturma");

                var result = Convert.ToInt32(Console.ReadLine());

                switch (result)
                {
                    case 1:
                        _policeService.ZeylTypesAndExplanation();
                        break;
                    case 2:
                        _personService.OverThirtyYearsOld();
                        break;
                    case 3:
                        _policeService.TariffNoAndExplanation();
                        break;
                    case 4:
                        _policeService.PoliceTypes();
                        break;
                    case 5:
                        _theTahHataService.ReadData();
                        break;
                    case 6:
                        _vkfeService.ReadData();
                        break;
                    case 7:
                        _genericPdfService.PoliceToPdf();
                        break;
                    default:
                        break;
                }

            }
        }
        private static IServiceProvider RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<IPersonService, PersonManager>();
            services.AddScoped<IPoliceService, PoliceManager>();
            services.AddScoped<ITheTahHataService, TheTahHataManager>();
            services.AddScoped<IVkfeService, VkfeManager>();
            services.AddScoped<IGenericPdfService, GenericPdfManager>();
            services.AddLogging();
            services.AddScoped<Program>();
            return services.BuildServiceProvider();
        }

        private static void DisposeServices(IServiceProvider serviceProvider)
        {
            if (serviceProvider == null)
            {
                return;
            }
            if (serviceProvider is IDisposable sp)
            {
                sp.Dispose();
            }
        }
    }
}
