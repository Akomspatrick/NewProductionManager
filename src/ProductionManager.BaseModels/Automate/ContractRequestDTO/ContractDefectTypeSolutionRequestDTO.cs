namespace ProductionManager.Contracts.RequestDTO
{
    public  record DefectTypeSolutionGetRequestByGuidDTO(Guid guid);
    public  record DefectTypeSolutionGetRequestByIdDTO(String ObjectNameId);
    public  record DefectTypeSolutionGetRequestDTO(Object Value);
    public  record DefectTypeSolutionCreateRequestDTO(string  defectName, string  stage, string  solution, DateTime  timestamp, string  userName, Guid  guidId );
    public  record DefectTypeSolutionUpdateRequestDTO(string  defectName, string  stage, string  solution, DateTime  timestamp, string  userName, Guid  guidId);
    public  record DefectTypeSolutionDeleteRequestDTO(Guid guid);
}