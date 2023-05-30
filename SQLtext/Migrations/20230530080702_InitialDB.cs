using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SQLtext.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "case_infor",
                columns: table => new
                {
                    Case_No = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_UnitName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Case_UnitNum = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_IDcard = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Case_Password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Case_Gender = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_Relig = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_BD = table.Column<DateTime>(type: "date", nullable: false),
                    Case_Lang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_Source = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_Work = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_Prof = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_Edu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_Addr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Case_House = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_Ident = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_Fund = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_Health = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_Actv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_Factly = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_Mari = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_Cnta = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_CntTel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_CntRel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_CntAdd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Case_Fami = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_Ques = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_Desc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_RegName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_RegTime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__case_inf__D0610232CD08B242", x => x.Case_No);
                });

            migrationBuilder.CreateTable(
                name: "lecture_class",
                columns: table => new
                {
                    Sch_Week = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Sch_Am = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Sch_Pm = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__lecture___CE91D8F57C0189BF", x => x.Sch_Week);
                });

            migrationBuilder.CreateTable(
                name: "Member_Information",
                columns: table => new
                {
                    Mem_SID = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Mem_UnitName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Mem_UnitNum = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Mem_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Mem_BD = table.Column<DateTime>(type: "date", nullable: false),
                    Mem_UID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Mem_Password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Mem_Gender = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Mem_Tphone = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Mem_MPhone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Mem_Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mem_Site = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mem_Prof = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mem_Cert = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mem_Trans = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mem_Expr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mem_Movt = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mem_PServ = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mem_Ident = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mem_SerRec = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Mem_Edu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Member_I__47D0834AC937CAE3", x => x.Mem_SID);
                });

            migrationBuilder.CreateTable(
                name: "case_act",
                columns: table => new
                {
                    Act_ID = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Act_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Act_Lec = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Act_Course = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Act_Loc = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Case_No = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Act_Ser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__case_act__6564ADDDE6E88FEE", x => x.Act_ID);
                    table.ForeignKey(
                        name: "FK__case_act__Case_N__2C3393D0",
                        column: x => x.Case_No,
                        principalTable: "case_infor",
                        principalColumn: "Case_No",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Case_Need",
                columns: table => new
                {
                    Case_NeedID = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_No = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_Read = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_Fami = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_Cons = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_Speak = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_Act = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_Med = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_See = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_Hear = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_Eat = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_Care = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_View1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_View2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_View3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_View4 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_View5 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_View6 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_View7 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_View8 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Case_View9 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Case_Need", x => x.Case_NeedID);
                    table.ForeignKey(
                        name: "FK__Case_Need__Case___36B12243",
                        column: x => x.Case_No,
                        principalTable: "case_infor",
                        principalColumn: "Case_No",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "case_physical_mental",
                columns: table => new
                {
                    Case_QAID = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_No = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_Live = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Case_Fre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Case_Content1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Case_Content2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Case_Content3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Case_Content4 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Case_Content5 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Case_Content6 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Case_Content7 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Case_Content8 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Case_Content9 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Case_Content10 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Case_Content11 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Case_Content12 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Case_Content13 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__case_phy__21B54A27A45929E0", x => x.Case_QAID);
                    table.ForeignKey(
                        name: "FK__case_phys__Case___398D8EEE",
                        column: x => x.Case_No,
                        principalTable: "case_infor",
                        principalColumn: "Case_No",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Case_Care_Records",
                columns: table => new
                {
                    Case_QAID = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_No = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_Time1 = table.Column<DateTime>(type: "datetime", nullable: false),
                    Case_Time2 = table.Column<DateTime>(type: "datetime", nullable: false),
                    Case_Cont = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Case_Issue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Case_Rem = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mem_SID = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_RegTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Case_Car__21B54A27F2CCAA90", x => x.Case_QAID);
                    table.ForeignKey(
                        name: "FK__Case_Care__Case___2F10007B",
                        column: x => x.Case_No,
                        principalTable: "case_infor",
                        principalColumn: "Case_No",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Case_Care__Mem_S__300424B4",
                        column: x => x.Mem_SID,
                        principalTable: "Member_Information",
                        principalColumn: "Mem_SID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "case_daily_registration",
                columns: table => new
                {
                    Case_ContID = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_No = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_dailyTime1 = table.Column<DateTime>(type: "datetime", nullable: false),
                    Case_dailyTime2 = table.Column<DateTime>(type: "datetime", nullable: false),
                    Case_Temp = table.Column<int>(type: "int", nullable: false),
                    Case_Pluse = table.Column<int>(type: "int", nullable: false),
                    Case_Cont = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Case_Issue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Case_Rem = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mem_SID = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_Pick = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Case_RegTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__case_dai__0D7D6BC7A01B2B94", x => x.Case_ContID);
                    table.ForeignKey(
                        name: "FK__case_dail__Case___32E0915F",
                        column: x => x.Case_No,
                        principalTable: "case_infor",
                        principalColumn: "Case_No",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__case_dail__Mem_S__33D4B598",
                        column: x => x.Mem_SID,
                        principalTable: "Member_Information",
                        principalColumn: "Mem_SID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Case_Tel_Records",
                columns: table => new
                {
                    Case_TelQAID = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_No = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_RegTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Case_Sick = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Case_TelTime1 = table.Column<DateTime>(type: "datetime", nullable: false),
                    Case_TelTime2 = table.Column<DateTime>(type: "datetime", nullable: false),
                    Case_Ans = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_Exp = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_Hea = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_Live = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_Fam = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_Mental = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Case_Com = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Mem_SID = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Case_Tel__8C289C65ED256F69", x => x.Case_TelQAID);
                    table.ForeignKey(
                        name: "FK__Case_Tel___Case___3C69FB99",
                        column: x => x.Case_No,
                        principalTable: "case_infor",
                        principalColumn: "Case_No",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Case_Tel___Mem_S__3D5E1FD2",
                        column: x => x.Mem_SID,
                        principalTable: "Member_Information",
                        principalColumn: "Mem_SID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "lecture_table",
                columns: table => new
                {
                    Lec_ID = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Mem_SID = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Lec_Theme = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Lec_Class = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Lec_Aim = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Lec_Date = table.Column<DateTime>(type: "date", nullable: false),
                    Lec_Leader = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Lec_Pla = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Lec_Tool = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Lec_Step = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__lecture___2E5B8E905793C8AC", x => x.Lec_ID);
                    table.ForeignKey(
                        name: "FK__lecture_t__Mem_S__4222D4EF",
                        column: x => x.Mem_SID,
                        principalTable: "Member_Information",
                        principalColumn: "Mem_SID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "car_pick",
                columns: table => new
                {
                    Car_ID = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Mem_SID = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Car_Date = table.Column<DateTime>(type: "date", nullable: false),
                    Car_Type = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Car_Num = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Car_Month = table.Column<DateTime>(type: "date", nullable: false),
                    Car_CaseAdr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Car_L = table.Column<double>(type: "float", nullable: false),
                    Car_Km = table.Column<double>(type: "float", nullable: false),
                    Car_Price = table.Column<decimal>(type: "money", nullable: false),
                    Case_ContID = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__car_pick__523653D98367FCC5", x => x.Car_ID);
                    table.ForeignKey(
                        name: "FK__car_pick__Case_C__45F365D3",
                        column: x => x.Case_ContID,
                        principalTable: "case_daily_registration",
                        principalColumn: "Case_ContID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__car_pick__Mem_SI__44FF419A",
                        column: x => x.Mem_SID,
                        principalTable: "Member_Information",
                        principalColumn: "Mem_SID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_car_pick_Case_ContID",
                table: "car_pick",
                column: "Case_ContID");

            migrationBuilder.CreateIndex(
                name: "IX_car_pick_Mem_SID",
                table: "car_pick",
                column: "Mem_SID");

            migrationBuilder.CreateIndex(
                name: "IX_case_act_Case_No",
                table: "case_act",
                column: "Case_No");

            migrationBuilder.CreateIndex(
                name: "IX_Case_Care_Records_Case_No",
                table: "Case_Care_Records",
                column: "Case_No");

            migrationBuilder.CreateIndex(
                name: "IX_Case_Care_Records_Mem_SID",
                table: "Case_Care_Records",
                column: "Mem_SID");

            migrationBuilder.CreateIndex(
                name: "IX_case_daily_registration_Case_No",
                table: "case_daily_registration",
                column: "Case_No");

            migrationBuilder.CreateIndex(
                name: "IX_case_daily_registration_Mem_SID",
                table: "case_daily_registration",
                column: "Mem_SID");

            migrationBuilder.CreateIndex(
                name: "IX_Case_Need_Case_No",
                table: "Case_Need",
                column: "Case_No");

            migrationBuilder.CreateIndex(
                name: "IX_case_physical_mental_Case_No",
                table: "case_physical_mental",
                column: "Case_No");

            migrationBuilder.CreateIndex(
                name: "IX_Case_Tel_Records_Case_No",
                table: "Case_Tel_Records",
                column: "Case_No");

            migrationBuilder.CreateIndex(
                name: "IX_Case_Tel_Records_Mem_SID",
                table: "Case_Tel_Records",
                column: "Mem_SID");

            migrationBuilder.CreateIndex(
                name: "IX_lecture_table_Mem_SID",
                table: "lecture_table",
                column: "Mem_SID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "car_pick");

            migrationBuilder.DropTable(
                name: "case_act");

            migrationBuilder.DropTable(
                name: "Case_Care_Records");

            migrationBuilder.DropTable(
                name: "Case_Need");

            migrationBuilder.DropTable(
                name: "case_physical_mental");

            migrationBuilder.DropTable(
                name: "Case_Tel_Records");

            migrationBuilder.DropTable(
                name: "lecture_class");

            migrationBuilder.DropTable(
                name: "lecture_table");

            migrationBuilder.DropTable(
                name: "case_daily_registration");

            migrationBuilder.DropTable(
                name: "case_infor");

            migrationBuilder.DropTable(
                name: "Member_Information");
        }
    }
}
