using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NEWHIRES.Migrations
{
    public partial class Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationInfo",
                columns: table => new
                {
                    AppID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppDate = table.Column<DateTime>(type: "date", nullable: true),
                    AppType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LastName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    MaidenName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    SSN = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    AppStatus = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationInfo", x => x.AppID);
                });

            migrationBuilder.CreateTable(
                name: "Employer",
                columns: table => new
                {
                    EmployerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployerName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PhoneNumbers = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    Fax = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    City = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    ZipCode = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Contact_Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Contact_Position = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Contact_Phone = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employer", x => x.EmployerID);
                });

            migrationBuilder.CreateTable(
                name: "FormsAcknowledgement",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppID = table.Column<int>(nullable: true),
                    FormID = table.Column<int>(nullable: true),
                    eSignature = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    eSignatureDate = table.Column<DateTime>(type: "date", nullable: true),
                    FormStatus = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormsAcknowledgement", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "I-9_Section_2",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false),
                    AppID = table.Column<int>(nullable: true),
                    Doc_List = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    Doc_Title = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    IssuingAuthority = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Doc_Number = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Doc_ExpirationDate = table.Column<DateTime>(type: "date", nullable: true),
                    AuthorizedRep_Title = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AuthorizedRep_LastName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AuthorizedRep_FirstName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AuthorizedRep_Signature = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AuthorizedRep_SignDate = table.Column<DateTime>(type: "date", nullable: true),
                    Notes = table.Column<string>(unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I-9_Section_2", x => x.EntryID);
                });

            migrationBuilder.CreateTable(
                name: "I-9_Section_3",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppID = table.Column<int>(nullable: true),
                    LastName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    MiddleName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    RehireDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DocumentTitle = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DocumentNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ExpirationDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AuthorizedRep_Signature = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AuthorizedRep_SignDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AuthorizedRep_LastName = table.Column<string>(unicode: false, maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I-9_Section_3", x => x.EntryID);
                });

            migrationBuilder.CreateTable(
                name: "JobSetup",
                columns: table => new
                {
                    JobID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SetupDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    JobNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    WorkState = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AppType = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    JobStatus = table.Column<int>(nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    IsDOT_required = table.Column<bool>(nullable: true),
                    SetupBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AuditTrail = table.Column<string>(unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__JobSetup__056690E28CBC8B8E", x => x.JobID);
                });

            migrationBuilder.CreateTable(
                name: "Pre_Emp_DrugTest",
                columns: table => new
                {
                    PID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppID = table.Column<int>(nullable: true),
                    ApplicantSignature = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    SignatureDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    HasAgreed = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Witness = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Pre_Emp_DrugTest", x => x.PID);
                });

            migrationBuilder.CreateTable(
                name: "ScreeningCompany",
                columns: table => new
                {
                    ScreenerID = table.Column<int>(nullable: false),
                    CompanyName = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    Address = table.Column<string>(unicode: false, maxLength: 120, nullable: true),
                    City = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    ZipCode = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Phone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Fax = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    TerminationDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreeningCompany", x => x.ScreenerID);
                });

            migrationBuilder.CreateTable(
                name: "TrainingCourses",
                columns: table => new
                {
                    CourseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseDescription = table.Column<string>(unicode: false, maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CourseOrder = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCourses", x => x.CourseID);
                });

            migrationBuilder.CreateTable(
                name: "TrainingDocumentation",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppID = table.Column<int>(nullable: false),
                    ApplicantSignature = table.Column<byte[]>(type: "image", nullable: true),
                    AppSignatureDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Trainer = table.Column<string>(unicode: false, maxLength: 75, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingDocumentation", x => x.EntryID);
                });

            migrationBuilder.CreateTable(
                name: "TrainingResultsDetails",
                columns: table => new
                {
                    DetailsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppID = table.Column<int>(nullable: false),
                    CourseID = table.Column<int>(nullable: true),
                    QuestID = table.Column<int>(nullable: true),
                    Answer = table.Column<string>(unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingResultsDetails", x => x.DetailsID);
                });

            migrationBuilder.CreateTable(
                name: "TrainingResultsSummary",
                columns: table => new
                {
                    SummaryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseID = table.Column<int>(nullable: false),
                    AppID = table.Column<int>(nullable: false),
                    NumCorrect = table.Column<int>(nullable: false),
                    TotalQuestions = table.Column<int>(nullable: false),
                    Acknowledge = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    TrainDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingResultsSummary", x => x.SummaryID);
                });

            migrationBuilder.CreateTable(
                name: "W4Info",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppID = table.Column<int>(nullable: false),
                    Filing = table.Column<string>(unicode: false, maxLength: 60, nullable: false),
                    LastNameDifferent = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    Allowances = table.Column<int>(nullable: true),
                    AdditionalAmt = table.Column<decimal>(type: "numeric(18, 0)", nullable: true),
                    WithholdExempt = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    EmpSignature = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    EmpSignDate = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_W4Info", x => x.EntryID);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppID = table.Column<int>(nullable: true),
                    Address_1 = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    Address_2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    City = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Zip = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    TimeAtAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Telephone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Cellphone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.EntryID);
                    table.ForeignKey(
                        name: "FK_Address_ApplicationInfo",
                        column: x => x.AppID,
                        principalTable: "ApplicationInfo",
                        principalColumn: "AppID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationWaiver",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppID = table.Column<int>(nullable: true),
                    ContactPrevEmployer = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    Self_CompletedApp = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    AppCompletedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AppWaiverSignature = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AppWaiverSignDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waiver", x => x.EntryID);
                    table.ForeignKey(
                        name: "FK_ApplicationWaiver_ApplicationInfo",
                        column: x => x.AppID,
                        principalTable: "ApplicationInfo",
                        principalColumn: "AppID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BackgroundInfo",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppID = table.Column<int>(nullable: true),
                    HasFelonyMisdemeanor = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    ExplainFelonyMisdemeanor = table.Column<string>(unicode: false, maxLength: 130, nullable: true),
                    ArmedForces = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    AFBranch = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    NationalGuard = table.Column<string>(maxLength: 5, nullable: true),
                    Specialty = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    CompanyPrevEmployee = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    CompanyPrevEmpDetails = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    IsFirstEmployment = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    HasSpecialLicense = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    SpecialLicDetails = table.Column<string>(unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundInfo", x => x.EntryID);
                    table.ForeignKey(
                        name: "FK_BackgroundInfo_ApplicationInfo",
                        column: x => x.AppID,
                        principalTable: "ApplicationInfo",
                        principalColumn: "AppID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DirectDeposit",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppID = table.Column<int>(nullable: true),
                    Bank_1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    RoutingNo_1 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    AcctNo_1 = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    AcctType_1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deposit_1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Bank_2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    RoutingNo_2 = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    AcctNo_2 = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    AcctType_2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deposit_2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    EmpSignature = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    EmpSignDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectDeposit", x => x.EntryID);
                    table.ForeignKey(
                        name: "FK_DirectDeposit_ApplicationInfo",
                        column: x => x.AppID,
                        principalTable: "ApplicationInfo",
                        principalColumn: "AppID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DOT",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppID = table.Column<int>(nullable: true),
                    PrevEmployers4DOT = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    NoDOT_Past2Yrs = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    DOT_Positive_Refusal = table.Column<bool>(nullable: true),
                    eSignature = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOT", x => x.EntryID);
                    table.ForeignKey(
                        name: "FK_DOT_ApplicationInfo",
                        column: x => x.EntryID,
                        principalTable: "ApplicationInfo",
                        principalColumn: "AppID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DrivingLicense",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppID = table.Column<int>(nullable: true),
                    DL_Number = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    DL_State = table.Column<string>(maxLength: 10, nullable: true),
                    DL_Expiration = table.Column<DateTime>(type: "date", nullable: true),
                    DL_Type = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HasValid_DL = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    NoDL_Acknowledged = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrivingLicense", x => x.EntryID);
                    table.ForeignKey(
                        name: "FK_DrivingLicense_ApplicationInfo",
                        column: x => x.AppID,
                        principalTable: "ApplicationInfo",
                        principalColumn: "AppID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmergencyContacts",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppID = table.Column<int>(nullable: false),
                    Contact_Name = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Relationship = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Phone = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    Cell = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    Notes = table.Column<string>(unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyContacts", x => x.EntryID);
                    table.ForeignKey(
                        name: "FK_EmergencyContacts_ApplicationInfo",
                        column: x => x.AppID,
                        principalTable: "ApplicationInfo",
                        principalColumn: "AppID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmploymentRecord",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppID = table.Column<int>(nullable: false),
                    Division = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PaycheckDelivery = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    CheckDeliveryLocation = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    CheckEmail = table.Column<string>(unicode: false, maxLength: 75, nullable: true),
                    HireDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Provide_EEO = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    EEO_Gender = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    EEO_Ethnicity = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Benefits_Medical = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    Benefits_Dental = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    Benefits_Supplemental = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    Benefits_Life = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    Benefits_401K = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    JobLocal = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    HomeLocal = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    CardNumber = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    Trade = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    Classification = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    ApprenticeYear = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    ApprenticeRate = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    OtherClassification = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    IsReferralAttached = table.Column<string>(unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentRecord", x => x.EntryID);
                    table.ForeignKey(
                        name: "FK_EmploymentRecord_ApplicationInfo",
                        column: x => x.AppID,
                        principalTable: "ApplicationInfo",
                        principalColumn: "AppID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmploymentScreening",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppID = table.Column<int>(nullable: true),
                    FelonyOrMisdemeanor = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    FelonyOrMisdemeanorDesc = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    eSSignature = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    SignatureDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    OtherLastName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ScreenerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentScreening", x => x.EntryID);
                    table.ForeignKey(
                        name: "FK_EmploymentScreening_ApplicationInfo1",
                        column: x => x.AppID,
                        principalTable: "ApplicationInfo",
                        principalColumn: "AppID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "I-9_Section_1",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppID = table.Column<int>(nullable: true),
                    OtherLastName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Nationality = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Res_DocumentType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Res_DocumentNumber_3 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Res_DocumentExpiration = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Res_AdmissionDoc = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CountryOfIssuance = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    eSignature = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    SignatureDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Self_Prepared = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    PreparerLastName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PreparerFirstname = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PreparerAddress = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    PreparerCity = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PreparerState = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    PreparerZip = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    PrepareSignature = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PreparerSignatureDate = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employment_Eligibility", x => x.EntryID);
                    table.ForeignKey(
                        name: "FK_I-9_Section_1_ApplicationInfo",
                        column: x => x.AppID,
                        principalTable: "ApplicationInfo",
                        principalColumn: "AppID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PreviousEmployer",
                columns: table => new
                {
                    EntryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppID = table.Column<int>(nullable: true),
                    EmployerName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    BusinessAddress = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    City = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    State = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    Zip = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Phone = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    Supervisor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    JobTitle = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    FromDate = table.Column<DateTime>(type: "date", nullable: true),
                    ToDate = table.Column<DateTime>(type: "date", nullable: true),
                    ReasonForLeaving = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    JobDuties = table.Column<string>(unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_Prev__3214EC2702DB990D", x => x.EntryID);
                    table.ForeignKey(
                        name: "FK_PreviousEmployer_ApplicationInfo",
                        column: x => x.AppID,
                        principalTable: "ApplicationInfo",
                        principalColumn: "AppID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "I-9_Documents",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppID = table.Column<int>(nullable: true),
                    DocData = table.Column<byte[]>(nullable: true),
                    Section2ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I-9_Documents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_I-9_Documents_I-9_Section_2",
                        column: x => x.Section2ID,
                        principalTable: "I-9_Section_2",
                        principalColumn: "EntryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingQuestions",
                columns: table => new
                {
                    QuestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseID = table.Column<int>(nullable: false),
                    QuestionNum = table.Column<int>(nullable: true),
                    ActiveQuestion = table.Column<bool>(nullable: true),
                    Question = table.Column<string>(unicode: false, nullable: true),
                    CorrectAnswer = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    Explanation = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingQuestions", x => x.QuestID);
                    table.ForeignKey(
                        name: "FK_TrainingQuestions_TrainingCourses",
                        column: x => x.CourseID,
                        principalTable: "TrainingCourses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_AppID",
                table: "Address",
                column: "AppID");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationWaiver_AppID",
                table: "ApplicationWaiver",
                column: "AppID");

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundInfo_AppID",
                table: "BackgroundInfo",
                column: "AppID");

            migrationBuilder.CreateIndex(
                name: "IX_DirectDeposit_AppID",
                table: "DirectDeposit",
                column: "AppID");

            migrationBuilder.CreateIndex(
                name: "IX_DrivingLicense_AppID",
                table: "DrivingLicense",
                column: "AppID");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyContacts_AppID",
                table: "EmergencyContacts",
                column: "AppID");

            migrationBuilder.CreateIndex(
                name: "IX_EmploymentRecord_AppID",
                table: "EmploymentRecord",
                column: "AppID");

            migrationBuilder.CreateIndex(
                name: "IX_EmploymentScreening_AppID",
                table: "EmploymentScreening",
                column: "AppID");

            migrationBuilder.CreateIndex(
                name: "IX_I-9_Documents_Section2ID",
                table: "I-9_Documents",
                column: "Section2ID");

            migrationBuilder.CreateIndex(
                name: "IX_I-9_Section_1_AppID",
                table: "I-9_Section_1",
                column: "AppID");

            migrationBuilder.CreateIndex(
                name: "IX_PreviousEmployer_AppID",
                table: "PreviousEmployer",
                column: "AppID");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingQuestions_CourseID",
                table: "TrainingQuestions",
                column: "CourseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "ApplicationWaiver");

            migrationBuilder.DropTable(
                name: "BackgroundInfo");

            migrationBuilder.DropTable(
                name: "DirectDeposit");

            migrationBuilder.DropTable(
                name: "DOT");

            migrationBuilder.DropTable(
                name: "DrivingLicense");

            migrationBuilder.DropTable(
                name: "EmergencyContacts");

            migrationBuilder.DropTable(
                name: "Employer");

            migrationBuilder.DropTable(
                name: "EmploymentRecord");

            migrationBuilder.DropTable(
                name: "EmploymentScreening");

            migrationBuilder.DropTable(
                name: "FormsAcknowledgement");

            migrationBuilder.DropTable(
                name: "I-9_Documents");

            migrationBuilder.DropTable(
                name: "I-9_Section_1");

            migrationBuilder.DropTable(
                name: "I-9_Section_3");

            migrationBuilder.DropTable(
                name: "JobSetup");

            migrationBuilder.DropTable(
                name: "Pre_Emp_DrugTest");

            migrationBuilder.DropTable(
                name: "PreviousEmployer");

            migrationBuilder.DropTable(
                name: "ScreeningCompany");

            migrationBuilder.DropTable(
                name: "TrainingDocumentation");

            migrationBuilder.DropTable(
                name: "TrainingQuestions");

            migrationBuilder.DropTable(
                name: "TrainingResultsDetails");

            migrationBuilder.DropTable(
                name: "TrainingResultsSummary");

            migrationBuilder.DropTable(
                name: "W4Info");

            migrationBuilder.DropTable(
                name: "I-9_Section_2");

            migrationBuilder.DropTable(
                name: "ApplicationInfo");

            migrationBuilder.DropTable(
                name: "TrainingCourses");
        }
    }
}
