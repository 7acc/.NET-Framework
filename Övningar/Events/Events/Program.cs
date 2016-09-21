using System;



namespace Events
{
    using System.Collections;

    public delegate void ChangedEventHandler(object sender, EventArgs e);

    public class ListWithChangedEvents : ArrayList
    {
        public event ChangedEventHandler Changed;

        protected virtual void OnChanged(EventArgs e)
        {
            if (Changed != null)
            {
                Changed(this, e);
            }
        }
        public override int Add(object value)
        {
            int i = base.Add(value);
            OnChanged(EventArgs.Empty);
            return i;
        }
        public override void Clear()
        {
            base.Clear();
            OnChanged(EventArgs.Empty);
        }

        public override object this[int index]
        {         
            set
            {
                base[index] = value;
                OnChanged(EventArgs.Empty);
            }
        }

    }


    namespace TestEvents
    {
        using Events;

        class EventListener
        {
            private ListWithChangedEvents List;

            public EventListener(ListWithChangedEvents list)
            {
                List = list;
                list.Changed += new ChangedEventHandler(ListChanged);
            }

            private void ListChanged(object sender, EventArgs e)
            {
                Console.WriteLine("FIIIRREEE!");
            }

            public void Detach()
            {
                List.Changed -= new ChangedEventHandler(ListChanged);
                List = null;
            }
        }

        class Test
        {
            public static void Main()
            {
                ListWithChangedEvents list = new ListWithChangedEvents();
                EventListener listener = new EventListener(list);

                list.Add("item1");
                list.Clear();
                listener.Detach();
                Console.ReadKey();
            }            
        }
    }
}
