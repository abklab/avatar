using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NEWHIRES.DAL
{
    public partial class NHDBContext : DbContext
    {
        public NHDBContext()
        {
        }

        public NHDBContext(DbContextOptions<NHDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<ApplicationInfo> ApplicationInfo { get; set; }
        public virtual DbSet<ApplicationWaiver> ApplicationWaiver { get; set; }
        public virtual DbSet<BackgroundInfo> BackgroundInfo { get; set; }
        public virtual DbSet<DOT> DOT { get; set; }
        public virtual DbSet<DirectDeposit> DirectDeposit { get; set; }
        public virtual DbSet<DrivingLicense> DrivingLicense { get; set; }
        public virtual DbSet<EmergencyContacts> EmergencyContacts { get; set; }
        public virtual DbSet<Employer> Employer { get; set; }
        public virtual DbSet<EmploymentRecord> EmploymentRecord { get; set; }
        public virtual DbSet<EmploymentScreening> EmploymentScreening { get; set; }
        public virtual DbSet<FormsAcknowledgement> FormsAcknowledgement { get; set; }
        public virtual DbSet<I_9_Documents> I_9_Documents { get; set; }
        public virtual DbSet<I_9_Section_1> I_9_Section_1 { get; set; }
        public virtual DbSet<I_9_Section_2> I_9_Section_2 { get; set; }
        public virtual DbSet<I_9_Section_3> I_9_Section_3 { get; set; }
        public virtual DbSet<JobSetup> JobSetup { get; set; }
        public virtual DbSet<Pre_Emp_DrugTest> Pre_Emp_DrugTest { get; set; }
        public virtual DbSet<PreviousEmployer> PreviousEmployer { get; set; }
        public virtual DbSet<ScreeningCompany> ScreeningCompany { get; set; }
        public virtual DbSet<TrainingCourses> TrainingCourses { get; set; }
        public virtual DbSet<TrainingDocumentation> TrainingDocumentation { get; set; }
        public virtual DbSet<TrainingQuestions> TrainingQuestions { get; set; }
        public virtual DbSet<TrainingResultsDetails> TrainingResultsDetails { get; set; }
        public virtual DbSet<TrainingResultsSummary> TrainingResultsSummary { get; set; }
        public virtual DbSet<W4Info> W4Info { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=NHDB;Persist Security Info=True;User ID=sa;Password=Systems2019!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.EntryID);

                entity.Property(e => e.Address_1)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Address_2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cellphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeAtAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.App)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.AppID)
                    .HasConstraintName("FK_Address_ApplicationInfo");
            });

            modelBuilder.Entity<ApplicationInfo>(entity =>
            {
                entity.HasKey(e => e.AppID);

                entity.Property(e => e.AppDate).HasColumnType("date");

                entity.Property(e => e.AppType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaidenName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSN)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApplicationWaiver>(entity =>
            {
                entity.HasKey(e => e.EntryID)
                    .HasName("PK_Waiver");

                entity.Property(e => e.AppCompletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AppWaiverSignDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AppWaiverSignature)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPrevEmployer)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Self_CompletedApp)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.App)
                    .WithMany(p => p.ApplicationWaiver)
                    .HasForeignKey(d => d.AppID)
                    .HasConstraintName("FK_ApplicationWaiver_ApplicationInfo");
            });

            modelBuilder.Entity<BackgroundInfo>(entity =>
            {
                entity.HasKey(e => e.EntryID);

                entity.Property(e => e.AFBranch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ArmedForces)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyPrevEmpDetails)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyPrevEmployee)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ExplainFelonyMisdemeanor)
                    .HasMaxLength(130)
                    .IsUnicode(false);

                entity.Property(e => e.HasFelonyMisdemeanor)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.HasSpecialLicense)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsFirstEmployment)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NationalGuard).HasMaxLength(5);

                entity.Property(e => e.SpecialLicDetails)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Specialty)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.App)
                    .WithMany(p => p.BackgroundInfo)
                    .HasForeignKey(d => d.AppID)
                    .HasConstraintName("FK_BackgroundInfo_ApplicationInfo");
            });

            modelBuilder.Entity<DOT>(entity =>
            {
                entity.HasKey(e => e.EntryID);

                entity.Property(e => e.EntryID).ValueGeneratedOnAdd();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.NoDOT_Past2Yrs)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrevEmployers4DOT)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.eSignature)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Entry)
                    .WithOne(p => p.DOT)
                    .HasForeignKey<DOT>(d => d.EntryID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOT_ApplicationInfo");
            });

            modelBuilder.Entity<DirectDeposit>(entity =>
            {
                entity.HasKey(e => e.EntryID);

                entity.Property(e => e.AcctNo_1)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AcctNo_2)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AcctType_1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AcctType_2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bank_1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bank_2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Deposit_1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Deposit_2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpSignDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpSignature)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingNo_1)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingNo_2)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.App)
                    .WithMany(p => p.DirectDeposit)
                    .HasForeignKey(d => d.AppID)
                    .HasConstraintName("FK_DirectDeposit_ApplicationInfo");
            });

            modelBuilder.Entity<DrivingLicense>(entity =>
            {
                entity.HasKey(e => e.EntryID);

                entity.Property(e => e.DL_Expiration).HasColumnType("date");

                entity.Property(e => e.DL_Number)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DL_State).HasMaxLength(10);

                entity.Property(e => e.DL_Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HasValid_DL)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoDL_Acknowledged)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.App)
                    .WithMany(p => p.DrivingLicense)
                    .HasForeignKey(d => d.AppID)
                    .HasConstraintName("FK_DrivingLicense_ApplicationInfo");
            });

            modelBuilder.Entity<EmergencyContacts>(entity =>
            {
                entity.HasKey(e => e.EntryID);

                entity.Property(e => e.Cell)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Contact_Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.App)
                    .WithMany(p => p.EmergencyContacts)
                    .HasForeignKey(d => d.AppID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmergencyContacts_ApplicationInfo");
            });

            modelBuilder.Entity<Employer>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contact_Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contact_Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contact_Position)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumbers)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmploymentRecord>(entity =>
            {
                entity.HasKey(e => e.EntryID);

                entity.Property(e => e.ApprenticeRate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ApprenticeYear)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Benefits_401K)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Benefits_Dental)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Benefits_Life)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Benefits_Medical)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Benefits_Supplemental)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CheckDeliveryLocation)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CheckEmail)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Classification)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EEO_Ethnicity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EEO_Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeLocal)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsReferralAttached)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.JobLocal)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OtherClassification)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaycheckDelivery)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Provide_EEO)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Trade)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.App)
                    .WithMany(p => p.EmploymentRecord)
                    .HasForeignKey(d => d.AppID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmploymentRecord_ApplicationInfo");
            });

            modelBuilder.Entity<EmploymentScreening>(entity =>
            {
                entity.HasKey(e => e.EntryID);

                entity.Property(e => e.FelonyOrMisdemeanor)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FelonyOrMisdemeanorDesc)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OtherLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SignatureDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.eSSignature)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.App)
                    .WithMany(p => p.EmploymentScreening)
                    .HasForeignKey(d => d.AppID)
                    .HasConstraintName("FK_EmploymentScreening_ApplicationInfo1");
            });

            modelBuilder.Entity<FormsAcknowledgement>(entity =>
            {
                entity.Property(e => e.eSignature)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.eSignatureDate).HasColumnType("date");
            });

            modelBuilder.Entity<I_9_Documents>(entity =>
            {
                entity.ToTable("I-9_Documents");

                entity.HasOne(d => d.Section2)
                    .WithMany(p => p.I_9_Documents)
                    .HasForeignKey(d => d.Section2ID)
                    .HasConstraintName("FK_I-9_Documents_I-9_Section_2");
            });

            modelBuilder.Entity<I_9_Section_1>(entity =>
            {
                entity.HasKey(e => e.EntryID)
                    .HasName("PK_Employment_Eligibility");

                entity.ToTable("I-9_Section_1");

                entity.Property(e => e.CountryOfIssuance)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrepareSignature)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreparerAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PreparerCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreparerFirstname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreparerLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreparerSignatureDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreparerState)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PreparerZip)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Res_AdmissionDoc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Res_DocumentExpiration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Res_DocumentNumber_3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Res_DocumentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Self_Prepared)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SignatureDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.eSignature)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.App)
                    .WithMany(p => p.I_9_Section_1)
                    .HasForeignKey(d => d.AppID)
                    .HasConstraintName("FK_I-9_Section_1_ApplicationInfo");
            });

            modelBuilder.Entity<I_9_Section_2>(entity =>
            {
                entity.HasKey(e => e.EntryID);

                entity.ToTable("I-9_Section_2");

                entity.Property(e => e.EntryID).ValueGeneratedNever();

                entity.Property(e => e.AuthorizedRep_FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorizedRep_LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorizedRep_SignDate).HasColumnType("date");

                entity.Property(e => e.AuthorizedRep_Signature)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorizedRep_Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Doc_ExpirationDate).HasColumnType("date");

                entity.Property(e => e.Doc_List)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Doc_Number)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Doc_Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IssuingAuthority)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<I_9_Section_3>(entity =>
            {
                entity.HasKey(e => e.EntryID);

                entity.ToTable("I-9_Section_3");

                entity.Property(e => e.AuthorizedRep_LastName)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorizedRep_SignDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorizedRep_Signature)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RehireDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JobSetup>(entity =>
            {
                entity.HasKey(e => e.JobID)
                    .HasName("PK__JobSetup__056690E28CBC8B8E");

                entity.Property(e => e.AppType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AuditTrail)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.JobNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SetupBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SetupDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkState)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pre_Emp_DrugTest>(entity =>
            {
                entity.HasKey(e => e.PID)
                    .HasName("PK_tbl_Pre_Emp_DrugTest");

                entity.Property(e => e.ApplicantSignature)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HasAgreed)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SignatureDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Witness)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PreviousEmployer>(entity =>
            {
                entity.HasKey(e => e.EntryID)
                    .HasName("PK__tbl_Prev__3214EC2702DB990D");

                entity.Property(e => e.BusinessAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.JobDuties)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonForLeaving)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.App)
                    .WithMany(p => p.PreviousEmployer)
                    .HasForeignKey(d => d.AppID)
                    .HasConstraintName("FK_PreviousEmployer_ApplicationInfo");
            });

            modelBuilder.Entity<ScreeningCompany>(entity =>
            {
                entity.HasKey(e => e.ScreenerID);

                entity.Property(e => e.ScreenerID).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TerminationDate).HasColumnType("date");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrainingCourses>(entity =>
            {
                entity.HasKey(e => e.CourseID);

                entity.Property(e => e.CourseDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrainingDocumentation>(entity =>
            {
                entity.HasKey(e => e.EntryID);

                entity.Property(e => e.AppSignatureDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicantSignature).HasColumnType("image");

                entity.Property(e => e.Trainer)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrainingQuestions>(entity =>
            {
                entity.HasKey(e => e.QuestID);

                entity.Property(e => e.CorrectAnswer)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Explanation).IsUnicode(false);

                entity.Property(e => e.Question).IsUnicode(false);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.TrainingQuestions)
                    .HasForeignKey(d => d.CourseID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingQuestions_TrainingCourses");
            });

            modelBuilder.Entity<TrainingResultsDetails>(entity =>
            {
                entity.HasKey(e => e.DetailsID);

                entity.Property(e => e.Answer)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrainingResultsSummary>(entity =>
            {
                entity.HasKey(e => e.SummaryID);

                entity.Property(e => e.Acknowledge)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TrainDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<W4Info>(entity =>
            {
                entity.HasKey(e => e.EntryID);

                entity.Property(e => e.AdditionalAmt).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EmpSignDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpSignature)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Filing)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.LastNameDifferent)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.WithholdExempt)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}
