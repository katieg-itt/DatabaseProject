namespace PostITT
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<CATEGORY> CATEGORies { get; set; }
        public virtual DbSet<ITTUSER> ITTUSERs { get; set; }
        public virtual DbSet<Medium> MEDIA { get; set; }
        public virtual DbSet<MEDIATYPE> MEDIATYPEs { get; set; }
        public virtual DbSet<POST> POSTs { get; set; }
        public virtual DbSet<POSTTYPE> POSTTYPEs { get; set; }
        public virtual DbSet<RANK> RANKs { get; set; }
        public virtual DbSet<TAG> TAGs { get; set; }
        public virtual DbSet<USERTYPE> USERTYPEs { get; set; }
        public virtual DbSet<MEDIA_MODERATOR_VIEW> MEDIA_MODERATOR_VIEW { get; set; }
        public virtual DbSet<VIEWPOST> VIEWPOSTS { get; set; }
        public virtual DbSet<VIEWUSER> VIEWUSERs { get; set; }
        public virtual DbSet<VIEWUSERPOST> VIEWUSERPOSTS { get; set; }
        public virtual DbSet<VIEWUSERPOSTSTYPECATTAGRANK> VIEWUSERPOSTSTYPECATTAGRANKs { get; set; }
        public virtual DbSet<VIEWUSERPROFILE> VIEWUSERPROFILEs { get; set; }
        public virtual DbSet<VIEWUSERTYPEPOST> VIEWUSERTYPEPOSTS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CATEGORY>()
                .Property(e => e.CATEGORYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<CATEGORY>()
                .HasMany(e => e.TAGs)
                .WithRequired(e => e.CATEGORY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ITTUSER>()
                .Property(e => e.FIRSTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ITTUSER>()
                .Property(e => e.SURNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ITTUSER>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<ITTUSER>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<ITTUSER>()
                .Property(e => e.PROFILEPIC)
                .IsUnicode(false);

            modelBuilder.Entity<ITTUSER>()
                .HasMany(e => e.RANKs)
                .WithRequired(e => e.ITTUSER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Medium>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<Medium>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<MEDIATYPE>()
                .Property(e => e.MEDIATYPEDESC)
                .IsUnicode(false);

            modelBuilder.Entity<POST>()
                .Property(e => e.POSTTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<POST>()
                .HasMany(e => e.POST1)
                .WithOptional(e => e.POST2)
                .HasForeignKey(e => e.PARENTID);

            modelBuilder.Entity<POSTTYPE>()
                .Property(e => e.POSTTYPE1)
                .IsUnicode(false);

            modelBuilder.Entity<TAG>()
                .Property(e => e.TAGNAME)
                .IsUnicode(false);

            modelBuilder.Entity<USERTYPE>()
                .Property(e => e.TYPEDESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<MEDIA_MODERATOR_VIEW>()
                .Property(e => e.SURNAME)
                .IsUnicode(false);

            modelBuilder.Entity<MEDIA_MODERATOR_VIEW>()
                .Property(e => e.POSTTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<MEDIA_MODERATOR_VIEW>()
                .Property(e => e.POSTTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<MEDIA_MODERATOR_VIEW>()
                .Property(e => e.CATEGORYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<MEDIA_MODERATOR_VIEW>()
                .Property(e => e.TAGNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEWPOST>()
                .Property(e => e.POSTTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<VIEWUSER>()
                .Property(e => e.FIRSTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEWUSER>()
                .Property(e => e.SURNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEWUSERPOST>()
                .Property(e => e.FIRSTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEWUSERPOST>()
                .Property(e => e.SURNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEWUSERPOST>()
                .Property(e => e.POSTTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<VIEWUSERPOSTSTYPECATTAGRANK>()
                .Property(e => e.SURNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEWUSERPOSTSTYPECATTAGRANK>()
                .Property(e => e.POSTTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<VIEWUSERPOSTSTYPECATTAGRANK>()
                .Property(e => e.POSTTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<VIEWUSERPOSTSTYPECATTAGRANK>()
                .Property(e => e.CATEGORYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEWUSERPOSTSTYPECATTAGRANK>()
                .Property(e => e.TAGNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEWUSERPROFILE>()
                .Property(e => e.FIRSTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEWUSERPROFILE>()
                .Property(e => e.SURNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEWUSERPROFILE>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<VIEWUSERPROFILE>()
                .Property(e => e.PROFILEPIC)
                .IsUnicode(false);

            modelBuilder.Entity<VIEWUSERTYPEPOST>()
                .Property(e => e.TYPEDESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<VIEWUSERTYPEPOST>()
                .Property(e => e.FIRSTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEWUSERTYPEPOST>()
                .Property(e => e.SURNAME)
                .IsUnicode(false);

            modelBuilder.Entity<VIEWUSERTYPEPOST>()
                .Property(e => e.POSTTEXT)
                .IsUnicode(false);
        }
    }
}
