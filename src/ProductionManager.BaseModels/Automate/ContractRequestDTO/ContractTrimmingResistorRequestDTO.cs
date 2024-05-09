namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record TrimmingResistorGetRequestByGuidDTO(Guid guid);
    public  record TrimmingResistorGetRequestByIdDTO(String EntityNameId);
    public  record TrimmingResistorGetRequestDTO(Object EntityNameId);
    public  record TrimmingResistorCreateRequestDTO(decimal  value, Guid  guidId );
    public  record TrimmingResistorUpdateRequestDTO(decimal  value, Guid  guidId);
    public  record TrimmingResistorDeleteRequestDTO(Guid guid);
}