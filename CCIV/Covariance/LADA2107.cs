namespace CCIV.Covariance;

public class LADA2107 : ICar<V8Engine>
{
    public V8Engine GetEngine() => new V8Engine();
}