using System.Runtime.CompilerServices;
using CCIV.Covariance;
using CCIV.Contrvariance;


namespace CCIV;

[TestClass]
public class UnitTests
{
    [TestMethod]
    public void CovarianceTest()
    {
        LADA2107 lada = new LADA2107();
        ICar<V8Engine> UnknownCar = lada;
        //ICar<Engine> someCar = lada; //При приведении к общему типу проявляется инвариантность
    }
    
    [TestMethod]
    public void ContrvarianceTest()
    {
        //IPushable<Cat> cats = new Stack<Animal>(); //для того чтобы это заработало нужно использовать контрвариантность
        IPushable<Cat> cats = new MyStack<Animal>();
        cats.Push(new Cat());
        // cats.Push(new Dog()); //НО при этом мы попрежнему можем запихивать туда только тот тип который указали в обобщении
    }
    
    [TestMethod]
    public void DelegatesTest()
    {
        CoVarianceDelegate<Cat> covariance = null;
        covariance += () => new Cat();
        var a = covariance?.Invoke();

        ContrVarianceDelegate<int, double> contrVarianceDelegate = null;
        contrVarianceDelegate += (obj) => Double.Parse(obj.ToString());
        var b = contrVarianceDelegate?.Invoke(57);
    }

}