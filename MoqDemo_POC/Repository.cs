using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqDemo_POC
{
    public class Repository : IRepository
    {
        //data will comes from database 
        public List<Band> GetBands()
        {
            var listOfBands = new List<Band>();
            listOfBands.AddRange(new List<Band>
            {
                new Band(){
                        Name = "Band New 1",
                        Origin = "India",
                        Genre = "Alternative",
                        BestSong = "May I know"
                },
                 new Band(){
                        Name = "Band New 2",
                        Origin = "India",
                        Genre = "Alternative",
                        BestSong = "May I know"
                },
                  new Band(){
                        Name = "Band New 3",
                        Origin = "India",
                        Genre = "Alternative",
                        BestSong = "May I know"
                },
            }
            );

            return listOfBands;
        }
    }
}
