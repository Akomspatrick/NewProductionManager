namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ShuntResistorGetRequestByGuidDTO(Guid guid);
    public  record ShuntResistorGetRequestByIdDTO(String EntityNameId);
    public  record ShuntResistorGetRequestDTO(Object EntityNameId);
    public  record ShuntResistorCreateRequestDTO(decimal  value, Guid  guidId );
    public  record ShuntResistorUpdateRequestDTO(decimal  value, Guid  guidId);
    public  record ShuntResistorDeleteRequestDTO(Guid guid);
}