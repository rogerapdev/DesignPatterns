using ObserverPattern.Interfaces;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class EstacaoMeteorologica : ISubject
    {
        private List<IObserver> observers;

        private float _temperatura;

        public float Temperatura {
            get { return _temperatura; }
            set { _temperatura = value; Notificar(); }
        }

        public EstacaoMeteorologica()
        {
            this.observers = new List<IObserver>();
        }

        public void Anexar(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Notificar()
        {
            observers.ForEach(o =>
            {
                o.Atualizar(this);
            });
        }
    }
}
