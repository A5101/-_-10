using System;
using System.Collections.Generic;

namespace ООАиД_ЛР10
{
    interface IObserver
    {
        void Update(Object ob);
    }

    interface IObservable
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }

    class Observable : IObservable
    {
        State sInfo; // текущее состояние
        List<IObserver> observers; //список наблюдателей
        public Observable()
        {
            observers = new List<IObserver>();
            sInfo = new State();
        }
        public void RegisterObserver(IObserver o)
        {
            if (o == null) throw new ArgumentNullException();
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            if (o == null) throw new ArgumentNullException();
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(sInfo);
            }
        }

        public void Change()
        {
            Random rnd = new Random();
            sInfo.Stat = rnd.Next(1, 100);
            NotifyObservers();
        }
    }

    class State
    {
        int state = 0;
        public int Stat { get { return state; } set { state = value; } }
    }

    //class Broker : IObserver
    //{
    //    public string Name { get; set; }
    //    IObservable stock;
    //    public Broker(string name, IObservable obs)
    //    {
    //        this.Name = name;
    //        stock = obs;
    //        stock.RegisterObserver(this);
    //    }
    //    public void Update(object ob)
    //    {
    //        StockInfo sInfo = (StockInfo)ob;

    //        if (sInfo.USD > 30)
    //            Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
    //        else
    //            Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
    //    }
    //    public void StopTrade()
    //    {
    //        stock.RemoveObserver(this);
    //        stock = null;
    //    }
    //}

    class CountObserver : IObserver
    {
        IObservable obs;
        int count = 0;
        public int Count { get { return count; } set { count = value; } }
        Form1 f;
        public CountObserver(IObservable obs)
        {
            this.obs = obs;
            this.obs.RegisterObserver(this);
        }
        public CountObserver(Form1 f)
        {
            this.f = f;
        }
        public void Update(object ob)
        {
            count++;
            f.GetCountTextBox().Text = count.ToString();
        }
    }
    class CurrentObserver : IObserver
    {
        IObservable obs;
        State st = new State();
        public State St { get { return st; } set { st = value; } }
        Form1 f;
        public CurrentObserver(IObservable obs)
        {
            this.obs = obs;
            this.obs.RegisterObserver(this);
        }
        public CurrentObserver(Form1 f)
        {
            this.f = f;
        }
        public void Update(object ob)
        {
            st = (State)ob;
            f.GetCurrStateTextBox().Text = st.Stat.ToString();
        }
    }
}
