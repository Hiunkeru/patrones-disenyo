
namespace Prototype.ejemplo2
{
    internal class TelefonoFactory
    {
        private readonly Telefono android, iphone;

        public TelefonoFactory()
        {
            android = new Android("Poco F3");
            iphone = new IPhone("Iphone 13");

        }

        public Telefono GetAndroid()
        {
            return android.Clone();
        }

        public Telefono GetIphone()
        {
            return iphone.Clone();
        }
    }
}
