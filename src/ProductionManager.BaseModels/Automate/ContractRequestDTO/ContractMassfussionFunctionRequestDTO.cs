namespace ProductionManager.Contracts.RequestDTO
{
    public  record MassfussionFunctionGetRequestByGuidDTO(Guid guid);
    public  record MassfussionFunctionGetRequestByIdDTO(String ObjectNameId);
    public  record MassfussionFunctionGetRequestDTO(Object Value);
    public  record MassfussionFunctionCreateRequestDTO(string  claim, string  description, string  applicationName, Guid  guidId );
    public  record MassfussionFunctionUpdateRequestDTO(string  claim, string  description, string  applicationName, Guid  guidId);
    public  record MassfussionFunctionDeleteRequestDTO(Guid guid);
}