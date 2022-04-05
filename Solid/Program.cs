
////Single Responsibility Principle

//public class GarageStation
//{
//    IGarageUtility _garageUtil;

//    public GarageStation(IGarageUtility garageUtil)
//    {
//        this._garageUtil = garageUtil;
//    }
//    public void OpenForService()
//    {
//        _garageUtil.OpenGate();
//    }
//    public void DoService()
//    {
      
//    }
//    public void CloseGarage()
//    {
//        _garageUtil.CloseGate();
//    }
//}
//public class GarageStationUtility : IGarageUtility
//{

//    public void OpenGate()
//    {
        
//    }

//    public void CloseGate()
//    {
       
//    }
//}

//public interface IGarageUtility
//{
//    void OpenGate();
//    void CloseGate();
//}

////Burada gorunduyu kimi qapi ile elaqedar olan kodlari basqa interface yaziriq.Bu o demekdir ki,Her bir kod duzgun yerde yazilmalidir.
////Gorunen classda qapi ile elaqedar olan kodlar yazilsa idi bu sehv olardi.