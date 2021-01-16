using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillBlazor.Shared.Entities
{
    public class Picture
    {
        public int Id { get; set; }
        public string PictureUrl { get; set; }
        public int HeightPx { get; set; }
        public int WidthPx { get; set; }

    }
}
