using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS_Library.Domain.Model
{
    public class RoomEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }
        public decimal SasPrice { get; set; }

        public virtual ICollection<UserRoomEntity> UserRoomEntity { get; set; }
    }
}
