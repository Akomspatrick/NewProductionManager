namespace ProductionManager.Contracts.RequestDTO
{
    public  record ProductMovingEventGetRequestByGuidDTO(Guid guid);
    public  record ProductMovingEventGetRequestByIdDTO(String ObjectNameId);
    public  record ProductMovingEventGetRequestDTO(Object Value);
    public  record ProductMovingEventCreateRequestDTO(string  sourceStage, string  destinationStage, string  movingNotes, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductMovingEventUpdateRequestDTO(string  sourceStage, string  destinationStage, string  movingNotes, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductMovingEventDeleteRequestDTO(Guid guid);
}