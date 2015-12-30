using System.Threading;
using BehavioralPatterns.ChainOfResponsibility;
using BehavioralPatterns.ObserverPattern;
using BehavioralPatterns.TemplateMethodPattern;
using CreationalPatterns.AbstractFactoryPattern;
using CreationalPatterns.AbstractFactoryPattern2;
using CreationalPatterns.BuilderPattern;
using CreationalPatterns.BuilderPattern2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralPatterns.ObserverPattern2;
using BehavioralPatterns.ObserverPattern3;
using StructuralPatterns.DecoratorPattern;
using O4 = BehavioralPatterns.ObserverPattern4;
using D2 = StructuralPatterns.DecoratorPattern2;
using A = StructuralPatterns.AdapterPattern;
using F = StructuralPatterns.FacadePattern;
using S = BehavioralPatterns.StrategyPattern;
using P = StructuralPatterns.ProxyPattern;
namespace DesignPatternsPractices.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CreationalPatterns.AbstractFactoryPattern
            //AnimalWorld animalWorld = new AnimalWorld(new AfricaFactory());
            //animalWorld.RunFood();

            //animalWorld = new AnimalWorld(new AmericaFactory());
            //animalWorld.RunFood();

            //Console.ReadKey(); 
            #endregion

            #region CreationalPatterns.AbstractFactoryPattern2
            //DeviceFactory deviceFactory = DeviceFactories.GetFactory(Brand.Samsung, DeviceType.Smart);

            //Device device = deviceFactory.CreateDevice();

            //Console.WriteLine(device.PhoneType.ToString());

            //SamsungSmartDevice samsungSmartDevice = (SamsungSmartDevice) device;

            //Console.WriteLine(samsungSmartDevice.Brand.ToString()); 
            #endregion

            #region CreationalPatterns.BuilderPattern
            //ReportBuildManager buildManager = new ReportBuildManager();
            //buildManager.Construct(new SalesReportBuilder());


            //Console.ReadKey(); 
            #endregion

            #region CreationalPatterns.BuilderPattern2

            //PhoneBuilderDirector phoneBuilderDirector = new PhoneBuilderDirector();
            //IPhoneBuilder phoneBuilder = new IosPhoneBuilder("IPhone 5");
            //phoneBuilderDirector.Build(phoneBuilder);
            //MobilePhone mobilePhone = phoneBuilder.MobilePhone;
            //Console.WriteLine(mobilePhone.ToString());
            //Console.ReadKey();

            #endregion


            #region BehavioralPatterns.ChainOfResponsibility

            //var reviewManager = new ReviewManager();

            //var documents = new List<Document>()
            //    {
            //        new Document() { Id = 1, Content = new string('*', 500)},
            //        new Document() { Id = 2, Content = new string('*', 850)},
            //        new Document() { Id = 3, Content = new string('*', 1500) }
            //    };

            //var executiveEditor = new ExecutiveEditor();
            //var editor = new Editor(executiveEditor);
            //reviewManager.Process(documents, editor);

            //Console.ReadKey(); 

            #endregion

            #region BehavioralPatterns.ObserverPattern


            //Kid aliKid = new Kid();
            //aliKid.Name = "ali";

            //Kid ayseKid = new Kid();
            //ayseKid.Name = "ayse";


            //Parent parent1 = new Parent();
            //parent1.Kids.Add(aliKid.Name, aliKid);
            //parent1.Kids.Add(ayseKid.Name, ayseKid);

            //aliKid.AddObserver(new NotifyObserver(parent1.DailyStatusUpdate));
            //ayseKid.AddObserver(new NotifyObserver(parent1.DailyStatusUpdate));

            //FamilyDoctor familyDoctor = new FamilyDoctor();
            //familyDoctor.Patients.Add(ayseKid.Name, ayseKid);

            //aliKid.DailyStatus = new Status(String.Format("{0} is happy", aliKid.Name), aliKid.Name);
            //ayseKid.DailyStatus = new Status(String.Format("{0} is fuzzy", ayseKid.Name), ayseKid.Name);

            //Thread.Sleep(5000);

            //ayseKid.AddObserver(new NotifyObserver(familyDoctor.ReciveNotes));

            //aliKid.DailyStatus = new Status(String.Format("{0} is happy", aliKid.Name), aliKid.Name);
            //ayseKid.DailyStatus = new Status(String.Format("{0} is sick. " + "Tempture : 39.7", ayseKid.Name), ayseKid.Name);

            //Thread.Sleep(5000);

            //aliKid.DailyStatus = new Status(String.Format("{0} is happy", aliKid.Name), aliKid.Name);
            //ayseKid.DailyStatus = new Status(String.Format("{0} is back to normal. " + "she is happy now", ayseKid.Name), ayseKid.Name);


            //Thread.Sleep(5000);


            //ayseKid.RemoveObserver(new NotifyObserver(familyDoctor.ReciveNotes));

            ////update two kids' status
            //aliKid.DailyStatus = new Status(String.Format("{0} is happy. " + "Just had a big lunch", aliKid.Name), aliKid.Name);
            //ayseKid.DailyStatus = new Status(String.Format("{0} is happy. " + "Playing with her best friend Kevin", ayseKid.Name), ayseKid.Name);

            //Console.WriteLine("Daily Report End!");
            //Console.Read();

            #endregion

            #region BehavioralPatterns.ObserverPattern2

            //Product product = new Product("Thule Notebook Bag 15''", 150m);
            //ProductCampaignController productCampaignController = new ProductCampaignController(product);
            //productCampaignController.CampaignStateChangeEvent += productCampaignController_CampaignStateChangeEvent;
            //productCampaignController.ChangeCampaignStatus(CampaignStatus.InSeasonCampaign);
            //productCampaignController.ChangeCampaignStatus(CampaignStatus.InOutOfSeasonCampaign);
            //productCampaignController.ChangeCampaignStatus(CampaignStatus.None);
            //Console.ReadKey(); 

            #endregion

            #region BehavioralPatterns.ObserverPattern3

            //NewsPublisher newsPublisher = new NewsPublisher();

            //NewsSubscriber newsSubscriber = new NewsSubscriber();

            //newsPublisher.RegisterObserver(newsSubscriber);

            //Message messageOne = MessageCreator.Create();

            //newsSubscriber.Update(messageOne);

            //Thread.Sleep(1000);

            //Message messageTwo = MessageCreator.Create( );

            //newsSubscriber.Update(messageTwo);

            //Thread.Sleep(1000);

            //Message messageThree = MessageCreator.Create( );

            //newsSubscriber.Update(messageThree);

            //Thread.Sleep(1000);

            //Console.ReadKey();

            #endregion

            #region BehavioralPatterns.ObserverPattern4

            //O4.NewsPublisher newsPublisher = new O4.NewsPublisher();

            //O4.NewsSubscriber newsSubscriber = new O4.NewsSubscriber();

            //newsPublisher.ArchiveChanged += newsSubscriber.Update;

            //O4.Message messageOne = O4.MessageCreator.Create();

            //newsSubscriber.Update(messageOne);

            //Thread.Sleep(1000);

            //O4.Message messageTwo = O4.MessageCreator.Create();

            //newsSubscriber.Update(messageTwo);

            //Thread.Sleep(1000);

            //O4.Message messageThree = O4.MessageCreator.Create();

            //newsSubscriber.Update(messageThree);

            //Thread.Sleep(1000);

            //Console.ReadKey(); 

            #endregion


            #region BehavioralPatterns.TemplateMethodPattern

            //HiringProcessor hiringProcessor = new ITDepartmentHiringProcessor();

            //Console.WriteLine("Hiring technical employee..");
            //hiringProcessor.HireEmploye();

            //Thread.Sleep(1000);

            //Console.WriteLine("Hiring marketing employee..");
            //hiringProcessor = new MarketingDepartmentHiringProcessor();
            //hiringProcessor.HireEmploye();

            //Console.ReadKey(); 

            #endregion


            #region StructuralPatterns.DecoratorPattern

            //OpelAstra car = new OpelAstra();

            //Console.WriteLine("Opel Astra base price are : {0}", car.Price);

            //DiscountSpecialOffer offer = new DiscountSpecialOffer(car);
            //offer.DiscountPercentage = 25;
            //offer.Offer = "25 % discount";

            //Console.WriteLine("{1} @ Opel Astra Special Offer and price are : {0} ", offer.Price, offer.Offer);

            //Console.ReadKey(); 

            #endregion


            #region StructuralPatterns.DecoratorPattern2

            //D2.IProductService productService = new D2.ProductService();
            //productService = new D2.ProductServiceCacheDecorator(productService);
            //List<D2.Product> product = productService.GetProducts();

            //Console.ReadKey();

            #endregion

            #region StructuralPatterns.AdapterPattern

            //A.ICategoryRepository categoryRepository = new A.CategoryRepository();
            //A.ICacheStorage cacheStorage = new A.ObjectCachingStorage();
            //A.CategoryService categoryService = new A.CategoryService(categoryRepository, cacheStorage);
            //List<A.Category> categories = categoryService.GetAllCategories().ToList();
            //categories.ForEach(x => Console.WriteLine(x.Name));
            //Console.ReadKey();

            #endregion

            #region StructuralPatterns.FacadePattern

            //F.IWeatherService weatherService =new F.WeatherService();
            //F.IGeoLocationService geoLocationService =new F.GeoLocationService();
            //F.ITemperatureService temperatureService =new F.TemperatureService(weatherService,geoLocationService);
            //F.LocalTemperature localTemperature = temperatureService.GetTemperature("1663");

            //Console.ReadKey(); 

            #endregion

            #region BehavioralPatterns.StrategyPattern


            //S.Order order = new S.Order();
            //S.Product product = new S.Product();
            //S.IShippingStrategy shippingStrategy = new S.UpsShippingStrategy();
            //S.ShippingCostCalculationService shippingCostCalculationService = new S.ShippingCostCalculationService();
            //double result = shippingCostCalculationService.CalculateShippingCost(order, shippingStrategy.Calculate);

            //Console.ReadKey();

            #endregion

            #region StructuralPatterns.ProxyPattern

            P.IRssReaderService rssReaderService = new P.RssReaderServiceProxy();
            rssReaderService.Initialize();
            var items = rssReaderService.GetRssData();

            Console.WriteLine("Items count : {0}", items.Count);

            
            Console.ReadKey();


            #endregion
        }

        private static void productCampaignController_CampaignStateChangeEvent(object campaignObject, CampaignStatus campaignStatus)
        {
            Product product = (Product)campaignObject;
            Console.WriteLine("Product Name : {0}", product.Name);
            Console.WriteLine("Price : {0:C}", product.Price);
            Console.WriteLine("Discounted Price : {0:C}", product.DiscountedPrice);

            if (campaignStatus != CampaignStatus.None)
                SendingSmsToCustomers(product, campaignStatus);
        }

        private static void SendingSmsToCustomers(Product product, CampaignStatus campaignStatus)
        {
            //Sending SMS Operations
            Console.WriteLine("Sms sending to customers...");
        }
    }
}
