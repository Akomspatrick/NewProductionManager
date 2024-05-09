namespace ProductionManager.Contracts.RequestDTO
{
    public  record UsersGroupGetRequestByGuidDTO(Guid guid);
    public  record UsersGroupGetRequestByIdDTO(String ObjectNameId);
    public  record UsersGroupGetRequestDTO(Object Value);
    public  record UsersGroupCreateRequestDTO(string  name, string  description, Guid  guidId );
    public  record UsersGroupUpdateRequestDTO(string  name, string  description, Guid  guidId);
    public  record UsersGroupDeleteRequestDTO(Guid guid);
}