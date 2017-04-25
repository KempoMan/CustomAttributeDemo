namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'02cc3c61-f729-42c7-8d9f-4054d4397d96', N'guest@vidly.com', 0, N'ANYZ4WGaTKfEo2Va1erlHEgsqwyumHtkVac+ep/btQm9lFSEnwTFTA9kkslJFWcy8w==', N'9ddf7e34-6c4e-426e-aa44-0fd61d475a90', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'63bcf116-5d3a-4fec-8916-4a58b5747eb4', N'admin@vidly.com', 0, N'AN8wSHWkmUyxnMvu6tbF5HWMOqy6Tdkb7PtnoPm3CUFy6grj45KOAKkYk9wKDcH3fg==', N'58f586e8-9d1b-4263-9485-fc0bfa0c0fc7', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'87693497-8cfc-4b77-a15e-1e87fccdff1a', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'63bcf116-5d3a-4fec-8916-4a58b5747eb4', N'87693497-8cfc-4b77-a15e-1e87fccdff1a')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
