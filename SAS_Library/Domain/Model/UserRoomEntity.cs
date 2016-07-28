using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS_Library.Domain.Model
{
    public class UserRoomEntity
    {
        public int Id { get; set; }
        public int UserEntityId { get; set; }
        public int RoomEntityId { get; set; }

        public virtual UserEntity UserEntity { get; set; }
        public virtual RoomEntity RoomEntity { get; set; }
    }
}
