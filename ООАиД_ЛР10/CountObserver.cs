using System;
using System.Collections.Generic;

namespace ООАиД_ЛР10
{
    public interface IObserver
    {
        void Update(object ob);
    }
    public interface IObservable
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
    public class Observable : IObservable
    {
        State sInfo;
        List<IObserver> observers; 
        public Observable()
        {
            observers = new List<IObserver>();
            sInfo = new State();
        }
        public void RegisterObserver(IObserver o)
        {
            if (o == null) throw new ArgumentNullException();
            if (observers.Contains(o)) throw new Exception();
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
        public int GetState()
        {
            return sInfo.Stat;
        }
    }
    public class State
    {
        int state = 0;
        public int Stat { get { return state; } set { state = value; } }
    }
    public class CountObserver : IObserver
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
    public class CurrentObserver : IObserver
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
