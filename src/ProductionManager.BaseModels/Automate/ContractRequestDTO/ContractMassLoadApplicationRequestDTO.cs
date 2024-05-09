namespace ProductionManager.Contracts.RequestDTO
{
    public  record MassLoadApplicationGetRequestByGuidDTO(Guid guid);
    public  record MassLoadApplicationGetRequestByIdDTO(String ObjectNameId);
    public  record MassLoadApplicationGetRequestDTO(Object Value);
    public  record MassLoadApplicationCreateRequestDTO(string  name, string  description, Guid  guidId );
    public  record MassLoadApplicationUpdateRequestDTO(string  name, string  description, Guid  guidId);
    public  record MassLoadApplicationDeleteRequestDTO(Guid guid);
}