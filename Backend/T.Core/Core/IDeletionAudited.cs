namespace T.Core
{
    interface IDeletionAudited: IHasDeletionTime
    {
        long? DeleterUserId { get; set; }
    }
}
