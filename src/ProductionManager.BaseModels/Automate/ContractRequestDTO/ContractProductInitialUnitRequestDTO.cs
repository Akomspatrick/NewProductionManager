namespace ProductionManager.Contracts.RequestDTO
{
    public  record ProductInitialUnitGetRequestByGuidDTO(Guid guid);
    public  record ProductInitialUnitGetRequestByIdDTO(String ObjectNameId);
    public  record ProductInitialUnitGetRequestDTO(Object Value);
    public  record ProductInitialUnitCreateRequestDTO(Int32  productId, DateTime  timeStamp, string  inputUnits, string  outputUnits, Guid  guidId );
    public  record ProductInitialUnitUpdateRequestDTO(Int32  productId, DateTime  timeStamp, string  inputUnits, string  outputUnits, Guid  guidId);
    public  record ProductInitialUnitDeleteRequestDTO(Guid guid);
}