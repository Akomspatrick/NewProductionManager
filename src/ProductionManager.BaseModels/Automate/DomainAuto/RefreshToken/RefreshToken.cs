using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class RefreshToken  : BaseEntity
    {
        private RefreshToken(){}
        public Int32 Id    { get; init; } 
        public string UserId    { get; init; }  = string.Empty; 
        public string Token    { get; init; }  = string.Empty; 
        public string JwtId    { get; init; }  = string.Empty; 
        public bool IsUsed    { get; init; } 
        public bool IsRevoked    { get; init; } 
        public DateTime CreatedAt    { get; init; } 
        public DateTime ExpiryDate    { get; init; } 
        public Guid GuidId    { get; init; } 
        
        public static RefreshToken Create(Int32  id, string  userId, string  token, string  jwtId, bool  isUsed, bool  isRevoked, DateTime  createdAt, DateTime  expiryDate, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"RefreshToken Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            Id = id ,
            UserId = userId ,
            Token = token ,
            JwtId = jwtId ,
            IsUsed = isUsed ,
            IsRevoked = isRevoked ,
            CreatedAt = createdAt ,
            ExpiryDate = expiryDate ,
            GuidId = guidId ,
        };
    }
    }
}