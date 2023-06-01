using System.Collections.ObjectModel;

namespace CCIV.Contrvariance;

public class MyStack<T> : IPushable<T> where T : Animal
{
    public Collection<T> Items { get; protected set; }

    public MyStack()
    {
        Items = new Collection<T>();  
    }
    public void Push(T obj)
    {
        Items.Add(obj);
    }
}