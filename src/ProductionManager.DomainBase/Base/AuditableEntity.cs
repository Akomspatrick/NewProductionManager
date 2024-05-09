

using ProductionManager.DomainBase.Interfaces;

namespace ProductionManager.DomainBase
{
    public class AuditableEntity : IAuditableEntity
    {
        public DateTimeOffset? CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTimeOffset? UpdatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CreatedBy { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }
        public string UpdatedBy { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }
    }
}
