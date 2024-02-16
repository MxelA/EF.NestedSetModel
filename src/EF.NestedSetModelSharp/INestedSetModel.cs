namespace EF.NestedSetModelSharp
{
    public interface INestedSetModel<T, TKey, TNullableKey> where T: INestedSetModel<T, TKey, TNullableKey>
    {
        TKey Id { get; set; }
        T Parent { get; set; }
        TNullableKey ParentId { get; set; }
        int Level { get; set; }
        int Left { get; set; }
        int Right { get; set; }
        bool Moving { get; set; }
        T Root { get; set; }
        TNullableKey RootId { get; set; }
        List<T> Children { get; set; }
        List<T> Descendants { get; set; }
    }
}