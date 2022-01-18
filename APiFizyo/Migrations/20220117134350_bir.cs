using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APiFizyo.Migrations
{
    public partial class bir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    RolID = table.Column<int>(type: "int", nullable: false),
                    RolAdı = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.RolID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanıcılar",
                columns: table => new
                {
                    KullanıcıID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eposta = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Şifre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RolID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanıcılar", x => x.KullanıcıID);
                    table.ForeignKey(
                        name: "FK_Kullanıcılar_Roller_RolID",
                        column: x => x.RolID,
                        principalTable: "Roller",
                        principalColumn: "RolID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roller",
                columns: new[] { "RolID", "RolAdı" },
                values: new object[,]
                {
                    { 1, "UserCandidate" },
                    { 2, "UserNormal" },
                    { 3, "Admin" },
                    { 4, "Supervisor" }
                });

            migrationBuilder.InsertData(
                table: "Kullanıcılar",
                columns: new[] { "KullanıcıID", "Eposta", "RolID", "Şifre" },
                values: new object[,]
                {
                    { 1, "sinan@outlook.com", 1, "Qwe123456" },
                    { 2, "ali@hotmail.com", 1, "Qwe123456" },
                    { 3, "mahmut@hotmail.com", 3, "Qwe123456" },
                    { 4, "mansurkürşad@icloud.com", 2, "Qwe123456" },
                    { 5, "gamze@gmail.com", 4, "Qwe123456" },
                    { 6, "miraç@hotmail.com", 3, "Qwe123456" },
                    { 7, "yücel@outlook.com", 1, "Qwe123456" },
                    { 8, "kubilay@gmail.com", 4, "Qwe123456" },
                    { 9, "hayati@hotmail.com", 3, "Qwe123456" },
                    { 10, "bedriyemüge@hotmail.com", 2, "Qwe123456" },
                    { 11, "birsen@icloud.com", 1, "Qwe123456" },
                    { 12, "serdal@gmail.com", 2, "Qwe123456" },
                    { 13, "bünyamin@gmail.com", 3, "Qwe123456" },
                    { 14, "özgür@gmail.com", 2, "Qwe123456" },
                    { 15, "ferdi@gmail.com", 1, "Qwe123456" },
                    { 16, "reyhan@outlook.com", 2, "Qwe123456" },
                    { 17, "ilhan@gmail.com", 2, "Qwe123456" },
                    { 18, "gülşah@icloud.com", 4, "Qwe123456" },
                    { 19, "nalan@outlook.com", 3, "Qwe123456" },
                    { 20, "semih@outlook.com", 2, "Qwe123456" },
                    { 21, "ergün@outlook.com", 1, "Qwe123456" },
                    { 22, "fatih@hotmail.com", 3, "Qwe123456" },
                    { 23, "şenay@gmail.com", 4, "Qwe123456" },
                    { 24, "serkan@outlook.com", 4, "Qwe123456" },
                    { 25, "emre@icloud.com", 4, "Qwe123456" },
                    { 26, "bahattin@gmail.com", 4, "Qwe123456" },
                    { 27, "irazca@gmail.com", 1, "Qwe123456" },
                    { 28, "hatice@icloud.com", 3, "Qwe123456" },
                    { 29, "bariş@icloud.com", 3, "Qwe123456" },
                    { 30, "rezan@hotmail.com", 3, "Qwe123456" },
                    { 31, "fatih@gmail.com", 2, "Qwe123456" },
                    { 32, "fuat@outlook.com", 1, "Qwe123456" },
                    { 33, "gökhan@icloud.com", 1, "Qwe123456" },
                    { 34, "orhan@outlook.com", 4, "Qwe123456" },
                    { 35, "mehmet@hotmail.com", 3, "Qwe123456" },
                    { 36, "evren@hotmail.com", 3, "Qwe123456" },
                    { 37, "oktay@gmail.com", 1, "Qwe123456" },
                    { 38, "harun@gmail.com", 1, "Qwe123456" },
                    { 39, "yavuz@hotmail.com", 4, "Qwe123456" },
                    { 40, "pinar@hotmail.com", 4, "Qwe123456" },
                    { 41, "mehmet@icloud.com", 2, "Qwe123456" },
                    { 42, "umut@outlook.com", 2, "Qwe123456" }
                });

            migrationBuilder.InsertData(
                table: "Kullanıcılar",
                columns: new[] { "KullanıcıID", "Eposta", "RolID", "Şifre" },
                values: new object[,]
                {
                    { 43, "mesude@hotmail.com", 4, "Qwe123456" },
                    { 44, "hüseyincahit@gmail.com", 4, "Qwe123456" },
                    { 45, "haşimonur@gmail.com", 2, "Qwe123456" },
                    { 46, "eyyupsabri@gmail.com", 3, "Qwe123456" },
                    { 47, "mustafa@icloud.com", 2, "Qwe123456" },
                    { 48, "mustafa@icloud.com", 2, "Qwe123456" },
                    { 49, "ufuk@icloud.com", 1, "Qwe123456" },
                    { 50, "ahmetali@hotmail.com", 2, "Qwe123456" },
                    { 51, "mediha@icloud.com", 2, "Qwe123456" },
                    { 52, "hasan@icloud.com", 3, "Qwe123456" },
                    { 53, "kamil@icloud.com", 3, "Qwe123456" },
                    { 54, "nebi@icloud.com", 1, "Qwe123456" },
                    { 55, "özcan@gmail.com", 4, "Qwe123456" },
                    { 56, "nagihan@gmail.com", 3, "Qwe123456" },
                    { 57, "ceren@gmail.com", 2, "Qwe123456" },
                    { 58, "serkan@hotmail.com", 3, "Qwe123456" },
                    { 59, "hasan@icloud.com", 3, "Qwe123456" },
                    { 60, "yusufkenan@gmail.com", 4, "Qwe123456" },
                    { 61, "çetin@icloud.com", 1, "Qwe123456" },
                    { 62, "tarkan@gmail.com", 2, "Qwe123456" },
                    { 63, "meralleman@hotmail.com", 2, "Qwe123456" },
                    { 64, "ergün@icloud.com", 4, "Qwe123456" },
                    { 65, "kenanahmet@icloud.com", 4, "Qwe123456" },
                    { 66, "ural@icloud.com", 4, "Qwe123456" },
                    { 67, "yahya@icloud.com", 2, "Qwe123456" },
                    { 68, "bengü@outlook.com", 2, "Qwe123456" },
                    { 69, "fatihnazmi@hotmail.com", 2, "Qwe123456" },
                    { 70, "dilek@outlook.com", 1, "Qwe123456" },
                    { 71, "mehmet@icloud.com", 1, "Qwe123456" },
                    { 72, "tufanakin@hotmail.com", 4, "Qwe123456" },
                    { 73, "mehmet@hotmail.com", 1, "Qwe123456" },
                    { 74, "turgayyilmaz@icloud.com", 4, "Qwe123456" },
                    { 75, "güldehen@icloud.com", 4, "Qwe123456" },
                    { 76, "gökmen@hotmail.com", 2, "Qwe123456" },
                    { 77, "bülent@gmail.com", 2, "Qwe123456" },
                    { 78, "erol@icloud.com", 2, "Qwe123456" },
                    { 79, "bahri@icloud.com", 1, "Qwe123456" },
                    { 80, "özenözlem@gmail.com", 2, "Qwe123456" },
                    { 81, "selma@icloud.com", 3, "Qwe123456" },
                    { 82, "tuğsem@hotmail.com", 1, "Qwe123456" },
                    { 83, "teslimenazli@gmail.com", 4, "Qwe123456" },
                    { 84, "gülçin@hotmail.com", 3, "Qwe123456" }
                });

            migrationBuilder.InsertData(
                table: "Kullanıcılar",
                columns: new[] { "KullanıcıID", "Eposta", "RolID", "Şifre" },
                values: new object[,]
                {
                    { 85, "ismail@icloud.com", 3, "Qwe123456" },
                    { 86, "murat@gmail.com", 4, "Qwe123456" },
                    { 87, "ebru@icloud.com", 2, "Qwe123456" },
                    { 88, "tümay@gmail.com", 2, "Qwe123456" },
                    { 89, "ahmet@gmail.com", 4, "Qwe123456" },
                    { 90, "ebru@icloud.com", 2, "Qwe123456" },
                    { 91, "hüseyinyavuz@gmail.com", 3, "Qwe123456" },
                    { 92, "başak@outlook.com", 1, "Qwe123456" },
                    { 93, "ayşegül@hotmail.com", 1, "Qwe123456" },
                    { 94, "evrim@icloud.com", 4, "Qwe123456" },
                    { 95, "yaser@hotmail.com", 3, "Qwe123456" },
                    { 96, "ülkü@icloud.com", 3, "Qwe123456" },
                    { 97, "özhan@icloud.com", 1, "Qwe123456" },
                    { 98, "ufuk@gmail.com", 4, "Qwe123456" },
                    { 99, "aksel@hotmail.com", 3, "Qwe123456" },
                    { 100, "fulya@icloud.com", 3, "Qwe123456" },
                    { 101, "burcu@icloud.com", 3, "Qwe123456" },
                    { 102, "taylan@hotmail.com", 4, "Qwe123456" },
                    { 103, "yilmaz@icloud.com", 2, "Qwe123456" },
                    { 104, "zeynep@gmail.com", 4, "Qwe123456" },
                    { 105, "bayram@icloud.com", 3, "Qwe123456" },
                    { 106, "gülay@hotmail.com", 3, "Qwe123456" },
                    { 107, "rabia@outlook.com", 1, "Qwe123456" },
                    { 108, "sevda@outlook.com", 2, "Qwe123456" },
                    { 109, "serhat@hotmail.com", 2, "Qwe123456" },
                    { 110, "engin@icloud.com", 3, "Qwe123456" },
                    { 111, "asli@hotmail.com", 2, "Qwe123456" },
                    { 112, "tuba@icloud.com", 2, "Qwe123456" },
                    { 113, "bariş@hotmail.com", 4, "Qwe123456" },
                    { 114, "sevgi@hotmail.com", 4, "Qwe123456" },
                    { 115, "kalender@outlook.com", 3, "Qwe123456" },
                    { 116, "halil@icloud.com", 4, "Qwe123456" },
                    { 117, "bilge@icloud.com", 1, "Qwe123456" },
                    { 118, "ferda@gmail.com", 4, "Qwe123456" },
                    { 119, "ezgi@hotmail.com", 2, "Qwe123456" },
                    { 120, "aysun@outlook.com", 4, "Qwe123456" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kullanıcılar_RolID",
                table: "Kullanıcılar",
                column: "RolID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kullanıcılar");

            migrationBuilder.DropTable(
                name: "Roller");
        }
    }
}
