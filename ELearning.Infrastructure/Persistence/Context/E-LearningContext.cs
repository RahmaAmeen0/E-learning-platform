using ELearning.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELearning.Infrastructure.Persistence.Context
{
    public class E_LearningContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public E_LearningContext(DbContextOptions<E_LearningContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(E_LearningContext).Assembly);
        }

        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Section> Sections => Set<Section>();
        public DbSet<Lesson> Lessons => Set<Lesson>();
        public DbSet<Enrollment> Enrollments => Set<Enrollment>();
        public DbSet<LessonProgress> LessonProgresses => Set<LessonProgress>();
        public DbSet<Certificate> Certificates => Set<Certificate>();
        public DbSet<Quiz> Quizzes => Set<Quiz>();
        public DbSet<Question> Questions => Set<Question>();
        public DbSet<AnswerOption> AnswerOptions => Set<AnswerOption>();
        public DbSet<QuizAttempt> QuizAttempts => Set<QuizAttempt>();
        public DbSet<AttemptAnswer> AttemptAnswers => Set<AttemptAnswer>();
        public DbSet<Payment> Payments => Set<Payment>();
        public DbSet<PaymentWebhook> PaymentWebhooks => Set<PaymentWebhook>();
        public DbSet<LiveSession> LiveSessions => Set<LiveSession>();
        public DbSet<LiveAnnouncement> LiveAnnouncements => Set<LiveAnnouncement>();
        public DbSet<Media> Medias => Set<Media>();
        public DbSet<Review> Reviews => Set<Review>();
        public DbSet<Notification> Notifications => Set<Notification>();
        public DbSet<NotificationPreference> NotificationPreferences => Set<NotificationPreference>();
    }
}
