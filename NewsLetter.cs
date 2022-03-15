using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegate
{
    public class NewsLetter:EventArgs 
    {
        public delegate void EventHandler(NewsLetter publisher,BroadCast e);
        public event EventHandler NewArticle;
        
        public void OnNewArticle()
        {
            if (true)
            {

            }
        }
    }
}
