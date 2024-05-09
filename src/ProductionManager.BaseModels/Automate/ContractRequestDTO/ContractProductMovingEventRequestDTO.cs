namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ProductMovingEventGetRequestByGuidDTO(Guid guid);
    public  record ProductMovingEventGetRequestByIdDTO(String EntityNameId);
    public  record ProductMovingEventGetRequestDTO(Object EntityNameId);
    public  record ProductMovingEventCreateRequestDTO(string  sourceStage, string  destinationStage, string  movingNotes, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductMovingEventUpdateRequestDTO(string  sourceStage, string  destinationStage, string  movingNotes, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductMovingEventDeleteRequestDTO(Guid guid);
}