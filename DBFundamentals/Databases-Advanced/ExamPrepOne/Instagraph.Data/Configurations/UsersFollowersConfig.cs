using Instagraph.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Instagraph.Data.Configurations
{
    public class UsersFollowersConfig : IEntityTypeConfiguration<UserFollower>
    {
        public void Configure(EntityTypeBuilder<UserFollower> entity)
        {
            entity.HasKey(e => new { e.UserId, e.FollowerId });

            entity.HasOne(e => e.User)
                .WithMany(u => u.Followers)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(e => e.Follower)
                .WithMany(f => f.UsersFollowing)
                .HasForeignKey(e => e.FollowerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
