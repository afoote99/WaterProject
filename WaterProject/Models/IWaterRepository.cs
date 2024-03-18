namespace WaterProject.Models
{
    public interface IWaterRepository //This sets the rules for what must be had, each table will have its own "public "Iqueryable<TableName> TableNamePlural {get;}"
    {
        public IQueryable<Project> Projects { get; }
    }
}
