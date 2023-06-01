namespace CCIV.Contrvariance;

//Для того чтобы указать что интерфейс
//является контрвариантным нужно
//использовать ключевое слово in
public interface IPushable<in T> where T : Animal
{
    public void Push(T obj);
}