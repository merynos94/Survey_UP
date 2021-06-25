﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SurveyUP.Models;

namespace SurveyUP.Migrations.N3mikos
{
    [DbContext(typeof(N3mikosContext))]
    partial class N3mikosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SurveyUP.Tables.VtsTbAnswer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnswerText")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<short?>("AnswerTypeId")
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("DefaultText")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<int?>("DisplayOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("AnswerId")
                        .IsClustered(false);

                    b.HasIndex("AnswerTypeId");

                    b.HasIndex(new[] { "DisplayOrder" }, "IX_Answer")
                        .HasFillFactor(80);

                    b.HasIndex(new[] { "QuestionId", "DisplayOrder" }, "IX_QuestionID")
                        .HasFillFactor(80);

                    b.ToTable("vts_tbAnswer");
                });

            modelBuilder.Entity("SurveyUP.Tables.VtsTbAnswerType", b =>
                {
                    b.Property<short>("AnswerTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("AnswerTypeID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("AnswerTypeId");

                    b.ToTable("vts_tbAnswerType");
                });

            modelBuilder.Entity("SurveyUP.Tables.VtsTbQuestion", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("ColumnsNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("HelpText")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<int?>("PageNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((1))");

                    b.Property<int?>("QuestionGroupId")
                        .HasColumnType("int")
                        .HasColumnName("QuestionGroupID");

                    b.Property<string>("QuestionText")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<byte?>("SelectionModeQuestionSelectionModeId")
                        .HasColumnType("tinyint");

                    b.Property<bool>("ShowHelpText")
                        .HasColumnType("bit");

                    b.Property<int?>("SurveyId")
                        .HasColumnType("int");

                    b.HasKey("QuestionId")
                        .IsClustered(false);

                    b.HasIndex("SelectionModeQuestionSelectionModeId");

                    b.HasIndex(new[] { "QuestionGroupId" }, "IX_QuestionGroupID")
                        .HasFillFactor(80);

                    b.HasIndex(new[] { "SurveyId" }, "IX_SurveyId")
                        .HasFillFactor(80);

                    b.ToTable("vts_tbQuestion");
                });

            modelBuilder.Entity("SurveyUP.Tables.VtsTbQuestionSelectionMode", b =>
                {
                    b.Property<byte>("QuestionSelectionModeId")
                        .HasColumnType("tinyint")
                        .HasColumnName("QuestionSelectionModeID");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TypeAssembly")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<int?>("TypeMode")
                        .HasColumnType("int");

                    b.Property<string>("TypeNameSpace")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.HasKey("QuestionSelectionModeId");

                    b.ToTable("vts_tbQuestionSelectionMode");
                });

            modelBuilder.Entity("SurveyUP.Tables.VtsTbSurvey", b =>
                {
                    b.Property<int>("SurveyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SurveyID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activated")
                        .HasColumnType("bit");

                    b.Property<bool>("Archive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CloseDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("OpenDate")
                        .HasColumnType("datetime");

                    b.Property<bool?>("Scored")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("SurveyDisplayTimes")
                        .HasColumnType("int");

                    b.Property<Guid?>("SurveyGuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("ThankYouMessage")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("SurveyId")
                        .IsClustered(false);

                    b.ToTable("vts_tbSurvey");
                });

            modelBuilder.Entity("SurveyUP.Tables.VtsTbUserAnswerType", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<short>("AnswerTypeId")
                        .HasColumnType("smallint");

                    b.HasKey("UserId", "AnswerTypeId");

                    b.HasIndex("AnswerTypeId");

                    b.ToTable("vts_tbUserAnswerType");
                });

            modelBuilder.Entity("SurveyUP.Tables.VtsTbUserSurvey", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SurveyId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "SurveyId");

                    b.HasIndex("SurveyId");

                    b.ToTable("vts_tbUserSurvey");
                });

            modelBuilder.Entity("SurveyUP.Tables.VtsTbVoter", b =>
                {
                    b.Property<int>("VoterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("VoterID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContextUserName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Ipsource")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("IPSource");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("SurveyId")
                        .HasColumnType("int")
                        .HasColumnName("SurveyID");

                    b.Property<string>("Uid")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("UID");

                    b.Property<bool?>("Validated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime?>("VoteDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("VoterId");

                    b.HasIndex(new[] { "Validated", "SurveyId" }, "IDX_Voter")
                        .HasFillFactor(80);

                    b.HasIndex(new[] { "SurveyId" }, "IX_SurveyID");

                    b.ToTable("vts_tbVoter");
                });

            modelBuilder.Entity("SurveyUP.Tables.VtsTbVoterAnswers", b =>
                {
                    b.Property<int>("VoterId")
                        .HasColumnType("int")
                        .HasColumnName("VoterID");

                    b.Property<int>("AnswerId")
                        .HasColumnType("int")
                        .HasColumnName("AnswerID");

                    b.Property<int>("SectionNumber")
                        .HasColumnType("int");

                    b.Property<string>("AnswerText")
                        .HasColumnType("ntext");

                    b.HasKey("VoterId", "AnswerId", "SectionNumber");

                    b.HasIndex(new[] { "AnswerId" }, "IX_Answer")
                        .HasDatabaseName("IX_Answer1")
                        .HasFillFactor(80);

                    b.ToTable("vts_tbVoterAnswers");
                });

            modelBuilder.Entity("SurveyUP.Tables.VtsTbAnswer", b =>
                {
                    b.HasOne("SurveyUP.Tables.VtsTbAnswerType", "AnswerType")
                        .WithMany("VtsTbAnswer")
                        .HasForeignKey("AnswerTypeId")
                        .HasConstraintName("FK_vts_tbAnswer_vts_tbAnswerType");

                    b.HasOne("SurveyUP.Tables.VtsTbQuestion", "Question")
                        .WithMany("VtsTbAnswer")
                        .HasForeignKey("QuestionId")
                        .HasConstraintName("FK_vts_tbAnswer_vts_tbQuestion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnswerType");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("SurveyUP.Tables.VtsTbQuestion", b =>
                {
                    b.HasOne("SurveyUP.Tables.VtsTbQuestionSelectionMode", "SelectionMode")
                        .WithMany("VtsTbQuestion")
                        .HasForeignKey("SelectionModeQuestionSelectionModeId");

                    b.HasOne("SurveyUP.Tables.VtsTbSurvey", "Survey")
                        .WithMany("VtsTbQuestion")
                        .HasForeignKey("SurveyId")
                        .HasConstraintName("FK_vts_tbQuestion_vts_tbSurvey")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("SelectionMode");

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("SurveyUP.Tables.VtsTbUserAnswerType", b =>
                {
                    b.HasOne("SurveyUP.Tables.VtsTbAnswerType", "AnswerType")
                        .WithMany("VtsTbUserAnswerType")
                        .HasForeignKey("AnswerTypeId")
                        .HasConstraintName("FK_vts_tbUserAnswerType_vts_tbAnswerType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AnswerType");
                });

            modelBuilder.Entity("SurveyUP.Tables.VtsTbUserSurvey", b =>
                {
                    b.HasOne("SurveyUP.Tables.VtsTbSurvey", "Survey")
                        .WithMany("VtsTbUserSurvey")
                        .HasForeignKey("SurveyId")
                        .HasConstraintName("FK_vts_tbUserSurvey_vts_tbSurvey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("SurveyUP.Tables.VtsTbVoterAnswers", b =>
                {
                    b.HasOne("SurveyUP.Tables.VtsTbAnswer", "Answer")
                        .WithMany("VtsTbVoterAnswers")
                        .HasForeignKey("AnswerId")
                        .HasConstraintName("FK_VoterAnswers_vts_tbAnswer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SurveyUP.Tables.VtsTbVoter", "Voter")
                        .WithMany("VtsTbVoterAnswers")
                        .HasForeignKey("VoterId")
                        .HasConstraintName("FK_VoterAnswers_vts_tbVoter")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Answer");

                    b.Navigation("Voter");
                });

            modelBuilder.Entity("SurveyUP.Tables.VtsTbAnswer", b =>
                {
                    b.Navigation("VtsTbVoterAnswers");
                });

            modelBuilder.Entity("SurveyUP.Tables.VtsTbAnswerType", b =>
                {
                    b.Navigation("VtsTbAnswer");

                    b.Navigation("VtsTbUserAnswerType");
                });

            modelBuilder.Entity("SurveyUP.Tables.VtsTbQuestion", b =>
                {
                    b.Navigation("VtsTbAnswer");
                });

            modelBuilder.Entity("SurveyUP.Tables.VtsTbQuestionSelectionMode", b =>
                {
                    b.Navigation("VtsTbQuestion");
                });

            modelBuilder.Entity("SurveyUP.Tables.VtsTbSurvey", b =>
                {
                    b.Navigation("VtsTbQuestion");

                    b.Navigation("VtsTbUserSurvey");
                });

            modelBuilder.Entity("SurveyUP.Tables.VtsTbVoter", b =>
                {
                    b.Navigation("VtsTbVoterAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
