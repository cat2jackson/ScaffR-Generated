// <auto-generated />
namespace DemoApplication.Infrastructure.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    public sealed partial class Log : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(Log));
        
        string IMigrationMetadata.Id
        {
            get { return "201303200322226_Log"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
