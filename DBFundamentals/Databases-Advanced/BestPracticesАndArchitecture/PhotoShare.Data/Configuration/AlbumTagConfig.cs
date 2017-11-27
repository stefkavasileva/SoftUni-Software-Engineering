using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhotoShare.Models;

namespace PhotoShare.Data.Configuration
{
    internal class AlbumTagConfig : IEntityTypeConfiguration<AlbumTag>
    {
        public void Configure(EntityTypeBuilder<AlbumTag> builder)
        {
            builder.HasKey(e => new { e.AlbumId, e.TagId });

            builder.HasOne(e => e.Album)
                .WithMany(a => a.AlbumTags)
                .HasForeignKey(e => e.AlbumId);

            builder.HasOne(e => e.Tag)
                .WithMany(a => a.AlbumTags)
                .HasForeignKey(e => e.TagId);
        }
    }
}
