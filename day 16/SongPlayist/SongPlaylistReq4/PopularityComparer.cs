using SongGroupReq4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongPlaylistReq4
{
        internal class PopularityComparer : IComparer<Song>
        {
            public int Compare(Song x, Song y)
            {

                return y._numberOfDownloads.CompareTo(x._numberOfDownloads);

            }

        }
    }
