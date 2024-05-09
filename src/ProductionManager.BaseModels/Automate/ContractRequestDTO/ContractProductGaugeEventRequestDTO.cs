namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ProductGaugeEventGetRequestByGuidDTO(Guid guid);
    public  record ProductGaugeEventGetRequestByIdDTO(String EntityNameId);
    public  record ProductGaugeEventGetRequestDTO(Object EntityNameId);
    public  record ProductGaugeEventCreateRequestDTO(string  guageModel, string  guageLotNo, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductGaugeEventUpdateRequestDTO(string  guageModel, string  guageLotNo, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductGaugeEventDeleteRequestDTO(Guid guid);
}