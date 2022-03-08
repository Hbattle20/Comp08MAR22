using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morningwork
{
    interface IMove
    {
        void MoveVechicle(int wheels);
    }
    
    interface IExhibit 
    {
        string Show();

    }
}
