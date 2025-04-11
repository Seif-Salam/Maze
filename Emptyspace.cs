using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class Emptyspace: Imazeobject
    {
        public char icon { get=>' ';  } // the shape of the maze object
        public bool isSolid { get => false;  } // Movement Bolck

        }
    
    
    }

