namespace ProductionManager.Contracts.RequestDTO
{
    public  record TrimmingResistorGetRequestByGuidDTO(Guid guid);
    public  record TrimmingResistorGetRequestByIdDTO(String ObjectNameId);
    public  record TrimmingResistorGetRequestDTO(Object Value);
    public  record TrimmingResistorCreateRequestDTO(decimal  value, Guid  guidId );
    public  record TrimmingResistorUpdateRequestDTO(decimal  value, Guid  guidId);
    public  record TrimmingResistorDeleteRequestDTO(Guid guid);
}