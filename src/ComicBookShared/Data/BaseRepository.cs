using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookShared.Data
{
    public abstract class BaseRepository
    {
        protected Context Context { get; set; }
        public BaseRepository(Context context)
        {

        }
    }
}
