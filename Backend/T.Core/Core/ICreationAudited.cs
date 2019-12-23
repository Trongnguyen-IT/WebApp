namespace T.Core
{
    public interface ICreationAudited: IHasCreationTime
    {
        long? CreatorUserId { get; set; }
    }
}
