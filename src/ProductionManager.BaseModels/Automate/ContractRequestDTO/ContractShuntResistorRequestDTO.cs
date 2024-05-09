namespace ProductionManager.Contracts.RequestDTO
{
    public  record ShuntResistorGetRequestByGuidDTO(Guid guid);
    public  record ShuntResistorGetRequestByIdDTO(String ObjectNameId);
    public  record ShuntResistorGetRequestDTO(Object Value);
    public  record ShuntResistorCreateRequestDTO(decimal  value, Guid  guidId );
    public  record ShuntResistorUpdateRequestDTO(decimal  value, Guid  guidId);
    public  record ShuntResistorDeleteRequestDTO(Guid guid);
}