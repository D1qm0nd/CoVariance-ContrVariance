namespace CCIV;


public delegate T DefaultDelegate<T>();

public delegate T CoVarianceDelegate<out T>();

public delegate TRes ContrVarianceDelegate<in T, out TRes>(T obj);