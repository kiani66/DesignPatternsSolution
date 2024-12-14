using AbstractFactoryService.Interfaces;
using FactoryMethodService.Interfaces;
using SingletonService.Implementations;
using SingletonService.Interfaces;
using BuilderService.Interfaces;
using BuilderService.Implementations;
using BuilderService.Directors;
using CompositeService.Interfaces;
using CompositeService.Implementations;
using AdapterService.Implementations;
using AdapterService.Interfaces;
using BridgeService.Implementations;
using BridgeService.Interfaces;
using FacadeService.Implementations;
using ProxyService.Implementations;
using ChainofResponsibility.Implementations;
using Command.Implementations;
using Iterator.Implementations;
using Mediator.Implementations;
using Observer.Implementations;
using State.Implementations;
using Strategy.Implementations;
using Strategy.Interfaces;

namespace ApplicationCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DesignPatternsSolution Console App");
            Console.WriteLine("=== Creational Design Patterns (01) ===");
            Console.WriteLine("01.1 Singleton Pattern");
            Console.WriteLine("01.2 Factory Method Pattern");
            Console.WriteLine("01.3 Abstract Factory Pattern");
            Console.WriteLine("01.4 Builder Pattern");
            Console.WriteLine("01.5 Prototype Pattern");
            Console.WriteLine();
            Console.WriteLine("=== Structural Design Patterns (02) ===");
            Console.WriteLine("02.1 Adapter Pattern");
            Console.WriteLine("02.2 Bridge Pattern");
            Console.WriteLine("02.3 Composite Pattern");
            Console.WriteLine("02.4 Decorator Pattern");
            Console.WriteLine("02.5 Facade Pattern");
            Console.WriteLine("02.6 Proxy Pattern");
            Console.WriteLine();
            Console.WriteLine("=== Behavioral Design Patterns (03) ===");
            Console.WriteLine("03.1 Chain of Responsibility Pattern");
            Console.WriteLine("03.2 Command Pattern");
            Console.WriteLine("03.3 Iterator Pattern");
            Console.WriteLine("03.4 Mediator Pattern");
            Console.WriteLine("03.5 Observer Pattern");
            Console.WriteLine("03.6 State Pattern");
            Console.WriteLine("03.7 Strategy Pattern");
            Console.WriteLine();
            Console.Write("Select an option to run the pattern (e.g., 01.1): ");
            var input = Console.ReadLine();
            switch (input)
            {
                // Creational Design Patterns
                case "01.1":
                    RunSingletonPattern();
                    break;
                case "01.2":
                    RunFactoryMethodPattern();
                    break;
                case "01.3":
                    RunAbstractFactoryPattern();
                    break;
                case "01.4":
                    RunBuilderPattern();
                    break;
                case "01.5":
                    RunPrototypePattern();
                    break;

                // Structural Design Patterns
                case "02.1":
                    RunAdapterPattern();
                    break;
                case "02.2":
                    RunBrigePattern();
                    break;
                case "02.3":
                    RunCompositePattern();
                    break;
                case "02.4":
                    RunDecoratorPattern();
                    break;
                case "02.5":
                    RunFacadePattern();
                    break;
                case "02.6":
                    RunProxyPattern();
                    break;

                // Behavioral Design Patterns
                case "03.1":
                    RunChainofResponsibilityPattern();
                    break;
                case "03.2":
                    RunCommandPattern();
                    break;
                case "03.3":
                    RunIteratorPattern();
                    break;
                case "03.4":
                    RunMediatorPattern();
                    break;
                case "03.5":
                    RunObserverPattern();
                    break;
                case "03.6":
                    RunStatePattern();
                    break;
                case "03.7":
                    RunStrategyPattern();
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please select a valid option from the list.");
                    break;
            }

            #region Creational Design Patterns
            static void RunSingletonPattern()
            {
                IStoreSettingsService storeSettings = StoreSettingsService.GetInstance();
                Console.WriteLine($"Store is open: {storeSettings.IsStoreOpen}");
                storeSettings.SetStoreStatus(false);
                Console.WriteLine($"Store is open: {storeSettings.IsStoreOpen}");
            }
            static void RunFactoryMethodPattern()
            {
                IProductFactory electronicsFactory = new FactoryMethodService.Implementations.ElectronicsFactory();
                FactoryMethodService.Interfaces.IProduct electronicsProduct = electronicsFactory.CreateProduct();
                Console.WriteLine($"Created Product: {electronicsProduct.GetName()}");

                IProductFactory clothingFactory = new FactoryMethodService.Implementations.ClothingFactory();
                FactoryMethodService.Interfaces.IProduct clothingProduct = clothingFactory.CreateProduct();
                Console.WriteLine($"Created Product: {clothingProduct.GetName()}");
            }
            static void RunAbstractFactoryPattern()
            {
                // ایجاد کارخانه محصولات الکترونیکی
                IAbstractFactory electronicsFactory = new AbstractFactoryService.Implementations.ElectronicsFactory();

                // تولید محصول تلفن همراه
                AbstractFactoryService.Interfaces.IProduct mobilePhone = electronicsFactory.CreateProduct("mobilephone");
                Console.WriteLine($"Created Product: {mobilePhone.GetName()}");

                // تولید محصول لپ‌تاپ
                AbstractFactoryService.Interfaces.IProduct laptop = electronicsFactory.CreateProduct("laptop");
                Console.WriteLine($"Created Product: {laptop.GetName()}");

                // تولید محصول از کارخانه پوشاک
                IAbstractFactory clothingFactory = new AbstractFactoryService.Implementations.ClothingFactory();
                AbstractFactoryService.Interfaces.IProduct shirt = clothingFactory.CreateProduct("shirt");
                Console.WriteLine($"Created Product: {shirt.GetName()}");
            }
            static void RunBuilderPattern()
            {
                ICartBuilder builder = new CartBuilder();
                CartDirector director = new CartDirector(builder);

                // ساخت یک سبد استاندارد با استفاده از Director
                director.BuildStandardCart();
                Cart standardCart = builder.GetCart();

                Console.WriteLine("Standard Cart:");
                Console.WriteLine($"Items: {string.Join(", ", standardCart.Items)}");
                Console.WriteLine($"Discount: {standardCart.Discount}%");

                // ساخت یک سبد خرید سفارشی
                builder.AddItem("Custom Item 1");
                builder.ApplyDiscount(5);
                Cart customCart = builder.GetCart();

                Console.WriteLine("\nCustom Cart:");
                Console.WriteLine($"Items: {string.Join(", ", customCart.Items)}");
                Console.WriteLine($"Discount: {customCart.Discount}%");
            }
            static void RunPrototypePattern()
            {
                // ایجاد سبد خرید اولیه
                var originalCart = new PrototypeService.Implementations.Cart(new List<string> { "Item 1", "Item 2" }, 10);
                Console.WriteLine("Original Cart:");
                Console.WriteLine($"Items: {string.Join(", ", originalCart.Items)}");
                Console.WriteLine($"Discount: {originalCart.Discount}%");

                // کلون کردن سبد خرید اولیه
                var clonedCart = originalCart.Clone();
                clonedCart.AddItem("Item 3");
                clonedCart.SetDiscount(15);

                Console.WriteLine("\nCloned Cart:");
                Console.WriteLine($"Items: {string.Join(", ", clonedCart.Items)}");
                Console.WriteLine($"Discount: {clonedCart.Discount}%");

                // بررسی اینکه سبد خرید اصلی تغییر نکرده است
                Console.WriteLine("\nOriginal Cart after cloning:");
                Console.WriteLine($"Items: {string.Join(", ", originalCart.Items)}");
                Console.WriteLine($"Discount: {originalCart.Discount}%");
            }
            #endregion

            #region Structural Design Patterns
            static void RunAdapterPattern()
            {
                Console.WriteLine("this is a AdapterPattern");
                Console.WriteLine("-------------------------------");

                IPaymentProcessor paypalAdapter = new PayPalAdapter();
                IPaymentProcessor bank1Adapter = new BankAdapter();

                Console.WriteLine("Processing payment through PayPal:");
                paypalAdapter.ProcessPayment("David", 150.00m, "Dollar");

                Console.WriteLine("\nProcessing payment through Iranian Bank:");
                bank1Adapter.ProcessPayment("jafar", 50000000, "IRR");
                bank1Adapter.ProcessPayment("reza", 20000000, "Rial");
            }
            static void RunBrigePattern()
            {
                // ایجاد روش پرداخت با کارت اعتباری
                IPaymentMethod creditCardPayment = new CreditCardPayment();

                // ایجاد دستگاه پرداخت آنلاین با روش پرداخت کارت اعتباری
                IPaymentDevice onlineDevice = new OnlinePaymentDevice(creditCardPayment);

                // پردازش پرداخت از طریق دستگاه پرداخت آنلاین
                Console.WriteLine("Processing payment through Online Payment Device:");
                onlineDevice.MakePayment(300.00m);

                // ایجاد دستگاه پرداخت POS با روش پرداخت کارت اعتباری
                IPaymentDevice posDevice = new POSPaymentDevice(creditCardPayment);

                // پردازش پرداخت از طریق دستگاه پرداخت POS
                Console.WriteLine("\nProcessing payment through POS Device:");
                posDevice.MakePayment(500.00m);
            }
            static void RunCompositePattern()
            {
                // ایجاد تراکنش‌های فردی
                ITransaction transaction1 = new SingleTransaction(100m, "Person1");
                ITransaction transaction2 = new SingleTransaction(200m, "Person2");
                ITransaction transaction3 = new SingleTransaction(150m, "Person1");

                // ایجاد گروه تراکنش‌ها
                TransactionGroup transactionGroup = new TransactionGroup();
                transactionGroup.AddTransaction(transaction1);
                transactionGroup.AddTransaction(transaction2);
                transactionGroup.AddTransaction(transaction3);

                // پردازش تمامی تراکنش‌ها
                Console.WriteLine("Processing all transactions:");
                transactionGroup.Process();

                // نمایش مجموع مبلغ تمامی تراکنش‌ها
                Console.WriteLine($"\nTotal amount of all transactions: {transactionGroup.GetAmount():C}");

                // نمایش تعداد تراکنش‌ها
                Console.WriteLine($"\nTotal number of transactions: {transactionGroup.GetTransactionCount()}");

                // محاسبه مجموع تراکنش‌های یک فرد خاص
                string personId = "Person1";
                decimal totalAmountForPerson = transactionGroup.GetTotalAmountForPerson(personId);
                Console.WriteLine($"\nTotal amount for {personId}: {totalAmountForPerson:C}");
            }
            static void RunDecoratorPattern()
            {

                DecoratorService.Interfaces.IPaymentProcessor baseProcessor =
                    new DecoratorService.Implementations.BasePaymentProcessor();

                // اضافه کردن لاگ‌گذاری به پردازشگر اصلی
                DecoratorService.Interfaces.IPaymentProcessor loggingProcessor =
                    new DecoratorService.Implementations.LoggingDecorator(baseProcessor);

                // اضافه کردن اعلان به پردازشگر با لاگ‌گذاری
                DecoratorService.Interfaces.IPaymentProcessor notificationProcessor =
                    new DecoratorService.Implementations.NotificationDecorator(loggingProcessor);

                // اضافه کردن مالیات به پردازشگر با لاگ‌گذاری و اعلان
                DecoratorService.Interfaces.IPaymentProcessor taxProcessor =
                    new DecoratorService.Implementations.TaxDecorator(notificationProcessor, 0.1m);

                // پردازش پرداخت
                Console.WriteLine("Starting payment process with multiple decorators:");
                taxProcessor.ProcessPayment(100.00m);
            }
            static void RunFacadePattern()
            {
                PaymentFacade paymentFacade = new PaymentFacade();

                // پردازش پرداخت با استفاده از Facade
                Console.WriteLine("Enter Payment Provider (PayPal or iranian):");
                string provider = Console.ReadLine();

                Console.WriteLine("Enter User ID:");
                string userId = Console.ReadLine();

                Console.WriteLine("Enter Amount:");
                decimal amount = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter Currency (e.g., USD, EUR):");
                string currency = Console.ReadLine();

                paymentFacade.ProcessPayment(provider, userId, amount, currency);

                // تولید گزارش پرداخت‌ها
                Console.WriteLine("\nGenerating Payment Report:");
                paymentFacade.GeneratePaymentReport();
            }
            static void RunProxyPattern()
            {
                // ایجاد پردازشگر واقعی پرداخت
                ProxyService.Interfaces.IPaymentProcessor realProcessor = new RealPaymentProcessor();

                // ایجاد پروکسی محدودکننده درخواست‌ها
                ProxyService.Interfaces.IPaymentProcessor requestLimiterProxy = new RequestLimiterProxy(realProcessor);

                // پردازش پرداخت‌ها از طریق پروکسی محدودکننده درخواست‌ها
                Console.WriteLine("Processing payments with Request Limiter Proxy:");
                for (int i = 0; i < 105; i++) // بیش از 100 بار برای شبیه‌سازی محدودیت
                {
                    requestLimiterProxy.ProcessPayment("User1", 100.00m, "USD");
                }

                // ایجاد پروکسی کش گزارش
                ReportCacheProxy reportCacheProxy = new ReportCacheProxy();

                // تولید و کش کردن گزارش‌ها
                Console.WriteLine("\nGenerating Reports with Report Cache Proxy:");
                string report1 = reportCacheProxy.GenerateReport("Report1");
                Console.WriteLine(report1);

                // دریافت دوباره همان گزارش از کش
                string report1Cached = reportCacheProxy.GenerateReport("Report1");
                Console.WriteLine(report1Cached);

                // تولید یک گزارش جدید
                string report2 = reportCacheProxy.GenerateReport("Report2");
                Console.WriteLine(report2);
            }
            #endregion

            #region Behavioral Design Patterns
            static void RunChainofResponsibilityPattern()
            {
                var emailHandler = new EmailHandler();
                var smsHandler = new SMSHandler();
                var pushHandler = new PushHandler();

                emailHandler.SetNext(smsHandler);
                smsHandler.SetNext(pushHandler);

                emailHandler.Handle("Email", "Welcome to the system!");
                emailHandler.Handle("SMS", "You have a new message!");
                emailHandler.Handle("Push", "Your order has been shipped!");
                emailHandler.Handle("Unknown", "Unsupported notification type.");

            }
            static void RunCommandPattern()
            {
                var emailCommand = new EmailCommand("Welcome to the Command Pattern!");
                emailCommand.Execute();
                emailCommand.Undo();
            }
            static void RunIteratorPattern()
            {
                // ایجاد مجموعه اعلان‌ها
                var notificationCollection = new NotificationCollection();
                notificationCollection.Add("Notification 1: Welcome!");
                notificationCollection.Add("Notification 2: You have a new message.");
                notificationCollection.Add("Notification 3: Your order has been shipped.");

                // ایجاد Iterator
                var iterator = notificationCollection.CreateIterator();

                // پیمایش اعلان‌ها
                Console.WriteLine("Iterating through notifications:");
                while (iterator.HasNext())
                {
                    Console.WriteLine(iterator.Next());
                }

                // بررسی عنصر بعدی
                Console.WriteLine("\nAttempting to fetch the next notification:");
                Console.WriteLine(iterator.Next());
            }
            static void RunMediatorPattern()
            {
                // ایجاد Mediator
                var mediator = new NotificationMediator();

                // ثبت هندلرها
                mediator.RegisterHandler("Email", new EmailMediatorHandler());
                mediator.RegisterHandler("SMS", new SMSMediatorHandler());
                mediator.RegisterHandler("Push", new PushMediatorHandler());

                // ارسال اعلان‌ها
                Console.WriteLine("Sending Email notification:");
                mediator.Notify("Email", "Welcome to the system!");

                Console.WriteLine("\nSending SMS notification:");
                mediator.Notify("SMS", "You have a new message!");

                Console.WriteLine("\nSending Push notification:");
                mediator.Notify("Push", "Your order has been shipped!");

                Console.WriteLine("\nSending unsupported notification:");
                mediator.Notify("Unsupported", "Unsupported notification type.");
            }
            static void RunObserverPattern()
            {
                var user1 = new User("Alice");
                var user2 = new User("Bob");

                var notificationService = new NotificationService();
                notificationService.Subscribe(user1);
                notificationService.Subscribe(user2);

                notificationService.Notify("System Update Available!");
            }
            static void RunStatePattern()
            {
                var context = new NotificationContext();

                context.SetState(new SentState());
                context.Process();

                context.SetState(new DeliveredState());
                context.Process();
            }
            static void RunStrategyPattern()
            {
                INotificationStrategy immediate = new ImmediateNotification();
                INotificationStrategy scheduled = new ScheduledNotification();

                immediate.Send("Hello, Immediate!");
                scheduled.Send("Hello, Scheduled!");
            }
            #endregion
        }
    }

}
