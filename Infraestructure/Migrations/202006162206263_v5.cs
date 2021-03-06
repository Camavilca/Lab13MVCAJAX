﻿namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "FechaCreacion", c => c.DateTime());
            AlterColumn("dbo.Students", "FechaModificacion", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "FechaModificacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Students", "FechaCreacion", c => c.DateTime(nullable: false));
        }
    }
}
