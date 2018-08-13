namespace EntityFramework_CodeFirst_Migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefatoradoCategoria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        descricao = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Produtoes", "categoria_id", c => c.Int());
            CreateIndex("dbo.Produtoes", "categoria_id");
            AddForeignKey("dbo.Produtoes", "categoria_id", "dbo.Categorias", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtoes", "categoria_id", "dbo.Categorias");
            DropIndex("dbo.Produtoes", new[] { "categoria_id" });
            DropColumn("dbo.Produtoes", "categoria_id");
            DropTable("dbo.Categorias");
        }
    }
}
