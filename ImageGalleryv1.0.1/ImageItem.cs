using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ImageGalleryv1._0._1
{
    
        public class ImageItem
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public byte[] Base64 { get; set; }
            public string Format { get; set; }
        }

    
}
