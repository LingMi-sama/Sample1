using GalaSoft.MvvmLight;
using LinGuGu1.Entity;
using System.Collections.ObjectModel;

namespace LinGuGu1.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {
        
        public MainViewModel()
        {
            InitUserModuleBar();
        }

        public ObservableCollection<UserModule> UserModeles { get; set; }

        public void InitUserModuleBar()
        {
            UserModeles = new ObservableCollection<UserModule>();
            UserModeles.Add(new UserModule() { FilePath = "Images/Image1.jpg", Username = "James Bloor", Contect = "What's up", SingTime = "32 min" });
            UserModeles.Add(new UserModule() { FilePath = "Images/Image2.jpg", Username = "Fionn Withehead", Contect = "Nice one", SingTime = "2 days" });
            UserModeles.Add(new UserModule() { FilePath = "Images/Image3.jpg", Username = "Damien Bonnard", Contect = "Go on in comi", SingTime = "1 weeks" });
            UserModeles.Add(new UserModule() { FilePath = "Images/Image4.jpg", Username = "Aneurin Barnaed", Contect = "I am comming", SingTime = "2 weeks" });
            UserModeles.Add(new UserModule() { FilePath = "Images/Image5.jpg", Username = "James  Bloor", Contect = "What's up", SingTime = "32min" });
            UserModeles.Add(new UserModule() { FilePath = "Images/Image6.jpg", Username = "Fionn Withehead", Contect = "Nice one", SingTime = "2 days" });
            UserModeles.Add(new UserModule() { FilePath = "Images/Image7.jpg", Username = "Damien Bonnard", Contect = "Go on in comi", SingTime = "1 weeks" });
            UserModeles.Add(new UserModule() { FilePath = "Images/Image8.jpg", Username = "Aneurin Barnaed", Contect = "I am comming", SingTime = "2 weeks" });
        }
    }
}