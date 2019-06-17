namespace TesteEstoque.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alteracao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ingredientes", "Validade", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ingredientes", "Validade");
        }
    }
}
