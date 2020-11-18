using ChopCheck.Data.Helpers;

namespace ChopCheck.Data.Models
{
    public abstract class BaseModel : IBaseModel
    {
        public DapperCommandType DapperCommandType { get; set; }
    }
}