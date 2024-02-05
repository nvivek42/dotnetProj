// See https://aka.ms/new-console-template for more information
using User;
Console.WriteLine("Hello, World!");

NotificationManager mgr =new NotificationManager();
//Handler agent=new Handler(mgr.SendEmail);
UserRegistration newUser = new UserRegistration("vivek Narole",123,"abc@123");
newUser.NotifyByEmail += new Handler(mgr.SendEmail);
newUser.NewUserRegistration();




