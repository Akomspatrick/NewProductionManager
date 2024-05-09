namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record DefectTypeSolutionGetRequestByGuidDTO(Guid guid);
    public  record DefectTypeSolutionGetRequestByIdDTO(String EntityNameId);
    public  record DefectTypeSolutionGetRequestDTO(Object EntityNameId);
    public  record DefectTypeSolutionCreateRequestDTO(string  defectName, string  stage, string  solution, DateTime  timestamp, string  userName, Guid  guidId );
    public  record DefectTypeSolutionUpdateRequestDTO(string  defectName, string  stage, string  solution, DateTime  timestamp, string  userName, Guid  guidId);
    public  record DefectTypeSolutionDeleteRequestDTO(Guid guid);
}