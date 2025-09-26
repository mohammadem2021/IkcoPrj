using IKCOProject.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IKCOProject.Persistence.Configuration;

public class NoteConfiguration:IEntityTypeConfiguration<Note>
{
    public void Configure(EntityTypeBuilder<Note> builder)
    {
        builder.ToTable("tbl_Note");
        builder.Property(p => p.Title)
            .HasMaxLength(250);
    }
}