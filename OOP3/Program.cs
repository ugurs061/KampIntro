
using OOP3;

// interfaceler de implament olduğu class'ın referans numarasını tutabildiği görülür.
IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLogerService = new FileLoggerService();


BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(ihtiyacKrediManager, new List<ILoggerService> {new DatabaseLoggerService(),new FileLoggerService()});// başvuru ile beraber aynı zamanda loglamış oluyoruz

List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager};
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);