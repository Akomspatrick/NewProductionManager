namespace ProductionManager.Contracts.RequestDTO
{
    public  record RefreshTokenGetRequestByGuidDTO(Guid guid);
    public  record RefreshTokenGetRequestByIdDTO(String ObjectNameId);
    public  record RefreshTokenGetRequestDTO(Object Value);
    public  record RefreshTokenCreateRequestDTO(Int32  id, string  userId, string  token, string  jwtId, bool  isUsed, bool  isRevoked, DateTime  createdAt, DateTime  expiryDate, Guid  guidId );
    public  record RefreshTokenUpdateRequestDTO(Int32  id, string  userId, string  token, string  jwtId, bool  isUsed, bool  isRevoked, DateTime  createdAt, DateTime  expiryDate, Guid  guidId);
    public  record RefreshTokenDeleteRequestDTO(Guid guid);
}