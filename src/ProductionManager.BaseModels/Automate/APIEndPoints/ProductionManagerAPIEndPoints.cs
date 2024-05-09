namespace ProductionManager.Api
{
    public static class ProductionManagerAPIEndPoints
    {
        public const string APIBase = "api";
        public static class MassfussionFunction
        {
            public const string Controller = "MassfussionFunctions";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class MassLoadApplication
        {
            public const string Controller = "MassLoadApplications";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class RefreshToken
        {
            public const string Controller = "RefreshTokens";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class UsersGroup
        {
            public const string Controller = "UsersGroups";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class AmplifierBoard
        {
            public const string Controller = "AmplifierBoards";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class DefectType
        {
            public const string Controller = "DefectTypes";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class DefectTypeSolution
        {
            public const string Controller = "DefectTypeSolutions";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class LogDetail
        {
            public const string Controller = "LogDetails";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class LogSummary
        {
            public const string Controller = "LogSummarys";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ModelVersion
        {
            public const string Controller = "ModelVersions";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class NonConformanceLog
        {
            public const string Controller = "NonConformanceLogs";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class Product
        {
            public const string Controller = "Products";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductAdditionalInfo
        {
            public const string Controller = "ProductAdditionalInfos";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductCablingEvent
        {
            public const string Controller = "ProductCablingEvents";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductCertificate
        {
            public const string Controller = "ProductCertificates";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductCertificateType
        {
            public const string Controller = "ProductCertificateTypes";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductFinalUnit
        {
            public const string Controller = "ProductFinalUnits";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductFinalVerifiationEvent
        {
            public const string Controller = "ProductFinalVerifiationEvents";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductFinishedEvent
        {
            public const string Controller = "ProductFinishedEvents";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductGaugeInspectionEvent
        {
            public const string Controller = "ProductGaugeInspectionEvents";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductGaugeEvent
        {
            public const string Controller = "ProductGaugeEvents";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductInitialUnit
        {
            public const string Controller = "ProductInitialUnits";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductInitialVerificationEvent
        {
            public const string Controller = "ProductInitialVerificationEvents";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductInventoryEvent
        {
            public const string Controller = "ProductInventoryEvents";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductLabellingEvent
        {
            public const string Controller = "ProductLabellingEvents";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductMovingEvent
        {
            public const string Controller = "ProductMovingEvents";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductPicture
        {
            public const string Controller = "ProductPictures";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductReceptionEvent
        {
            public const string Controller = "ProductReceptionEvents";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductResistorInstallationEvent
        {
            public const string Controller = "ProductResistorInstallationEvents";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductSealingEvent
        {
            public const string Controller = "ProductSealingEvents";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductShippingEvent
        {
            public const string Controller = "ProductShippingEvents";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductStage
        {
            public const string Controller = "ProductStages";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductSurfacePreparationEvent
        {
            public const string Controller = "ProductSurfacePreparationEvents";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductVersionChangedEvent
        {
            public const string Controller = "ProductVersionChangedEvents";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ProductWiringEvent
        {
            public const string Controller = "ProductWiringEvents";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ReferenceCellCalibration
        {
            public const string Controller = "ReferenceCellCalibrations";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ReferenceStandard
        {
            public const string Controller = "ReferenceStandards";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class ShuntResistor
        {
            public const string Controller = "ShuntResistors";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class Test
        {
            public const string Controller = "Tests";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class Tester
        {
            public const string Controller = "Testers";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
        public static class TrimmingResistor
        {
            public const string Controller = "TrimmingResistors";
            public const string Create = $"{APIBase}/{Controller}";
            public const string Delete = $"{APIBase}/{Controller}/{{request}}";
            public const string GetById = $"{APIBase}/{Controller}/{{NameOrGuid}}";
            public const string GetByJSONBody = $"{APIBase}/{Controller}/JsonBody";
            public const string Get = $"{APIBase}/{Controller}";
            public const string Update = $"{APIBase}/{Controller}";
        }
    }
}