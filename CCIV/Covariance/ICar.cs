namespace CCIV.Covariance;

//Для того чтобы сделать обобщённый интерфейс ковариантным
//нужно использовать ключевое слово out
public interface ICar<out T> where T : Engine
{
    T GetEngine();
}