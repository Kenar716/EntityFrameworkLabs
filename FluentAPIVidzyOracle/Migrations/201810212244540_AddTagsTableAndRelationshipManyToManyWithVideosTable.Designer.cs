// <auto-generated />
namespace CodeFirstVidzyOracle.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.0.0-20911")]
    public sealed partial class AddTagsTableAndRelationshipManyToManyWithVideosTable : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(AddTagsTableAndRelationshipManyToManyWithVideosTable));
        
        string IMigrationMetadata.Id
        {
            get { return "201810212244540_AddTagsTableAndRelationshipManyToManyWithVideosTable"; }
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
