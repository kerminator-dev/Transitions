using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitionsLibrary.Models
{
    public interface ITransition
    {
        void Start();
        void Stop();
    }
}
