// <auto-generated />
namespace ApiSample.DA.Tables.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    public sealed partial class AddAuditLog : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(AddAuditLog));
        
        string IMigrationMetadata.Id
        {
            get { return "201310080104449_AddAuditLog"; }
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
