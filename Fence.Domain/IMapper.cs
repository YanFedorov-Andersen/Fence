namespace Fence.Domain
{
    public interface IMapper<T, DTO>
    {
        DTO AutoMap(T item);
        T ReverseAutoMap(DTO item, T initialItem);
    }
}
