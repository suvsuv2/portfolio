using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Conference.Models
{
    public partial class MaincontextM : DbContext
    {
        public MaincontextM()
            : base("name=MaincontextM")
        {
        }

        public virtual DbSet<Activity> ActivityZ { get; set; }
        public virtual DbSet<Cities> CitiesZ { get; set; }
        public virtual DbSet<Country> CountryZ { get; set; }
        public virtual DbSet<Events> EventsZ { get; set; }
        public virtual DbSet<Moderator> ModeratorZ { get; set; }
        public virtual DbSet<Organizer> OrganizerZ { get; set; }
        public virtual DbSet<Participant> ParticipantZ { get; set; }
        public virtual DbSet<Shuri> ShuriZ { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>()
                .Property(e => e.ActivityName)
                .IsUnicode(false);

            modelBuilder.Entity<Activity>()
                .Property(e => e.BeginDate)
                .IsUnicode(false);

            modelBuilder.Entity<Activity>()
                .Property(e => e.ActivityEvent)
                .IsUnicode(false);

            modelBuilder.Entity<Activity>()
                .Property(e => e.DayCount)
                .IsUnicode(false);

            modelBuilder.Entity<Activity>()
                .Property(e => e.BeginTime)
                .IsUnicode(false);

            modelBuilder.Entity<Activity>()
                .Property(e => e.Moderator)
                .IsUnicode(false);

            modelBuilder.Entity<Activity>()
                .Property(e => e.Shuri1)
                .IsUnicode(false);

            modelBuilder.Entity<Activity>()
                .Property(e => e.Shuri2)
                .IsUnicode(false);

            modelBuilder.Entity<Activity>()
                .Property(e => e.Shuri3)
                .IsUnicode(false);

            modelBuilder.Entity<Activity>()
                .Property(e => e.Shuri4)
                .IsUnicode(false);

            modelBuilder.Entity<Activity>()
                .Property(e => e.Shuri5)
                .IsUnicode(false);

            modelBuilder.Entity<Activity>()
                .Property(e => e.Winner)
                .IsUnicode(false);

            modelBuilder.Entity<Cities>()
                .Property(e => e.CountryNameRus)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.CountryNameRus)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.CountryNameEng)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.CodeText)
                .IsUnicode(false);

            modelBuilder.Entity<Events>()
                .Property(e => e.EventName)
                .IsUnicode(false);

            modelBuilder.Entity<Events>()
                .Property(e => e.EventPicture)
                .IsFixedLength();

            modelBuilder.Entity<Events>()
                .Property(e => e.EventDirection)
                .IsFixedLength();

            modelBuilder.Entity<Moderator>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<Moderator>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Moderator>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<Moderator>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Moderator>()
                .Property(e => e.TelephoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Moderator>()
                .Property(e => e.Profession)
                .IsUnicode(false);

            modelBuilder.Entity<Moderator>()
                .Property(e => e.Event)
                .IsUnicode(false);

            modelBuilder.Entity<Moderator>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Moderator>()
                .Property(e => e.Photo)
                .IsUnicode(false);

            modelBuilder.Entity<Organizer>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<Organizer>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<Organizer>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Organizer>()
                .Property(e => e.TelephoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Organizer>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Organizer>()
                .Property(e => e.Photo)
                .IsUnicode(false);

            modelBuilder.Entity<Organizer>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.TelephoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Photo)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Shuri>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<Shuri>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<Shuri>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<Shuri>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Shuri>()
                .Property(e => e.TelephoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Shuri>()
                .Property(e => e.Specialization)
                .IsUnicode(false);

            modelBuilder.Entity<Shuri>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Shuri>()
                .Property(e => e.Photo)
                .IsUnicode(false);
        }
    }
}
