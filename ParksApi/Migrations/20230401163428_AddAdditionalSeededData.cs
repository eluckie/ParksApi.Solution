using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParksApi.Migrations
{
    public partial class AddAdditionalSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Parks",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "City", "Name", "NationalPark", "State", "StatePark" },
                values: new object[,]
                {
                    { 1, "Grand Canyon Village", "Grand Canyon National Park", true, "Arizona", false },
                    { 2, "Aurora", "Cherry Creek State Park", false, "Colorado", true },
                    { 3, "Littleton", "Chatfield State Park", false, "Colorado", true },
                    { 4, "Yosemite National Park", "Yosemite National Park", true, "California", false },
                    { 5, "West Glacier", "Glacier National Park", true, "Montana", false },
                    { 6, "Commerce City", "Barr Lake State Park", false, "Colorado", true },
                    { 7, "Colorado Springs", "Cheyenne Mountain State Park", false, "Colorado", true },
                    { 8, "Crawford", "Crawford State Park", false, "Colorado", true },
                    { 9, "Lake George", "Eleven Mile State Park", false, "Colorado", true },
                    { 10, "Orchard", "Jackson Lake State Park", false, "Colorado", true },
                    { 11, "Hasty", "John Martin Reservoir State Park", false, "Colorado", true },
                    { 12, "Pueblo", "Lake Pueblo State Park", false, "Colorado", true },
                    { 13, "Mancos", "Mancos State Park", false, "Colorado", true },
                    { 14, "Ridgway", "Ridgway State Park", false, "Colorado", true },
                    { 15, "Firestone", "St. Vrain State Park", false, "Colorado", true },
                    { 16, "Pine", "Staunton State Park", false, "Colorado", true },
                    { 17, "Clark", "Steamboat Lake State Park", false, "Colorado", true },
                    { 18, "Trinidad", "Trinidad Lake State Park", false, "Colorado", true },
                    { 19, "Denali Park", "Denali National Park", true, "Alaska", false },
                    { 20, "Fairbanks", "Gates of the Arctic National Park", true, "Alaska", false },
                    { 21, "Gustavus", "Glacier Bay National Park Preserve", true, "Alaska", false },
                    { 22, "King Salmon", "Katmai National Park", true, "Alaska", false },
                    { 23, "Seward", "Kenai Fjords National Park", true, "Alaska", false },
                    { 24, "Kotzebue", "Kobuk Valley National Park", true, "Alaska", false },
                    { 25, "Anchorage", "Lake Clark National Park and Preserve", true, "Alaska", false },
                    { 26, "Copper Center", "Wrangell-St. Elias National Park and Preserve", true, "Alaska", false },
                    { 27, "Petrified Forest", "Petrified Forest National Park", true, "Arizona", false },
                    { 28, "Tucson", "Saguaro National Park", true, "Arizona", false },
                    { 29, "Hot Springs", "Hot Springs National Park", true, "Arkansas", false },
                    { 30, "Ventura", "Channel Islands National Park", true, "California", false },
                    { 31, "Furnace Creek", "Death Valley National Park", true, "California", false },
                    { 32, "Joshua Tree", "Joshua Tree National Park", true, "California", false },
                    { 33, "Three Rivers", "Kings Canyon National Park", true, "California", false },
                    { 34, "Mineral", "Lassen Volcanic National Park", true, "California", false },
                    { 35, "Paicines", "Pinnacles National Park", true, "California", false },
                    { 36, "Crescent City", "Del Norte Coast Redwoods State Park", false, "California", true },
                    { 37, "Three Rivers", "Sequoia National Park", true, "California", false },
                    { 38, "Montrose", "Black Canyon of the Gunnison National Park", true, "Colorado", false },
                    { 39, "Mosca", "Great Sand Dunes National Park", true, "Colorado", false },
                    { 40, "Mesa Verde National Park", "Mesa Verde National Park", true, "Colorado", false },
                    { 41, "Homestead", "Biscayne National Park", true, "Florida", false },
                    { 42, "Homestead", "Dry Tortugas National Park", true, "Florida", false },
                    { 43, "Homestead", "Everglades National Park", true, "Florida", false },
                    { 44, "Makawao", "Haleakala National Park", true, "Hawaii", false },
                    { 45, "Hawaii National Park", "Hawaii Volcanoes National Park", true, "Hawaii", false },
                    { 46, "Yellowstone National Park", "Yellowstone National Park", true, "Wyoming", false },
                    { 47, "Porter", "Indiana Dunes National Park", true, "Indiana", false },
                    { 48, "Bar Harbor", "Acadia National Park", true, "Maine", false },
                    { 49, "Houghton", "Isle Royale National Park", true, "Michigan", false },
                    { 50, "International Falls", "Voyageurs National Park", true, "Minnesota", false },
                    { 51, "St. Louis", "Gateway Arch National Park", true, "Missouri", false },
                    { 52, "Peninsula", "Cuyahoga Valley National Park", true, "Ohio", false },
                    { 53, "Baker", "Great Basin National Park", true, "Nevada", false },
                    { 54, "Carlsbad", "Carlsbad Caverns National Park", true, "New Mexico", false },
                    { 55, "Alamogordo", "White Sands National Park", true, "New Mexico", false },
                    { 56, "Medora", "Theodore Roosevelt National Park", true, "North Dakota", false },
                    { 57, "Gatlinburg", "Great Smoky Mountains", true, "Tenneessee", false },
                    { 58, "Crater Lake", "Crater Lake National Park", true, "Oregon", false },
                    { 59, "Hopkins", "Congaree National Park", true, "South Carolina", false },
                    { 60, "Interior", "Badlands National Park", true, "South Dakota", false },
                    { 61, "Hot Springs", "Wind Cave National Park", true, "South Dakota", false },
                    { 62, "", "Arches National Park", true, "Utah", false },
                    { 63, "Crescent City", "Redwood National Park", true, "California", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 1);

                migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 2);

                migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 3);

                migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 4);

                migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "",
                keyValue: 63);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Parks",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
