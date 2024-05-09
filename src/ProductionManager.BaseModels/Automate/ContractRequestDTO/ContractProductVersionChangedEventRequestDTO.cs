namespace ProductionManager.Contracts.RequestDTO
{
    public  record ProductVersionChangedEventGetRequestByGuidDTO(Guid guid);
    public  record ProductVersionChangedEventGetRequestByIdDTO(String ObjectNameId);
    public  record ProductVersionChangedEventGetRequestDTO(Object Value);
    public  record ProductVersionChangedEventCreateRequestDTO(Int32  prevModelVersionId, string  prevModelName, Int32  currentModelVersionId, string  currentPrevModelName, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductVersionChangedEventUpdateRequestDTO(Int32  prevModelVersionId, string  prevModelName, Int32  currentModelVersionId, string  currentPrevModelName, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductVersionChangedEventDeleteRequestDTO(Guid guid);
}