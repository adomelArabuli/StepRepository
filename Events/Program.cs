namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region UsualEvent

            //MyPublisher publisher = new MyPublisher();
            //Subscriber subscriber = new Subscriber();

            //subscriber.Subscribe(publisher);

            //publisher.DoSomething();

            //subscriber.UnSubscribe(publisher);

            //publisher.DoSomething();

            #endregion

            #region BirthDayCelebrator

            BirthDayCelebrator birthDayCelebrator = new BirthDayCelebrator();
            PartySubscriber subscriber = new PartySubscriber();

            subscriber.Subscribe(birthDayCelebrator);

            birthDayCelebrator.CelebrateBirthDay();

            if(subscriber.IsSucbscibed)
            {
                subscriber.Subscribe(birthDayCelebrator);
            }
            else
            {
                Console.WriteLine("You're already subscribed");
            }

            birthDayCelebrator.CelebrateBirthDay();



            #endregion

        }
    }

    public class MyEventArgs : EventArgs 
    {
        public string Message { get; }

        public MyEventArgs(string message)
        {
            Message = message;
        }
    }

    public class MyPublisher
    {
        public event EventHandler<MyEventArgs> Myevent;

        protected virtual void OnMyevent(string message)
        {
            MyEventArgs args = new MyEventArgs(message);

            Myevent?.Invoke(this, args);
        }

        public void DoSomething()
        {
            OnMyevent("Something happened!");
        }
    }

    public class Subscriber
    {
        private void MyEventHandler(object sender, MyEventArgs e)
        {
            Console.WriteLine($"Event handled by subscriber: {e.Message}");
        }

        public void Subscribe(MyPublisher publisher)
        {
            publisher.Myevent += MyEventHandler;
        }

        public void UnSubscribe(MyPublisher publisher)
        {
            publisher.Myevent -= MyEventHandler;
        }
    }

}