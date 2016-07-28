using SAS_Library.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS_Library.Domain.Mapping
{
   public class UserRoomMapping : EntityTypeConfiguration<UserRoomEntity>
    {
        public UserRoomMapping()
        {
            this.ToTable("UserRoomEntity");

            this.HasRequired(ur => ur.UserEntity)
                .WithMany(u => u.UserRoomEntity)
                .HasForeignKey(ur => ur.UserEntityId)
                .WillCascadeOnDelete(true);

            this.HasRequired(userRoomEnity => userRoomEnity.RoomEntity)
                .WithMany(roomEntity => roomEntity.UserRoomEntity)
                .HasForeignKey(userRoomEnity => userRoomEnity.RoomEntityId)
                .WillCascadeOnDelete(true);
        }
    }
}
