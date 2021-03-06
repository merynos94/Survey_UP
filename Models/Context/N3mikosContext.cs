// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

using SurveyUP.Tables;

#nullable disable

namespace SurveyUP.Models
{
    public partial class N3mikosContext : DbContext
    {
        public N3mikosContext()
        {
        }

        public N3mikosContext(DbContextOptions<N3mikosContext> options)
            : base(options)
        {
        }

      
        public virtual DbSet<VtsTbAnswer> VtsTbAnswer { get; set; }
        public virtual DbSet<VtsTbAnswerType> VtsTbAnswerType { get; set; }
        public virtual DbSet<VtsTbQuestion> VtsTbQuestion { get; set; }
        public virtual DbSet<VtsTbQuestionSelectionMode> VtsTbQuestionSelectionMode { get; set; }
        public virtual DbSet<VtsTbSurvey> VtsTbSurvey { get; set; }
        public virtual DbSet<VtsTbUserAnswerType> VtsTbUserAnswerType { get; set; }
        public virtual DbSet<VtsTbUserSurvey> VtsTbUserSurvey { get; set; }
        public virtual DbSet<VtsTbVoter> VtsTbVoter { get; set; }
        public virtual DbSet<VtsTbVoterAnswers> VtsTbVoterAnswers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=127.0.0.1,8433;Initial Catalog=n3mikos;Persist Security Info=True;User ID=n3Mikos;Password=almeria01#");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

          

          

         

            modelBuilder.Entity<VtsTbAnswer>(entity =>
            {
                entity.HasKey(e => e.AnswerId)
                    .IsClustered(false);

                entity.ToTable("vts_tbAnswer");

                entity.HasIndex(e => new { e.DisplayOrder }, "IX_Answer")
                    .HasFillFactor((byte)80);



                entity.HasIndex(e => new { e.QuestionId, e.DisplayOrder}, "IX_QuestionID")
                    .HasFillFactor((byte)80);


  

                entity.Property(e => e.AnswerText).HasMaxLength(4000);

                entity.Property(e => e.AnswerTypeId).HasDefaultValueSql("((1))");


                entity.Property(e => e.DefaultText).HasMaxLength(4000);

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((1))");


                entity.HasOne(d => d.AnswerType)
                    .WithMany(p => p.VtsTbAnswer)
                    .HasForeignKey(d => d.AnswerTypeId)
                    .HasConstraintName("FK_vts_tbAnswer_vts_tbAnswerType");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.VtsTbAnswer)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_vts_tbAnswer_vts_tbQuestion");

            });

     

      

            modelBuilder.Entity<VtsTbAnswerType>(entity =>
            {
                entity.HasKey(e => e.AnswerTypeId);

                entity.ToTable("vts_tbAnswerType");

                entity.Property(e => e.AnswerTypeId).HasColumnName("AnswerTypeID");


                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

            });

            
       
            modelBuilder.Entity<VtsTbQuestion>(entity =>
            {
                entity.HasKey(e => e.QuestionId)
                    .IsClustered(false);

                entity.ToTable("vts_tbQuestion");


                entity.HasIndex(e => e.QuestionGroupId, "IX_QuestionGroupID")
                    .HasFillFactor((byte)80);


                entity.HasIndex(e => e.SurveyId, "IX_SurveyId")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Alias).HasMaxLength(255);

                entity.Property(e => e.ColumnsNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.HelpText).HasMaxLength(4000);


                entity.Property(e => e.PageNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.QuestionGroupId).HasColumnName("QuestionGroupID");



                entity.Property(e => e.QuestionText).HasMaxLength(4000);


                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.VtsTbQuestion)
                    .HasForeignKey(d => d.SurveyId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_vts_tbQuestion_vts_tbSurvey");
            });


            modelBuilder.Entity<VtsTbQuestionSelectionMode>(entity =>
            {
                entity.HasKey(e => e.QuestionSelectionModeId);

                entity.ToTable("vts_tbQuestionSelectionMode");

                entity.Property(e => e.QuestionSelectionModeId).HasColumnName("QuestionSelectionModeID");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.TypeAssembly)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TypeNameSpace)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });


            modelBuilder.Entity<VtsTbSurvey>(entity =>
            {
                entity.HasKey(e => e.SurveyId)
                    .IsClustered(false);

                entity.ToTable("vts_tbSurvey");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");


                entity.Property(e => e.CloseDate).HasColumnType("datetime");


                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");


                entity.Property(e => e.OpenDate).HasColumnType("datetime");




                entity.Property(e => e.Scored).HasDefaultValueSql("((0))");

                entity.Property(e => e.SurveyGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ThankYouMessage).HasMaxLength(4000);

                entity.Property(e => e.Title).HasMaxLength(255);


              

            });

            

            modelBuilder.Entity<VtsTbUserAnswerType>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.AnswerTypeId });

                entity.ToTable("vts_tbUserAnswerType");

                entity.HasOne(d => d.AnswerType)
                    .WithMany(p => p.VtsTbUserAnswerType)
                    .HasForeignKey(d => d.AnswerTypeId)
                    .HasConstraintName("FK_vts_tbUserAnswerType_vts_tbAnswerType");
            });



            modelBuilder.Entity<VtsTbUserSurvey>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.SurveyId });

                entity.ToTable("vts_tbUserSurvey");

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.VtsTbUserSurvey)
                    .HasForeignKey(d => d.SurveyId)
                    .HasConstraintName("FK_vts_tbUserSurvey_vts_tbSurvey");
            });

            modelBuilder.Entity<VtsTbVoter>(entity =>
            {
                entity.HasKey(e => e.VoterId);

                entity.ToTable("vts_tbVoter");

                entity.HasIndex(e => new { e.Validated, e.SurveyId }, "IDX_Voter")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.SurveyId, "IX_SurveyID");

                entity.Property(e => e.VoterId).HasColumnName("VoterID");

                entity.Property(e => e.ContextUserName).HasMaxLength(255);

                entity.Property(e => e.Ipsource)
                    .HasMaxLength(50)
                    .HasColumnName("IPSource");


                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.Property(e => e.Uid)
                    .HasMaxLength(40)
                    .HasColumnName("UID");

                entity.Property(e => e.Validated).HasDefaultValueSql("((0))");

                entity.Property(e => e.VoteDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<VtsTbVoterAnswers>(entity =>
            {
                entity.HasKey(e => new { e.VoterId, e.AnswerId, e.SectionNumber });

                entity.ToTable("vts_tbVoterAnswers");

                entity.HasIndex(e => e.AnswerId, "IX_Answer")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.VoterId).HasColumnName("VoterID");

                entity.Property(e => e.AnswerId).HasColumnName("AnswerID");

                entity.Property(e => e.AnswerText).HasColumnType("ntext");

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.VtsTbVoterAnswers)
                    .HasForeignKey(d => d.AnswerId)
                    .HasConstraintName("FK_VoterAnswers_vts_tbAnswer");

                entity.HasOne(d => d.Voter)
                    .WithMany(p => p.VtsTbVoterAnswers)
                    .HasForeignKey(d => d.VoterId)
                    .HasConstraintName("FK_VoterAnswers_vts_tbVoter");
            });

            


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}