namespace Task3
{
    public interface IFamily<T>
    {
        T Name { get; }
        IFamily<T> Parent { get; }
    }
}