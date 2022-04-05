//public interface IOrder
//{
//    void AddToCart();
//}

//public interface IOnlineOrder
//{
//    void CCProcess();
//}

//public class OnlineOrder : IOrder, IOnlineOrder
//{
//    public void AddToCart()
//    {
        
//    }

//    public void CCProcess()
//    {
        
//    }
//}

//public class OfflineOrder : IOrder
//{
//    public void AddToCart()
//    {
      
//    }
//}

////Bu prinsipde esas bacariqlari ehate edir.Bu odemekdir ki,Biz yarardigimiz interfacesin icindeki funksiyalari her defe cagirdiqda lazim olmayan funksiyari da 
////cagirmis sayiliriq .Ona gorede bu koddda bacariqlar yeni interfaceler konfigurasiya olunub.Eger bize AddTocart lazimdirsa  biz IOrder cagiraraq ancaq addToCarda muraciet etmis oluruq.